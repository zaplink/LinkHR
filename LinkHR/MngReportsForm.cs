using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkHR
{
    public partial class MngReportsForm : Form
    {
        private System.Windows.Forms.Timer searchTimer;
        private CancellationTokenSource searchCts;
        private bool suppressTextChanged = false;
        private string selectedEmployeeId = null;

        // Report types can be filled here
        private List<string> reportTypes = new List<string> { "Salary", "Attendance", "Work Hours" };

        public MngReportsForm()
        {
            InitializeComponent();

            // Initialize components like ComboBox for report types and export types
            cmbReportType.Items.AddRange(reportTypes.ToArray());
            cmbExportType.Items.AddRange(new string[] { "Excel", "PDF" });

            // Set default selections
            cmbReportType.SelectedIndex = 0; // Default Report: Salary
            cmbExportType.SelectedIndex = 0; // Default Export: Excel

            // Initialize the Employee search and report functionality
            searchTimer = new System.Windows.Forms.Timer();
            searchTimer.Interval = 400;
            searchTimer.Tick += SearchTimer_Tick;

            txtSearchEmp.TextChanged += TxtSearchEmp_TextChanged;
            txtSearchEmp.Click += TxtSearchEmp_Click;
            lstEmployees.MouseClick += LstEmployees_MouseClick;
            this.Click += HideListBoxOnOutsideClick;

            lstEmployees.Visible = false;
            suppressTextChanged = true;
            txtSearchEmp.Text = "[All Employees]";
            suppressTextChanged = false;
            selectedEmployeeId = null;
            btnGenerate.Enabled = true;
        }

        // Search Timer Tick event to handle asynchronous employee search
        private async void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchCts?.Cancel();
            searchCts = new CancellationTokenSource();
            var token = searchCts.Token;

            string q = txtSearchEmp.Text.Trim();
            if (string.IsNullOrEmpty(q)) { lstEmployees.Visible = false; return; }

            lstEmployees.DataSource = null;
            lstEmployees.Items.Clear();
            lstEmployees.Items.Add("Searching...");
            PositionListBoxUnderTextBox();
            lstEmployees.BringToFront();
            lstEmployees.Visible = true;

            try
            {
                var emps = await Task.Run(() => SearchEmployees(q), token);
                if (token.IsCancellationRequested) return;

                BeginInvoke(new Action(() =>
                {
                    if (emps.Count > 0)
                    {
                        lstEmployees.DataSource = emps;
                        lstEmployees.DisplayMember = "Display";
                    }
                    else
                    {
                        lstEmployees.DataSource = null;
                        lstEmployees.Items.Clear();
                        lstEmployees.Items.Add("No results");
                    }
                }));
            }
            catch (OperationCanceledException) { }
        }

        private void TxtSearchEmp_TextChanged(object sender, EventArgs e)
        {
            if (suppressTextChanged) return;
            btnGenerate.Enabled = false;
            dgvReport.DataSource = null;
            searchTimer.Stop();
            searchTimer.Start();
        }

        private void TxtSearchEmp_Click(object sender, EventArgs e)
        {
            string q = txtSearchEmp.Text.Trim();
            var emps = SearchEmployees(q);
            if (emps.Count > 0)
            {
                lstEmployees.DataSource = emps;
                lstEmployees.DisplayMember = "Display";
                PositionListBoxUnderTextBox();
                lstEmployees.Visible = true;
            }
            else lstEmployees.Visible = false;
        }

        private void LstEmployees_MouseClick(object sender, MouseEventArgs e)
        {
            int idx = lstEmployees.IndexFromPoint(e.Location);
            if (idx == ListBox.NoMatches) return;

            var sel = (Employee)lstEmployees.Items[idx];
            suppressTextChanged = true;
            txtSearchEmp.Text = sel.Display;
            suppressTextChanged = false;
            selectedEmployeeId = sel.id == "0" ? null : sel.id;
            lstEmployees.Visible = false;
            btnGenerate.Enabled = true;
        }

        private void HideListBoxOnOutsideClick(object sender, EventArgs e)
        {
            Point c = this.PointToClient(Cursor.Position);
            if (!lstEmployees.Bounds.Contains(c) && !txtSearchEmp.Bounds.Contains(c))
            {
                lstEmployees.Visible = false;
                if (!IsValidEmployee(txtSearchEmp.Text)) { btnGenerate.Enabled = false; }
            }
        }

        private void PositionListBoxUnderTextBox()
        {
            var tb = txtSearchEmp.PointToScreen(Point.Empty);
            var frm = PointToScreen(Point.Empty);
            lstEmployees.Location = new Point(tb.X - frm.X, tb.Y - frm.Y + txtSearchEmp.Height);
            lstEmployees.Width = txtSearchEmp.Width;
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

        // Handle Report generation and display
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedEmployeeId) && txtSearchEmp.Text != "[All Employees]")
            {
                MessageBox.Show("Please select a valid employee.");
                return;
            }

            LoadReportData(selectedEmployeeId, dtFrom.Value.Date, dtTo.Value.Date);
        }

        private void LoadReportData(string empId, DateTime from, DateTime to)
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

                // Debugging: Log the number of rows retrieved
                MessageBox.Show($"Rows Retrieved: {dt.Rows.Count}");

                // If no data is found, return early
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No records found for the selected date range.");
                    return;
                }

                // Clear existing columns
                dgvReport.Columns.Clear();

                // Add columns based on the DataTable schema
                dgvReport.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "employee_id",
                    HeaderText = "Employee ID",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
                dgvReport.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "date",
                    HeaderText = "Date",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
                dgvReport.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "check_in",
                    HeaderText = "Check In",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
                dgvReport.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "check_out",
                    HeaderText = "Check Out",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
                dgvReport.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "hours_worked",
                    HeaderText = "Hours Worked",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });

                // Bind the DataTable to the DataGridView
                dgvReport.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report data: " + ex.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string exportType = cmbExportType.SelectedItem.ToString();
            if (exportType == "Excel")
            {
                // Export to Excel logic
                ExportToExcel(dgvReport);
            }
            else if (exportType == "PDF")
            {
                // Export to PDF logic
                ExportToPdf(dgvReport);
            }
            MessageBox.Show($"Report Exported as {exportType}.");
        }

        // Export to Excel logic (implement as per your requirements)
        private void ExportToExcel(DataGridView dgv)
        {
            // Logic to export to Excel
        }

        // Export to PDF logic (implement as per your requirements)
        private void ExportToPdf(DataGridView dgv)
        {
            // Logic to export to PDF
        }
    }
}
