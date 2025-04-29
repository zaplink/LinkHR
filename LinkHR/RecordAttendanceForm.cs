using Microsoft.Data.SqlClient;

namespace LinkHR
{
    public partial class RecordAttendanceForm : Form
    {
        public RecordAttendanceForm()
        {
            InitializeComponent();

            // Update DateTime pickers to work only as relevant picker type (date or time only)

            CheckInTime.Format = DateTimePickerFormat.Time;
            CheckInTime.ShowUpDown = true;

            CheckOutTime.Format = DateTimePickerFormat.Time;
            CheckOutTime.ShowUpDown = true;

            DatePicker.Format = DateTimePickerFormat.Short;
            DatePicker.ShowUpDown = false;
        }

        // Function fot record attendance
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

                       
                        // Derive work hours
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

        // Function for calculate work hours
        private double CalculateHoursWorked(TimeOnly chekIn, TimeOnly chekOut)
        {
            // Validate check-in and check-out times
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

        // Update attendance recordings
        private void RecordAttendanceBtn_Click(object sender, EventArgs e)
        {
            string empId = EmpIdTxt.Text;

            DateOnly date = DateOnly.FromDateTime(DatePicker.Value);
            TimeOnly checkIn = TimeOnly.FromDateTime(CheckInTime.Value);
            TimeOnly checkOut = TimeOnly.FromDateTime(CheckOutTime.Value);

            RecordAttendance(empId, date, checkIn, checkOut);
        }

        private void RecordAttendanceForm_Load(object sender, EventArgs e)
        {

        }

    }
}
