namespace LinkHR
{
    partial class EmpDashboard
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
            mainPanel = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            logoutButton = new Button();
            panel2 = new Panel();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            saleryToolStripMenuItem = new ToolStripMenuItem();
            leavesToolStripMenuItem = new ToolStripMenuItem();
            mainPanel.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.Control;
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(panel1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Font = new Font("Microsoft Sans Serif", 8.25F);
            mainPanel.Location = new Point(0, 30);
            mainPanel.Margin = new Padding(0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1332, 723);
            mainPanel.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(301, 60);
            label2.Name = "label2";
            label2.Size = new Size(135, 35);
            label2.TabIndex = 4;
            label2.Text = "Welcome..!";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(logoutButton);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 723);
            panel1.TabIndex = 0;
            // 
            // logoutButton
            // 
            logoutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logoutButton.BackColor = SystemColors.ControlDark;
            logoutButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutButton.Location = new Point(12, 663);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(225, 48);
            logoutButton.TabIndex = 3;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackgroundImage = Properties.Resources.employee;
            panel2.Location = new Point(52, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(120, 120);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(55, 64);
            label1.Name = "label1";
            label1.Size = new Size(117, 30);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.AppWorkspace;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, saleryToolStripMenuItem, leavesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1332, 30);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            // 
            // saleryToolStripMenuItem
            // 
            saleryToolStripMenuItem.Name = "saleryToolStripMenuItem";
            saleryToolStripMenuItem.Size = new Size(63, 24);
            saleryToolStripMenuItem.Text = "Salery";
            // 
            // leavesToolStripMenuItem
            // 
            leavesToolStripMenuItem.Name = "leavesToolStripMenuItem";
            leavesToolStripMenuItem.Size = new Size(67, 24);
            leavesToolStripMenuItem.Text = "Leaves";
            // 
            // EmpDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 753);
            Controls.Add(mainPanel);
            Controls.Add(menuStrip1);
            Name = "EmpDashboard";
            Text = "EmpDashboard";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel mainPanel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem saleryToolStripMenuItem;
        private ToolStripMenuItem leavesToolStripMenuItem;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Button logoutButton;
    }
}