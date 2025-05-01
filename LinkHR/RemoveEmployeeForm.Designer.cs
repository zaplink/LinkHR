namespace LinkHR
{
    partial class RemoveEmployeeForm
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
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            buttonRemove = new Button();
            buttonClear = new Button();
            textBoxEmployeeId = new TextBox();
            textBoxName = new TextBox();
            textBoxDepartment = new TextBox();
            textBoxPosition = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(433, 34);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 0;
            label1.Text = "Remove Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(92, 113);
            label2.Name = "label2";
            label2.Size = new Size(168, 23);
            label2.TabIndex = 1;
            label2.Text = "Search By ID/Name :";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(282, 110);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(269, 27);
            textBoxSearch.TabIndex = 2;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(591, 109);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(92, 203);
            label3.Name = "label3";
            label3.Size = new Size(140, 23);
            label3.TabIndex = 4;
            label3.Text = "Employee Details";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(92, 226);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(593, 220);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 258);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 6;
            label4.Text = "Employee ID :";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(128, 299);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 7;
            label5.Text = "Name :";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(128, 348);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 8;
            label6.Text = "Department :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(128, 399);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 9;
            label7.Text = "Position :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(356, 468);
            label8.Name = "label8";
            label8.Size = new Size(329, 20);
            label8.TabIndex = 10;
            label8.Text = "Warning: Removing this employee is irreversible.";
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.RosyBrown;
            buttonRemove.Location = new Point(517, 504);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(168, 40);
            buttonRemove.TabIndex = 11;
            buttonRemove.Text = "Remove Employee";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click_1;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(92, 504);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(132, 40);
            buttonClear.TabIndex = 12;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click_1;
            // 
            // textBoxEmployeeId
            // 
            textBoxEmployeeId.Location = new Point(272, 251);
            textBoxEmployeeId.Name = "textBoxEmployeeId";
            textBoxEmployeeId.Size = new Size(306, 27);
            textBoxEmployeeId.TabIndex = 13;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(272, 292);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(306, 27);
            textBoxName.TabIndex = 14;
            // 
            // textBoxDepartment
            // 
            textBoxDepartment.Location = new Point(272, 341);
            textBoxDepartment.Name = "textBoxDepartment";
            textBoxDepartment.Size = new Size(306, 27);
            textBoxDepartment.TabIndex = 15;
            // 
            // textBoxPosition
            // 
            textBoxPosition.Location = new Point(272, 392);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.Size = new Size(306, 27);
            textBoxPosition.TabIndex = 16;
            // 
            // RemoveEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 596);
            Controls.Add(textBoxPosition);
            Controls.Add(textBoxDepartment);
            Controls.Add(textBoxName);
            Controls.Add(textBoxEmployeeId);
            Controls.Add(buttonClear);
            Controls.Add(buttonRemove);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RemoveEmployeeForm";
            Text = "RemoveEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button buttonRemove;
        private Button buttonClear;
        private TextBox textBoxEmployeeId;
        private TextBox textBoxName;
        private TextBox textBoxDepartment;
        private TextBox textBoxPosition;
    }
}