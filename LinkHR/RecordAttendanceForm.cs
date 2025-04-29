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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace LinkHR
{
    public partial class RecordAttendanceForm : Form
    {

        public RecordAttendanceForm()
        {
            InitializeComponent();

            CheckInTime.Format = DateTimePickerFormat.Time;
            CheckInTime.ShowUpDown = true;

            CheckOutTime.Format = DateTimePickerFormat.Time;
            CheckOutTime.ShowUpDown = true;

            DatePicker.Format = DateTimePickerFormat.Short;
            DatePicker.ShowUpDown = false;
        }

        private void RecordAttendance(string empID, DateOnly date, TimeOnly checkIn, TimeOnly checkOut)
        {
            try
            {
                using (SqlConnection conn = DBConnector.GetConnection())
                {
                    conn.Open();

                    string query = "INSERT INTO Attendance (employee_id, date, check_in, check_out, hours_worked) VALUES (@empID, @date, @checkIn, @checkOut, @hoursWorked)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@empID", empID);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@checkIn", checkIn);
                        cmd.Parameters.AddWithValue("@checkOut", checkOut);

                        try
                        {
                            double hoursWorked = CalculateHoursWorked(checkIn, checkOut);
                            cmd.Parameters.AddWithValue("@hoursWorked", hoursWorked);
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return; 
                        }

                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine($"Insert successful. Rows affected: {rowsAffected}");
                        MessageBox.Show("SUCCESS: Attendance recorded!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert failed: " + ex.Message);
            }
        }

        private double CalculateHoursWorked(TimeOnly chekIn, TimeOnly chekOut)
        {
            if (chekOut > chekIn)
            {
                TimeSpan duration = chekOut - chekIn;
                double totalHours = duration.TotalHours;

                return totalHours;
            }
            else
            {
                throw new Exception("ERROR: Check-out time must be after check-in time!");
            }
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

        private void RecordAttendanceBtn_Click(object sender, EventArgs e)
        {
            string empId = EmpIdTxt.Text;

            DateOnly date = DateOnly.FromDateTime(DatePicker.Value);
            TimeOnly checkIn = TimeOnly.FromDateTime(CheckInTime.Value);
            TimeOnly checkOut = TimeOnly.FromDateTime(CheckOutTime.Value);

            RecordAttendance(empId, date, checkIn, checkOut);
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
