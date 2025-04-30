using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LinkHR
{
    public partial class RecordAttendanceForm : Form
    {
        private System.Windows.Forms.Timer searchTimer;
        private bool suppressTextChanged = false;
        private CancellationTokenSource searchCts;
        private string selectedEmployeeId = null;

        public RecordAttendanceForm()
        {
            InitializeComponent();

            searchTimer = new System.Windows.Forms.Timer();
            searchTimer.Interval = 400;
            searchTimer.Tick += SearchTimer_Tick;

            CheckInTime.Format = DateTimePickerFormat.Custom;
            CheckInTime.CustomFormat = "hh:mm tt";
            CheckInTime.ShowUpDown = true;

            CheckOutTime.Format = DateTimePickerFormat.Custom;
            CheckOutTime.CustomFormat = "hh:mm tt";
            CheckOutTime.ShowUpDown = true;

            DatePicker.Format = DateTimePickerFormat.Short;
            DatePicker.ShowUpDown = false;
            DatePicker.MaxDate = DateTime.Today;

            EmployeeListBox.Visible = false;
            RecordAttendanceBtn.Enabled = false;

            EmpIdTxt.Click += EmpIdTxt_Click;
            this.Click += HideListBoxOnOutsideClick;
            EmpIdTxt.TextChanged += EmpIdTxt_TextChanged;
            EmployeeListBox.MouseClick += EmployeeListBox_MouseClick;
            SaveCheckIn.CheckedChanged += SaveCheckIn_CheckedChanged;
            SaveCheckOut.CheckedChanged += SaveCheckOut_CheckedChanged;
        }

        private void RecordAttendanceBtn_Click(object sender, EventArgs e)
        {
            string empId = EmpIdTxt.Text;
            DateOnly date = DateOnly.FromDateTime(DatePicker.Value);

            TimeOnly? checkIn = SaveCheckIn.Checked ? TimeOnly.FromDateTime(CheckInTime.Value).TruncateToMinutes() : (TimeOnly?)null;
            TimeOnly? checkOut = SaveCheckOut.Checked ? TimeOnly.FromDateTime(CheckOutTime.Value).TruncateToMinutes() : (TimeOnly?)null;

            if (!checkIn.HasValue && !checkOut.HasValue)
            {
                MessageBox.Show("Please select at least one of Check-In or Check-Out.");
                return;
            }

            RecordAttendance(empId, date, checkIn, checkOut);

            var (lastDate, inStr, outStr) = GetLastAttendance(empId);
            EmpLastAttendanceDateFill.Text = lastDate == DateOnly.MinValue ? "_" : lastDate.ToString("yyyy-MM-dd");
            EmpLastCheckInFill.Text = inStr;
            EmpLastCheckOutFill.Text = outStr;
        }

        private void RecordAttendance(string empID, DateOnly date, TimeOnly? checkIn, TimeOnly? checkOut)
        {
            try
            {
                using SqlConnection conn = DBConnector.GetConnection();
                conn.Open();
                string query = @"INSERT INTO Attendance (employee_id, date, check_in, check_out, hours_worked) 
                                 VALUES (@empID, @date, @checkIn, @checkOut, @hoursWorked)";
                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@empID", empID);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@checkIn", checkIn.HasValue ? checkIn.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@checkOut", checkOut.HasValue ? checkOut.Value : DBNull.Value);

                if (checkIn.HasValue && checkOut.HasValue)
                {
                    double hours = CalculateHoursWorked(checkIn.Value, checkOut.Value);
                    cmd.Parameters.AddWithValue("@hoursWorked", hours);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@hoursWorked", DBNull.Value);
                }

                cmd.ExecuteNonQuery();
                MessageBox.Show("SUCCESS: Attendance recorded!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert failed: " + ex.Message);
            }
        }

        private double CalculateHoursWorked(TimeOnly ci, TimeOnly co)
        {
            if (co > ci)
                return (co - ci).TotalHours;

            throw new Exception("ERROR: Check-out time must be after check-in time!");
        }

        public class Employee
        {
            public string id { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
            public string department { get; set; }
            public string lastAttendanceDate { get; set; }
            public string lastCheckIn { get; set; }
            public string lastCheckOut { get; set; }
            public string Display => $"{id}\t{firstName}\t{lastName}\t{lastAttendanceDate}\t{lastCheckIn}\t{lastCheckOut}";
        }

        private List<Employee> SearchEmployees(string search)
        {
            var list = new List<Employee>();
            try
            {
                using SqlConnection conn = DBConnector.GetConnection();
                conn.Open();
                string sql = @"SELECT username, first_name, last_name, contact_no, email, department_id
                               FROM Employee
                               WHERE username LIKE @q OR contact_no LIKE @q OR first_name LIKE @q OR last_name LIKE @q";
                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@q", "%" + search + "%");
                using SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string empId = rdr["username"].ToString();
                    var (d, ci, co) = GetLastAttendance(empId);
                    string dep = GetDepartment(rdr["department_id"].ToString());
                    list.Add(new Employee
                    {
                        id = empId,
                        firstName = rdr["first_name"].ToString(),
                        lastName = rdr["last_name"].ToString(),
                        phone = rdr["contact_no"].ToString(),
                        email = rdr["email"].ToString(),
                        department = dep,
                        lastAttendanceDate = d == DateOnly.MinValue ? "_" : d.ToString("yyyy-MM-dd"),
                        lastCheckIn = ci,
                        lastCheckOut = co
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }
            return list;
        }

        private void EmpIdTxt_TextChanged(object sender, EventArgs e)
        {
            if (suppressTextChanged) return;
            RecordAttendanceBtn.Enabled = false;
            ResetEmployeeDetails();
            searchTimer.Stop();
            searchTimer.Start();
        }

        private async void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();

            searchCts?.Cancel();
            searchCts = new CancellationTokenSource();
            var token = searchCts.Token;

            string q = EmpIdTxt.Text.Trim();
            if (string.IsNullOrEmpty(q)) { EmployeeListBox.Visible = false; return; }

            EmployeeListBox.DataSource = null;
            EmployeeListBox.Items.Clear();
            EmployeeListBox.Items.Add("Searching...");
            PositionListBoxUnderTextBox();
            EmployeeListBox.BringToFront();
            EmployeeListBox.Visible = true;

            try
            {
                var emps = await Task.Run(() => SearchEmployees(q), token);
                if (token.IsCancellationRequested) return;

                BeginInvoke(new Action(() =>
                {
                    if (emps.Count > 0)
                    {
                        EmployeeListBox.DataSource = emps;
                        EmployeeListBox.DisplayMember = "Display";
                        PositionListBoxUnderTextBox();
                        EmployeeListBox.BringToFront();
                        EmployeeListBox.Visible = true;
                    }
                    else
                    {
                        EmployeeListBox.DataSource = null;
                        EmployeeListBox.Items.Clear();
                        EmployeeListBox.Items.Add("No results");
                    }
                }));
            }
            catch (OperationCanceledException) { }
        }

        private void EmployeeListBox_MouseClick(object sender, MouseEventArgs e)
        {
            int idx = EmployeeListBox.IndexFromPoint(e.Location);
            if (idx == ListBox.NoMatches) return;
            var sel = (Employee)EmployeeListBox.Items[idx];
            suppressTextChanged = true;
            EmpIdTxt.Text = sel.id;
            suppressTextChanged = false;
            selectedEmployeeId = sel.id;
            EmployeeListBox.Visible = false;
            RecordAttendanceBtn.Enabled = true;
            ShowEmployeeDetails(sel);
        }

        private void EmpIdTxt_Click(object sender, EventArgs e)
        {
            string q = EmpIdTxt.Text.Trim();
            var emps = SearchEmployees(q);
            if (emps.Count > 0)
            {
                EmployeeListBox.DataSource = emps;
                EmployeeListBox.DisplayMember = "Display";
                PositionListBoxUnderTextBox();
                EmployeeListBox.BringToFront();
                EmployeeListBox.Visible = true;
            }
            else EmployeeListBox.Visible = false;
        }

        private void HideListBoxOnOutsideClick(object sender, EventArgs e)
        {
            Point c = this.PointToClient(Cursor.Position);
            if (!EmployeeListBox.Bounds.Contains(c) && !EmpIdTxt.Bounds.Contains(c))
            {
                EmployeeListBox.Visible = false;
                if (!IsValidEmployee(EmpIdTxt.Text)) { RecordAttendanceBtn.Enabled = false; ResetEmployeeDetails(); }
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Point p = PointToClient(MousePosition);
            if (!EmployeeListBox.Bounds.Contains(p) && !EmpIdTxt.Bounds.Contains(p))
                EmployeeListBox.Visible = false;
        }

        private void PositionListBoxUnderTextBox()
        {
            var tb = EmpIdTxt.PointToScreen(Point.Empty);
            var frm = PointToScreen(Point.Empty);
            EmployeeListBox.Location = new Point(tb.X - frm.X, tb.Y - frm.Y + EmpIdTxt.Height);
            EmployeeListBox.Width = EmpIdTxt.Width;
        }

        private bool IsValidEmployee(string empId) => SearchEmployees(empId).Exists(e => e.id.Equals(empId, StringComparison.OrdinalIgnoreCase));

        private void ShowEmployeeDetails(Employee s)
        {
            EmpIdFill.Text = s.id;
            EmpFirstNameFill.Text = s.firstName;
            EmpLastNameFill.Text = s.lastName;
            EmpPhoneFill.Text = s.phone;
            EmpEmailFill.Text = s.email;
            EmpDepartmentFill.Text = s.department;
            EmpLastAttendanceDateFill.Text = s.lastAttendanceDate;
            EmpLastCheckInFill.Text = s.lastCheckIn;
            EmpLastCheckOutFill.Text = s.lastCheckOut;
        }

        private void ResetEmployeeDetails()
        {
            EmpIdFill.Text = EmpFirstNameFill.Text = EmpLastNameFill.Text = EmpPhoneFill.Text = EmpEmailFill.Text = EmpDepartmentFill.Text = EmpLastAttendanceDateFill.Text = EmpLastCheckInFill.Text = EmpLastCheckOutFill.Text = "_";
            selectedEmployeeId = null;
        }

        private (DateOnly date, string checkIn, string checkOut) GetLastAttendance(string empId)
        {
            try
            {
                using SqlConnection conn = DBConnector.GetConnection();
                conn.Open();
                DateTime? ld;
                using (var cmdD = new SqlCommand("SELECT MAX([date]) FROM Attendance WHERE employee_id=@empId", conn))
                {
                    cmdD.Parameters.AddWithValue("@empId", empId);
                    var r = cmdD.ExecuteScalar();
                    ld = r == DBNull.Value ? null : (DateTime?)r;
                }
                if (ld == null) return (DateOnly.MinValue, "_", "_");

                using (var cmd = new SqlCommand(@"SELECT MAX(check_in) AS ci, MAX(check_out) AS co FROM Attendance WHERE employee_id=@empId AND [date]=@lastDate", conn))
                {
                    cmd.Parameters.AddWithValue("@empId", empId);
                    cmd.Parameters.AddWithValue("@lastDate", ld.Value);
                    using var rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        string fmt(object v)
                        {
                            if (v == DBNull.Value) return "_";
                            if (v is TimeSpan ts) return DateTime.Today.Add(ts).ToString("hh:mm tt");
                            return Convert.ToDateTime(v).ToString("hh:mm tt");
                        }
                        return (DateOnly.FromDateTime(ld.Value), fmt(rdr["ci"]), fmt(rdr["co"]));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching last attendance: " + ex.Message);
            }
            return (DateOnly.MinValue, "_", "_");
        }

        private string GetDepartment(string depId)
        {
            try
            {
                using SqlConnection conn = DBConnector.GetConnection();
                conn.Open();
                using var cmd = new SqlCommand("SELECT name FROM Department WHERE id=@depId", conn);
                cmd.Parameters.AddWithValue("@depId", depId);
                var r = cmd.ExecuteScalar();
                return r == null ? "_" : r.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching department: " + ex.Message);
                return "_";
            }
        }

        private void SaveCheckIn_CheckedChanged(object sender, EventArgs e) => UpdateRecordButtonState();

        private void SaveCheckOut_CheckedChanged(object sender, EventArgs e) => UpdateRecordButtonState();

        private void UpdateRecordButtonState()
        {
            bool isEmpValid = !string.IsNullOrEmpty(selectedEmployeeId) &&
                              selectedEmployeeId.Equals(EmpIdTxt.Text.Trim(), StringComparison.OrdinalIgnoreCase);

            RecordAttendanceBtn.Enabled = (SaveCheckIn.Checked || SaveCheckOut.Checked) && isEmpValid;
        }

        private void RecordAttendanceForm_Load(object sender, EventArgs e)
        {
            ResetEmployeeDetails();
        }
    }

    public static class TimeOnlyExtensions
    {
        public static TimeOnly TruncateToMinutes(this TimeOnly t) => new TimeOnly(t.Hour, t.Minute);
    }
}
