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
            attendanceDateInp = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkInDateInp = new DateTimePicker();
            checkOutDateInp = new DateTimePicker();
            dbtestbtn = new Button();
            recordAttendanceBtn = new Button();
            empIdInp = new TextBox();
            SuspendLayout();
            // 
            // empIdInp
            // 
            empIdInp.Location = new Point(163, 40);
            empIdInp.Margin = new Padding(3, 4, 3, 4);
            empIdInp.Name = "empIdInp";
            empIdInp.Size = new Size(193, 27);
            empIdInp.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 112);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 0;
            label1.Text = "Date :";
            // 
            // attendanceDateInp
            // 
            attendanceDateInp.Location = new Point(118, 104);
            attendanceDateInp.Margin = new Padding(3, 4, 3, 4);
            attendanceDateInp.Name = "attendanceDateInp";
            attendanceDateInp.Size = new Size(228, 27);
            attendanceDateInp.TabIndex = 1;
            attendanceDateInp.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 51);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 2;
            label2.Text = "Employee :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 172);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 4;
            label3.Text = "Check-In : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 229);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 5;
            label4.Text = "Check-Out : ";
            // 
            // checkInDateInp
            // 
            checkInDateInp.Format = DateTimePickerFormat.Time;
            checkInDateInp.Location = new Point(163, 161);
            checkInDateInp.Margin = new Padding(3, 4, 3, 4);
            checkInDateInp.Name = "checkInDateInp";
            checkInDateInp.Size = new Size(228, 27);
            checkInDateInp.TabIndex = 6;
            // 
            // checkOutDateInp
            // 
            checkOutDateInp.Format = DateTimePickerFormat.Time;
            checkOutDateInp.Location = new Point(163, 219);
            checkOutDateInp.Margin = new Padding(3, 4, 3, 4);
            checkOutDateInp.Name = "checkOutDateInp";
            checkOutDateInp.Size = new Size(228, 27);
            checkOutDateInp.TabIndex = 7;
            // 
            // dbtestbtn
            // 
            dbtestbtn.Location = new Point(667, 39);
            dbtestbtn.Margin = new Padding(3, 4, 3, 4);
            dbtestbtn.Name = "dbtestbtn";
            dbtestbtn.Size = new Size(86, 31);
            dbtestbtn.TabIndex = 9;
            dbtestbtn.Text = "DB";
            dbtestbtn.UseVisualStyleBackColor = true;
            dbtestbtn.Click += dbtestbtn_Click;
            // 
            // recordAttendanceBtn
            // 
            recordAttendanceBtn.Location = new Point(55, 362);
            recordAttendanceBtn.Name = "recordAttendanceBtn";
            recordAttendanceBtn.Size = new Size(357, 29);
            recordAttendanceBtn.TabIndex = 10;
            recordAttendanceBtn.Text = "Record Attendance";
            recordAttendanceBtn.UseVisualStyleBackColor = true;
            recordAttendanceBtn.Click += recordAttendanceBtn_Click;
            // 
            // RecordAttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(recordAttendanceBtn);
            Controls.Add(dbtestbtn);
            Controls.Add(checkOutDateInp);
            Controls.Add(checkInDateInp);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(empIdInp);
            Controls.Add(label2);
            Controls.Add(attendanceDateInp);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RecordAttendanceForm";
            Text = "RecordAttendanceForm";
            Load += RecordAttendanceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker attendanceDateInp;
        private Label label2;
        private TextBox empIdInp;
        private Label label3;
        private Label label4;
        private DateTimePicker checkInDateInp;
        private DateTimePicker checkOutDateInp;
        private Button dbtestbtn;
        private Button recordAttendanceBtn;
    }
}