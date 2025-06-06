﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkHR
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            loadform(new HomeAdmin());
        }

        private Form activeForm = null;

        private void loadform(Form childForm)
        {
            try
            {
                // Close and dispose of the previous form if it exists
                if (activeForm != null)
                {
                    activeForm.Close();
                    activeForm.Dispose();
                    activeForm = null;
                }

                // Clear the panel's controls to ensure no old forms remain
                adminPanel.Controls.Clear();

                // Configure the new child form
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;

                // Add the child form to the panel and show it
                adminPanel.Controls.Add(childForm);
                childForm.BringToFront();
                childForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            loginForm.ResetForm();
            this.Close();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new AddEmployeeForm());
        }

        private void removeEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new RemoveEmployeeForm());
        }

        private void viewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new EmployeeListForm());
        }

        private void recordAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new MngRecordAttendanceForm());
        }

        private void viewAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new MngViewAttendanceForm());
        }

        private void leavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new MngViewLeaves());
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new ReportAttendence());
        }

        private void registerManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new RegisterManager());
        }

        private void removeMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new RemoveManager());
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new HomeAdmin());
        }

    }
}
