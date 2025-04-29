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
            label1 = new Label();
            DatePicker = new DateTimePicker();
            label2 = new Label();
            EmpIdTxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            CheckInTime = new DateTimePicker();
            CheckOutTime = new DateTimePicker();
            RecordAttendanceBtn = new Button();
            dbtestbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 84);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Date :";
            // 
            // Date
            // 
            DatePicker.Location = new Point(103, 78);
            DatePicker.Name = "Date";
            DatePicker.Size = new Size(200, 23);
            DatePicker.TabIndex = 1;
            DatePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 38);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Employee :";
            label2.Click += label2_Click;
            // 
            // EmpIdTxt
            // 
            EmpIdTxt.Location = new Point(143, 30);
            EmpIdTxt.Name = "EmpIdTxt";
            EmpIdTxt.Size = new Size(169, 23);
            EmpIdTxt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 129);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 4;
            label3.Text = "Check-In : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 172);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 5;
            label4.Text = "Check-Out : ";
            // 
            // CheckInTime
            // 
            CheckInTime.Format = DateTimePickerFormat.Time;
            CheckInTime.Location = new Point(143, 121);
            CheckInTime.Name = "CheckInTime";
            CheckInTime.Size = new Size(200, 23);
            CheckInTime.TabIndex = 6;
            // 
            // CheckOutTime
            // 
            CheckOutTime.Format = DateTimePickerFormat.Time;
            CheckOutTime.Location = new Point(143, 164);
            CheckOutTime.Name = "CheckOutTime";
            CheckOutTime.Size = new Size(200, 23);
            CheckOutTime.TabIndex = 7;
            // 
            // RecordAttendanceBtn
            // 
            RecordAttendanceBtn.Location = new Point(36, 232);
            RecordAttendanceBtn.Name = "RecordAttendanceBtn";
            RecordAttendanceBtn.Size = new Size(243, 23);
            RecordAttendanceBtn.TabIndex = 8;
            RecordAttendanceBtn.Text = "Record Attendance";
            RecordAttendanceBtn.UseVisualStyleBackColor = true;
            RecordAttendanceBtn.Click += RecordAttendanceBtn_Click;
            // 
            // dbtestbtn
            // 
            dbtestbtn.Location = new Point(584, 29);
            dbtestbtn.Name = "dbtestbtn";
            dbtestbtn.Size = new Size(75, 23);
            dbtestbtn.TabIndex = 9;
            dbtestbtn.Text = "DB";
            dbtestbtn.UseVisualStyleBackColor = true;
            dbtestbtn.Click += dbtestbtn_Click;
            // 
            // RecordAttendanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dbtestbtn);
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
        private Button dbtestbtn;
        private Button RecordAttendanceBtn;
    }
}