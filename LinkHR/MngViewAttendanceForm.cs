using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LinkHR
{
    public partial class MngViewAttendanceForm : Form
    {
        private System.Windows.Forms.Timer searchTimer;
        private CancellationTokenSource searchCts;
        private bool suppressTextChanged = false;
        private string selectedEmployeeId = null;

        public MngViewAttendanceForm()
        {
            InitializeComponent();

            searchTimer = new System.Windows.Forms.Timer();
            searchTimer.Interval = 400;
            searchTimer.Tick += SearchTimer_Tick;

            FromDate.Format = DateTimePickerFormat.Short;
            ToDate.Format = DateTimePickerFormat.Short;
            ToDate.Value = DateTime.Today;

            ViewAttendanceBtn.Click += ViewAttendanceBtn_Click;
            EmpIdTxt.TextChanged += EmpIdTxt_TextChanged;
            EmpIdTxt.Click += EmpIdTxt_Click;
            EmployeeListBox.MouseClick += EmployeeListBox_MouseClick;
            this.Click += HideListBoxOnOutsideClick;

            EmployeeListBox.Visible = false;
            AttendanceDataGrid.AutoGenerateColumns = false;


            suppressTextChanged = true;
            EmpIdTxt.Text = "[All Employees]";
            suppressTextChanged = false;
            selectedEmployeeId = null;
            ViewAttendanceBtn.Enabled = true;

        }

        private void EmpIdTxt_TextChanged(object sender, EventArgs e)
        {
            if (suppressTextChanged) return;
            ViewAttendanceBtn.Enabled = false;
            AttendanceDataGrid.DataSource = null;
            EmpTotalWorkingHoursFill.Text = "0";
            searchTimer.Stop();
            searchTimer.Start();
        }

        private async void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchCts?.Cancel();
            searchCts = new CancellationTokenSource();
            var token = searchCts.Token;

            string q = EmpIdTxt.Text.Trim();
            if (string.IsNullOrEmpty(q)) { EmployeeListBox.Visible = false; return; }

            EmployeeListBox.DataSource = null;
            EmployeeListBox.Items.Clear();
            EmployeeListBox.Items.Add("Searching...");
            PositionListBoxUnderTextBox();
            EmployeeListBox.BringToFront();
            EmployeeListBox.Visible = true;

            try
            {
                var emps = await Task.Run(() => SearchEmployees(q), token);
                if (token.IsCancellationRequested) return;

                BeginInvoke(new Action(() =>
                {
                    if (emps.Count > 0)
                    {
                        EmployeeListBox.DataSource = emps;
                        EmployeeListBox.DisplayMember = "Display";
                    }
                    else
                    {
                        EmployeeListBox.DataSource = null;
                        EmployeeListBox.Items.Clear();
                        EmployeeListBox.Items.Add("No results");
                    }
                }));
            }
            catch (OperationCanceledException) { }
        }

        private void EmpIdTxt_Click(object sender, EventArgs e)
        {
            string q = EmpIdTxt.Text.Trim();
            var emps = SearchEmployees(q);
            if (emps.Count > 0)
            {
                EmployeeListBox.DataSource = emps;
                EmployeeListBox.DisplayMember = "Display";
                PositionListBoxUnderTextBox();
                EmployeeListBox.Visible = true;
            }
            else EmployeeListBox.Visible = false;
        }

        private void EmployeeListBox_MouseClick(object sender, MouseEventArgs e)
        {
            int idx = EmployeeListBox.IndexFromPoint(e.Location);
            if (idx == ListBox.NoMatches) return;
            var sel = (Employee)EmployeeListBox.Items[idx];
            suppressTextChanged = true;
            EmpIdTxt.Text = sel.Display;
            suppressTextChanged = false;
            selectedEmployeeId = sel.id == "0" ? null : sel.id;
            EmployeeListBox.Visible = false;
            ViewAttendanceBtn.Enabled = true;
        }

        private void HideListBoxOnOutsideClick(object sender, EventArgs e)
        {
            Point c = this.PointToClient(Cursor.Position);
            if (!EmployeeListBox.Bounds.Contains(c) && !EmpIdTxt.Bounds.Contains(c))
            {
                EmployeeListBox.Visible = false;
                if (!IsValidEmployee(EmpIdTxt.Text)) { ViewAttendanceBtn.Enabled = false; }
            }
        }

        private void PositionListBoxUnderTextBox()
        {
            var tb = EmpIdTxt.PointToScreen(Point.Empty);
            var frm = PointToScreen(Point.Empty);
            EmployeeListBox.Location = new Point(tb.X - frm.X, tb.Y - frm.Y + EmpIdTxt.Height);
            EmployeeListBox.Width = EmpIdTxt.Width;
        }

        private bool IsValidEmployee(string empDisplayText)
        {
            var emps = SearchEmployees("");
            return emps.Any(e => e.Display.Equals(empDisplayText, StringComparison.OrdinalIgnoreCase));
        }

        private List<Employee> SearchEmployees(string search)
        {
            var list = new List<Employee>
            {
                new Employee { id = "0", firstName = "[All", lastName = "Employees]" }
            };

            try
            {
                using SqlConnection conn = DBConnector.GetConnection();
                conn.Open();
                string sql = @"SELECT id, first_name, last_name FROM Employee
                               WHERE first_name LIKE @q OR last_name LIKE @q OR CAST(id AS NVARCHAR) LIKE @q";
                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@q", "%" + search + "%");
                using SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(new Employee
                    {
                        id = rdr["id"].ToString(),
                        firstName = rdr["first_name"].ToString(),
                        lastName = rdr["last_name"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving employees: " + ex.Message);
            }

            return list;
        }

        public class Employee
        {
            public string id { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string Display => id == "0" ? "[All Employees]" : $"{id} {firstName} {lastName}";
        }

        private void ViewAttendanceBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedEmployeeId) && EmpIdTxt.Text != "[All Employees]")
            {
                MessageBox.Show("Please select a valid employee.");
                return;
            }

            LoadAttendanceData(selectedEmployeeId, FromDate.Value.Date, ToDate.Value.Date);
        }

        private void LoadAttendanceData(string empId, DateTime from, DateTime to)
        {
            try
            {
                using SqlConnection conn = DBConnector.GetConnection();
                conn.Open();

                string query;
                SqlCommand cmd;

                if (string.IsNullOrEmpty(empId))
                {
                    query = @"SELECT employee_id, date, check_in, check_out, hours_worked
                              FROM Attendance
                              WHERE date BETWEEN @from AND @to
                              ORDER BY employee_id, date";
                    cmd = new SqlCommand(query, conn);
                }
                else
                {
                    query = @"SELECT date, check_in, check_out, hours_worked
                              FROM Attendance
                              WHERE employee_id = @empId AND date BETWEEN @from AND @to
                              ORDER BY date";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@empId", empId);
                }

                cmd.Parameters.AddWithValue("@from", from);
                cmd.Parameters.AddWithValue("@to", to);

                using SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                AttendanceDataGrid.Columns.Clear();

                if (string.IsNullOrEmpty(empId))
                {
                    AttendanceDataGrid.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "employee_id",
                        HeaderText = "Employee ID",
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    });
                }

                AttendanceDataGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "date",
                    HeaderText = "Date",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
                AttendanceDataGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "check_in",
                    HeaderText = "Check In",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
                AttendanceDataGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "check_out",
                    HeaderText = "Check Out",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
                AttendanceDataGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "hours_worked",
                    HeaderText = "Hours Worked",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });

                AttendanceDataGrid.DataSource = dt;

                double totalHours = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["hours_worked"] != DBNull.Value)
                        totalHours += Convert.ToDouble(row["hours_worked"]);
                }

                EmpTotalWorkingHoursFill.Text = totalHours.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance: " + ex.Message);
            }
        }

        private void ViewAttendanceForm_Load(object sender, EventArgs e) { }
    }
}
