using System.IO.Pipes;

namespace WinFormsApp1
{

    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
            string user_type = "employee";
        }

        private void UserTitle_Load(object sender, EventArgs e)
        {

        }

        private void employee_CheckedChanged(object sender, EventArgs e)
        {
            string user_type= "employee";
        }

        private void login_Click(object sender, EventArgs e)
        {
            status.Visible = true;
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void cust_CheckedChanged(object sender, EventArgs e)
        {
            string user_type= "customer";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
