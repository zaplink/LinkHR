namespace LinkHR
{
    partial class ViewDepartment
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            DepartmentID = new DataGridViewTextBoxColumn();
            DepartmentName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(333, 51);
            label1.Name = "label1";
            label1.Size = new Size(181, 20);
            label1.TabIndex = 0;
            label1.Text = "Department Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 128);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 1;
            label2.Text = "Department Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(283, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 27);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(180, 204);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 3;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(376, 204);
            button2.Name = "button2";
            button2.Size = new Size(94, 39);
            button2.TabIndex = 4;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(584, 204);
            button3.Name = "button3";
            button3.Size = new Size(94, 39);
            button3.TabIndex = 5;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DepartmentID, DepartmentName });
            dataGridView1.Location = new Point(283, 260);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(301, 151);
            dataGridView1.TabIndex = 6;
            // 
            // DepartmentID
            // 
            DepartmentID.HeaderText = "Department ID";
            DepartmentID.MinimumWidth = 6;
            DepartmentID.Name = "DepartmentID";
            DepartmentID.Width = 125;
            // 
            // DepartmentName
            // 
            DepartmentName.HeaderText = "Department Name";
            DepartmentName.MinimumWidth = 6;
            DepartmentName.Name = "DepartmentName";
            DepartmentName.Width = 125;
            // 
            // ViewDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 502);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ViewDepartment";
            Text = "ViewDepartment";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn DepartmentID;
        private DataGridViewTextBoxColumn DepartmentName;
    }
}