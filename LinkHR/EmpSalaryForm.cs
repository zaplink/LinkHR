using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LinkHR
{
    public partial class EmpSalaryForm : Form
    {
        private int employeeId;

        public EmpSalaryForm()
        {
            InitializeComponent();
            this.Load += EmpSalaryForm_Load;
            ViewSalaryBtn.Click += ViewSalaryBtn_Click;
        }

        private async void EmpSalaryForm_Load(object sender, EventArgs e)
        {
            ResetSummaryLabels();
            InitFilters();
            await LoadEmployeeIdAsync();
            await LoadSalaryDataAsync();
        }

        private void InitFilters()
        {
            int currentYear = DateTime.Now.Year;
            yearFilter.Items.Clear();
            for (int i = 0; i < 5; i++)
                yearFilter.Items.Add((currentYear - i).ToString());
            yearFilter.SelectedItem = currentYear.ToString();

            monthFilter.Items.Clear();
            foreach (string month in System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames)
            {
                if (!string.IsNullOrEmpty(month)) monthFilter.Items.Add(month);
            }
            monthFilter.Items.Insert(0, "All");
            monthFilter.SelectedIndex = 0;

            statusFilter.Items.Clear();
            statusFilter.Items.AddRange(new string[] { "All", "Pending", "Processed", "Failed" });
            statusFilter.SelectedIndex = 0;

            SalaryData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async Task LoadEmployeeIdAsync()
        {
            try
            {
                using SqlConnection conn = DBConnector.GetConnection();
                await conn.OpenAsync();

                string query = "SELECT id FROM Employee WHERE username = @username";
                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", CurrentSession.Username);

                object result = await cmd.ExecuteScalarAsync();
                if (result != null)
                {
                    employeeId = Convert.ToInt32(result);
                }
                else
                {
                    MessageBox.Show("Employee ID not found.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee ID: " + ex.Message);
            }
        }

        private async void ViewSalaryBtn_Click(object sender, EventArgs e)
        {
            await LoadSalaryDataAsync();
        }

        private void ResetSummaryLabels()
        {
            TotPaid.Text = "_";
            TotBonus.Text = "_";
            TotDedcutions.Text = "_";
            TotOvertime.Text = "_";
        }

        private async Task LoadSalaryDataAsync()
        {
            try
            {
                using SqlConnection conn = DBConnector.GetConnection();
                await conn.OpenAsync();

                string query = @"
                    SELECT id, employee_id, year, month, basic, overtime, bonus, deductions, net_amount, status
                    FROM Payroll
                    WHERE employee_id = @employeeId
                    AND (@year IS NULL OR year = @year)
                    AND (@month IS NULL OR month = @month)
                    AND (@status = 'All' OR status = @status)
                    ORDER BY year DESC, month DESC";

                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@employeeId", employeeId);
                cmd.Parameters.AddWithValue("@year", int.Parse(yearFilter.SelectedItem.ToString()));

                if (monthFilter.SelectedItem.ToString() == "All")
                    cmd.Parameters.AddWithValue("@month", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@month", monthFilter.SelectedIndex);

                cmd.Parameters.AddWithValue("@status", statusFilter.SelectedItem.ToString());

                using SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                SalaryData.DataSource = table;

                // Hide internal columns
                if (SalaryData.Columns.Contains("id"))
                    SalaryData.Columns["id"].Visible = false;
                if (SalaryData.Columns.Contains("employee_id"))
                    SalaryData.Columns["employee_id"].Visible = false;

                // Rename columns
                if (SalaryData.Columns.Contains("year")) SalaryData.Columns["year"].HeaderText = "Year";
                if (SalaryData.Columns.Contains("month")) SalaryData.Columns["month"].HeaderText = "Month";
                if (SalaryData.Columns.Contains("basic")) SalaryData.Columns["basic"].HeaderText = "Basic Pay";
                if (SalaryData.Columns.Contains("overtime")) SalaryData.Columns["overtime"].HeaderText = "Overtime";
                if (SalaryData.Columns.Contains("bonus")) SalaryData.Columns["bonus"].HeaderText = "Bonus";
                if (SalaryData.Columns.Contains("deductions")) SalaryData.Columns["deductions"].HeaderText = "Deductions";
                if (SalaryData.Columns.Contains("net_amount")) SalaryData.Columns["net_amount"].HeaderText = "Net Amount";
                if (SalaryData.Columns.Contains("status")) SalaryData.Columns["status"].HeaderText = "Status";

                // Reorder columns: Year and Month first
                if (SalaryData.Columns.Contains("year"))
                    SalaryData.Columns["year"].DisplayIndex = 0;
                if (SalaryData.Columns.Contains("month"))
                    SalaryData.Columns["month"].DisplayIndex = 1;

                // Update totals
                decimal totalPaid = 0, totalBonus = 0, totalDeduction = 0, totalOvertime = 0;
                foreach (DataRow row in table.Rows)
                {
                    totalPaid += row["net_amount"] != DBNull.Value ? Convert.ToDecimal(row["net_amount"]) : 0;
                    totalBonus += row["bonus"] != DBNull.Value ? Convert.ToDecimal(row["bonus"]) : 0;
                    totalDeduction += row["deductions"] != DBNull.Value ? Convert.ToDecimal(row["deductions"]) : 0;
                    totalOvertime += row["overtime"] != DBNull.Value ? Convert.ToDecimal(row["overtime"]) : 0;
                }

                TotPaid.Text = $"{totalPaid:C}";
                TotBonus.Text = $"{totalBonus:C}";
                TotDedcutions.Text = $"{totalDeduction:C}";
                TotOvertime.Text = $"{totalOvertime:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load salary data: " + ex.Message);
            }
        }

        private void yearFilter_SelectedIndexChanged(object sender, EventArgs e) { }
        private void monthFilter_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
