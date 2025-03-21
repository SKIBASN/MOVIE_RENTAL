using System.IO.Pipes;

namespace WinFormsApp1
{

    public partial class Window : Form
    {
        private string user_type;

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
            user_type = "employee";
        }

        private void login_Click(object sender, EventArgs e)
        {
            //example list of users-------------------------------------------
            List<(string, string)> C_users = new List<(string, string)>
            {
                ("userA", "password"),
                ("userB", "password"),
                ("userC", "password")
            };
            List<(string, string)> E_users = new List<(string, string)>
            {
                ("empA", "password"),
                ("empB", "password"),
                ("empC", "password")
            };
            //----------------------------------------------------------------

            status.Visible = true;
            //check user type
            if (user_type == "customer")
            {
                foreach ((string, string) u in C_users)
                {
                    if (u.Item1 == user.Text)
                    {
                        //open new window
                        status.Text = "Login Successful";
                        return;
                    }
                }
            }
            else
            {
                foreach ((string, string) emp in E_users)   
                {
                    if (emp.Item1 == user.Text)
                    {
                        //open new window
                        status.Text = "Login Successful";
                        return;
                    }
                }
            }
            //check for user in database
            //check if password matches
            //if all is good, open new window
            //if not, display error message
            status.Text = "Username or Password is incorrect";
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void cust_CheckedChanged(object sender, EventArgs e)
        {
            user_type = "customer";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
