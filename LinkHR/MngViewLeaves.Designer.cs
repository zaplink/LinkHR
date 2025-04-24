namespace LinkHR
{
    partial class MngViewLeaves
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            EmployeeID = new DataGridViewTextBoxColumn();
            LeaveType = new DataGridViewTextBoxColumn();
            Reason = new DataGridViewTextBoxColumn();
            FromDate = new DataGridViewTextBoxColumn();
            ToDate = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmployeeID, LeaveType, Reason, FromDate, ToDate, Action });
            dataGridView1.Location = new Point(72, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(804, 188);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(555, 62);
            button1.Name = "button1";
            button1.Size = new Size(110, 45);
            button1.TabIndex = 1;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(715, 62);
            button2.Name = "button2";
            button2.Size = new Size(110, 45);
            button2.TabIndex = 2;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // EmployeeID
            // 
            EmployeeID.HeaderText = "Employee ID";
            EmployeeID.MinimumWidth = 6;
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Width = 125;
            // 
            // LeaveType
            // 
            LeaveType.HeaderText = "Leave Type";
            LeaveType.MinimumWidth = 6;
            LeaveType.Name = "LeaveType";
            LeaveType.Width = 125;
            // 
            // Reason
            // 
            Reason.HeaderText = "Reason";
            Reason.MinimumWidth = 6;
            Reason.Name = "Reason";
            Reason.Width = 125;
            // 
            // FromDate
            // 
            FromDate.HeaderText = "From";
            FromDate.MinimumWidth = 6;
            FromDate.Name = "FromDate";
            FromDate.Width = 125;
            // 
            // ToDate
            // 
            ToDate.HeaderText = "To";
            ToDate.MinimumWidth = 6;
            ToDate.Name = "ToDate";
            ToDate.Width = 125;
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.MinimumWidth = 6;
            Action.Name = "Action";
            Action.Width = 125;
            // 
            // MngViewLeaves
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 479);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "MngViewLeaves";
            Text = "MngViewLeaves";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn LeaveType;
        private DataGridViewTextBoxColumn Reason;
        private DataGridViewTextBoxColumn FromDate;
        private DataGridViewTextBoxColumn ToDate;
        private DataGridViewTextBoxColumn Action;
    }
}