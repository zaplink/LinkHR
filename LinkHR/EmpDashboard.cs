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
    public partial class EmpDashboard : Form
    {
        public EmpDashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private Form activeForm = null;

        private void loadform(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            loginForm.ResetForm();
            this.Close();
        }

        private void leavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new EmpLeaveForm());
        }

        private void saleryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new EmpSalaryForm());
        }
    }
}
