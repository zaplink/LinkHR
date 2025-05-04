namespace LinkHR
{
    partial class MngViewAttendanceForm
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
            FromDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            ToDate = new DateTimePicker();
            label4 = new Label();
            EmpIdTxt = new TextBox();
            AttendanceDataGrid = new DataGridView();
            ViewAttendanceBtn = new Button();
            label5 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            EmpTotalWorkingHoursFill = new Label();
            EmployeeListBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)AttendanceDataGrid).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // FromDate
            // 
            FromDate.Location = new Point(21, 47);
            FromDate.Name = "FromDate";
            FromDate.Size = new Size(200, 23);
            FromDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 24);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "From";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 24);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 3;
            label3.Text = "To";
            // 
            // ToDate
            // 
            ToDate.Location = new Point(267, 47);
            ToDate.Name = "ToDate";
            ToDate.Size = new Size(200, 23);
            ToDate.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 24);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 5;
            label4.Text = "Employee : ";
            // 
            // EmpIdTxt
            // 
            EmpIdTxt.Location = new Point(100, 21);
            EmpIdTxt.Name = "EmpIdTxt";
            EmpIdTxt.Size = new Size(206, 23);
            EmpIdTxt.TabIndex = 6;
            // 
            // AttendanceDataGrid
            // 
            AttendanceDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AttendanceDataGrid.Location = new Point(10, 28);
            AttendanceDataGrid.Name = "AttendanceDataGrid";
            AttendanceDataGrid.Size = new Size(479, 260);
            AttendanceDataGrid.TabIndex = 7;
            // 
            // ViewAttendanceBtn
            // 
            ViewAttendanceBtn.Location = new Point(23, 68);
            ViewAttendanceBtn.Name = "ViewAttendanceBtn";
            ViewAttendanceBtn.Size = new Size(283, 32);
            ViewAttendanceBtn.TabIndex = 8;
            ViewAttendanceBtn.Text = "View Attendance";
            ViewAttendanceBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 28);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 9;
            label5.Text = "Total Working Hours: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FromDate);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ToDate);
            groupBox1.Location = new Point(325, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(495, 88);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter Date";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(AttendanceDataGrid);
            groupBox2.Location = new Point(23, 150);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(495, 294);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Full Details";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(EmpTotalWorkingHoursFill);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(532, 150);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(288, 62);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Summary";
            // 
            // EmpTotalWorkingHoursFill
            // 
            EmpTotalWorkingHoursFill.AutoSize = true;
            EmpTotalWorkingHoursFill.Location = new Point(162, 28);
            EmpTotalWorkingHoursFill.Name = "EmpTotalWorkingHoursFill";
            EmpTotalWorkingHoursFill.Size = new Size(115, 15);
            EmpTotalWorkingHoursFill.TabIndex = 10;
            EmpTotalWorkingHoursFill.Text = "Total Working Hours";
            // 
            // EmployeeListBox
            // 
            EmployeeListBox.FormattingEnabled = true;
            EmployeeListBox.ItemHeight = 15;
            EmployeeListBox.Location = new Point(100, 50);
            EmployeeListBox.Name = "EmployeeListBox";
            EmployeeListBox.Size = new Size(206, 94);
            EmployeeListBox.TabIndex = 13;
            // 
            // ViewAttendanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 450);
            Controls.Add(EmployeeListBox);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(ViewAttendanceBtn);
            Controls.Add(groupBox1);
            Controls.Add(EmpIdTxt);
            Controls.Add(label4);
            Name = "ViewAttendanceForm";
            Text = "ViewAttendanceForm";
            Load += ViewAttendanceForm_Load;
            ((System.ComponentModel.ISupportInitialize)AttendanceDataGrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker FromDate;
        private Label label2;
        private Label label3;
        private DateTimePicker ToDate;
        private Label label4;
        private TextBox EmpIdTxt;
        private DataGridView AttendanceDataGrid;
        private Button ViewAttendanceBtn;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label EmpTotalWorkingHoursFill;
        private ListBox EmployeeListBox;
    }
}