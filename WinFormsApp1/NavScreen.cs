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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class NavScreen : Form
    {
        public Database db;
        private int choice = 0;


        // Change the type of 'result' from 'object' to 'Control' to access the 'Visible' property
        private Control result;

        public NavScreen(Database DT)
        {
            InitializeComponent();
            db = DT;
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
                Specif.Visible = false;
                SpecifTitle1.Visible = false;
                SpecifTitle2.Visible = false;
                cal1.Visible = false;
                cal2.Visible = false;
                DateSelect1.Visible = false;
                DateSelect2.Visible = false;
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
                //db.myCommand.Parameters.Clear(); // Always clear parameters before use

                if (choice == 0) // Top 3 customers with most rentals
                {
                    try
                    {
                        string query = @"
                                        WITH CHOICE5 AS (
                                        SELECT R.CustomerID, C.FirstName, C.LastName, R.Numb_of_rentals,
                                        DENSE_RANK() OVER(ORDER BY R.Numb_of_rentals DESC) AS rnk
                                        FROM Customer C
                                        JOIN (
                                        SELECT CustomerID, COUNT(*) AS Numb_of_rentals 
                                        FROM Rental 
                                        GROUP BY CustomerID
                                        ) R 
                                        ON R.CustomerID = C.CustomerID
                                        ) 
                                        SELECT CustomerID, FirstName, LastName, Numb_of_rentals 
                                        FROM CHOICE5 
                                        WHERE rnk <= 3 
                                        ORDER BY Numb_of_rentals DESC;
        ";
                        db.query(query);

                        RepRes.Columns.Add("CustomerID", "Customer ID");
                        RepRes.Columns.Add("FirstName", "First Name");
                        RepRes.Columns.Add("LastName", "Last Name");
                        RepRes.Columns.Add("Numb_of_rentals", "# of Rentals");

                        RepRes.Rows.Clear();
                        while (db.myReader.Read())
                        {
                            RepRes.Rows.Add(db.myReader["CustomerID"].ToString(), db.myReader["FirstName"].ToString(), db.myReader["LastName"].ToString(), db.myReader["Numb_of_rentals"].ToString());
                        }

                        db.myReader.Close();
                    }
                    catch (Exception e3)
                    {
                        MessageBox.Show(e3.ToString(), "Error");
                    }
                }

                else if (choice == 1) // Top 5 rented movies in date range
                {
                    DateTime date1, date2;
                    if (!DateTime.TryParse(DateSelect1.Text, out date1) || !DateTime.TryParse(DateSelect2.Text, out date2))
                    {
                        MessageBox.Show("Invalid dates selected.");
                        return;
                    }

                    try
                    {
                        string query = @"
                                        WITH RankedMovies AS (
                                        SELECT 
                                        M.MovieID, 
                                        M.MovieName, 
                                        COUNT(*) AS Numb_of_Rentals,
                                        DENSE_RANK() OVER (ORDER BY COUNT(*) DESC) AS rnk
                                        FROM Rental R
                                        JOIN Movie M ON R.MovieID = M.MovieID
                                        WHERE R.CheckoutDateTime BETWEEN @date1 AND @date2
                                        GROUP BY M.MovieID, M.MovieName
                                        )
                                        SELECT MovieID, MovieName, Numb_of_Rentals
                                        FROM RankedMovies
                                        WHERE rnk <= 5
                                        ORDER BY Numb_of_Rentals DESC;";
                        db.Date_Param_query(query, date1, date2);

                        RepRes.Columns.Add("MovieID", "Movie ID");
                        RepRes.Columns.Add("MovieName", "Movie Name");
                        RepRes.Columns.Add("Numb_of_rentals", "# of Rentals");

                        RepRes.Rows.Clear();
                        while (db.myReader.Read())
                        {
                            RepRes.Rows.Add(db.myReader["MovieID"].ToString(), db.myReader["MovieName"].ToString(), db.myReader["Numb_of_rentals"].ToString());
                        }

                        db.myReader.Close();
                    }
                    catch (Exception e3)
                    {
                        MessageBox.Show(e3.ToString(), "Error");
                    }
                }
                else if (choice == 2) // Top movies rented by an employee (FIXED INCOMPLETE QUERY)
                {
                    try
                    {
                        string query = @"
                                        WITH RankedMovies AS (
                                        SELECT r.MovieID, m.MovieName, COUNT(*) AS numb_of_rentals,
                                        DENSE_RANK() OVER (ORDER BY COUNT(*) DESC) AS rnk
                                        FROM rental r, movie m
	                                    WHERE r.EmployeeID= @ID and r.MovieID=m.MovieID
                                        GROUP BY r.MovieID, m.MovieName
                                        )
                                        SELECT MovieID, MovieName,  numb_of_rentals
                                        FROM RankedMovies
                                        WHERE rnk <= 3
                                        ORDER BY numb_of_rentals DESC;"
                        ;
                        System.String empID= Specif.Text;
                        db.ID_Param_query(query, empID);

                        RepRes.Columns.Add("MovieID", "Movie ID");
                        RepRes.Columns.Add("MovieName", "Movie Name");
                        RepRes.Columns.Add("Numb_of_rentals", "# of Rentals");

                        RepRes.Rows.Clear();
                        while (db.myReader.Read())
                        {
                            RepRes.Rows.Add(db.myReader["MovieID"].ToString(), db.myReader["MovieName"].ToString(), db.myReader["Numb_of_rentals"].ToString());
                        }

                        db.myReader.Close();
                    
                    }
                    catch (Exception e3)
                    {
                        MessageBox.Show(e3.ToString(), "Error");
                    }
                }
                else if (choice == 3) // Top 3 rented movie types in date range
                {
                    DateTime date1, date2;
                    if (!DateTime.TryParse(DateSelect1.Text, out date1) || !DateTime.TryParse(DateSelect2.Text, out date2))
                    {
                        MessageBox.Show("Invalid dates selected.");
                        return;
                    }

                    try
                    {
                        string query = @"
                                        WITH RankedMovies AS (
                                        SELECT m.MovieType, COUNT(*) AS numb_of_rentals,
                                        DENSE_RANK() OVER (ORDER BY COUNT(*) DESC) AS rank
                                        FROM rental r
                                        JOIN movie m ON m.MovieID = r.MovieID
                                        WHERE r.CheckoutDateTime BETWEEN @Date1 AND @Date2
                                        GROUP BY m.MovieType
                                         )
                                        SELECT MovieType, numb_of_rentals
                                        FROM RankedMovies
                                        WHERE rank <= 3
                                        ORDER BY numb_of_rentals DESC;";
                        db.Date_Param_query(query, date1, date2);

                        RepRes.Columns.Add("MovieType", "Movie Type");
                        RepRes.Columns.Add("Numb_of_rentals", "# of Rentals");

                        RepRes.Rows.Clear();
                        while (db.myReader.Read())
                        {
                            RepRes.Rows.Add(db.myReader["MovieType"].ToString(), db.myReader["Numb_of_rentals"].ToString());
                        }

                        db.myReader.Close();
                    }
                    catch (Exception e3)
                    {
                        MessageBox.Show(e3.ToString(), "Error");
                    }
                }
                else if (choice == 4) // Top 3 rented movies by an actor
                {
                    try
                    {
                        string query = @"
                                    WITH RankedMovies AS (
                                        SELECT m.MovieName, r.MovieID, COUNT(*) AS numb_of_rentals,
                                               DENSE_RANK() OVER (ORDER BY COUNT(*) DESC) AS rank
                                        FROM Rental r
                                        JOIN AppearedIn a ON r.MovieID = a.MovieID
                                        JOIN Movie m ON r.MovieID = m.MovieID
                                        WHERE a.ActorID = @ID
                                        GROUP BY r.MovieID, m.MovieName
                                    )
                                    SELECT MovieName, MovieID, numb_of_rentals
                                    FROM RankedMovies
                                    WHERE rank <= 3
                                    ORDER BY numb_of_rentals DESC;
        ";
                        System.String actorID = Specif.Text;
                        db.ID_Param_query(query, actorID);

                        RepRes.Columns.Add("MovieID", "Movie ID");
                        RepRes.Columns.Add("MovieName", "Movie Name");
                        RepRes.Columns.Add("Numb_of_rentals", "# of Rentals");

                        RepRes.Rows.Clear();
                        while (db.myReader.Read())
                        {
                            RepRes.Rows.Add(db.myReader["MovieID"].ToString(), db.myReader["MovieName"].ToString(), db.myReader["Numb_of_rentals"].ToString());
                        }

                        db.myReader.Close();
                    }
                    catch (Exception e3)
                    {
                        MessageBox.Show(e3.ToString(), "Error");
                    }
                }
            }
        }
            

        private void Specif_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EnterR_Click_1(object sender, EventArgs e)
        {

        }
    }
}
   