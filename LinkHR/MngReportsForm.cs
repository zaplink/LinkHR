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
    public partial class MngReportsForm : Form
    {
        public MngReportsForm()
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

            reportPanel.Controls.Add(childForm);
            reportPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    loadform(new ReportAttendence());
                    break;
                case 1:
                    loadform(new ReportPayroll());
                    break;
                default:
                    MessageBox.Show("Invalid selection");
                    break;
            }

        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;  // Selects the first item
        }
    }
}
