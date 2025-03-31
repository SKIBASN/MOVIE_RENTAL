using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.IO.Pipes;
using System.Runtime.CompilerServices;

namespace WinFormsApp1
{

    public partial class LoginScreen : Form
    {
        public Database db;
        public LoginScreen()
        {
            InitializeComponent();
            db = new Database(); // Initialize the object and create the connection
            db.ConvertPasswordsToHashes();
        }


        private void UserTitle_Load(object sender, EventArgs e)
        {

        }


        private void login_Click(object sender, EventArgs e)
        {
            status.Visible = true;
            status.Text = "Authenticating...";

            string username = user.Text.Trim();
            string enteredPassword = password.Text;

            // Check if missing an input
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(enteredPassword))
            {
                status.Text = "Enter credentials";
                MessageBox.Show("Please enter both username and password");
                return;
            }

            try
            {
                bool loginSuccessful = false;

                db.myCommand.Parameters.Clear();
                db.myCommand.Parameters.AddWithValue("@username", username);

                db.query("SELECT Password FROM Employee WHERE Username = @username");



                if (db.myReader.Read())
                {

                    string storedHash = db.myReader["Password"].ToString();
                    loginSuccessful = Database.VerifyPassword(enteredPassword, storedHash);

                    //if (Database.VerifyPassword(enteredPassword, storedHash))
                    if (loginSuccessful)
                    {
                        status.Text = "Login successful";
                        NavScreen f2 = new NavScreen(db);
                        f2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or password.");
                        status.Text = "Username or Password is incorrect";
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or password.");
                    status.Text = "Username or Password is incorrect";
                }
                    
                db.myReader.Close();


            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                status.Text = "Login error";
            }

        }


        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

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


        private void Report_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Click(object sender, EventArgs e)
        {

        }

        private void Movie_Click(object sender, EventArgs e)
        {

        }

        private void Rental_Click(object sender, EventArgs e)
                {

                }


        }
    }
