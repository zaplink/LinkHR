namespace LinkHR
{
    partial class ViewAttendanceForm
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
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            CheckIn = new DataGridViewTextBoxColumn();
            CheckOut = new DataGridViewTextBoxColumn();
            HoursWorked = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 42);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Date :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(152, 36);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 42);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "From";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(371, 42);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 3;
            label3.Text = "To";
            label3.Click += label3_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(410, 36);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 96);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 5;
            label4.Text = "Employee : ";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 23);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Date, CheckIn, CheckOut, HoursWorked });
            dataGridView1.Location = new Point(23, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 66);
            dataGridView1.TabIndex = 7;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // CheckIn
            // 
            CheckIn.HeaderText = "Check-In";
            CheckIn.Name = "CheckIn";
            // 
            // CheckOut
            // 
            CheckOut.HeaderText = "Check-Out";
            CheckOut.Name = "CheckOut";
            // 
            // HoursWorked
            // 
            HoursWorked.HeaderText = "Hours Worked";
            HoursWorked.Name = "HoursWorked";
            // 
            // button1
            // 
            button1.Location = new Point(335, 87);
            button1.Name = "button1";
            button1.Size = new Size(165, 23);
            button1.TabIndex = 8;
            button1.Text = "View Attendance";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 152);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 9;
            label5.Text = "Total Working Hours: ";
            label5.Click += label5_Click;
            // 
            // ViewAttendanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "ViewAttendanceForm";
            Text = "ViewAttendanceForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn CheckIn;
        private DataGridViewTextBoxColumn CheckOut;
        private DataGridViewTextBoxColumn HoursWorked;
        private Button button1;
        private Label label5;
    }
}