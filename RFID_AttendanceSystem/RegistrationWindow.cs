using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace RFID_AttendanceSystem
{


    public partial class RegistrationWindow : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aaron\Desktop\RFID-Based-Attendance-System-with-Turnstile-Integration-and-Live-Camera-Verification-RFID-Tag-Scan-main\StudentRegistration.mdf;Integrated Security=True;Connect Timeout=30");
        private DataGridView dataGridView1;

        public RegistrationWindow()
        {
            InitializeComponent();
            dataGridView1 = new DataGridView();
            this.Controls.Add(dataGridView1);
        }

        private void RegistrationWindow_Load(object sender, EventArgs e)
        {
            string[] registration = { "Student_Id", "Name", "RFID", "Program" };
           
        }

        

        private void btnSave_Click(object sender, EventArgs e)

            {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO StudentRegistration (Student_Id, Name, RFID, Program, [Date]) VALUES (@Student_Id, @Name, @RFID, @Program, @Date)", con);
                cmd.Parameters.AddWithValue("@Student_Id", txtBoxStudId.Text);
                cmd.Parameters.AddWithValue("@Name", txtBoxName.Text);
                cmd.Parameters.AddWithValue("@RFID", txtBoxRFID.Text);
                cmd.Parameters.AddWithValue("@Program", txtBoxProgram.Text);
                cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Successfully");

                txtBoxStudId.Clear();
                txtBoxName.Clear();
                txtBoxRFID.Clear();
                txtBoxProgram.Clear();

              
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

        public void DisplayData()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Table";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
