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
            LeaveTypeCombo = new ComboBox();
            FromDatePicker = new DateTimePicker();
            ToDatePicker = new DateTimePicker();
            SubmitLeaveBtn = new Button();
            groupBox1 = new GroupBox();
            LeaveHistoryGrid = new DataGridView();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LeaveHistoryGrid).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(374, 39);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Leave Type :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 97);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 39);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 5;
            label6.Text = "From Date :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 110);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 6;
            label7.Text = "To Date :";
            // 
            // LeaveTypeCombo
            // 
            LeaveTypeCombo.FormattingEnabled = true;
            LeaveTypeCombo.Items.AddRange(new object[] { "Casual ", "Sick", "Half Day" });
            LeaveTypeCombo.Location = new Point(459, 36);
            LeaveTypeCombo.Margin = new Padding(3, 2, 3, 2);
            LeaveTypeCombo.Name = "LeaveTypeCombo";
            LeaveTypeCombo.Size = new Size(214, 23);
            LeaveTypeCombo.TabIndex = 12;
            // 
            // FromDatePicker
            // 
            FromDatePicker.Location = new Point(98, 36);
            FromDatePicker.Margin = new Padding(3, 2, 3, 2);
            FromDatePicker.Name = "FromDatePicker";
            FromDatePicker.Size = new Size(214, 23);
            FromDatePicker.TabIndex = 13;
            // 
            // ToDatePicker
            // 
            ToDatePicker.Location = new Point(99, 104);
            ToDatePicker.Margin = new Padding(3, 2, 3, 2);
            ToDatePicker.Name = "ToDatePicker";
            ToDatePicker.Size = new Size(213, 23);
            ToDatePicker.TabIndex = 14;
            // 
            // SubmitLeaveBtn
            // 
            SubmitLeaveBtn.Location = new Point(374, 92);
            SubmitLeaveBtn.Margin = new Padding(3, 2, 3, 2);
            SubmitLeaveBtn.Name = "SubmitLeaveBtn";
            SubmitLeaveBtn.Size = new Size(299, 37);
            SubmitLeaveBtn.TabIndex = 21;
            SubmitLeaveBtn.Text = "Submit Request";
            SubmitLeaveBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(LeaveTypeCombo);
            groupBox1.Controls.Add(SubmitLeaveBtn);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(ToDatePicker);
            groupBox1.Controls.Add(FromDatePicker);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(695, 154);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Submit a Leave Request";
            // 
            // LeaveHistoryGrid
            // 
            LeaveHistoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LeaveHistoryGrid.Location = new Point(0, 22);
            LeaveHistoryGrid.Name = "LeaveHistoryGrid";
            LeaveHistoryGrid.Size = new Size(688, 232);
            LeaveHistoryGrid.TabIndex = 24;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LeaveHistoryGrid);
            groupBox2.Location = new Point(12, 187);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(688, 254);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "My Leave Request History";
            // 
            // EmpLeaveForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 453);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmpLeaveForm";
            Text = "LeaveForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LeaveHistoryGrid).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox LeaveTypeCombo;
        private DateTimePicker FromDatePicker;
        private DateTimePicker ToDatePicker;
        private Button SubmitLeaveBtn;
        private GroupBox groupBox1;
        private DataGridView LeaveHistoryGrid;
        private GroupBox groupBox2;
    }
}