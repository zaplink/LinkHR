namespace LinkHR
{
    partial class EmpViewLeaves
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
            FromDate = new DataGridViewTextBoxColumn();
            ToDate = new DataGridViewTextBoxColumn();
            Reason = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FromDate, ToDate, Reason, Type, Status });
            dataGridView1.Location = new Point(50, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(638, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // Reason
            // 
            Reason.HeaderText = "Reason";
            Reason.MinimumWidth = 6;
            Reason.Name = "Reason";
            Reason.Width = 125;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // EmpViewLeaves
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "EmpViewLeaves";
            Text = "EmpViewLeaves";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn FromDate;
        private DataGridViewTextBoxColumn ToDate;
        private DataGridViewTextBoxColumn Reason;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Status;
    }
}