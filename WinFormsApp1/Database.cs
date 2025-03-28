using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WinFormsApp1
{
    public class Database
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Database()
        {
            String connectionString = "Server = BRIGHT-THINKPAD; Database = TEAM4CMPT291DATABASE; Trusted_Connection = yes;";
            this.myConnection = new SqlConnection(connectionString); // Timeout in seconds

            try
            {
                this.myConnection.Open(); // Open connection
                this.myCommand = new SqlCommand();
                this.myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }
        }


        public void query(String query_string)
        {
            this.myCommand.CommandText = query_string;
            this.myReader = this.myCommand.ExecuteReader();
        }


        // Hash the entered password
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convert password to bytes
                byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                
                string strPassword = Convert.ToBase64String(hashValue); // 44-character Base64 string
                return strPassword;
            }
        }

        // Compare password against stored hash 
        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            string enteredHash = HashPassword(enteredPassword);
            return enteredHash == storedHash;
        }

     
        // Convert existing passwords to hashes in the table
        public void ConvertPasswordsToHashes()
        {
            try
            {
                query("SELECT EmployeeID, Password FROM Employee");
                List<(int id, string hash)> employees = new();

                while (myReader.Read())
                {
                    int id = Convert.ToInt32(myReader["EmployeeID"]);
                    string password = myReader.GetString(1);

                    if (password.Length == 44 || password.Length == 64)
                        continue;

                    employees.Add((id, HashPassword(password)));
                }
                myReader.Close();

                // Update non-hashed passwords
                foreach (var employee in employees)
                {
                    myCommand.Parameters.Clear();
                    myCommand.Parameters.AddWithValue("@id", employee.id);
                    myCommand.Parameters.AddWithValue("@hash", employee.hash);
                    query("UPDATE Employee SET Password = @hash WHERE EmployeeID = @id");

                    myReader.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Conversion failed: {ex.Message}");
            }
            finally
            {
                myReader?.Close();
            }

        }





        // Functions for Customer and/or Movie screen(s)
        /*      public void insert(String insert_statement)
              {
                  this.myCommand.CommandText = insert_statement;
                  this.myCommand.ExecuteNonQuery();
              } */









    }

}