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
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            button1 = new Button();
            dbtestbtn = new Button();
            SuspendLayout();
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(163, 105);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(238, 27);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
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
            // textBox1
            // 
            textBox1.Location = new Point(163, 48);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 27);
            textBox1.TabIndex = 3;
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
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(163, 161);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(238, 27);
            dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.Location = new Point(163, 222);
            dateTimePicker3.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(238, 27);
            dateTimePicker3.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(41, 292);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(278, 31);
            button1.TabIndex = 8;
            button1.Text = "Record Attendance";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // MngRecordAttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dbtestbtn);
            Controls.Add(button1);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MngRecordAttendanceForm";
            Text = "RecordAttendanceForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private Button button1;
        private Button dbtestbtn;
    }
}