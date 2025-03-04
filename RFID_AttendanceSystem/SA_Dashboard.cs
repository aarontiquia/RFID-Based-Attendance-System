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
    public partial class SA_Dashboard : Form
    {
        public SA_Dashboard()
        {
            InitializeComponent();
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
            panelDashboardSA.Controls.Add(childForm);
            panelDashboardSA.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDashboardSA_Click(object sender, EventArgs e)
        {
            openChildForm(new SA_DashboardPanel());
        }

        private void panelDashboardSA_Paint(object sender, PaintEventArgs e)
        {
            openChildForm(new SA_DashboardPanel());
        }

        private void btnRegistrationSA_Click(object sender, EventArgs e)
        {
            openChildForm(new SA_RegistrationForm());
        }

        private void btnReportsSA_Click(object sender, EventArgs e)
        {
            openChildForm(new SA_Reports());
        }

        private void btnSettingsSA_Click(object sender, EventArgs e)
        {
            openChildForm(new SA_Settings());
        }
    }
}
