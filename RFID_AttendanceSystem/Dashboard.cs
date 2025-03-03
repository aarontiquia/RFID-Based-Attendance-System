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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void crownLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            openChildForm(new RegistrationForm());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new DashboardPanel());
        }

        private void btnLiveView_Click(object sender, EventArgs e)
        {
            openChildForm(new LiveView());
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDashboard.Controls.Add(childForm);
            panelDashboard.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelDashboard_Paint(object sender, PaintEventArgs e)
        {
            openChildForm(new DashboardPanel());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            openChildForm(new Reports());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            openChildForm(new Settings());
        }
    }
}
