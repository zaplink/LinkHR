namespace LinkHR
{
    partial class MngSalaryForm
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
            EmpIdTxt = new TextBox();
            label1 = new Label();
            EmployeeListBox = new ListBox();
            groupBox1 = new GroupBox();
            ToDate = new DateTimePicker();
            FromDate = new DateTimePicker();
            StatusFilter = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ViewSalaryBtn = new Button();
            ProcessSelectedBtn = new Button();
            SalaryDataGrid = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SalaryDataGrid).BeginInit();
            SuspendLayout();
            // 
            // EmpIdTxt
            // 
            EmpIdTxt.Location = new Point(93, 12);
            EmpIdTxt.Name = "EmpIdTxt";
            EmpIdTxt.Size = new Size(167, 23);
            EmpIdTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 15);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "Employee :";
            // 
            // EmployeeListBox
            // 
            EmployeeListBox.FormattingEnabled = true;
            EmployeeListBox.ItemHeight = 15;
            EmployeeListBox.Location = new Point(94, 42);
            EmployeeListBox.Name = "EmployeeListBox";
            EmployeeListBox.Size = new Size(166, 94);
            EmployeeListBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ToDate);
            groupBox1.Controls.Add(FromDate);
            groupBox1.Controls.Add(StatusFilter);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(289, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(453, 181);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter Details";
            // 
            // ToDate
            // 
            ToDate.Location = new Point(18, 128);
            ToDate.Name = "ToDate";
            ToDate.Size = new Size(200, 23);
            ToDate.TabIndex = 13;
            // 
            // FromDate
            // 
            FromDate.Location = new Point(18, 64);
            FromDate.Name = "FromDate";
            FromDate.Size = new Size(200, 23);
            FromDate.TabIndex = 12;
            // 
            // StatusFilter
            // 
            StatusFilter.FormattingEnabled = true;
            StatusFilter.Location = new Point(258, 64);
            StatusFilter.Name = "StatusFilter";
            StatusFilter.Size = new Size(168, 23);
            StatusFilter.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(258, 35);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 10;
            label4.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 102);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 9;
            label3.Text = "To";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 35);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 8;
            label2.Text = "From";
            // 
            // ViewSalaryBtn
            // 
            ViewSalaryBtn.Location = new Point(22, 117);
            ViewSalaryBtn.Name = "ViewSalaryBtn";
            ViewSalaryBtn.Size = new Size(238, 32);
            ViewSalaryBtn.TabIndex = 4;
            ViewSalaryBtn.Text = "View Salaries";
            ViewSalaryBtn.UseVisualStyleBackColor = true;
            // 
            // ProcessSelectedBtn
            // 
            ProcessSelectedBtn.Location = new Point(22, 164);
            ProcessSelectedBtn.Name = "ProcessSelectedBtn";
            ProcessSelectedBtn.Size = new Size(238, 32);
            ProcessSelectedBtn.TabIndex = 6;
            ProcessSelectedBtn.Text = "Process Selected";
            ProcessSelectedBtn.UseVisualStyleBackColor = true;
            ProcessSelectedBtn.Click += ProcessSelectedBtn_Click;
            // 
            // SalaryDataGrid
            // 
            SalaryDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SalaryDataGrid.Location = new Point(22, 219);
            SalaryDataGrid.Name = "SalaryDataGrid";
            SalaryDataGrid.Size = new Size(870, 270);
            SalaryDataGrid.TabIndex = 7;
            // 
            // MngSalaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 529);
            Controls.Add(SalaryDataGrid);
            Controls.Add(ProcessSelectedBtn);
            Controls.Add(ViewSalaryBtn);
            Controls.Add(groupBox1);
            Controls.Add(EmployeeListBox);
            Controls.Add(label1);
            Controls.Add(EmpIdTxt);
            Name = "MngSalaryForm";
            Text = "MngSalaryForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SalaryDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EmpIdTxt;
        private Label label1;
        private ListBox EmployeeListBox;
        private GroupBox groupBox1;
        private Button ViewSalaryBtn;
        private Button ProcessSelectedBtn;
        private Label label3;
        private Label label2;
        private DataGridView SalaryDataGrid;
        private DateTimePicker ToDate;
        private DateTimePicker FromDate;
        private ComboBox StatusFilter;
        private Label label4;
    }
}