using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;

namespace LinkHR
{
    public partial class AddEmployeeForm : Form
    {
        // Define a class for department items
        public class DepartmentItem
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Name; // Display the Name in the ComboBox
            }
        }

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            // Populate the Department ComboBox
            PopulateDepartmentComboBox();

            // Set default values for DateTimePickers
            dateTimePickerDOB.Value = DateTime.Today.AddYears(-20); // Default to 20 years ago
            dateTimePickerJoiningDate.Value = DateTime.Today; // Default to today

            // Set default gender to Male
            radioButtonMale.Checked = true;
        }

        private void PopulateDepartmentComboBox()
        {
            try
            {
                // Clear any existing items
                comboBoxDepartment.Items.Clear();

                using (SqlConnection conn = DBConnector.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT id, name FROM Department";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Add department as a DepartmentItem
                                comboBoxDepartment.Items.Add(new DepartmentItem
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Name = reader["name"].ToString()
                                });
                            }
                        }
                    }
                }

                // Select the first department by default if available
                if (comboBoxDepartment.Items.Count > 0)
                {
                    comboBoxDepartment.SelectedIndex = 0;
                    // Debug: Confirm the selected item
                    if (comboBoxDepartment.SelectedItem != null)
                    {
                        var selectedDept = (DepartmentItem)comboBoxDepartment.SelectedItem;
                        Console.WriteLine($"Selected department: Id={selectedDept.Id}, Name={selectedDept.Name}");
                    }
                }
                else
                {
                    MessageBox.Show("No departments found. Please add a department first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close(); // Close the form if no departments are available
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading departments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Close the form if an error occurs
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (!ValidateInputs())
            {
                return;
            }

            try
            {
                using (SqlConnection conn = DBConnector.GetConnection())
                {
                    conn.Open();

                    // Prepare the INSERT query
                    string query = @"
                        INSERT INTO Employee (id, username, password, email, first_name, last_name, contact_no, address, 
                                             department_id, role, dob, gender, joining_date)
                        VALUES (@id, @username, @password, @email, @first_name, @last_name, @contact_no, @address, 
                                @department_id, @role, @dob, @gender, @joining_date)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@id", int.Parse(textBoxEmployeeId.Text));
                        cmd.Parameters.AddWithValue("@username", textBoxUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", textBoxPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", textBoxEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@first_name", textBoxFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@last_name", textBoxLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@contact_no", textBoxContactNo.Text.Trim());
                        cmd.Parameters.AddWithValue("@address", textBoxAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@department_id", ((DepartmentItem)comboBoxDepartment.SelectedItem).Id);
                        cmd.Parameters.AddWithValue("@role", "emp"); // Default role to 'emp'
                        cmd.Parameters.AddWithValue("@dob", dateTimePickerDOB.Value);
                        cmd.Parameters.AddWithValue("@gender", radioButtonMale.Checked ? "M" : "F");
                        cmd.Parameters.AddWithValue("@joining_date", dateTimePickerJoiningDate.Value);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm(); // Clear the form after successful insertion
                            this.Close(); // Close the form to return to the previous view
                        }
                        else
                        {
                            MessageBox.Show("Failed to add employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Violation of UNIQUE constraint
                {
                    MessageBox.Show("Username, email, or employee ID already exists. Please use a different one.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            ClearForm();
        }

        private bool ValidateInputs()
        {
            // Check for empty required fields
            if (string.IsNullOrWhiteSpace(textBoxEmployeeId.Text))
            {
                MessageBox.Show("Please enter an Employee ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(textBoxEmployeeId.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Please enter a valid positive integer for Employee ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text))
            {
                MessageBox.Show("Please enter a first name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                MessageBox.Show("Please enter a last name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                MessageBox.Show("Please enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Please enter a password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxConfirmPassword.Text))
            {
                MessageBox.Show("Please confirm the password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (textBoxPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Please enter an email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate email format
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(textBoxEmail.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (comboBoxDepartment.SelectedItem == null || comboBoxDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a department.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate contact number format (allow 2-15 digits)
            if (!string.IsNullOrWhiteSpace(textBoxContactNo.Text) && !Regex.IsMatch(textBoxContactNo.Text, @"^\d{2,15}$"))
            {
                MessageBox.Show("Please enter a valid contact number (2-15 digits).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate dates
            if (dateTimePickerDOB.Value >= DateTime.Today)
            {
                MessageBox.Show("Date of birth must be in the past.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dateTimePickerJoiningDate.Value > DateTime.Today)
            {
                MessageBox.Show("Joining date cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            textBoxEmployeeId.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxConfirmPassword.Clear();
            textBoxEmail.Clear();
            textBoxContactNo.Clear();
            textBoxAddress.Clear();
            if (comboBoxDepartment.Items.Count > 0)
            {
                comboBoxDepartment.SelectedIndex = 0;
            }
            dateTimePickerDOB.Value = DateTime.Today.AddYears(-20); // Default to 20 years ago
            dateTimePickerJoiningDate.Value = DateTime.Today;
            radioButtonMale.Checked = true; // Default to Male
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
    }
}