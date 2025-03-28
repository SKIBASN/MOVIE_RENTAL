using System;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WinFormsApp1
{
    public class Database : IDisposable
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Database()
        {
            String connectionString = "Server=DESKTOP-MNUPRSE; Database=TEAM4CMPT291DATABASE; Trusted_Connection=yes;";
            this.myConnection = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            try
            {
                if (myConnection.State == System.Data.ConnectionState.Closed)
                {
                    myConnection.Open();
                    myCommand = new SqlCommand { Connection = myConnection };
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }
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
            OpenConnection();
            myCommand.CommandText = insert_statement;
            myCommand.ExecuteNonQuery();
        }

        public void query(string query_string)
        {
            OpenConnection();
            myCommand.CommandText = query_string;
            myReader = myCommand.ExecuteReader();
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