using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.IO.Pipes;

namespace WinFormsApp1
{
    public partial class NavScreen : Form
    {
        public Database db;
        private int choice = 0;
        // Change the type of 'result' from 'object' to 'Control' to access the 'Visible' property
        private Control result;

        public NavScreen()
        {
            InitializeComponent();
            //db = new Database(); // Initialize the object and create the connection
            // Initialize result with a TextBox instance
            // Add result to the form's controls
        }

        private void Report_Click(object sender, EventArgs e)
        {

        }

        private void Movie_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReportSelection.SelectedIndex == 0) // Assuming 0 is the index for "Who are the top 3 customers with the most rentals?"
            {
                EnterR.Visible = true;
                RepRes.Visible = true;
                choice = 0;
            }
            else if (ReportSelection.SelectedIndex == 1)
            {
                SpecifTitle1.Text = "Date 1";
                SpecifTitle2.Text = "Date 2";
                SpecifTitle1.Visible = true;
                SpecifTitle2.Visible = true;
                DateSelect1.Text = "";
                DateSelect2.Text = "";
                DateSelect1.Visible = true;
                DateSelect2.Visible = true;
                cal1.Visible = true;
                cal2.Visible = true;
                EnterR.Visible = true;
                Specif.Visible = false;
                choice = 1;
            }
            else if (ReportSelection.SelectedIndex == 2)
            {
                SpecifTitle1.Text = "Employee ID";
                SpecifTitle1.Visible = true;
                Specif.Text = "";
                Specif.Visible = true;
                EnterR.Visible = true;

                SpecifTitle2.Visible = false;
                DateSelect1.Visible = false;
                DateSelect2.Visible = false;
                cal1.Visible = false;
                cal2.Visible = false;

                choice = 2;
            }
            else if (ReportSelection.SelectedIndex == 3)
            {
                SpecifTitle1.Text = "Date 1";
                SpecifTitle2.Text = "Date 2";
                SpecifTitle1.Visible = true;
                SpecifTitle2.Visible = true;
                DateSelect1.Text = "";
                DateSelect2.Text = "";
                DateSelect1.Visible = true;
                DateSelect2.Visible = true;
                cal1.Visible = true;
                cal2.Visible = true;
                EnterR.Visible = true;


                Specif.Visible = false;

                choice = 3;
            }
            else if (ReportSelection.SelectedIndex == 4)
            {
                SpecifTitle1.Text = "Actor ID";
                SpecifTitle1.Visible = true;
                Specif.Text = "";
                Specif.Visible = true;
                EnterR.Visible = true;

                SpecifTitle2.Visible = false;
                DateSelect1.Visible = false;
                DateSelect2.Visible = false;
                cal1.Visible = false;
                cal2.Visible = false;

                choice = 4;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DateSelect_Click(object sender, EventArgs e)
        {

        }

        private void cal_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateSelect1.Text = cal1.SelectionStart.ToShortDateString();
        }
        private void cal_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateSelect1.Text = cal1.SelectionStart.ToShortDateString();
        }


        private void cal2_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateSelect2.Text = cal2.SelectionStart.ToShortDateString();
        }

        private void cal2_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateSelect2.Text = cal2.SelectionStart.ToShortDateString();
        }

        private void EnterR_Click(object sender, EventArgs e)
        {
            using (db = new Database()) // Ensure proper disposal
            {
                db.myCommand.Parameters.Clear(); // Always clear parameters before use

                if (choice == 0) // Top 3 customers with most rentals
                {
                    db.myCommand.CommandText = @"
            SELECT TOP 3 R.CustomerID, C.FirstName, C.LastName, R.Numb_of_rentals
            FROM Customer C
            JOIN (
                SELECT CustomerID, COUNT(*) AS Numb_of_rentals
                FROM Rental
                GROUP BY CustomerID
            ) R ON R.CustomerID = C.CustomerID
            ORDER BY Numb_of_rentals DESC;";

                    db.OpenConnection(); // Open the connection before execution
                    db.myReader = db.myCommand.ExecuteReader();

                    // Use a DataTable to hold the result
 
                    if (db.myReader.HasRows)
                    {
                        try
                        {
                            DataTable dataTable = new DataTable();
                            // Only load the data if there are rows to read
                            dataTable.Load(db.myReader);

                            // Bind the data to the DataGridView
                            this.Invoke((MethodInvoker)delegate
                            {
                                RepRes.ClearSelection();
                                RepRes.DataSource = dataTable;
                                RepRes.Refresh();
                            });
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);

                        }
                    }
                    else
                    {
                        MessageBox.Show("No data found.");
                    }

                    db.myReader.Close();
                }
                else if (choice == 1) // Top 5 rented movies in date range
                {
                    DateTime date1, date2;
                    if (!DateTime.TryParse(DateSelect1.Text, out date1) || !DateTime.TryParse(DateSelect2.Text, out date2))
                    {
                        MessageBox.Show("Invalid dates selected.");
                        return;
                    }

                    db.myCommand.CommandText = @"
            WITH RankedMovies AS (
                SELECT M.MovieID, M.MovieName, COUNT(*) AS Numb_of_Rentals,
                DENSE_RANK() OVER (ORDER BY COUNT(*) DESC) AS rnk
                FROM Rental R
                JOIN Movie M ON R.MovieID = M.MovieID
                WHERE R.CheckoutDateTime BETWEEN @Date1 AND @Date2
                GROUP BY M.MovieID, M.MovieName
            )
            SELECT MovieID, MovieName, Numb_of_Rentals
            FROM RankedMovies
            WHERE rnk <= 5
            ORDER BY Numb_of_Rentals DESC;";

                    db.myCommand.Parameters.AddWithValue("@Date1", date1);
                    db.myCommand.Parameters.AddWithValue("@Date2", date2);

                    db.OpenConnection();
                    db.myReader = db.myCommand.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(db.myReader);

                    RepRes.ClearSelection();
                    RepRes.DataSource = dataTable;

                    db.myReader.Close();
                }
                else if (choice == 2) // Top movies rented by an employee (FIXED INCOMPLETE QUERY)
                {
                    string empID = Specif.Text.Trim();
                    if (string.IsNullOrEmpty(empID))
                    {
                        MessageBox.Show("Please enter a valid Employee ID.");
                        return;
                    }

                    db.myCommand.CommandText = @"
            WITH RankedMovies AS (
                SELECT MovieID, COUNT(*) AS numb_of_rentals,
                DENSE_RANK() OVER (ORDER BY COUNT(*) DESC) AS rnk
                FROM Rental
                WHERE EmployeeID = @EmpID
                GROUP BY MovieID
            )
            SELECT MovieID, numb_of_rentals
            FROM RankedMovies
            WHERE rnk <= 3
            ORDER BY numb_of_rentals DESC;";

                    db.myCommand.Parameters.AddWithValue("@EmpID", empID);

                    db.OpenConnection();
                    db.myReader = db.myCommand.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(db.myReader);

                    RepRes.ClearSelection();
                    RepRes.DataSource = dataTable;

                    db.myReader.Close();
                }
                else if (choice == 3) // Top 3 rented movie types in date range
                {
                    DateTime date1, date2;
                    if (!DateTime.TryParse(DateSelect1.Text, out date1) || !DateTime.TryParse(DateSelect2.Text, out date2))
                    {
                        MessageBox.Show("Invalid dates selected.");
                        return;
                    }

                    db.myCommand.CommandText = @"
            WITH RankedMovies AS (
                SELECT M.MovieType, COUNT(*) AS numb_of_rentals,
                DENSE_RANK() OVER (ORDER BY COUNT(*) DESC) AS rank
                FROM Rental R
                JOIN Movie M ON M.MovieID = R.MovieID
                WHERE R.CheckoutDateTime BETWEEN @Date1 AND @Date2
                GROUP BY M.MovieType
            )
            SELECT MovieType, numb_of_rentals
            FROM RankedMovies
            WHERE rank <= 3
            ORDER BY numb_of_rentals DESC;";

                    db.myCommand.Parameters.AddWithValue("@Date1", date1);
                    db.myCommand.Parameters.AddWithValue("@Date2", date2);

                    db.OpenConnection();
                    db.myReader = db.myCommand.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(db.myReader);

                    RepRes.ClearSelection();
                    RepRes.DataSource = dataTable;

                    db.myReader.Close();
                }
                else if (choice == 4) // Top 3 rented movies by an actor
                {
                    string actorID = Specif.Text.Trim();
                    if (string.IsNullOrEmpty(actorID))
                    {
                        MessageBox.Show("Please enter a valid Actor ID.");
                        return;
                    }

                    db.myCommand.CommandText = @"
            WITH RankedMovies AS (
                SELECT M.MovieName, R.MovieID, COUNT(*) AS numb_of_rentals,
                DENSE_RANK() OVER (ORDER BY COUNT(*) DESC) AS rank
                FROM Rental R
                JOIN AppearedIn A ON R.MovieID = A.MovieID
                JOIN Movie M ON R.MovieID = M.MovieID
                WHERE A.ActorID = @ActorID
                GROUP BY R.MovieID, M.MovieName
            )
            SELECT MovieName, numb_of_rentals
            FROM RankedMovies
            WHERE rank <= 3
            ORDER BY numb_of_rentals DESC;";

                    db.myCommand.Parameters.AddWithValue("@ActorID", actorID);

                    db.OpenConnection();
                    db.myReader = db.myCommand.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(db.myReader);

                    RepRes.ClearSelection();
                    RepRes.DataSource = dataTable;

                    db.myReader.Close();
                }
            }
        }

        private void Specif_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
   