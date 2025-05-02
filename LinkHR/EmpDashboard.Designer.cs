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
            mainPanel.Controls.Add(panel1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Font = new Font("Microsoft Sans Serif", 8.25F);
            mainPanel.Location = new Point(0, 30);
            mainPanel.Margin = new Padding(0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1333, 719);
            mainPanel.TabIndex = 5;
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
            panel1.Size = new Size(250, 719);
            panel1.TabIndex = 0;
            // 
            // logoutButton
            // 
            logoutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logoutButton.BackColor = SystemColors.ControlDark;
            logoutButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutButton.Location = new Point(11, 659);
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
            panel2.Location = new Point(53, 128);
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
            menuStrip1.Size = new Size(1333, 30);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // saleryToolStripMenuItem
            // 
            saleryToolStripMenuItem.Name = "saleryToolStripMenuItem";
            saleryToolStripMenuItem.Size = new Size(50, 20);
            saleryToolStripMenuItem.Text = "Salary";
            saleryToolStripMenuItem.Click += saleryToolStripMenuItem_Click;
            // 
            // leavesToolStripMenuItem
            // 
            leavesToolStripMenuItem.Name = "leavesToolStripMenuItem";
            leavesToolStripMenuItem.Size = new Size(67, 24);
            leavesToolStripMenuItem.Text = "Leaves";
            leavesToolStripMenuItem.Click += leavesToolStripMenuItem_Click;
            // 
            // EmpDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 749);
            Controls.Add(mainPanel);
            Controls.Add(menuStrip1);
            Name = "EmpDashboard";
            Text = "EmpDashboard";
            Load += EmpDashboard_Load;
            mainPanel.ResumeLayout(false);
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
        private Panel panel2;
        private Label label1;
        private Button logoutButton;
    }
}