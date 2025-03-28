using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class Database : IDisposable
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        private bool disposed = false;

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

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    myReader?.Close();
                    myCommand?.Dispose();
                    myConnection?.Close();
                    myConnection?.Dispose();
                }
                disposed = true;
            }
        }

        ~Database()
        {
            Dispose(false);
        }
    }
}