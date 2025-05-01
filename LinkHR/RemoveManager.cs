using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkHR
{
    public partial class RemoveManager : Form
    {
        // Event to notify other forms (e.g., ManagerListForm) of removal
        public event EventHandler ManagerRemoved;

        public RemoveManager()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
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
                                    id,
                                    first_name,
                                    last_name,
                                    email,
                                    contact_no
                                FROM Manager
                                WHERE id = @searchId";
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@searchId", searchId);
                        }
                        else
                        {
                            // Search by first_name or last_name (partial match)
                            query = @"
                                SELECT 
                                    id,
                                    first_name,
                                    last_name,
                                    email,
                                    contact_no
                                FROM Manager
                                WHERE first_name LIKE '%' + @searchTerm + '%' 
                                   OR last_name LIKE '%' + @searchTerm + '%'";
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@searchTerm", searchTerm);
                        }

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate the fields with manager details
                                textBoxManagerId.Text = reader["id"].ToString();
                                textBoxName.Text = $"{reader["first_name"]} {reader["last_name"]}";
                                textBoxEmail.Text = reader["email"]?.ToString() ?? "N/A";
                                textBoxPhoneNo.Text = reader["contact_no"]?.ToString() ?? "N/A";
                            }
                            else
                            {
                                MessageBox.Show("No manager found with the given ID or name.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFields();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching for manager: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxManagerId.Text))
            {
                MessageBox.Show("Please search for a manager to remove.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm removal
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to remove manager ID {textBoxManagerId.Text}? This action is irreversible.",
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

                    // Delete the manager by ID
                    string query = "DELETE FROM Manager WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(textBoxManagerId.Text));

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Manager removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            ManagerRemoved?.Invoke(this, EventArgs.Empty); // Notify other forms
                        }
                        else
                        {
                            MessageBox.Show("Failed to remove manager. Manager not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing manager: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            textBoxSearch.Clear();
            textBoxManagerId.Clear();
            textBoxName.Clear();
            textBoxEmail.Clear();
            textBoxPhoneNo.Clear();
        }


    }
}
