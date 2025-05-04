namespace LinkHR
{
    partial class HomeAdmin
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
            calendarPanel = new Panel();
            lblWelcome = new Label();
            panel3 = new Panel();
            label3 = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // calendarPanel
            // 
            calendarPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            calendarPanel.BackColor = SystemColors.ButtonHighlight;
            calendarPanel.Location = new Point(38, 204);
            calendarPanel.Name = "calendarPanel";
            calendarPanel.Size = new Size(480, 414);
            calendarPanel.TabIndex = 48;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(38, 63);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(129, 31);
            lblWelcome.TabIndex = 45;
            lblWelcome.Text = "Welcome..!";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ButtonShadow;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(38, 146);
            panel3.Name = "panel3";
            panel3.Size = new Size(480, 52);
            panel3.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 17);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 1;
            label3.Text = "Calendar";
            // 
            // HomeAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 676);
            Controls.Add(panel3);
            Controls.Add(calendarPanel);
            Controls.Add(lblWelcome);
            Name = "HomeAdmin";
            Text = "HomeAdmin";
            Load += HomeAdmin_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel calendarPanel;
        private Label lblWelcome;
        private Panel panel3;
        private Label label3;
    }
}