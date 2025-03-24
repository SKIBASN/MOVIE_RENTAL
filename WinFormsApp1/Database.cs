using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Function to convert existing passwords to hash?
        public static string HashPassword(string password)
        {

        }
        
        // Functions for Customer and/or Movie screen(s)
  /*      public void insert(String insert_statement)
        {
            this.myCommand.CommandText = insert_statement;
            this.myCommand.ExecuteNonQuery();
        }
        
        public void query(String query_string)
        {
            this.myCommand.CommandText = query_string;
            this.myReader = this.myCommand.ExecuteReader();
        }*/
    }
}