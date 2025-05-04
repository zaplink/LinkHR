using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LinkHR
{
    public partial class MngViewLeaves : Form
    {
        private string selectedEmployeeId = null;
        private System.Windows.Forms.Timer searchTimer;
        private CancellationTokenSource searchCts;
        private bool suppressTextChanged = false;

        public MngViewLeaves()
        {
            InitializeComponent();

            FromDate.Format = DateTimePickerFormat.Short;
            ToDate.Format = DateTimePickerFormat.Short;
            ToDate.Value = DateTime.Today;

            StatusFilter.Items.AddRange(new string[] { "All", "Pending", "Approved", "Rejected" });
            StatusFilter.SelectedIndex = 0;

            ApproveBtn.Enabled = false;
            RejectBtn.Enabled = false;

            LeavesDataGrid.AutoGenerateColumns = false;
            LeavesDataGrid.MultiSelect = false;
            LeavesDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LeavesDataGrid.Columns.Clear();

            LeavesDataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "LeaveID", HeaderText = "ID", DataPropertyName = "id", Visible = false }); // Important
            LeavesDataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "EmployeeID", HeaderText = "Employee ID", DataPropertyName = "employee_id" });
            LeavesDataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "RequestedDate", HeaderText = "Requested Date", DataPropertyName = "requested_date" });
            LeavesDataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "FromDate", HeaderText = "From Date", DataPropertyName = "from_date" });
            LeavesDataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "ToDate", HeaderText = "To Date", DataPropertyName = "to_date" });
            LeavesDataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Type", HeaderText = "Type", DataPropertyName = "type" });
            LeavesDataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", HeaderText = "Status", DataPropertyName = "status" });
            LeavesDataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Manager", HeaderText = "Handled By (Manager ID)", DataPropertyName = "manager_display" });
            LeavesDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            searchTimer = new System.Windows.Forms.Timer();
            searchTimer.Interval = 400;
            searchTimer.Tick += SearchTimer_Tick;

            ViewLeavesBtn.Click += ViewLeavesBtn_Click;
            LeavesDataGrid.SelectionChanged += LeavesDataGrid_SelectionChanged;
            ApproveBtn.Click += ApproveBtn_Click;
            RejectBtn.Click += RejectBtn_Click;
            EmpIdTxt.TextChanged += EmpIdTxt_TextChanged;
            EmpIdTxt.Click += EmpIdTxt_Click;
            EmployeeListBox.MouseClick += EmployeeListBox_MouseClick;
            this.Click += HideListBoxOnOutsideClick;

            suppressTextChanged = true;
            EmpIdTxt.Text = "[All Employees]";
            suppressTextChanged = false;
            selectedEmployeeId = null;
            EmployeeListBox.Visible = false;
        }

        private void EmpIdTxt_TextChanged(object sender, EventArgs e)
        {
            if (suppressTextChanged) return;
            searchTimer.Stop();
            searchTimer.Start();
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchCts?.Cancel();
            searchCts = new CancellationTokenSource();
            var token = searchCts.Token;

            string query = EmpIdTxt.Text.Trim();
            if (string.IsNullOrEmpty(query)) { EmployeeListBox.Visible = false; return; }

            BeginInvoke(async () =>
            {
                EmployeeListBox.DataSource = null;
                EmployeeListBox.Items.Clear();
                EmployeeListBox.Items.Add("Searching...");
                PositionListBoxUnderTextBox();
                EmployeeListBox.Visible = true;

                var results = await Task.Run(() => SearchEmployees(query), token);
                if (token.IsCancellationRequested) return;

                results.Insert(0, new Employee { Id = null, FirstName = "[All Employees]", LastName = "", DisplayOverride = "[All Employees]" });

                BeginInvoke(new Action(() =>
                {
                    EmployeeListBox.DataSource = results;
                    EmployeeListBox.DisplayMember = "Display";
                }));
            });
        }

        private void EmpIdTxt_Click(object sender, EventArgs e)
        {
            string query = EmpIdTxt.Text.Trim();
            var results = SearchEmployees(query);
            results.Insert(0, new Employee { Id = null, FirstName = "[All Employees]", LastName = "", DisplayOverride = "[All Employees]" });
            EmployeeListBox.DataSource = results;
            EmployeeListBox.DisplayMember = "Display";
            PositionListBoxUnderTextBox();
            EmployeeListBox.Visible = true;
        }

        private void PositionListBoxUnderTextBox()
        {
            var pt = EmpIdTxt.PointToScreen(Point.Empty);
            var local = this.PointToClient(pt);
            EmployeeListBox.Location = new Point(local.X, local.Y + EmpIdTxt.Height);
            EmployeeListBox.Width = EmpIdTxt.Width;
            EmployeeListBox.BringToFront();
            EmployeeListBox.Parent.Controls.SetChildIndex(EmployeeListBox, 0);
        }

        private void HideListBoxOnOutsideClick(object sender, EventArgs e)
        {
            Point cursor = this.PointToClient(Cursor.Position);
            if (!EmployeeListBox.Bounds.Contains(cursor) && !EmpIdTxt.Bounds.Contains(cursor))
            {
                EmployeeListBox.Visible = false;
            }
        }

        private void EmployeeListBox_MouseClick(object sender, MouseEventArgs e)
        {
            int idx = EmployeeListBox.IndexFromPoint(e.Location);
            if (idx == ListBox.NoMatches) return;

            var selected = (Employee)EmployeeListBox.Items[idx];
            selectedEmployeeId = selected.Id;
            suppressTextChanged = true;
            EmpIdTxt.Text = selected.Display;
            suppressTextChanged = false;
            EmployeeListBox.Visible = false;
        }

        private List<Employee> SearchEmployees(string search)
        {
            var list = new List<Employee>();
            try
            {
                using SqlConnection conn = DBConnector.GetConnection();
                conn.Open();
                string sql = @"SELECT id, first_name, last_name FROM Employee
                               WHERE CAST(id AS NVARCHAR) LIKE @q OR first_name LIKE @q OR last_name LIKE @q";
                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@q", "%" + search + "%");
                using SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(new Employee
                    {
                        Id = rdr["id"].ToString(),
                        FirstName = rdr["first_name"].ToString(),
                        LastName = rdr["last_name"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Employee search failed: " + ex.Message);
            }
            return list;
        }

        private void ViewLeavesBtn_Click(object sender, EventArgs e)
        {
            LoadLeaveData();
        }

        private void LoadLeaveData()
        {
            try
            {
                using SqlConnection conn = DBConnector.GetConnection();
                conn.Open();
                string sql = @"SELECT id, employee_id, from_date, to_date, type, status, requested_date, 
                               COALESCE(CAST(manager_id AS VARCHAR), '_') AS manager_display
                               FROM Leaves
                               WHERE (@empId IS NULL OR employee_id = @empId)
                               AND from_date >= @from AND to_date <= @to
                               AND (@status = 'All' OR status = @status)
                               ORDER BY from_date DESC";

                using SqlCommand cmd = new SqlCommand(sql, conn);
                if (int.TryParse(selectedEmployeeId, out int empId))
                    cmd.Parameters.AddWithValue("@empId", empId);
                else
                    cmd.Parameters.AddWithValue("@empId", DBNull.Value);

                cmd.Parameters.AddWithValue("@from", FromDate.Value.Date);
                cmd.Parameters.AddWithValue("@to", ToDate.Value.Date);
                cmd.Parameters.AddWithValue("@status", StatusFilter.SelectedItem.ToString());

                using SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                LeavesDataGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load leave data: " + ex.Message);
            }
        }

        private void LeavesDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (LeavesDataGrid.SelectedRows.Count != 1)
            {
                ApproveBtn.Enabled = false;
                RejectBtn.Enabled = false;
                return;
            }

            var status = LeavesDataGrid.SelectedRows[0].Cells["Status"].Value.ToString();
            bool isPending = status.Equals("Pending", StringComparison.OrdinalIgnoreCase);
            ApproveBtn.Enabled = isPending;
            RejectBtn.Enabled = isPending;
        }

        private void ApproveBtn_Click(object sender, EventArgs e) => UpdateLeaveStatus("Approved");
        private void RejectBtn_Click(object sender, EventArgs e) => UpdateLeaveStatus("Rejected");

        private void UpdateLeaveStatus(string newStatus)
        {
            if (LeavesDataGrid.SelectedRows.Count != 1) return;

            var row = LeavesDataGrid.SelectedRows[0];
            string leaveId = row.Cells["LeaveID"].Value.ToString();

            try
            {
                using SqlConnection conn = DBConnector.GetConnection();
                conn.Open();

                // Get manager ID from Manager table using CurrentSession.Username
                int managerId = -1;
                using (SqlCommand getIdCmd = new SqlCommand("SELECT id FROM Manager WHERE username = @username", conn))
                {
                    getIdCmd.Parameters.AddWithValue("@username", CurrentSession.Username);
                    object result = getIdCmd.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("Manager ID not found.");
                        return;
                    }
                    managerId = Convert.ToInt32(result);
                }

                // Update the specific leave request
                using (SqlCommand cmd = new SqlCommand("UPDATE Leaves SET status = @status, manager_id = @managerId WHERE id = @leaveId", conn))
                {
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@managerId", managerId);
                    cmd.Parameters.AddWithValue("@leaveId", int.Parse(leaveId));
                    cmd.ExecuteNonQuery();
                }

                LoadLeaveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }

        public class Employee
        {
            public string Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string DisplayOverride { get; set; }

            public string Display =>
                !string.IsNullOrEmpty(DisplayOverride) ? DisplayOverride :
                $"{Id} {FirstName} {LastName}";
        }
    }
}
