using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Data.SqlClient;
using DotNetEnv;


namespace LinkHR
{
    public partial class RecordAttendanceForm : Form
    {

        public RecordAttendanceForm()
        {
            InitializeComponent();
        }

        private void InsertUser(string username, string email)
        {
            try
            {
                using (SqlConnection conn = DBConnector.GetConnection())
                {
                    conn.Open();

                    string query = "INSERT INTO TestConnection (Username, Email) VALUES (@Username, @Email)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Email", email);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"Insert successful. Rows affected: {rowsAffected}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert failed: " + ex.Message);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dbtestbtn_Click(object sender, EventArgs e)
        {
            InsertUser("John", "john@example.com");
        }
    }
}
