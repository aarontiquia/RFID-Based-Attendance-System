namespace RFID_AttendanceSystem;



public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void materialButton1_Click(object sender, EventArgs e)
    {
        Dashboard form = new Dashboard();
        form.Show();
    }
}
