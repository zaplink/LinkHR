namespace LinkHR
{
    partial class MngReportsForm
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
            label3 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            cmbReportType = new ComboBox();
            cmbExportType = new ComboBox();
            groupBox1 = new GroupBox();
            btnGenerate = new Button();
            lstEmployees = new ListBox();
            label6 = new Label();
            txtSearchEmp = new TextBox();
            btnExport = new Button();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            dtTo = new DateTimePicker();
            dtFrom = new DateTimePicker();
            groupBox2 = new GroupBox();
            dgvReport = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 412);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 4;
            label3.Text = "Export Type :";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "PDF", "Excel" });
            comboBox2.Location = new Point(206, 406);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(133, 23);
            comboBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(456, 405);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(94, 22);
            button1.TabIndex = 6;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = true;
            // 
            // cmbReportType
            // 
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Location = new Point(23, 141);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(153, 23);
            cmbReportType.TabIndex = 7;
            // 
            // cmbExportType
            // 
            cmbExportType.FormattingEnabled = true;
            cmbExportType.Location = new Point(515, 55);
            cmbExportType.Name = "cmbExportType";
            cmbExportType.Size = new Size(153, 23);
            cmbExportType.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGenerate);
            groupBox1.Controls.Add(lstEmployees);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtSearchEmp);
            groupBox1.Controls.Add(btnExport);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbReportType);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtTo);
            groupBox1.Controls.Add(cmbExportType);
            groupBox1.Controls.Add(dtFrom);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(740, 208);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Export Report";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(515, 92);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(153, 41);
            btnGenerate.TabIndex = 19;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            // 
            // lstEmployees
            // 
            lstEmployees.FormattingEnabled = true;
            lstEmployees.ItemHeight = 15;
            lstEmployees.Location = new Point(23, 84);
            lstEmployees.Name = "lstEmployees";
            lstEmployees.Size = new Size(153, 94);
            lstEmployees.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 32);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 17;
            label6.Text = "Employee";
            // 
            // txtSearchEmp
            // 
            txtSearchEmp.Location = new Point(23, 55);
            txtSearchEmp.Name = "txtSearchEmp";
            txtSearchEmp.Size = new Size(153, 23);
            txtSearchEmp.TabIndex = 16;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(515, 141);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(153, 41);
            btnExport.TabIndex = 15;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 118);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 10;
            label2.Text = "Report Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(239, 118);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 14;
            label5.Text = "To Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(515, 37);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 9;
            label1.Text = "File Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 37);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 13;
            label4.Text = "From Date";
            // 
            // dtTo
            // 
            dtTo.Location = new Point(239, 136);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(200, 23);
            dtTo.TabIndex = 12;
            // 
            // dtFrom
            // 
            dtFrom.Location = new Point(239, 55);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(200, 23);
            dtFrom.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvReport);
            groupBox2.Location = new Point(12, 247);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(740, 222);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Preview";
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(0, 31);
            dgvReport.Name = "dgvReport";
            dgvReport.Size = new Size(740, 191);
            dgvReport.TabIndex = 0;
            // 
            // MngReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 512);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MngReportsForm";
            Text = "ReportsForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private ComboBox comboBox2;
        private Button button1;
        private ComboBox cmbReportType;
        private ComboBox cmbExportType;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private DateTimePicker dtFrom;
        private DateTimePicker dtTo;
        private Label label4;
        private Label label5;
        private Button btnExport;
        private TextBox txtSearchEmp;
        private ListBox lstEmployees;
        private Label label6;
        private GroupBox groupBox2;
        private DataGridView dgvReport;
        private Button btnGenerate;
    }
}