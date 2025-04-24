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
            recordAttendanceToolStripMenuItem = new ToolStripMenuItem();
            viewAttendanceToolStripMenuItem = new ToolStripMenuItem();
            leavesToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            sidepanel = new Panel();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            logoutButton = new Button();
            img = new Panel();
            label1 = new Label();
            mainPanel = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label4 = new Label();
            panel5 = new Panel();
            label6 = new Label();
            panel2 = new Panel();
            panel6 = new Panel();
            label5 = new Label();
            announcements = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            sidepanel.SuspendLayout();
            mainPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            announcements.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.AppWorkspace;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, employeesToolStripMenuItem, attendenceToolStripMenuItem, leavesToolStripMenuItem, reportsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1332, 30);
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
            attendenceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { recordAttendanceToolStripMenuItem, viewAttendanceToolStripMenuItem });
            attendenceToolStripMenuItem.Name = "attendenceToolStripMenuItem";
            attendenceToolStripMenuItem.Size = new Size(99, 24);
            attendenceToolStripMenuItem.Text = "Attendence";
            attendenceToolStripMenuItem.Click += attendenceToolStripMenuItem_Click;
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
            // sidepanel
            // 
            sidepanel.BackColor = SystemColors.AppWorkspace;
            sidepanel.Controls.Add(button2);
            sidepanel.Controls.Add(button1);
            sidepanel.Controls.Add(button3);
            sidepanel.Controls.Add(logoutButton);
            sidepanel.Controls.Add(img);
            sidepanel.Controls.Add(label1);
            sidepanel.Dock = DockStyle.Left;
            sidepanel.Location = new Point(0, 30);
            sidepanel.Margin = new Padding(0);
            sidepanel.Name = "sidepanel";
            sidepanel.Size = new Size(250, 723);
            sidepanel.TabIndex = 1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(40, 365);
            button2.Name = "button2";
            button2.Size = new Size(155, 51);
            button2.TabIndex = 4;
            button2.Text = "Administration";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(40, 443);
            button1.Name = "button1";
            button1.Size = new Size(155, 51);
            button1.TabIndex = 3;
            button1.Text = "Payroll ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = SystemColors.ControlDarkDark;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Window;
            button3.Location = new Point(40, 292);
            button3.Name = "button3";
            button3.Size = new Size(155, 51);
            button3.TabIndex = 2;
            button3.Text = "Departments";
            button3.UseVisualStyleBackColor = false;
            // 
            // logoutButton
            // 
            logoutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logoutButton.BackColor = SystemColors.ControlDark;
            logoutButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutButton.Location = new Point(11, 663);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(225, 48);
            logoutButton.TabIndex = 0;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // img
            // 
            img.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            img.BackgroundImage = Properties.Resources.people_together;
            img.Location = new Point(54, 104);
            img.Name = "img";
            img.Size = new Size(120, 120);
            img.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(40, 59);
            label1.Name = "label1";
            label1.Size = new Size(155, 30);
            label1.TabIndex = 0;
            label1.Text = "Team ZapLink";
            label1.Click += label1_Click;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(panel3);
            mainPanel.Controls.Add(panel2);
            mainPanel.Controls.Add(announcements);
            mainPanel.Controls.Add(label2);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Font = new Font("Microsoft Sans Serif", 8.25F);
            mainPanel.Location = new Point(250, 30);
            mainPanel.Margin = new Padding(0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1082, 723);
            mainPanel.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(555, 361);
            panel3.Name = "panel3";
            panel3.Size = new Size(480, 371);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonShadow;
            panel4.Controls.Add(label4);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(480, 55);
            panel4.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 17);
            label4.Name = "label4";
            label4.Size = new Size(78, 23);
            label4.TabIndex = 1;
            label4.Text = "Calendar";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = SystemColors.ButtonShadow;
            panel5.Controls.Add(label6);
            panel5.Location = new Point(3, 15);
            panel5.Name = "panel5";
            panel5.Size = new Size(0, 55);
            panel5.TabIndex = 2;
            panel5.Paint += panel5_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(13, 15);
            label6.Name = "label6";
            label6.Size = new Size(107, 23);
            label6.TabIndex = 0;
            label6.Text = "Quick access";
            label6.Click += label6_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(panel6);
            panel2.Location = new Point(29, 364);
            panel2.Name = "panel2";
            panel2.Size = new Size(411, 368);
            panel2.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonShadow;
            panel6.Controls.Add(label5);
            panel6.Location = new Point(0, 1);
            panel6.Name = "panel6";
            panel6.Size = new Size(411, 55);
            panel6.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 13);
            label5.Name = "label5";
            label5.Size = new Size(95, 23);
            label5.TabIndex = 2;
            label5.Text = "Quick Start";
            // 
            // announcements
            // 
            announcements.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            announcements.BackColor = SystemColors.ButtonHighlight;
            announcements.Controls.Add(panel1);
            announcements.Location = new Point(26, 104);
            announcements.Name = "announcements";
            announcements.Size = new Size(1017, 221);
            announcements.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 55);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 15);
            label3.Name = "label3";
            label3.Size = new Size(135, 23);
            label3.TabIndex = 0;
            label3.Text = "Announcements";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(26, 35);
            label2.Name = "label2";
            label2.Size = new Size(135, 35);
            label2.TabIndex = 3;
            label2.Text = "Welcome..!";
            label2.Click += label2_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 753);
            Controls.Add(mainPanel);
            Controls.Add(sidepanel);
            Controls.Add(menuStrip1);
            Name = "Dashboard";
            Text = "LinkHR";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            sidepanel.ResumeLayout(false);
            sidepanel.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            announcements.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel img;
        private Label label1;
        private Button logoutButton;
        private Label label2;
        private Button button3;
        private Button button1;
        private Button button2;
        private Panel announcements;
        private Panel panel1;
        private Label label3;
        private Panel panel2;
        private Panel panel5;
        private Label label6;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private Label label4;
        private Label label5;
        private ToolStripMenuItem recordAttendanceToolStripMenuItem;
        private ToolStripMenuItem viewAttendanceToolStripMenuItem;
    }
}