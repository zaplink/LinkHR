namespace LinkHR
{
    partial class AdminDashboard
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
            recordAttendanceToolStripMenuItem = new ToolStripMenuItem();
            viewAttendanceToolStripMenuItem = new ToolStripMenuItem();
            leavesToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            logoutButton = new Button();
            panel2 = new Panel();
            label1 = new Label();
            adminPanel = new Panel();
            label2 = new Label();
            managersToolStripMenuItem = new ToolStripMenuItem();
            registerManagerToolStripMenuItem = new ToolStripMenuItem();
            removeMToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            adminPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.AppWorkspace;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, employeesToolStripMenuItem, managersToolStripMenuItem, attendenceToolStripMenuItem, leavesToolStripMenuItem, reportsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1332, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
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
            detailsToolStripMenuItem.Size = new Size(224, 26);
            detailsToolStripMenuItem.Text = "Register Employee";
            detailsToolStripMenuItem.Click += detailsToolStripMenuItem_Click;
            // 
            // removeEmployeeToolStripMenuItem
            // 
            removeEmployeeToolStripMenuItem.Name = "removeEmployeeToolStripMenuItem";
            removeEmployeeToolStripMenuItem.Size = new Size(224, 26);
            removeEmployeeToolStripMenuItem.Text = "Remove Employee";
            removeEmployeeToolStripMenuItem.Click += removeEmployeeToolStripMenuItem_Click;
            // 
            // viewEmployeeToolStripMenuItem
            // 
            viewEmployeeToolStripMenuItem.Name = "viewEmployeeToolStripMenuItem";
            viewEmployeeToolStripMenuItem.Size = new Size(224, 26);
            viewEmployeeToolStripMenuItem.Text = "View Employee";
            viewEmployeeToolStripMenuItem.Click += viewEmployeeToolStripMenuItem_Click;
            // 
            // attendenceToolStripMenuItem
            // 
            attendenceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { recordAttendanceToolStripMenuItem, viewAttendanceToolStripMenuItem });
            attendenceToolStripMenuItem.Name = "attendenceToolStripMenuItem";
            attendenceToolStripMenuItem.Size = new Size(99, 24);
            attendenceToolStripMenuItem.Text = "Attendence";
            // 
            // recordAttendanceToolStripMenuItem
            // 
            recordAttendanceToolStripMenuItem.Name = "recordAttendanceToolStripMenuItem";
            recordAttendanceToolStripMenuItem.Size = new Size(219, 26);
            recordAttendanceToolStripMenuItem.Text = "Record Attendance";
            recordAttendanceToolStripMenuItem.Click += recordAttendanceToolStripMenuItem_Click;
            // 
            // viewAttendanceToolStripMenuItem
            // 
            viewAttendanceToolStripMenuItem.Name = "viewAttendanceToolStripMenuItem";
            viewAttendanceToolStripMenuItem.Size = new Size(219, 26);
            viewAttendanceToolStripMenuItem.Text = "View Attendance";
            viewAttendanceToolStripMenuItem.Click += viewAttendanceToolStripMenuItem_Click;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(logoutButton);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 723);
            panel1.TabIndex = 2;
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
            panel2.BackgroundImage = Properties.Resources.admin;
            panel2.Location = new Point(50, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(120, 120);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(38, 47);
            label1.Name = "label1";
            label1.Size = new Size(155, 30);
            label1.TabIndex = 1;
            label1.Text = "Team ZapLink";
            // 
            // adminPanel
            // 
            adminPanel.Controls.Add(label2);
            adminPanel.Dock = DockStyle.Fill;
            adminPanel.Location = new Point(250, 30);
            adminPanel.Name = "adminPanel";
            adminPanel.Size = new Size(1082, 723);
            adminPanel.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(46, 42);
            label2.Name = "label2";
            label2.Size = new Size(135, 35);
            label2.TabIndex = 4;
            label2.Text = "Welcome..!";
            // 
            // managersToolStripMenuItem
            // 
            managersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registerManagerToolStripMenuItem, removeMToolStripMenuItem });
            managersToolStripMenuItem.Name = "managersToolStripMenuItem";
            managersToolStripMenuItem.Size = new Size(88, 24);
            managersToolStripMenuItem.Text = "Managers";
            // 
            // registerManagerToolStripMenuItem
            // 
            registerManagerToolStripMenuItem.Name = "registerManagerToolStripMenuItem";
            registerManagerToolStripMenuItem.Size = new Size(224, 26);
            registerManagerToolStripMenuItem.Text = "Register Manager";
            // 
            // removeMToolStripMenuItem
            // 
            removeMToolStripMenuItem.Name = "removeMToolStripMenuItem";
            removeMToolStripMenuItem.Size = new Size(224, 26);
            removeMToolStripMenuItem.Text = "Remove Manager";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 753);
            Controls.Add(adminPanel);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            adminPanel.ResumeLayout(false);
            adminPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem detailsToolStripMenuItem;
        private ToolStripMenuItem removeEmployeeToolStripMenuItem;
        private ToolStripMenuItem viewEmployeeToolStripMenuItem;
        private ToolStripMenuItem attendenceToolStripMenuItem;
        private ToolStripMenuItem recordAttendanceToolStripMenuItem;
        private ToolStripMenuItem viewAttendanceToolStripMenuItem;
        private ToolStripMenuItem leavesToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private Panel panel1;
        private Panel adminPanel;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Button logoutButton;
        private ToolStripMenuItem managersToolStripMenuItem;
        private ToolStripMenuItem registerManagerToolStripMenuItem;
        private ToolStripMenuItem removeMToolStripMenuItem;
    }
}