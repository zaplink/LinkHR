namespace LinkHR
{
    partial class Dashboard
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
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            detailsToolStripMenuItem = new ToolStripMenuItem();
            removeEmployeeToolStripMenuItem = new ToolStripMenuItem();
            viewEmployeeToolStripMenuItem = new ToolStripMenuItem();
            attendenceToolStripMenuItem = new ToolStripMenuItem();
            leavesToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            sidepanel = new Panel();
            mainPanel = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.AppWorkspace;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, employeesToolStripMenuItem, attendenceToolStripMenuItem, leavesToolStripMenuItem, reportsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1151, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            // 
            // employeesToolStripMenuItem
            // 
            employeesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { detailsToolStripMenuItem, removeEmployeeToolStripMenuItem, viewEmployeeToolStripMenuItem });
            employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            employeesToolStripMenuItem.Size = new Size(95, 24);
            employeesToolStripMenuItem.Text = "Employees";
            // 
            // detailsToolStripMenuItem
            // 
            detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            detailsToolStripMenuItem.Size = new Size(216, 26);
            detailsToolStripMenuItem.Text = "Register Employee";
            detailsToolStripMenuItem.Click += detailsToolStripMenuItem_Click;
            // 
            // removeEmployeeToolStripMenuItem
            // 
            removeEmployeeToolStripMenuItem.Name = "removeEmployeeToolStripMenuItem";
            removeEmployeeToolStripMenuItem.Size = new Size(216, 26);
            removeEmployeeToolStripMenuItem.Text = "Remove Employee";
            removeEmployeeToolStripMenuItem.Click += removeEmployeeToolStripMenuItem_Click;
            // 
            // viewEmployeeToolStripMenuItem
            // 
            viewEmployeeToolStripMenuItem.Name = "viewEmployeeToolStripMenuItem";
            viewEmployeeToolStripMenuItem.Size = new Size(216, 26);
            viewEmployeeToolStripMenuItem.Text = "View Employee";
            viewEmployeeToolStripMenuItem.Click += viewEmployeeToolStripMenuItem_Click;
            // 
            // attendenceToolStripMenuItem
            // 
            attendenceToolStripMenuItem.Name = "attendenceToolStripMenuItem";
            attendenceToolStripMenuItem.Size = new Size(99, 24);
            attendenceToolStripMenuItem.Text = "Attendence";
            attendenceToolStripMenuItem.Click += attendenceToolStripMenuItem_Click;
            // 
            // leavesToolStripMenuItem
            // 
            leavesToolStripMenuItem.Name = "leavesToolStripMenuItem";
            leavesToolStripMenuItem.Size = new Size(67, 24);
            leavesToolStripMenuItem.Text = "Leaves";
            leavesToolStripMenuItem.Click += leavesToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(74, 24);
            reportsToolStripMenuItem.Text = "Reports";
            reportsToolStripMenuItem.Click += reportsToolStripMenuItem_Click;
            // 
            // sidepanel
            // 
            sidepanel.BackColor = SystemColors.AppWorkspace;
            sidepanel.Dock = DockStyle.Left;
            sidepanel.Location = new Point(0, 28);
            sidepanel.Margin = new Padding(0);
            sidepanel.Name = "sidepanel";
            sidepanel.Size = new Size(250, 617);
            sidepanel.TabIndex = 1;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(250, 28);
            mainPanel.Margin = new Padding(0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(901, 617);
            mainPanel.TabIndex = 2;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 645);
            Controls.Add(mainPanel);
            Controls.Add(sidepanel);
            Controls.Add(menuStrip1);
            Name = "Dashboard";
            Text = "LinkHR";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem detailsToolStripMenuItem;
        private ToolStripMenuItem removeEmployeeToolStripMenuItem;
        private ToolStripMenuItem attendenceToolStripMenuItem;
        private ToolStripMenuItem leavesToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private Panel sidepanel;
        private Panel mainPanel;
        private ToolStripMenuItem viewEmployeeToolStripMenuItem;
    }
}