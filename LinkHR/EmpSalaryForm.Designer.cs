namespace LinkHR
{
    partial class EmpSalaryForm
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
            groupBox1 = new GroupBox();
            statusFilter = new ComboBox();
            label11 = new Label();
            yearFilter = new ComboBox();
            monthFilter = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            SalaryData = new DataGridView();
            ViewSalaryBtn = new Button();
            groupBox3 = new GroupBox();
            TotOvertime = new Label();
            label10 = new Label();
            TotBonus = new Label();
            label8 = new Label();
            TotDedcutions = new Label();
            label6 = new Label();
            TotPaid = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SalaryData).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(statusFilter);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(yearFilter);
            groupBox1.Controls.Add(monthFilter);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 131);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter Details";
            // 
            // statusFilter
            // 
            statusFilter.FormattingEnabled = true;
            statusFilter.Location = new Point(302, 30);
            statusFilter.Name = "statusFilter";
            statusFilter.Size = new Size(129, 23);
            statusFilter.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(240, 33);
            label11.Name = "label11";
            label11.Size = new Size(45, 15);
            label11.TabIndex = 4;
            label11.Text = "Status :";
            // 
            // yearFilter
            // 
            yearFilter.FormattingEnabled = true;
            yearFilter.Location = new Point(68, 81);
            yearFilter.Name = "yearFilter";
            yearFilter.Size = new Size(135, 23);
            yearFilter.TabIndex = 3;
            // 
            // monthFilter
            // 
            monthFilter.FormattingEnabled = true;
            monthFilter.Location = new Point(68, 33);
            monthFilter.Name = "monthFilter";
            monthFilter.Size = new Size(135, 23);
            monthFilter.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 84);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Year :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Month :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(SalaryData);
            groupBox2.Location = new Point(12, 212);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(834, 292);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Full Details";
            // 
            // SalaryData
            // 
            SalaryData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SalaryData.Location = new Point(0, 22);
            SalaryData.Name = "SalaryData";
            SalaryData.Size = new Size(834, 247);
            SalaryData.TabIndex = 0;
            // 
            // ViewSalaryBtn
            // 
            ViewSalaryBtn.Location = new Point(12, 158);
            ViewSalaryBtn.Name = "ViewSalaryBtn";
            ViewSalaryBtn.Size = new Size(450, 38);
            ViewSalaryBtn.TabIndex = 2;
            ViewSalaryBtn.Text = "View Salary Details";
            ViewSalaryBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(TotOvertime);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(TotBonus);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(TotDedcutions);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(TotPaid);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(482, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(364, 184);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Summary Details";
            // 
            // TotOvertime
            // 
            TotOvertime.AutoSize = true;
            TotOvertime.Location = new Point(188, 135);
            TotOvertime.Name = "TotOvertime";
            TotOvertime.Size = new Size(133, 15);
            TotOvertime.TabIndex = 11;
            TotOvertime.Text = "Total Overtime This Year";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 135);
            label10.Name = "label10";
            label10.Size = new Size(139, 15);
            label10.TabIndex = 10;
            label10.Text = "Total Overtime This Year :";
            // 
            // TotBonus
            // 
            TotBonus.AutoSize = true;
            TotBonus.Location = new Point(188, 101);
            TotBonus.Name = "TotBonus";
            TotBonus.Size = new Size(117, 15);
            TotBonus.TabIndex = 9;
            TotBonus.Text = "Total Bonus This Year";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 101);
            label8.Name = "label8";
            label8.Size = new Size(123, 15);
            label8.TabIndex = 8;
            label8.Text = "Total Bonus This Year :";
            // 
            // TotDedcutions
            // 
            TotDedcutions.AutoSize = true;
            TotDedcutions.Location = new Point(188, 69);
            TotDedcutions.Name = "TotDedcutions";
            TotDedcutions.Size = new Size(144, 15);
            TotDedcutions.TabIndex = 7;
            TotDedcutions.Text = "Total Deductions This Year";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 69);
            label6.Name = "label6";
            label6.Size = new Size(150, 15);
            label6.TabIndex = 6;
            label6.Text = "Total Deductions This Year :";
            // 
            // TotPaid
            // 
            TotPaid.AutoSize = true;
            TotPaid.Location = new Point(188, 36);
            TotPaid.Name = "TotPaid";
            TotPaid.Size = new Size(107, 15);
            TotPaid.TabIndex = 5;
            TotPaid.Text = "Total Paid This Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 36);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 4;
            label3.Text = "Total Paid This Year :";
            // 
            // EmpSalaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 617);
            Controls.Add(groupBox3);
            Controls.Add(ViewSalaryBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "EmpSalaryForm";
            Text = "EmpSalaryForm";
            Load += EmpSalaryForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SalaryData).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox yearFilter;
        private ComboBox monthFilter;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView SalaryData;
        private Button ViewSalaryBtn;
        private GroupBox groupBox3;
        private Label TotDedcutions;
        private Label label6;
        private Label TotPaid;
        private Label label3;
        private Label TotOvertime;
        private Label label10;
        private Label TotBonus;
        private Label label8;
        private ComboBox statusFilter;
        private Label label11;
    }
}