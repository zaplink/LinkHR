namespace LinkHR
{
    partial class mgrReportPayroll
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
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 0;
            label1.Text = "Pay period Selector";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 49);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "From :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(530, 49);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 2;
            label3.Text = "To :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(213, 88);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(530, 88);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 193);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 5;
            label4.Text = "Employee ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(213, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(323, 27);
            textBox1.TabIndex = 6;
            // 
            // ReportPayroll
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReportPayroll";
            Text = "ReportPayroll";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private TextBox textBox1;
    }
}