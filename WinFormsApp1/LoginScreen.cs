using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.IO.Pipes;

namespace WinFormsApp1
{
    public partial class LoginScreen : Form
    {
        public Database db;

        public LoginScreen()
        {
            InitializeComponent();
            db = new Database(); // Initialize the object and create the connection

            //ConvertExistingPasswordsToHash(db);
        }

        // Convert existing users' passwords to hashes
        //private void ConvertPasswordsToHash(Database db)
        //{
        //    string selectQuery = "SELECT User"
        //}

        private void UserTitle_Load(object sender, EventArgs e)
        {

        }


        private void login_Click(object sender, EventArgs e)
        {
            status.Visible = true;

            try
            {
                db.myCommand.CommandText = "SELECT Username, firstName FROM Employee WHERE Username = @user AND password = @pass";
                db.myCommand.Parameters.Clear();
                db.myCommand.Parameters.AddWithValue("@user", user.Text);
                db.myCommand.Parameters.AddWithValue("@pass", password.Text);

                db.myReader = db.myCommand.ExecuteReader();

                // Check if any row is returned
                if (db.myReader.Read())
                {
                    //string empName = myReader["firstName"].ToString();
                    //MessageBox.Show("Login successful for employee " + myReader["firstName"].ToString());

                    status.Text = "Login successful";
                    NavScreen f2 = new();
                    db.myReader.Close();
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid employeeID or password.");
                    status.Text = "Username or Password is incorrect";
                    NavScreen f2 = new();
                    db.myReader.Close();
                    f2.Show();
                    this.Hide();


                }

                //db.myReader.Close();

            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                status.Text = "Username or Password is incorrect";
                NavScreen f2 = new();
                f2.Show();
                this.Hide();
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
