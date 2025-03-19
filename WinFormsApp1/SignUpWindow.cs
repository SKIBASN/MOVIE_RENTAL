using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SignUpWindow : Form
    {
        private string connectionString = "Data Source=MovieRentalDB.db;Version=3;";

        public SignUpWindow()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string userType = cmbUserType.SelectedItem?.ToString(); // Ensure userType is not null

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || 
                string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(userType))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                    using (SQLiteCommand checkCmd = new SQLiteCommand(checkUserQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", username);
                        long userCount = (long)checkCmd.ExecuteScalar();
                        if (userCount > 0)
                        {
                            MessageBox.Show("Username already exists! Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert new user
                    string insertQuery = "INSERT INTO Users (FirstName, LastName, Username, Password, UserType) VALUES (@FirstName, @LastName, @Username, @Password, @UserType)";
                    using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password); // Consider hashing
                        cmd.Parameters.AddWithValue("@UserType", userType);
                        cmd.ExecuteNonQuery();
                    }
                }
                
                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}