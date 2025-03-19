using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string user_type;
        private string connectionString = "Data Source=MovieRentalDB.db;Version=3;";

        public Form1()
        {
            InitializeComponent();
            user_type = "employee"; // Default user type
        }

        private void login_Click(object sender, EventArgs e)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password AND UserType = @UserType";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", user.Text);
                    cmd.Parameters.AddWithValue("@Password", password.Text);
                    cmd.Parameters.AddWithValue("@UserType", user_type);

                    long userExists = (long)cmd.ExecuteScalar();

                    status.Visible = true;

                    if (userExists > 0)
                    {
                        status.Text = "Login Successful";
                        OpenNewWindow();
                    }
                    else
                    {
                        status.Text = "Username or Password is incorrect";
                    }
                }
            }
        }

        private void OpenNewWindow()
        {
            this.Hide();
            using (MainAppWindow mainApp = new MainAppWindow(user_type))
            {
                mainApp.ShowDialog();
            }
            this.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            using (SignUpWindow signUpForm = new SignUpWindow())
            {
                signUpForm.ShowDialog();
            }
        }

        private void employee_CheckedChanged(object sender, EventArgs e)
        {
            user_type = "employee";
        }

        private void cust_CheckedChanged(object sender, EventArgs e)
        {
            user_type = "customer";
        }
    }
}