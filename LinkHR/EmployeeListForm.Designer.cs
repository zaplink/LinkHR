namespace LinkHR
{
    partial class EmployeeListForm
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
            EmpListdataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)EmpListdataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(413, 55);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 0;
            label1.Text = "Employee List";
            // 
            // EmpListdataGridView
            // 
            EmpListdataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EmpListdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmpListdataGridView.Location = new Point(27, 106);
            EmpListdataGridView.Name = "EmpListdataGridView";
            EmpListdataGridView.RowHeadersWidth = 51;
            EmpListdataGridView.Size = new Size(1000, 525);
            EmpListdataGridView.TabIndex = 1;
            // 
            // EmployeeListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 676);
            Controls.Add(EmpListdataGridView);
            Controls.Add(label1);
            Name = "EmployeeListForm";
            Text = "EmployeeListForm";
            Load += EmployeeListForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)EmpListdataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView EmpListdataGridView;
    }
}