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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ja\Documents\StudentRegistration.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        private DataGridView dataGridView1;
        private RegistrationForm _mainForm;
        public RegistrationWindow(RegistrationForm mainForm)
        {
            InitializeComponent();
            dataGridView1 = new DataGridView();
            this.Controls.Add(dataGridView1);
            this._mainForm = mainForm;
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Image Files(*.png)|*.png|(*.jpg)|*.jpg";
                openFileDialog1.ShowDialog();
                pictureBox2.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }
        private void RegistrationWindow_Load(object sender, EventArgs e)
        {
            string[] registration = { "Student_Id", "Name", "RFID", "Program" };

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox2.BackgroundImage != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox2.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] arrImage = ms.ToArray(); // Use ToArray instead of GetBuffer (avoids unnecessary padding)

                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO StudentRegistration (Student_Id, Name, RFID, Program, [Date], Image) VALUES (@Student_Id, @Name, @RFID, @Program, @Date, @Image)", con);
                    cmd.Parameters.AddWithValue("@Student_Id", txtBoxStudId.Text);
                    cmd.Parameters.AddWithValue("@Name", txtBoxName.Text);
                    cmd.Parameters.AddWithValue("@RFID", txtBoxRFID.Text);
                    cmd.Parameters.AddWithValue("@Program", txtBoxProgram.Text);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Image", arrImage);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record Inserted Successfully");

                    // Clear Fields
                    txtBoxStudId.Clear();
                    txtBoxName.Clear();
                    txtBoxRFID.Clear();
                    txtBoxProgram.Clear();

                    // Check if the default image exists
                    string defaultImagePath = Path.Combine(Application.StartupPath, "image.png");
                    if (File.Exists(defaultImagePath))
                    {
                        pictureBox2.BackgroundImage = Image.FromFile(defaultImagePath);
                    }
                    else
                    {
                        pictureBox2.BackgroundImage = null;
                    }

                    // Refresh DataGridView in RegistrationForm
                    RegistrationForm mainForm = Application.OpenForms["RegistrationForm"] as RegistrationForm;
                    if (mainForm != null)
                    {
                        mainForm.localRecords(); // Refresh data
                    }
                }
                else
                {
                    MessageBox.Show("Please select an image.");
                }
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

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        /*try
        {
            if (pictureBox2.BackgroundImage != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox2.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arrImage = ms.GetBuffer();

                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO StudentRegistration (Student_Id, Name, RFID, Program, [Date], Image) VALUES (@Student_Id, @Name, @RFID, @Program, @Date, @Image)", con);
                cmd.Parameters.AddWithValue("@Student_Id", txtBoxStudId.Text);
                cmd.Parameters.AddWithValue("@Name", txtBoxName.Text);
                cmd.Parameters.AddWithValue("@RFID", txtBoxRFID.Text);
                cmd.Parameters.AddWithValue("@Program", txtBoxProgram.Text);
                cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Image", arrImage);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Successfully");

                txtBoxStudId.Clear();
                txtBoxName.Clear();
                txtBoxRFID.Clear();
                txtBoxProgram.Clear();
                //pictureBox2.BackgroundImage = Image.FromFile(Application.StartupPath + @"\image.png");
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please select an image.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
        finally
        {
            con.Close();
        *///}


        //}

        public void DisplayData()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM StudentRegistration";
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
