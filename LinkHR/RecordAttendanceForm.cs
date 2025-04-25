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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


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

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert failed: " + ex.Message);
            }
        }

        private void recordAttendance(string empId, string date, string checkIn, string checkOut)
        {
            try
            {
                using (SqlConnection conn = DBConnector.GetConnection())
                {
                    conn.Open();

                    string query = "INSERT INTO Attendance (employee_id, date, check_in, check_out) VALUES (@empId, @date, @checkIn, @checkOut)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@empId", empId);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@checkIn", checkIn);
                        cmd.Parameters.AddWithValue("@checkOut", checkOut);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"Insert successful. Rows affected: {rowsAffected}");
                    }

                    conn.Close();
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dbtestbtn_Click(object sender, EventArgs e)
        {
            InsertUser("John", "john@example.com");
        }

        private void RecordAttendanceForm_Load(object sender, EventArgs e)
        {

        }

        private void recordAttendanceBtn_Click(object sender, EventArgs e)
        {
            string empId = empIdInp.Text;
            string date = attendanceDateInp.Text;
            string checkIn = checkInDateInp.Text;
            string checkOut = checkOutDateInp.Text;
            recordAttendance(empId, date, checkIn, checkOut);
        }
    }
}
