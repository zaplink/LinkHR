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

        private void EmployeeListForm_Load_1(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        public void RefreshData()
        {
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            try
            {
                using (SqlConnection conn = DBConnector.GetConnection())
                {
                    conn.Open();

                    // Query to fetch employee data with department name, excluding first_name and last_name separately
                    string query = @"
                        SELECT 
                            e.id,
                            e.username,
                            e.role,
                            e.email,
                            CONCAT(e.first_name, ' ', e.last_name) AS full_name,
                            e.contact_no,
                            e.address,
                            d.name AS department_name,
                            e.dob,
                            e.gender,
                            e.joining_date
                        FROM Employee e
                        LEFT JOIN Department d ON e.department_id = d.id";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable employeeTable = new DataTable();
                        adapter.Fill(employeeTable);

                        // Bind the DataTable to the DataGridView
                        EmpListdataGridView.DataSource = employeeTable;

                        // Customize column headers for better readability
                        EmpListdataGridView.Columns["id"].HeaderText = "ID";
                        EmpListdataGridView.Columns["username"].HeaderText = "Username";
                        EmpListdataGridView.Columns["role"].HeaderText = "Role";
                        EmpListdataGridView.Columns["email"].HeaderText = "Email";
                        EmpListdataGridView.Columns["full_name"].HeaderText = "Name";
                        EmpListdataGridView.Columns["contact_no"].HeaderText = "Contact No";
                        EmpListdataGridView.Columns["address"].HeaderText = "Address";
                        EmpListdataGridView.Columns["department_name"].HeaderText = "Department";
                        EmpListdataGridView.Columns["dob"].HeaderText = "DOB";
                        EmpListdataGridView.Columns["gender"].HeaderText = "Gender";
                        EmpListdataGridView.Columns["joining_date"].HeaderText = "Joining Date";

                        // Make the DataGridView scrollable
                        EmpListdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Size columns based on content
                        EmpListdataGridView.ScrollBars = ScrollBars.Both; // Enable both horizontal and vertical scrollbars

                        // Optional: Format date columns for better readability
                        EmpListdataGridView.Columns["dob"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        EmpListdataGridView.Columns["joining_date"].DefaultCellStyle.Format = "dd/MM/yyyy";

                        // Optional: Make the DataGridView read-only
                        EmpListdataGridView.ReadOnly = true;
                        EmpListdataGridView.AllowUserToAddRows = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employee data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}