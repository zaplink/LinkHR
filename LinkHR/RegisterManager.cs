using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LinkHR
{
    public partial class RegisterManager : Form
    {
        public RegisterManager()
        {
            InitializeComponent();
        }

        private void RegisterManager_Load(object sender, EventArgs e)
        {
            // Set default values for date pickers (optional)
            dateTimePickerDOB.Value = DateTime.Now.AddYears(-30); // Default to 30 years ago
            dateTimePickerJoiningDate.Value = DateTime.Now; // Default to today
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text))
            {
                MessageBox.Show("Please enter the first name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                MessageBox.Show("Please enter the last name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Please enter the email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                MessageBox.Show("Please enter the username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Please enter the password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBoxPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the username already exists
            try
            {
                using (SqlConnection conn = DBConnector.GetConnection())
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Manager WHERE username = @username";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose a different username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert the new manager
                    string insertQuery = @"
                        INSERT INTO Manager (username, password, role, email, first_name, last_name, contact_no, address, department_id, dob, gender, joining_date)
                        VALUES (@username, @password, 'mng', @email, @first_name, @last_name, @contact_no, @address, @department_id, @dob, @gender, @joining_date)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
                        cmd.Parameters.AddWithValue("@password", textBoxPassword.Text); // In a real app, hash the password
                        cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                        cmd.Parameters.AddWithValue("@first_name", textBoxFirstName.Text);
                        cmd.Parameters.AddWithValue("@last_name", textBoxLastName.Text);
                        cmd.Parameters.AddWithValue("@contact_no", string.IsNullOrWhiteSpace(textBoxContactNo.Text) ? (object)DBNull.Value : textBoxContactNo.Text);
                        cmd.Parameters.AddWithValue("@address", string.IsNullOrWhiteSpace(textBoxAddress.Text) ? (object)DBNull.Value : textBoxAddress.Text);
                        cmd.Parameters.AddWithValue("@department_id", 1); // Hardcoded to HR department (1)
                        cmd.Parameters.AddWithValue("@dob", dateTimePickerDOB.Value.Date);
                        cmd.Parameters.AddWithValue("@gender", radioButtonMale.Checked ? "M" : (radioButtonFemale.Checked ? "F" : (object)DBNull.Value));
                        cmd.Parameters.AddWithValue("@joining_date", dateTimePickerJoiningDate.Value.Date);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Manager registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to register manager.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error registering manager: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            dateTimePickerDOB.Value = DateTime.Now.AddYears(-30);
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            textBoxContactNo.Clear();
            textBoxEmail.Clear();
            textBoxAddress.Clear();
            dateTimePickerJoiningDate.Value = DateTime.Now;
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxConfirmPassword.Clear();
        }



    }
}