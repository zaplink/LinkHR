using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LinkHR
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim(); // Assuming textBox1 is the Username textbox
            string password = textBox2.Text.Trim(); // Assuming textBox2 is the Password textbox

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DBConnector.GetConnection())
                {
                    conn.Open();

                    // Check if the user is an Admin
                    string adminQuery = "SELECT role FROM Admin WHERE username = @username AND password = @password";
                    using (SqlCommand cmd = new SqlCommand(adminQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader["role"].ToString();
                                if (role == "admin")
                                {
                                    OpenDashboard(new AdminDashboard());
                                    return;
                                }
                            }
                        }
                    }

                    // Check if the user is an Manager
                    string mngQuery = "SELECT role FROM Manager WHERE username = @username AND password = @password";
                    using (SqlCommand cmd = new SqlCommand(mngQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader["role"].ToString();
                                if (role == "mng")
                                {
                                    OpenDashboard(new MngDashboard());
                                    return;
                                }
                            }
                        }
                    }

                    // Check if the user is an Employee
                    string empQuery = "SELECT id, role FROM Employee WHERE username = @username AND password = @password";
                    using (SqlCommand cmd = new SqlCommand(empQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int employeeId = Convert.ToInt32(reader["id"]);
                                string role = reader["role"].ToString();
                                if (role == "emp")
                                {
                                    OpenDashboard(new EmpDashboard());
                                    return;
                                }
                            }
                        }
                    }

                    // If no match is found
                    MessageBox.Show("Invalid username or password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenDashboard(Form dashboardForm)
        {
            dashboardForm.Show();
            this.Hide();
        }


        // Method to reset the form's state (clear username and password fields)
        public void ResetForm()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}