namespace LinkHR
{
    partial class EmpLeaveForm
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 37);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 3;
            label4.Text = "Leave type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 129);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 105);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 5;
            label6.Text = "From Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(98, 166);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 6;
            label7.Text = "To Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(98, 245);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 8;
            label9.Text = "Reason";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Casual ", "Sick", "Half Day" });
            comboBox2.Location = new Point(300, 37);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(244, 28);
            comboBox2.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(300, 98);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(244, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(301, 166);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(243, 27);
            dateTimePicker2.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(300, 229);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(243, 106);
            textBox4.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(91, 382);
            button1.Name = "button1";
            button1.Size = new Size(150, 49);
            button1.TabIndex = 21;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(300, 382);
            button2.Name = "button2";
            button2.Size = new Size(142, 49);
            button2.TabIndex = 22;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // EmpLeaveForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 604);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Name = "EmpLeaveForm";
            Text = "LeaveForm";
            Load += LeaveForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
    }
}