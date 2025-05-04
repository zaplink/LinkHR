using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LinkHR
{
    public partial class HomeEmployee : Form
    {
        public HomeEmployee()
        {
            InitializeComponent();
        }

        private void HomeEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployeeDetails();
            RenderCalendar();
        }

        private void LoadEmployeeDetails()
        {
            try
            {
                using (SqlConnection conn = DBConnector.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            id,
                            first_name,
                            last_name,
                            username,
                            email,
                            contact_no
                        FROM Employee
                        WHERE username = @username AND role = @role";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", CurrentSession.Username);
                        cmd.Parameters.AddWithValue("@role", CurrentSession.Role);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate the welcome message and account details
                                lblWelcome.Text = $"Welcome, {reader["first_name"]}";
                                txtEmployeeId.Text = reader["id"].ToString();
                                txtName.Text = $"{reader["first_name"]} {reader["last_name"]}";
                                txtUsername.Text = reader["username"].ToString();
                                txtEmail.Text = reader["email"].ToString();
                                txtPhoneNo.Text = reader["contact_no"]?.ToString() ?? "N/A";
                            }
                            else
                            {
                                MessageBox.Show("Employee details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employee details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RenderCalendar()
        {
            // Create a MonthCalendar control
            MonthCalendar calendar = new MonthCalendar
            {
                Dock = DockStyle.Fill, // Make the calendar fill the panel's width
                MaxSelectionCount = 1, // Allow only single-day selection
                BackColor = System.Drawing.Color.White,
                ForeColor = System.Drawing.Color.Black,
                TitleBackColor = System.Drawing.Color.LightGray,
                TitleForeColor = System.Drawing.Color.Black,
                CalendarDimensions = new System.Drawing.Size(2, 1) // Display 2 months horizontally
            };

            // Set today's date as the selected date
            calendar.SetDate(DateTime.Today);

            // Clear any existing controls and add the calendar to the calendarPanel
            calendarPanel.Controls.Clear();
            calendarPanel.Controls.Add(calendar);

            // Enable scrolling in the panel if the calendar height exceeds the panel
            calendarPanel.AutoScroll = true;

            // Ensure no padding or margin interferes with the layout
            calendarPanel.Padding = new Padding(0);
            calendarPanel.Margin = new Padding(0);
        }
    }
}