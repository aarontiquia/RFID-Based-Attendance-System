using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_AttendanceSystem
{
    public partial class LiveView : Form
    {
        public LiveView()
        {
            InitializeComponent();
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dddd MMM, dd, yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
            lblDate2.Text = DateTime.Now.ToString("dddd MMM, dd, yyyy");
            lblTime2.Text = DateTime.Now.ToString("hh:mm:ss");
            lblDate3.Text = DateTime.Now.ToString("dddd MMM, dd, yyyy");
            lblTime3.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void lblStatus2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
