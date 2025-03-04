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
    public partial class SA_RegistrationForm : Form
    {
        public SA_RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnCreateNewSA_Click(object sender, EventArgs e)
        {
            SA_RegistrationWindow registrationWindow = new SA_RegistrationWindow();
            registrationWindow.ShowDialog();
        }
    }
}
