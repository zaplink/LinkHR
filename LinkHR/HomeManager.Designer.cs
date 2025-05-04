namespace LinkHR
{
    partial class HomeManager
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
            lblWelcome = new Label();
            txtPhoneNo = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            txtManagerId = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            label8 = new Label();
            calendarPanel = new Panel();
            panel4 = new Panel();
            label9 = new Label();
            panel1 = new Panel();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 13F);
            lblWelcome.Location = new Point(76, 62);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(120, 30);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome..!";
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Location = new Point(159, 300);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(238, 27);
            txtPhoneNo.TabIndex = 36;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(159, 242);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(238, 27);
            txtEmail.TabIndex = 35;
            // 
            // txtName
            // 
            txtName.Location = new Point(159, 123);
            txtName.Name = "txtName";
            txtName.Size = new Size(238, 27);
            txtName.TabIndex = 34;
            // 
            // txtManagerId
            // 
            txtManagerId.Location = new Point(159, 65);
            txtManagerId.Name = "txtManagerId";
            txtManagerId.Size = new Size(238, 27);
            txtManagerId.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 307);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 32;
            label7.Text = "Phone no.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 249);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 31;
            label6.Text = "Email :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 130);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 30;
            label5.Text = "Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 72);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 29;
            label4.Text = "Manager ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(76, 178);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 27;
            label3.Text = "Your Account";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(159, 183);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(238, 27);
            txtUsername.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 190);
            label8.Name = "label8";
            label8.Size = new Size(82, 20);
            label8.TabIndex = 37;
            label8.Text = "Username :";
            // 
            // calendarPanel
            // 
            calendarPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            calendarPanel.BackColor = SystemColors.ButtonHighlight;
            calendarPanel.Location = new Point(548, 206);
            calendarPanel.Name = "calendarPanel";
            calendarPanel.Size = new Size(480, 393);
            calendarPanel.TabIndex = 39;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.BackColor = SystemColors.ButtonShadow;
            panel4.Controls.Add(label9);
            panel4.Location = new Point(548, 148);
            panel4.Name = "panel4";
            panel4.Size = new Size(480, 55);
            panel4.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(26, 17);
            label9.Name = "label9";
            label9.Size = new Size(78, 23);
            label9.TabIndex = 1;
            label9.Text = "Calendar";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtPhoneNo);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtManagerId);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(73, 206);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 396);
            panel1.TabIndex = 40;
            // 
            // HomeManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 676);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(calendarPanel);
            Controls.Add(label3);
            Controls.Add(lblWelcome);
            Name = "HomeManager";
            Text = "HomeManager";
            Load += HomeManager_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private TextBox txtPhoneNo;
        private TextBox txtEmail;
        private TextBox txtName;
        private TextBox txtManagerId;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtUsername;
        private Label label8;
        private Panel calendarPanel;
        private Panel panel4;
        private Label label9;
        private Panel panel1;
    }
}