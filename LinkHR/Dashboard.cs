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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
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


        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new AddEmployeeForm());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void leavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new EmpLeaveForm());
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
            loadform(new AttendenceForm());
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new MngReportsForm());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
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

        private void announcements_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
