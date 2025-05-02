using System;
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
    public partial class MngDashboard : Form
    {
        public MngDashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
                mngPanel.Controls.Clear();

                // Configure the new child form
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;

                // Add the child form to the panel and show it
                mngPanel.Controls.Add(childForm);
                childForm.BringToFront();
                childForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add the Load event handler to display HomeManager by default
        private void MngDashboard_Load_1(object sender, EventArgs e)
        {
            loadform(new HomeManager());
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

        private void attendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new HomeManager());
        }


    }
}   