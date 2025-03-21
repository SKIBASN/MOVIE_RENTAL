using System.Data.SqlClient;
using System.IO.Pipes;

namespace WinFormsApp1
{

    public partial class Window : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Window()
        {
            InitializeComponent();

            String connectionString = "Server = BRIGHT-THINKPAD; Database = TEAM4CMPT291DATABASE; Trusted_Connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        private void UserTitle_Load(object sender, EventArgs e)
        {

        }

      
        private void login_Click(object sender, EventArgs e)
        //check for user in database
        //check if password matches
        //if all is good, open new window
        //if not, display error message
        {

            status.Visible = true;
            
              try
            {
                myCommand.CommandText = "SELECT Username, firstName FROM Employee WHERE Username = @user AND password = @pass";
                myCommand.Parameters.Clear();
                myCommand.Parameters.AddWithValue("@user", user.Text);
                myCommand.Parameters.AddWithValue("@pass", password.Text);

                myReader = myCommand.ExecuteReader();

                // Check if any row is returned
                if (myReader.Read())
                {
                    //string empID = myReader["employeeID"].ToString();
                    string empName = myReader["firstName"].ToString();
                    //MessageBox.Show("Login successful for employee " + myReader["employeeID"].ToString());
                    MessageBox.Show("Login successful for employee " + myReader["firstName"].ToString());
                    // Continue with further actions, such as opening the main form
                    status.Text = "Username or Password is correct";
                }
                else
                {
                    MessageBox.Show("Invalid employeeID or password.");
                    status.Text = "Username or Password is incorrect";
                }
                                                                   
                myReader.Close();

            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                status.Text = "Username or Password is incorrect";
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

    }
}
