using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace RFID_AttendanceSystem
{
    public partial class RegistrationForm : Form
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;

        public RegistrationForm()
        {
            InitializeComponent();
            con = new SqlConnection();
            com = new SqlCommand(); // Initialize com to avoid CS8618
            dr = null;
        }

        public void localRecords()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM StudentRegistration ORDER BY [name]", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt; // Directly bind data instead of manually adding rows
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow(this); // Pass this form
            registrationWindow.ShowDialog();
        }
    }
}
