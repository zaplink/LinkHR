namespace LinkHR
{
    partial class RecordAttendanceForm
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
            label5 = new Label();
            EmpIdLbl = new Label();
            EmpFirstNameLbl = new Label();
            EmpLastNameLbl = new Label();
            EmpEmailLbl = new Label();
            EmpPhoneLbl = new Label();
            EmpEmailFill = new Label();
            EmpPhoneFill = new Label();
            EmpLastNameFill = new Label();
            EmpFirstNameFill = new Label();
            EmpIdFill = new Label();
            empIdInp = new TextBox();
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
            label1.Location = new Point(425, 18);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Date :";
            // 
            // DatePicker
            // 
            DatePicker.Location = new Point(516, 12);
            DatePicker.Margin = new Padding(3, 2, 3, 2);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(176, 23);
            DatePicker.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 18);
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
            EmpIdTxt.Click += EmpIdTxt_Click;
            EmpIdTxt.TextChanged += EmpIdTxt_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(425, 66);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 4;
            label3.Text = "Check-In : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(425, 121);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 5;
            label4.Text = "Check-Out : ";
            // 
            // CheckInTime
            // 
            CheckInTime.Format = DateTimePickerFormat.Time;
            CheckInTime.Location = new Point(516, 60);
            CheckInTime.Margin = new Padding(3, 2, 3, 2);
            CheckInTime.Name = "CheckInTime";
            CheckInTime.Size = new Size(176, 23);
            CheckInTime.TabIndex = 6;
            // 
            // CheckOutTime
            // 
            CheckOutTime.Format = DateTimePickerFormat.Time;
            CheckOutTime.Location = new Point(516, 115);
            CheckOutTime.Margin = new Padding(3, 2, 3, 2);
            CheckOutTime.Name = "CheckOutTime";
            CheckOutTime.Size = new Size(176, 23);
            CheckOutTime.TabIndex = 7;
            // 
            // RecordAttendanceBtn
            // 
            RecordAttendanceBtn.Location = new Point(425, 204);
            RecordAttendanceBtn.Margin = new Padding(3, 2, 3, 2);
            RecordAttendanceBtn.Name = "RecordAttendanceBtn";
            RecordAttendanceBtn.Size = new Size(267, 33);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 68);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 11;
            label5.Text = "Employee  Details";
            // 
            // EmpIdLbl
            // 
            EmpIdLbl.AutoSize = true;
            EmpIdLbl.Location = new Point(40, 105);
            EmpIdLbl.Name = "EmpIdLbl";
            EmpIdLbl.Size = new Size(24, 15);
            EmpIdLbl.TabIndex = 12;
            EmpIdLbl.Text = "ID :";
            // 
            // EmpFirstNameLbl
            // 
            EmpFirstNameLbl.AutoSize = true;
            EmpFirstNameLbl.Location = new Point(40, 137);
            EmpFirstNameLbl.Name = "EmpFirstNameLbl";
            EmpFirstNameLbl.Size = new Size(70, 15);
            EmpFirstNameLbl.TabIndex = 13;
            EmpFirstNameLbl.Text = "First Name :";
            // 
            // EmpLastNameLbl
            // 
            EmpLastNameLbl.AutoSize = true;
            EmpLastNameLbl.Location = new Point(40, 173);
            EmpLastNameLbl.Name = "EmpLastNameLbl";
            EmpLastNameLbl.Size = new Size(69, 15);
            EmpLastNameLbl.TabIndex = 14;
            EmpLastNameLbl.Text = "Last Name :";
            // 
            // EmpEmailLbl
            // 
            EmpEmailLbl.AutoSize = true;
            EmpEmailLbl.Location = new Point(40, 240);
            EmpEmailLbl.Name = "EmpEmailLbl";
            EmpEmailLbl.Size = new Size(42, 15);
            EmpEmailLbl.TabIndex = 16;
            EmpEmailLbl.Text = "Email :";
            // 
            // EmpPhoneLbl
            // 
            EmpPhoneLbl.AutoSize = true;
            EmpPhoneLbl.Location = new Point(40, 204);
            EmpPhoneLbl.Name = "EmpPhoneLbl";
            EmpPhoneLbl.Size = new Size(69, 15);
            EmpPhoneLbl.TabIndex = 15;
            EmpPhoneLbl.Text = "Phone No. :";
            // 
            // EmpEmailFill
            // 
            EmpEmailFill.AutoSize = true;
            EmpEmailFill.Location = new Point(139, 240);
            EmpEmailFill.Name = "EmpEmailFill";
            EmpEmailFill.Size = new Size(36, 15);
            EmpEmailFill.TabIndex = 21;
            EmpEmailFill.Text = "Email";
            // 
            // EmpPhoneFill
            // 
            EmpPhoneFill.AutoSize = true;
            EmpPhoneFill.Location = new Point(139, 204);
            EmpPhoneFill.Name = "EmpPhoneFill";
            EmpPhoneFill.Size = new Size(63, 15);
            EmpPhoneFill.TabIndex = 20;
            EmpPhoneFill.Text = "Phone No.";
            // 
            // EmpLastNameFill
            // 
            EmpLastNameFill.AutoSize = true;
            EmpLastNameFill.Location = new Point(139, 173);
            EmpLastNameFill.Name = "EmpLastNameFill";
            EmpLastNameFill.Size = new Size(63, 15);
            EmpLastNameFill.TabIndex = 19;
            EmpLastNameFill.Text = "Last Name";
            // 
            // EmpFirstNameFill
            // 
            EmpFirstNameFill.AutoSize = true;
            EmpFirstNameFill.Location = new Point(139, 137);
            EmpFirstNameFill.Name = "EmpFirstNameFill";
            EmpFirstNameFill.Size = new Size(64, 15);
            EmpFirstNameFill.TabIndex = 18;
            EmpFirstNameFill.Text = "First Name";
            // 
            // EmpIdFill
            // 
            EmpIdFill.AutoSize = true;
            EmpIdFill.Location = new Point(139, 105);
            EmpIdFill.Name = "EmpIdFill";
            EmpIdFill.Size = new Size(18, 15);
            EmpIdFill.TabIndex = 17;
            EmpIdFill.Text = "ID";
            // 
            // RecordAttendanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EmpEmailFill);
            Controls.Add(EmpPhoneFill);
            Controls.Add(EmpLastNameFill);
            Controls.Add(EmpFirstNameFill);
            Controls.Add(EmpIdFill);
            Controls.Add(EmpEmailLbl);
            Controls.Add(EmpPhoneLbl);
            Controls.Add(EmpLastNameLbl);
            Controls.Add(EmpFirstNameLbl);
            Controls.Add(EmpIdLbl);
            Controls.Add(label5);
            Controls.Add(EmployeeListBox);
            Controls.Add(RecordAttendanceBtn);
            Controls.Add(CheckOutTime);
            Controls.Add(CheckInTime);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(EmpIdTxt);
            Controls.Add(label2);
            Controls.Add(DatePicker);
            Controls.Add(label1);
            Name = "RecordAttendanceForm";
            Text = "RecordAttendanceForm";
            Load += RecordAttendanceForm_Load;
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
        private Label label5;
        private Label EmpIdLbl;
        private Label EmpFirstNameLbl;
        private Label EmpLastNameLbl;
        private Label EmpEmailLbl;
        private Label EmpPhoneLbl;
        private Label EmpEmailFill;
        private Label EmpPhoneFill;
        private Label EmpLastNameFill;
        private Label EmpFirstNameFill;
        private Label EmpIdFill;
    }
}