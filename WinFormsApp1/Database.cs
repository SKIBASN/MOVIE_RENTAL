using System;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Diagnostics.Eventing.Reader;
using System.Data;
using Microsoft.VisualBasic.Devices;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Diagnostics.Metrics;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class Database : IDisposable
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Database()
        {
            String connectionString = "Server=BRIGHT-THINKPAD; Database=TEAM4CMPT291DATABASE; Trusted_Connection=yes;";
            this.myConnection = new SqlConnection(connectionString);

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

        // DataTable class to retrieve customers from database
        public DataTable GetCustomers()
        {
            DataTable dt = new DataTable();
            try
            {
                query("SELECT * FROM Customer");
                dt.Load(myReader);
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving customers: " + ex.Message);
            }
            return dt;
        }

        // DataTable class to retrieve movies from database
        public DataTable GetMovies()
        {
            DataTable dt = new DataTable();
            try
            {
                //query("SELECT * FROM Movie");

                query(@"SELECT movie.*, " +
                    "CASE WHEN (movie.NumberOfCopies - " +
                     "  (SELECT COUNT(*) FROM RentalOrder rental " +
                     "  WHERE rental.MovieID = movie.MovieID " +
                     "      AND rental.ReturnDateTime IS NULL)) < 0" +

                     "  THEN 0 " +
                     "  ELSE " +
                         "  (movie.NumberOfCopies - " +
                         "  (SELECT COUNT(*) FROM RentalOrder rental " +
                         "  WHERE rental.MovieID = movie.MovieID " +
                         "      AND rental.ReturnDateTime IS NULL)) " +
                     "END AS AvailableCopies " +
                     "FROM Movie movie");
                   
                dt.Load(myReader);
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving movies: " + ex.Message);
            }
            return dt;
        }



        // Hash an entered password
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


        public void insert(string insert_statement)
        {
            //OpenConnection();
            myCommand.CommandText = insert_statement;
            myCommand.ExecuteNonQuery();
        }


        public void Date_Param_query(string query_string, DateTime param1, DateTime param2)
        {
            //OpenConnection();
            myCommand.CommandText = query_string;

            // Add parameters to the command
            myCommand.Parameters.AddWithValue("@date1", param1);
            myCommand.Parameters.AddWithValue("@date2", param2);

            myReader = myCommand.ExecuteReader();
        }
        public void ID_Param_query(string query_string, String param1)
        {
            //OpenConnection();
            myCommand.CommandText = query_string;

            // Add parameters to the command 
            myCommand.Parameters.AddWithValue("@ID", param1);

            myReader = myCommand.ExecuteReader();
        }
        public bool VID_Param_query(string query_string, String param1)
        {
            //OpenConnection();
            myCommand.CommandText = query_string;

            // Add parameters to the command  
            myCommand.Parameters.AddWithValue("@VID", param1);

            myReader = myCommand.ExecuteReader();
            if (myReader.HasRows)
            {
                myReader.Close();
                return true; // Data exists
            }
            else
            {
                myReader.Close();
                return false; // No data
            }
        }

        public void query(string query_string)
        {
            //OpenConnection();
            if (myReader != null && !myReader.IsClosed)
            {
                myReader.Close();
            }
            if (myConnection.State != ConnectionState.Open)
            {
                myConnection.Open();
            }

            this.myCommand.CommandText = query_string;
            this.myReader = this.myCommand.ExecuteReader();
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
                    int id = myReader.GetInt32(0);
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



        public void Dispose()
        {
            if (myReader != null)
            {
                myReader.Dispose();
                myReader = null;
            }
            if (myCommand != null)
            {
                myCommand.Dispose();
                myCommand = null;
            }
            if (myConnection != null)
            {
                myConnection.Dispose();
                myConnection = null;
            }
        }

    }
}