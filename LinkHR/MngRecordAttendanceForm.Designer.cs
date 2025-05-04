namespace LinkHR
{
    partial class MngRecordAttendanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextBox empIdInp;
            label1 = new Label();
            DatePicker = new DateTimePicker();
            label2 = new Label();
            EmpIdTxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            CheckInTime = new DateTimePicker();
            CheckOutTime = new DateTimePicker();
            RecordAttendanceBtn = new Button();
            EmployeeListBox = new ListBox();
            EmpIdLbl = new Label();
            EmpFirstNameLbl = new Label();
            EmpLastNameLbl = new Label();
            EmpLastNameFill = new Label();
            EmpFirstNameFill = new Label();
            EmpIdFill = new Label();
            SaveCheckIn = new CheckBox();
            SaveCheckOut = new CheckBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            EmpLastAttendanceDateFill = new Label();
            label9 = new Label();
            EmpLastCheckOutFill = new Label();
            EmpLastCheckInFill = new Label();
            groupBox2 = new GroupBox();
            EmpDepartmentFill = new Label();
            groupBox3 = new GroupBox();
            empIdInp = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // empIdInp
            // 
            empIdInp.Location = new Point(163, 40);
            empIdInp.Margin = new Padding(3, 4, 3, 4);
            empIdInp.Name = "empIdInp";
            empIdInp.Size = new Size(193, 23);
            empIdInp.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 58);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Date :";
            // 
            // DatePicker
            // 
            DatePicker.Location = new Point(75, 52);
            DatePicker.Margin = new Padding(3, 2, 3, 2);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(176, 23);
            DatePicker.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 18);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Employee :";
            // 
            // EmpIdTxt
            // 
            EmpIdTxt.Location = new Point(97, 15);
            EmpIdTxt.Margin = new Padding(3, 2, 3, 2);
            EmpIdTxt.Name = "EmpIdTxt";
            EmpIdTxt.Size = new Size(260, 23);
            EmpIdTxt.TabIndex = 3;
            EmpIdTxt.TextChanged += EmpIdTxt_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 118);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 4;
            label3.Text = "Check-In : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 206);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 5;
            label4.Text = "Check-Out : ";
            // 
            // CheckInTime
            // 
            CheckInTime.Format = DateTimePickerFormat.Time;
            CheckInTime.Location = new Point(22, 145);
            CheckInTime.Margin = new Padding(3, 2, 3, 2);
            CheckInTime.Name = "CheckInTime";
            CheckInTime.Size = new Size(176, 23);
            CheckInTime.TabIndex = 6;
            // 
            // CheckOutTime
            // 
            CheckOutTime.Format = DateTimePickerFormat.Time;
            CheckOutTime.Location = new Point(22, 233);
            CheckOutTime.Margin = new Padding(3, 2, 3, 2);
            CheckOutTime.Name = "CheckOutTime";
            CheckOutTime.Size = new Size(176, 23);
            CheckOutTime.TabIndex = 7;
            // 
            // RecordAttendanceBtn
            // 
            RecordAttendanceBtn.Location = new Point(22, 304);
            RecordAttendanceBtn.Margin = new Padding(3, 2, 3, 2);
            RecordAttendanceBtn.Name = "RecordAttendanceBtn";
            RecordAttendanceBtn.Size = new Size(306, 33);
            RecordAttendanceBtn.TabIndex = 8;
            RecordAttendanceBtn.Text = "Record Attendance";
            RecordAttendanceBtn.UseVisualStyleBackColor = true;
            RecordAttendanceBtn.Click += RecordAttendanceBtn_Click;
            // 
            // EmployeeListBox
            // 
            EmployeeListBox.FormattingEnabled = true;
            EmployeeListBox.ItemHeight = 15;
            EmployeeListBox.Location = new Point(97, 40);
            EmployeeListBox.Name = "EmployeeListBox";
            EmployeeListBox.Size = new Size(260, 94);
            EmployeeListBox.TabIndex = 10;
            EmployeeListBox.MouseClick += EmployeeListBox_MouseClick;
            // 
            // EmpIdLbl
            // 
            EmpIdLbl.AutoSize = true;
            EmpIdLbl.Location = new Point(28, 36);
            EmpIdLbl.Name = "EmpIdLbl";
            EmpIdLbl.Size = new Size(24, 15);
            EmpIdLbl.TabIndex = 12;
            EmpIdLbl.Text = "ID :";
            // 
            // EmpFirstNameLbl
            // 
            EmpFirstNameLbl.AutoSize = true;
            EmpFirstNameLbl.Location = new Point(28, 68);
            EmpFirstNameLbl.Name = "EmpFirstNameLbl";
            EmpFirstNameLbl.Size = new Size(70, 15);
            EmpFirstNameLbl.TabIndex = 13;
            EmpFirstNameLbl.Text = "First Name :";
            // 
            // EmpLastNameLbl
            // 
            EmpLastNameLbl.AutoSize = true;
            EmpLastNameLbl.Location = new Point(28, 104);
            EmpLastNameLbl.Name = "EmpLastNameLbl";
            EmpLastNameLbl.Size = new Size(69, 15);
            EmpLastNameLbl.TabIndex = 14;
            EmpLastNameLbl.Text = "Last Name :";
            // 
            // EmpLastNameFill
            // 
            EmpLastNameFill.AutoSize = true;
            EmpLastNameFill.Location = new Point(127, 104);
            EmpLastNameFill.Name = "EmpLastNameFill";
            EmpLastNameFill.Size = new Size(63, 15);
            EmpLastNameFill.TabIndex = 19;
            EmpLastNameFill.Text = "Last Name";
            // 
            // EmpFirstNameFill
            // 
            EmpFirstNameFill.AutoSize = true;
            EmpFirstNameFill.Location = new Point(127, 68);
            EmpFirstNameFill.Name = "EmpFirstNameFill";
            EmpFirstNameFill.Size = new Size(64, 15);
            EmpFirstNameFill.TabIndex = 18;
            EmpFirstNameFill.Text = "First Name";
            // 
            // EmpIdFill
            // 
            EmpIdFill.AutoSize = true;
            EmpIdFill.Location = new Point(127, 36);
            EmpIdFill.Name = "EmpIdFill";
            EmpIdFill.Size = new Size(18, 15);
            EmpIdFill.TabIndex = 17;
            EmpIdFill.Text = "ID";
            // 
            // SaveCheckIn
            // 
            SaveCheckIn.AutoSize = true;
            SaveCheckIn.Location = new Point(217, 150);
            SaveCheckIn.Name = "SaveCheckIn";
            SaveCheckIn.Size = new Size(101, 19);
            SaveCheckIn.TabIndex = 22;
            SaveCheckIn.Text = "Save Check-In";
            SaveCheckIn.UseVisualStyleBackColor = true;
            // 
            // SaveCheckOut
            // 
            SaveCheckOut.AutoSize = true;
            SaveCheckOut.Location = new Point(217, 238);
            SaveCheckOut.Name = "SaveCheckOut";
            SaveCheckOut.Size = new Size(111, 19);
            SaveCheckOut.TabIndex = 23;
            SaveCheckOut.Text = "Save Check-Out";
            SaveCheckOut.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 139);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 24;
            label6.Text = "Department :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 69);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 25;
            label7.Text = "Last Check-In :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 100);
            label8.Name = "label8";
            label8.Size = new Size(95, 15);
            label8.TabIndex = 26;
            label8.Text = "Last Check-Out :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(EmpLastAttendanceDateFill);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(EmpLastCheckOutFill);
            groupBox1.Controls.Add(EmpLastCheckInFill);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(12, 251);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 133);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Recent Attendance Detials";
            // 
            // EmpLastAttendanceDateFill
            // 
            EmpLastAttendanceDateFill.AutoSize = true;
            EmpLastAttendanceDateFill.Location = new Point(130, 39);
            EmpLastAttendanceDateFill.Name = "EmpLastAttendanceDateFill";
            EmpLastAttendanceDateFill.Size = new Size(31, 15);
            EmpLastAttendanceDateFill.TabIndex = 29;
            EmpLastAttendanceDateFill.Text = "Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 39);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 28;
            label9.Text = "Date :";
            // 
            // EmpLastCheckOutFill
            // 
            EmpLastCheckOutFill.AutoSize = true;
            EmpLastCheckOutFill.Location = new Point(130, 100);
            EmpLastCheckOutFill.Name = "EmpLastCheckOutFill";
            EmpLastCheckOutFill.Size = new Size(89, 15);
            EmpLastCheckOutFill.TabIndex = 27;
            EmpLastCheckOutFill.Text = "Last Check-Out";
            // 
            // EmpLastCheckInFill
            // 
            EmpLastCheckInFill.AutoSize = true;
            EmpLastCheckInFill.Location = new Point(130, 69);
            EmpLastCheckInFill.Name = "EmpLastCheckInFill";
            EmpLastCheckInFill.Size = new Size(79, 15);
            EmpLastCheckInFill.TabIndex = 26;
            EmpLastCheckInFill.Text = "Last Check-In";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(EmpDepartmentFill);
            groupBox2.Controls.Add(EmpIdLbl);
            groupBox2.Controls.Add(EmpFirstNameLbl);
            groupBox2.Controls.Add(EmpLastNameLbl);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(EmpIdFill);
            groupBox2.Controls.Add(EmpFirstNameFill);
            groupBox2.Controls.Add(EmpLastNameFill);
            groupBox2.Location = new Point(12, 59);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 175);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Employee Profile Details";
            // 
            // EmpDepartmentFill
            // 
            EmpDepartmentFill.AutoSize = true;
            EmpDepartmentFill.Location = new Point(127, 139);
            EmpDepartmentFill.Name = "EmpDepartmentFill";
            EmpDepartmentFill.Size = new Size(70, 15);
            EmpDepartmentFill.TabIndex = 25;
            EmpDepartmentFill.Text = "Department";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(DatePicker);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(SaveCheckOut);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(SaveCheckIn);
            groupBox3.Controls.Add(CheckInTime);
            groupBox3.Controls.Add(CheckOutTime);
            groupBox3.Controls.Add(RecordAttendanceBtn);
            groupBox3.Location = new Point(408, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(351, 372);
            groupBox3.TabIndex = 31;
            groupBox3.TabStop = false;
            groupBox3.Text = "Update Attendace Details";
            // 
            // MngRecordAttendanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 474);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(EmployeeListBox);
            Controls.Add(EmpIdTxt);
            Controls.Add(label2);
            Name = "MngRecordAttendanceForm";
            Text = "RecordAttendanceForm";
            Load += MngRecordAttendanceForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker DatePicker;
        private Label label2;
        private TextBox EmpIdTxt;
        private Label label3;
        private Label label4;
        private DateTimePicker CheckInTime;
        private DateTimePicker CheckOutTime;
        private Button RecordAttendanceBtn;
        private ListBox EmployeeListBox;
        private Label EmpIdLbl;
        private Label EmpFirstNameLbl;
        private Label EmpLastNameLbl;
        private Label EmpLastNameFill;
        private Label EmpFirstNameFill;
        private Label EmpIdFill;
        private CheckBox SaveCheckIn;
        private CheckBox SaveCheckOut;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label EmpLastCheckOutFill;
        private Label EmpLastCheckInFill;
        private Label EmpDepartmentFill;
        private Label EmpLastAttendanceDateFill;
        private Label label9;
    }
}