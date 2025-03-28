using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class Database
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Database()
        {
            String connectionString = "Server=192.168.1.190;Database=TEAM4CMPT291DATABASE;User Id=sa;Password=YourPassword123;";
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

        public void AddCustomer(string firstName, string lastName, string address, string city, string state, string zip, string email, string accountNumber, string creditCardNumber)
        {
            try
            {
                string query = @"INSERT INTO Customer 
                (FirstName, LastName, Address, City, State, ZipCode, EmailAddress, AccountNumber, AccountCreateDate, CreditCardNumber)
                VALUES 
                (@FirstName, @LastName, @Address, @City, @State, @ZipCode, @EmailAddress, @AccountNumber, GETDATE(), @CreditCardNumber);";

                SqlCommand command = new SqlCommand(query, myConnection);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@State", state);
                command.Parameters.AddWithValue("@ZipCode", zip);
                command.Parameters.AddWithValue("@EmailAddress", email);
                command.Parameters.AddWithValue("@AccountNumber", accountNumber);
                command.Parameters.AddWithValue("@CreditCardNumber", creditCardNumber);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding customer: " + ex.Message);
            }
        }

        // Optional: Legacy manual insert method
        /*
        public void insert(String insert_statement)
        {
            this.myCommand.CommandText = insert_statement;
            this.myCommand.ExecuteNonQuery();
        }

        public void query(String query_string)
        {
            this.myCommand.CommandText = query_string;
            this.myReader = this.myCommand.ExecuteReader();
        }
        */
    }
}