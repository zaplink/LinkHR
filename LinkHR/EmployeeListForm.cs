using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LinkHR
{
    public partial class EmployeeListForm : Form
    {
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("EmployeeListForm_Load event fired.");
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            try
            {
                Console.WriteLine("Attempting to load employee data...");

                using (SqlConnection conn = DBConnector.GetConnection())
                {
                    Console.WriteLine("Opening database connection...");
                    conn.Open();
                    Console.WriteLine("Connection opened successfully.");

                    // SQL query to fetch employee data with department name
                    string query = @"
                        SELECT 
                            e.id,
                            e.first_name,
                            e.last_name,
                            e.dob,
                            e.contact_no,
                            e.address,
                            e.email,
                            d.name AS department_name,
                            e.gender,
                            e.joining_date,
                            e.role
                        FROM Employee e
                        LEFT JOIN Department d ON e.department_id = d.id";

                    Console.WriteLine("Executing query...");
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        // Create a DataTable to hold the query results
                        DataTable employeeTable = new DataTable();
                        adapter.Fill(employeeTable);

                        Console.WriteLine($"Rows retrieved: {employeeTable.Rows.Count}");

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = employeeTable;

                        if (employeeTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No employees found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                // Customize the DataGridView columns
                CustomizeDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employee data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Exception occurred: {ex.Message}");
            }
        }

        private void CustomizeDataGridView()
        {
            // Ensure the DataGridView is not null and has a data source
            if (dataGridView1.DataSource == null)
            {
                Console.WriteLine("DataGridView DataSource is null.");
                return;
            }

            // Rename column headers to be more user-friendly
            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["first_name"].HeaderText = "First name";
            dataGridView1.Columns["last_name"].HeaderText = "Last name";
            dataGridView1.Columns["dob"].HeaderText = "Birthday";
            dataGridView1.Columns["contact_no"].HeaderText = "Phone no.";
            dataGridView1.Columns["address"].HeaderText = "Address";
            dataGridView1.Columns["email"].HeaderText = "Email";
            dataGridView1.Columns["department_name"].HeaderText = "Department";
            dataGridView1.Columns["gender"].HeaderText = "Gender";
            dataGridView1.Columns["joining_date"].HeaderText = "Joining Date";
            dataGridView1.Columns["role"].HeaderText = "Role";

            // Adjust column widths (optional)
            dataGridView1.Columns["id"].Width = 50;
            dataGridView1.Columns["first_name"].Width = 100;
            dataGridView1.Columns["last_name"].Width = 100;
            dataGridView1.Columns["dob"].Width = 100;
            dataGridView1.Columns["contact_no"].Width = 100;
            dataGridView1.Columns["address"].Width = 150;
            dataGridView1.Columns["email"].Width = 150;
            dataGridView1.Columns["department_name"].Width = 100;
            dataGridView1.Columns["gender"].Width = 60;
            dataGridView1.Columns["joining_date"].Width = 100;
            dataGridView1.Columns["role"].Width = 60;

            // Format the date columns
            dataGridView1.Columns["dob"].DefaultCellStyle.Format = "yyyy-MM-dd";
            dataGridView1.Columns["joining_date"].DefaultCellStyle.Format = "yyyy-MM-dd";

            // Optional: Make the DataGridView read-only
            dataGridView1.ReadOnly = true;

            // Optional: Disable row headers and prevent adding new rows
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;

            Console.WriteLine("DataGridView customized successfully.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Add functionality later (e.g., view/edit employee details on click)
        }
    }
}