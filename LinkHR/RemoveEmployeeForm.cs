using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LinkHR
{
    public partial class RemoveEmployeeForm : Form
    {
        public event EventHandler EmployeeRemoved;

        public RemoveEmployeeForm()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter an ID or name to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DBConnector.GetConnection())
                {
                    conn.Open();

                    string query;
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;

                        // Check if the search term is an integer (for ID search)
                        if (int.TryParse(searchTerm, out int searchId))
                        {
                            // Search by ID (exact match)
                            query = @"
                                SELECT 
                                    e.id,
                                    e.first_name,
                                    e.last_name,
                                    d.name AS department_name,
                                    e.role
                                FROM Employee e
                                LEFT JOIN Department d ON e.department_id = d.id
                                WHERE e.id = @searchId";
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@searchId", searchId);
                        }
                        else
                        {
                            // Search by first_name or last_name (partial match)
                            query = @"
                                SELECT 
                                    e.id,
                                    e.first_name,
                                    e.last_name,
                                    d.name AS department_name,
                                    e.role
                                FROM Employee e
                                LEFT JOIN Department d ON e.department_id = d.id
                                WHERE e.first_name LIKE '%' + @searchTerm + '%' 
                                   OR e.last_name LIKE '%' + @searchTerm + '%'";
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@searchTerm", searchTerm);
                        }

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate the fields with employee details
                                textBoxEmployeeId.Text = reader["id"].ToString();
                                textBoxName.Text = $"{reader["first_name"]} {reader["last_name"]}";
                                textBoxDepartment.Text = reader["department_name"]?.ToString() ?? "N/A";
                                textBoxPosition.Text = reader["role"]?.ToString() ?? "N/A";
                            }
                            else
                            {
                                MessageBox.Show("No employee found with the given ID or name.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFields();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching for employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemove_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmployeeId.Text))
            {
                MessageBox.Show("Please search for an employee to remove.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to remove employee ID {textBoxEmployeeId.Text}? This action is irreversible.",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (SqlConnection conn = DBConnector.GetConnection())
                {
                    conn.Open();

                    string query = "DELETE FROM Employee WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(textBoxEmployeeId.Text));

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            EmployeeRemoved?.Invoke(this, EventArgs.Empty);
                        }
                        else
                        {
                            MessageBox.Show("Failed to remove employee. Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            textBoxSearch.Clear();
            textBoxEmployeeId.Clear();
            textBoxName.Clear();
            textBoxDepartment.Clear();
            textBoxPosition.Clear();
        }

        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
    }
}