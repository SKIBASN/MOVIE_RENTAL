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
                if (DateSelect1.Text != "" && DateSelect2.Text != "" && (DateTime.Parse(DateSelect1.Text) > DateTime.Parse(DateSelect2.Text)))
                {
                    EnterR.Visible = true;
                }

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
            if (choice == 0) // What Movies haven't been rented since a specific date?
            {
                db = new Database();
                db.myCommand.CommandText = @"
                                                select *
                                                from (SELECT R.CustomerID, C.FirstName, C.LastName, R.Numb_of_rentals
		                                        FROM Customer c,
		                                        (SELECT CustomerID, COUNT(*) AS Numb_of_rentals
		                                        FROM Rental
		                                        GROUP BY CustomerID) R
		                                        WHERE R.customerID=C.customerID) CHOICE5
                                                ORDER BY Numb_of_rentals DESC;";

                db.myCommand.Parameters.Clear();
                db.myReader = db.myCommand.ExecuteReader();
                String output = "";

                if (db.myReader.HasRows)
                {
                    while (db.myReader.Read())
                    {
                        string firstName = db.myReader["FirstName"]?.ToString() ?? "Unknown";
                        string lastName = db.myReader["LastName"]?.ToString() ?? "Unknown";
                        string CustomerID = db.myReader["CustomerID"]?.ToString() ?? "Unknown";
                        String Numb_of_rentals = db.myReader["Numb_of_rentals"]?.ToString() ?? "Unknown";
                        output = output + ($"{firstName} {lastName} ({CustomerID}): {Numb_of_rentals}\n");
                    }
                    RepRes.Text = output;
                }

                else
                {
                    RepRes.Text = "Error Occured";
                }
            }
            else if (choice == 1) //
            {
                db = new Database();
                DateOnly date1 = DateOnly.Parse(DateSelect1.Text);
                DateOnly date2 = DateOnly.Parse(DateSelect1.Text);
                db.myCommand.CommandText = @$"
                                               $WITH RankedMovies AS (
                                                        SELECT 
                                                         M.MovieID, 
                                                         M.MovieName, 
                                                         COUNT(*) AS Numb_of_Rentals,
                                                         DENSE_RANK() OVER (ORDER BY COUNT(*) DESC) AS rnk
                                                        FROM Rental R
                                                        JOIN Movie M ON R.MovieID = M.MovieID
                                                        WHERE R.CheckoutDateTime BETWEEN {date1} AND {date2}
                                                        GROUP BY M.MovieID, M.MovieName)
                                                        SELECT MovieID, MovieName, Numb_of_Rentals
                                                        FROM RankedMovies
                                                        WHERE rnk <= 5
                                                        ORDER BY Numb_of_Rentals DESC;";

                db.myCommand.Parameters.Clear();
                db.myReader = db.myCommand.ExecuteReader();
                String output = "";

                if (db.myReader.HasRows)
                {
                    while (db.myReader.Read())
                    {
                        string MovieName = db.myReader["MovieName"]?.ToString() ?? "Unknown";
                        string MovieID = db.myReader["MovieID"]?.ToString() ?? "Unknown";
                        String Numb_of_rentals = db.myReader["Numb_of_rentals"]?.ToString() ?? "Unknown";
                        output = output + ($"{MovieName} ({MovieID}): {Numb_of_rentals}\n");
                    }
                    RepRes.Text = output;
                }

                else
                {
                    RepRes.Text = "Error Occured";
                }
            }
            else if (choice == 2)
            {
                db = new Database();
                String EmpID = Specif.Text;
                db.myCommand.CommandText = @$"
                                               WITH RankedMovies AS (
                                                SELECT MovieID, COUNT(*) AS numb_of_rentals,
                                                DENSE_RANK() OVER (ORDER BY COUNT(*) DESC) AS rnk
                                                FROM rental
                                                GROUP BY MovieID
                                                )
                                                SELECT MovieID, numb_of_rentals
                                                FROM RankedMovies
                                                WHERE rnk <=   
                                                ORDER BY numb_of_rentals DESC;";

                db.myCommand.Parameters.Clear();
                db.myReader = db.myCommand.ExecuteReader();
                String output = "";

                if (db.myReader.HasRows)
                {
                    while (db.myReader.Read())
                    {

                        string MovieID = db.myReader["MovieID"]?.ToString() ?? "Unknown";
                        String Numb_of_rentals = db.myReader["Numb_of_rentals"]?.ToString() ?? "Unknown";
                        output = output + ($"({MovieID}): {Numb_of_rentals}\n");
                    }
                    RepRes.Text = output;
                }

                else
                {
                    RepRes.Text = "Error Occured";
                }
            }
            else if (choice == 3)
            {
                db = new Database();
                DateOnly date1 = DateOnly.Parse(DateSelect1.Text);
                DateOnly date2 = DateOnly.Parse(DateSelect1.Text);
                db.myCommand.CommandText = @$"
                                                WITH RankedMovies AS (
                                                SELECT m.MovieType, COUNT(*) AS numb_of_rentals,
                                                DENSE_RANK() OVER (ORDER BY COUNT(*) DESC) AS rank
                                                FROM rental r
                                                JOIN movie m ON m.MovieID = r.MovieID
                                                WHERE r.CheckoutDateTime BETWEEN @myDateA AND @myDateB
                                                GROUP BY m.MovieType
                                                )
                                                SELECT MovieType, numb_of_rentals
                                                FROM RankedMovies
                                                WHERE rank <= 3
                                                ORDER BY numb_of_rentals DESC;";

                db.myCommand.Parameters.Clear();
                db.myReader = db.myCommand.ExecuteReader();
                String output = "";

                if (db.myReader.HasRows)
                {
                    while (db.myReader.Read())
                    {
                        string MovieType = db.myReader["MovieType"]?.ToString() ?? "Unknown";
                        String Numb_of_rentals = db.myReader["Numb_of_rentals"]?.ToString() ?? "Unknown";
                        output = output + ($"{MovieType}: {Numb_of_rentals}\n");
                    }
                    RepRes.Text = output;
                }

                else
                {
                    RepRes.Text = "Error Occured";
                }
            }
            else if (choice == 4)
            {
                db = new Database();
                String ActorID = Specif.Text;
                db.myCommand.CommandText = @$"
                                                WITH RankedMovies AS (
                                                SELECT m.MovieName, r.MovieID, COUNT(*) AS numb_of_rentals,
                                                DENSE_RANK() OVER (ORDER BY COUNT(*) DESC) AS rank
                                                FROM Rental r
                                                JOIN AppearedIn a ON r.MovieID = a.MovieID
                                                JOIN Movie m ON r.MovieID = m.MovieID
                                                WHERE a.ActorID = {ActorID}
                                                GROUP BY r.MovieID, m.MovieName
                                                )
                                                SELECT MovieName, numb_of_rentals
                                                FROM RankedMovies
                                                WHERE rank <= 3
                                                ORDER BY numb_of_rentals DESC;";

                db.myCommand.Parameters.Clear();
                db.myReader = db.myCommand.ExecuteReader();
                String output = "";

                if (db.myReader.HasRows)
                {
                    while (db.myReader.Read())
                    {
                        string MovieName = db.myReader["MovieName"]?.ToString() ?? "Unknown";
                        string MovieID = db.myReader["MovieID"]?.ToString() ?? "Unknown";
                        String Numb_of_rentals = db.myReader["Numb_of_rentals"]?.ToString() ?? "Unknown";
                        output = output + ($"{MovieName} ({MovieID}): {Numb_of_rentals}\n");
                    }
                    RepRes.Text = output;
                }

                else
                {
                    RepRes.Text = "Error Occured";
                }
            }
        }
    }
}
   