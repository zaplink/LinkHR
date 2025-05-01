using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LinkHR
{
    public partial class EmpLeaveForm : Form
    {
        private string employeeId;

        public EmpLeaveForm()
        {
            InitializeComponent();
            InitializeForm();
            this.Load += EmpLeaveForm_Load;
        }

        private async void EmpLeaveForm_Load(object sender, EventArgs e)
        {
            await LoadEmployeeIdAsync();
            await LoadLeaveHistoryAsync();
        }

        private void InitializeForm()
        {
            // Fix: Clear previous items before adding new ones
            LeaveTypeCombo.Items.Clear();
            LeaveTypeCombo.Items.AddRange(new[] { "Select a type", "Half Day", "Full Day", "Annual", "Sick" });
            LeaveTypeCombo.SelectedIndex = 0; // Default selection is "Select a type"

            SubmitLeaveBtn.Enabled = false;

            // Enable/Disable Submit button based on selection
            LeaveTypeCombo.SelectedIndexChanged += (s, e) =>
            {
                SubmitLeaveBtn.Enabled = LeaveTypeCombo.SelectedIndex > 0; // Only enable if a valid type is selected
            };

            // DatePicker formats
            FromDatePicker.Format = DateTimePickerFormat.Short;
            ToDatePicker.Format = DateTimePickerFormat.Short;

            // Button click event
            SubmitLeaveBtn.Click += SubmitLeaveBtn_Click;

            // DataGridView settings for full-width
            LeaveHistoryGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LeaveHistoryGrid.RowHeadersVisible = false;
            LeaveHistoryGrid.AllowUserToAddRows = false;
            LeaveHistoryGrid.ReadOnly = true;
        }

        private async Task LoadEmployeeIdAsync()
        {
            try
            {
                using SqlConnection conn = DBConnector.GetConnection();
                await conn.OpenAsync();

                string sql = "SELECT id FROM Employee WHERE LOWER(username) = @username";
                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", CurrentSession.Username.Trim().ToLower());

                var result = await cmd.ExecuteScalarAsync();
                if (result == null)
                {
                    MessageBox.Show("No employee found for current session user: " + CurrentSession.Username);
                    return;
                }

                employeeId = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee ID: " + ex.Message);
            }
        }

        private async Task LoadLeaveHistoryAsync()
        {
            if (string.IsNullOrWhiteSpace(employeeId)) return;

            try
            {
                using SqlConnection conn = DBConnector.GetConnection();
                await conn.OpenAsync();

                string sql = @"SELECT 
                                requested_date AS [Requested Date],
                                from_date AS [From Date],
                                to_date AS [To Date],
                                type AS [Type],
                                status AS [Status]
                               FROM Leaves
                               WHERE employee_id = @empId
                               ORDER BY requested_date DESC";

                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@empId", employeeId);

                using SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                LeaveHistoryGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load leave history: " + ex.Message);
            }
        }

        private async void SubmitLeaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(employeeId))
            {
                MessageBox.Show("Employee ID is not loaded.");
                return;
            }

            string leaveType = LeaveTypeCombo.SelectedItem.ToString();
            DateTime fromDate = FromDatePicker.Value.Date;
            DateTime toDate = ToDatePicker.Value.Date;

            if (fromDate > toDate)
            {
                MessageBox.Show("From Date cannot be after To Date.");
                return;
            }

            try
            {
                using SqlConnection conn = DBConnector.GetConnection();
                await conn.OpenAsync();

                string insertSql = @"INSERT INTO Leaves 
                    (employee_id, requested_date, from_date, to_date, type, status)
                    VALUES (@empId, @reqDate, @fromDate, @toDate, @type, 'Pending')";

                using SqlCommand cmd = new SqlCommand(insertSql, conn);
                cmd.Parameters.AddWithValue("@empId", employeeId);
                cmd.Parameters.AddWithValue("@reqDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@fromDate", fromDate);
                cmd.Parameters.AddWithValue("@toDate", toDate);
                cmd.Parameters.AddWithValue("@type", leaveType);

                await cmd.ExecuteNonQueryAsync();

                MessageBox.Show("Leave request submitted.");
                LeaveTypeCombo.SelectedIndex = 0;

                await LoadLeaveHistoryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting leave request: " + ex.Message);
            }
        }
    }
}
