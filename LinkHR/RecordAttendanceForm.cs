using Microsoft.Data.SqlClient;

namespace LinkHR
{
    public partial class RecordAttendanceForm : Form
    {
        private System.Windows.Forms.Timer searchTimer;

        private bool suppressTextChanged = false;

        public RecordAttendanceForm()
        {
            InitializeComponent();

            searchTimer = new System.Windows.Forms.Timer();
            searchTimer.Interval = 300;
            searchTimer.Tick += SearchTimer_Tick;

            CheckInTime.Format = DateTimePickerFormat.Time;
            CheckInTime.ShowUpDown = true;

            CheckOutTime.Format = DateTimePickerFormat.Time;
            CheckOutTime.ShowUpDown = true;

            DatePicker.Format = DateTimePickerFormat.Short;
            DatePicker.ShowUpDown = false;

            EmployeeListBox.Visible = false;

            RecordAttendanceBtn.Enabled = false;

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
                        catch (Exception ex)
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

        private void RecordAttendanceBtn_Click(object sender, EventArgs e)
        {
            string empId = EmpIdTxt.Text;

            DateOnly date = DateOnly.FromDateTime(DatePicker.Value);
            TimeOnly checkIn = TimeOnly.FromDateTime(CheckInTime.Value);
            TimeOnly checkOut = TimeOnly.FromDateTime(CheckOutTime.Value);

            RecordAttendance(empId, date, checkIn, checkOut);
        }

        public class Employee
        {
            public string id { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string email { get; set; }
            public string phone { get; set; }

            public string Display => $"{id} \t {firstName} \t {lastName}";
        }

        private List<Employee> SearchEmployees(string searchQuery)
        {
            List<Employee> employees = new List<Employee>();

            try
            {
                using (SqlConnection conn = DBConnector.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT username, first_name, last_name, contact_no, email FROM Employee WHERE username LIKE @searchQuery OR first_name LIKE @searchQuery OR last_name LIKE @searchQuery";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            employees.Add(new Employee
                            {
                                id = reader["username"].ToString(),
                                firstName = reader["first_name"].ToString(),
                                lastName = reader["last_name"].ToString(),
                                phone = reader["contact_no"].ToString(),
                                email = reader["email"].ToString()
                                
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }

            return employees;
        }

        private void EmpIdTxt_TextChanged(object sender, EventArgs e)
        {

            if (suppressTextChanged) return;

            RecordAttendanceBtn.Enabled = false;
            ResetEmployeeDetails();

            searchTimer.Stop();


            searchTimer.Start();
            
        }


        private void SearchTimer_Tick(object sender, EventArgs e)
        {

            searchTimer.Stop();

            string searchQuery = EmpIdTxt.Text.Trim();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                List<Employee> employees = SearchEmployees(searchQuery);

                Console.WriteLine($"Found {employees.Count} employees.");

                if (employees.Count > 0)
                {
                    EmployeeListBox.DataSource = employees;
                    EmployeeListBox.DisplayMember = "Display";
                    PositionListBoxUnderTextBox();
                    EmployeeListBox.Visible = true;
                }
                else
                {
                    EmployeeListBox.DataSource = null;
                    EmployeeListBox.Visible = false;
                }
            }
            else
            {
                EmployeeListBox.DataSource = null;
                EmployeeListBox.Visible = false;
            }
        }

        private void EmployeeListBox_MouseClick(object sender, MouseEventArgs e)
        {
            int index = EmployeeListBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                var selectedEmployee = (Employee)EmployeeListBox.Items[index];

                suppressTextChanged = true;
                EmpIdTxt.Text = selectedEmployee.id;
                suppressTextChanged = false;

                EmployeeListBox.Visible = false;

                RecordAttendanceBtn.Enabled = true;

                ShowEmployeeDetails(selectedEmployee);
            }
        }
        private void HideListBoxOnOutsideClick(object sender, EventArgs e)
        {
            Point cursor = this.PointToClient(Cursor.Position);
            if (!EmployeeListBox.Bounds.Contains(cursor) && !EmpIdTxt.Bounds.Contains(cursor))
            {
                EmployeeListBox.Visible = false;

                if (!IsValidEmployee(EmpIdTxt.Text))
                {
                    RecordAttendanceBtn.Enabled = false;
                    ResetEmployeeDetails();
                }
            }
        }

        private void RecordAttendanceForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(EmployeeListBox);
            EmployeeListBox.BringToFront();
            this.Click += HideListBoxOnOutsideClick;
            ResetEmployeeDetails();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!EmployeeListBox.Bounds.Contains(PointToClient(MousePosition)) &&
                !EmpIdTxt.Bounds.Contains(PointToClient(MousePosition)))
            {
                EmployeeListBox.Visible = false;
            }
        }

        private void PositionListBoxUnderTextBox()
        {
            var textBoxLocation = EmpIdTxt.PointToScreen(Point.Empty);
            var formLocation = this.PointToScreen(Point.Empty);
            int x = textBoxLocation.X - formLocation.X;
            int y = textBoxLocation.Y - formLocation.Y + EmpIdTxt.Height;

            EmployeeListBox.Location = new Point(x, y);
            EmployeeListBox.Width = EmpIdTxt.Width;
        }

        private void EmpIdTxt_Click(object sender, EventArgs e)
        {
            string searchQuery = EmpIdTxt.Text.Trim();
            List<Employee> employees = SearchEmployees(searchQuery);

            if (employees.Count > 0)
            {
                EmployeeListBox.DataSource = employees;
                EmployeeListBox.DisplayMember = "Display";
                PositionListBoxUnderTextBox();
                EmployeeListBox.Visible = true;
            }
            else
            {
                EmployeeListBox.Visible = false;
            }
        }

        private bool IsValidEmployee(string empId)
        {
            return SearchEmployees(empId).Exists(e => e.id.Equals(empId, StringComparison.OrdinalIgnoreCase));
        }

        private void ShowEmployeeDetails(Employee selectedEmployee)
        {
            EmpIdFill.Text = selectedEmployee.id;
            EmpFirstNameFill.Text = selectedEmployee.firstName;
            EmpLastNameFill.Text = selectedEmployee.lastName;
            EmpPhoneFill.Text = selectedEmployee.phone;
            EmpEmailFill.Text = selectedEmployee.email;
        }

        private void ResetEmployeeDetails()
        {
            EmpIdFill.Text = "_";
            EmpFirstNameFill.Text = "_";
            EmpLastNameFill.Text = "_";
            EmpPhoneFill.Text = "_";
            EmpEmailFill.Text = "_";
        }
    }

}
