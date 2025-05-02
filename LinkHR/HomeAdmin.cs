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
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {
            RenderCalendar();
        }

        private void RenderCalendar()
        {
            // Create a MonthCalendar control
            MonthCalendar calendar = new MonthCalendar
            {
                Dock = DockStyle.Fill, // Make the calendar fill the panel's width
                MaxSelectionCount = 1, // Allow only single-day selection
                BackColor = System.Drawing.Color.White,
                ForeColor = System.Drawing.Color.Black,
                TitleBackColor = System.Drawing.Color.LightGray,
                TitleForeColor = System.Drawing.Color.Black,
                CalendarDimensions = new System.Drawing.Size(2, 1) // Display 2 months horizontally
            };

            // Set today's date as the selected date
            calendar.SetDate(DateTime.Today);

            // Clear any existing controls and add the calendar to the calendarPanel
            calendarPanel.Controls.Clear();
            calendarPanel.Controls.Add(calendar);

            // Enable scrolling in the panel if the calendar height exceeds the panel
            calendarPanel.AutoScroll = true;

            // Ensure no padding or margin interferes with the layout
            calendarPanel.Padding = new Padding(0);
            calendarPanel.Margin = new Padding(0);

        }
    }
}
