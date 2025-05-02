using Microsoft.Data.SqlClient;
using System.Data;

namespace LinkHR
{
    public partial class MngSalaryForm : Form
    {
        private System.Windows.Forms.Timer searchTimer;
        private CancellationTokenSource searchCts;
        private bool suppressTextChanged = false;
        private string selectedEmployeeId = null;

        public MngSalaryForm()
        {
            InitializeComponent();

            searchTimer = new System.Windows.Forms.Timer();
            searchTimer.Interval = 400;
            searchTimer.Tick += SearchTimer_Tick;

            FromDate.Format = DateTimePickerFormat.Short;
            ToDate.Format = DateTimePickerFormat.Short;
            ToDate.Value = DateTime.Today;

            ViewSalaryBtn.Click += ViewSalaryBtn_Click;
            EmpIdTxt.TextChanged += EmpIdTxt_TextChanged;
            EmpIdTxt.Click += EmpIdTxt_Click;
            EmployeeListBox.MouseClick += EmployeeListBox_MouseClick;
            this.Click += HideListBoxOnOutsideClick;

            ProcessSelectedBtn.Click += ProcessSelectedBtn_Click;
            ProcessSelectedBtn.Enabled = false;

            SalaryDataGrid.SelectionChanged += SalaryDataGrid_SelectionChanged;

            EmployeeListBox.Visible = false;

            InitializeSalaryGrid();

            suppressTextChanged = true;
            EmpIdTxt.Text = "[All Employees]";
            suppressTextChanged = false;
            selectedEmployeeId = null;
            ViewSalaryBtn.Enabled = true;

            StatusFilter.Items.AddRange(new[] { "All", "Pending", "Processed", "Failed" });
            StatusFilter.SelectedIndex = 0;
        }

        private void InitializeSalaryGrid()
        {
            SalaryDataGrid.AutoGenerateColumns = false;
            SalaryDataGrid.Columns.Clear();

            SalaryDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "employee_id", HeaderText = "Employee ID", Name = "employee_id" });
            SalaryDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "year", HeaderText = "Year", Name = "year" });
            SalaryDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "month", HeaderText = "Month", Name = "month" });
            SalaryDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "basic", HeaderText = "Basic" });
            SalaryDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "overtime", HeaderText = "Overtime" });
            SalaryDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "bonus", HeaderText = "Bonus" });
            SalaryDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "deductions", HeaderText = "Deductions" });
            SalaryDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "net_amount", HeaderText = "Net Pay" });
            SalaryDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "status", HeaderText = "Status", Name = "status" });
        }

        private void EmpIdTxt_TextChanged(object sender, EventArgs e)
        {
            if (suppressTextChanged) return;
            ViewSalaryBtn.Enabled = false;
            SalaryDataGrid.DataSource = null;
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
                    EmployeeListBox.BringToFront(); // bring again just in case
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
                EmployeeListBox.BringToFront();
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
            ViewSalaryBtn.Enabled = true;
        }

        private void HideListBoxOnOutsideClick(object sender, EventArgs e)
        {
            Point c = this.PointToClient(Cursor.Position);
            if (!EmployeeListBox.Bounds.Contains(c) && !EmpIdTxt.Bounds.Contains(c))
            {
                EmployeeListBox.Visible = false;
                if (!IsValidEmployee(EmpIdTxt.Text)) { ViewSalaryBtn.Enabled = false; }
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

        private async void ViewSalaryBtn_Click(object sender, EventArgs e)
        {
            await LoadPayrollDataAsync();
        }

        private async Task LoadPayrollDataAsync()
        {
            try
            {
                using SqlConnection conn = DBConnector.GetConnection();
                await conn.OpenAsync();

                int fromMonth = FromDate.Value.Month;
                int fromYear = FromDate.Value.Year;
                int toMonth = ToDate.Value.Month;
                int toYear = ToDate.Value.Year;

                string query = @"SELECT employee_id, year, month, basic, overtime, bonus, deductions, net_amount, status
                                 FROM Payroll
                                 WHERE (@empId IS NULL OR employee_id = @empId)
                                 AND (year > @fromYear OR (year = @fromYear AND month >= @fromMonth))
                                 AND (year < @toYear OR (year = @toYear AND month <= @toMonth))
                                 AND (@status = 'All' OR status = @status)
                                 ORDER BY year DESC, month DESC";

                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@empId", string.IsNullOrEmpty(selectedEmployeeId) ? (object)DBNull.Value : selectedEmployeeId);
                cmd.Parameters.AddWithValue("@fromYear", fromYear);
                cmd.Parameters.AddWithValue("@fromMonth", fromMonth);
                cmd.Parameters.AddWithValue("@toYear", toYear);
                cmd.Parameters.AddWithValue("@toMonth", toMonth);
                cmd.Parameters.AddWithValue("@status", StatusFilter.SelectedItem?.ToString() ?? "All");

                using SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                SalaryDataGrid.DataSource = table;
                ProcessSelectedBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payroll data: " + ex.Message);
            }
        }

        private void SalaryDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (SalaryDataGrid.SelectedRows.Count == 0)
            {
                ProcessSelectedBtn.Enabled = false;
                return;
            }

            try
            {
                var row = SalaryDataGrid.SelectedRows[0];
                var status = row.Cells[FindColumnIndexByName("status")].Value?.ToString();
                ProcessSelectedBtn.Enabled = status != null && status.Equals("Pending", StringComparison.OrdinalIgnoreCase);
            }
            catch
            {
                ProcessSelectedBtn.Enabled = false;
            }
        }

        private async void ProcessSelectedBtn_Click(object sender, EventArgs e)
        {
            if (SalaryDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to process.");
                return;
            }

            ProcessSelectedBtn.Enabled = false; // Disable button to prevent multiple clicks

            var row = SalaryDataGrid.SelectedRows[0];
            var employeeId = row.Cells[FindColumnIndexByName("employee_id")].Value.ToString();
            var year = Convert.ToInt32(row.Cells[FindColumnIndexByName("year")].Value);
            var month = Convert.ToInt32(row.Cells[FindColumnIndexByName("month")].Value);
            var status = row.Cells[FindColumnIndexByName("status")].Value?.ToString();

            // Prevent re-processing if already processed
            if (status?.Equals("Processed", StringComparison.OrdinalIgnoreCase) == true)
            {
                MessageBox.Show("This payroll is already processed.");
                ProcessSelectedBtn.Enabled = true;
                return;
            }

            try
            {
                using SqlConnection conn = DBConnector.GetConnection();
                await conn.OpenAsync();

                string sql = @"UPDATE Payroll 
                       SET status = 'Processed' 
                       WHERE employee_id = @empId AND year = @year AND month = @month AND status = 'Pending'";

                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@empId", employeeId);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@month", month);

                int rowsAffected = await cmd.ExecuteNonQueryAsync();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Status updated to 'Processed'.");
                }
                else
                {
                    Console.WriteLine("No changes made. It may already be processed or not pending.");
                }

                await LoadPayrollDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating status: " + ex.Message);
            }
            finally
            {
                ProcessSelectedBtn.Enabled = true;
            }
        }


        private int FindColumnIndexByName(string name)
        {
            foreach (DataGridViewColumn col in SalaryDataGrid.Columns)
            {
                if (col.Name == name) return col.Index;
            }
            throw new ArgumentException($"Column '{name}' not found.");
        }
    }
}
