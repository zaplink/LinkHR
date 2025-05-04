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
            EmpIdTxt = new TextBox();
            EmployeeListBox = new ListBox();
            ApproveBtn = new Button();
            RejectBtn = new Button();
            ViewLeavesBtn = new Button();
            LeavesDataGrid = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ToDate = new DateTimePicker();
            FromDate = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            StatusFilter = new ComboBox();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)LeavesDataGrid).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // EmpIdTxt
            // 
            EmpIdTxt.Location = new Point(6, 22);
            EmpIdTxt.Name = "EmpIdTxt";
            EmpIdTxt.Size = new Size(231, 23);
            EmpIdTxt.TabIndex = 1;
            // 
            // EmployeeListBox
            // 
            EmployeeListBox.FormattingEnabled = true;
            EmployeeListBox.ItemHeight = 15;
            EmployeeListBox.Location = new Point(12, 159);
            EmployeeListBox.Name = "EmployeeListBox";
            EmployeeListBox.Size = new Size(231, 94);
            EmployeeListBox.TabIndex = 2;
            // 
            // ApproveBtn
            // 
            ApproveBtn.Location = new Point(15, 36);
            ApproveBtn.Name = "ApproveBtn";
            ApproveBtn.Size = new Size(114, 34);
            ApproveBtn.TabIndex = 3;
            ApproveBtn.Text = "Approve";
            ApproveBtn.UseVisualStyleBackColor = true;
            // 
            // RejectBtn
            // 
            RejectBtn.Location = new Point(150, 36);
            RejectBtn.Name = "RejectBtn";
            RejectBtn.Size = new Size(114, 33);
            RejectBtn.TabIndex = 4;
            RejectBtn.Text = "Reject";
            RejectBtn.UseVisualStyleBackColor = true;
            // 
            // ViewLeavesBtn
            // 
            ViewLeavesBtn.Location = new Point(551, 29);
            ViewLeavesBtn.Name = "ViewLeavesBtn";
            ViewLeavesBtn.Size = new Size(279, 34);
            ViewLeavesBtn.TabIndex = 5;
            ViewLeavesBtn.Text = "View Leaves";
            ViewLeavesBtn.UseVisualStyleBackColor = true;
            // 
            // LeavesDataGrid
            // 
            LeavesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LeavesDataGrid.Location = new Point(12, 169);
            LeavesDataGrid.Name = "LeavesDataGrid";
            LeavesDataGrid.Size = new Size(818, 150);
            LeavesDataGrid.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ApproveBtn);
            groupBox1.Controls.Add(RejectBtn);
            groupBox1.Location = new Point(551, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 84);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actions";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ToDate);
            groupBox2.Controls.Add(FromDate);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(261, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(284, 127);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filter Date";
            // 
            // ToDate
            // 
            ToDate.Location = new Point(56, 83);
            ToDate.Name = "ToDate";
            ToDate.Size = new Size(200, 23);
            ToDate.TabIndex = 3;
            // 
            // FromDate
            // 
            FromDate.Location = new Point(56, 32);
            FromDate.Name = "FromDate";
            FromDate.Size = new Size(200, 23);
            FromDate.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 1;
            label2.Text = "To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "From";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(StatusFilter);
            groupBox3.Location = new Point(12, 87);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(243, 66);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Filter Leave Status";
            // 
            // StatusFilter
            // 
            StatusFilter.FormattingEnabled = true;
            StatusFilter.Location = new Point(6, 25);
            StatusFilter.Name = "StatusFilter";
            StatusFilter.Size = new Size(183, 23);
            StatusFilter.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(EmpIdTxt);
            groupBox4.Location = new Point(12, 26);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(243, 55);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Search Employee";
            // 
            // MngViewLeaves
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 359);
            Controls.Add(EmployeeListBox);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(LeavesDataGrid);
            Controls.Add(ViewLeavesBtn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MngViewLeaves";
            Text = "MngViewLeaves";
            ((System.ComponentModel.ISupportInitialize)LeavesDataGrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox EmpIdTxt;
        private ListBox EmployeeListBox;
        private Button ApproveBtn;
        private Button RejectBtn;
        private Button ViewLeavesBtn;
        private DataGridView LeavesDataGrid;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ComboBox StatusFilter;
        private DateTimePicker ToDate;
        private DateTimePicker FromDate;
        private Label label2;
        private Label label1;
        private GroupBox groupBox4;
    }
}