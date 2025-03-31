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
        private readonly int employeeID;
        public Database db;
        private int choice = 0;

        public NavScreen(int _employeeID, Database DT)
        {
            InitializeComponent();
            db = DT;
            employeeID = _employeeID;
            LoadCustomersIntoDataGridView();
            LoadMoviesIntoDataGridView();

            dgvRentalCustomers.DefaultCellStyle.ForeColor = Color.Black;
            dgvRentalMovies.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void LoadCustomersIntoDataGridView()
        {
            try
            {
                dgvRentalCustomers.DataSource = null;
                dgvRentalCustomers.Columns.Clear();

                DataTable customersTable = db.GetCustomers();   // Retrieve the customer data as a DataTable


                dgvRentalCustomers.DataSource = customersTable; // Bind the DataTable to the DataGridView

                // rename columns
                dgvRentalCustomers.Columns["CustomerID"].HeaderText = "Customer ID";
                dgvRentalCustomers.Columns["SocialSecurityNum"].HeaderText = "SSN";
                dgvRentalCustomers.Columns["FirstName"].HeaderText = "First Name";
                dgvRentalCustomers.Columns["LastName"].HeaderText = "Last Name";
                dgvRentalCustomers.Columns["ZipCode"].HeaderText = "Zip Code";
                dgvRentalCustomers.Columns["EmailAddress"].HeaderText = "Email Address";
                dgvRentalCustomers.Columns["AccountNumber"].HeaderText = "Account Number";
                dgvRentalCustomers.Columns["AccountCreateDate"].HeaderText = "Date Joined";
                dgvRentalCustomers.Columns["CreditCardNumber"].HeaderText = "Credit Card Number";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message);
            }
        }

        private void LoadMoviesIntoDataGridView()
        {
            try
            {
                dgvRentalMovies.DataSource = null;
                dgvRentalMovies.Columns.Clear();

                DataTable moviesTable = db.GetMovies();   // Retrieve the customer data as a DataTable


                dgvRentalMovies.DataSource = moviesTable; // Bind the DataTable to the DataGridView

                // rename columns
                dgvRentalMovies.Columns["MovieID"].HeaderText = "Movie ID";
                dgvRentalMovies.Columns["MovieName"].HeaderText = "Movie Name";
                dgvRentalMovies.Columns["MovieType"].HeaderText = "Type";
                dgvRentalMovies.Columns["DistributionFee"].HeaderText = "Distribution Fee";
                dgvRentalMovies.Columns["NumberOfCopies"].HeaderText = "Number Of Copies";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message);
            }
        }

        private void Rental_Click(object sender, EventArgs e)
        {

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


        //
        /* For Report Screen */
        //
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReportSelection.SelectedIndex == 0) // Assuming 0 is the index for "Who are the top 3 customers with the most rentals?"
            {
                ErrorMes.Text = "";
                RepRes.Rows.Clear();
                RepRes.Columns.Clear();
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
                RepRes.Rows.Clear();
                RepRes.Columns.Clear();
                ErrorMes.Text = "";
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
                RepRes.Rows.Clear();
                RepRes.Columns.Clear();
                ErrorMes.Text = "";
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
                ErrorMes.Text = "";
                RepRes.Rows.Clear();
                RepRes.Columns.Clear();
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
                ErrorMes.Text = "";
                RepRes.Rows.Clear();
                RepRes.Columns.Clear();
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
            //using (db = new Database()) // Ensure proper disposal
            //{
            //db.myCommand.Parameters.Clear(); // Always clear parameters before use


            RepRes.Rows.Clear();
            RepRes.Columns.Clear();
            ErrorMes.Text = "";

            try
            {
                // Top 3 customers with most rentals
                if (choice == 0)
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

                // Top 5 rented movies in date range
                else if (choice == 1)
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

                    DateTime date1, date2;
                    if (!DateTime.TryParse(DateSelect1.Text, out date1) || !DateTime.TryParse(DateSelect2.Text, out date2))
                    {
                        ErrorMes.Text = "Invalid Date Range.";
                        //RepRes.Rows.Clear();
                        //RepRes.Columns.Clear();
                        return;
                    }
                    else if (string.IsNullOrEmpty(DateSelect1.Text) || string.IsNullOrEmpty(DateSelect2.Text))
                    {
                        ErrorMes.Text = "Please enter a date range.";
                        //RepRes.Rows.Clear();
                        //RepRes.Columns.Clear();
                        return;

                    }
                    else if (date1 > date2)
                    {
                        ErrorMes.Text = "Invalid date range.";
                        //RepRes.Rows.Clear();
                        //RepRes.Columns.Clear();
                        return;
                    }
                    else
                    {
                        //ErrorMes.Text = "";

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

                }
                else if (choice == 2) // Top movies rented by an employee (FIXED INCOMPLETE QUERY)
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
                                    ORDER BY numb_of_rentals DESC;";

                    System.String empID = Specif.Text;
                    if (string.IsNullOrWhiteSpace(empID))
                    {
                        ErrorMes.Text = "Empty Employee ID.";
                        RepRes.Rows.Clear();
                        RepRes.Columns.Clear();

                    }
                    else
                    {
                        string Vquery = @"
                                        SELECT *
                                        FROM Employee
                                        WHERE EmployeeID = @VID;";


                        bool empExists = db.VID_Param_query(Vquery, empID);
                        if (!empExists)
                        {
                            ErrorMes.Text = "Invalid Employee ID.";
                            RepRes.Rows.Clear();
                            RepRes.Columns.Clear();
                            db.myReader.Close();

                        }
                        else
                        {
                            //ErrorMes.Text = "";
                            //db.myReader.Close();
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
                    }

                }
                else if (choice == 3) // Top 3 rented movie types in date range
                {
                    DateTime date1, date2;

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

                    if (!DateTime.TryParse(DateSelect1.Text, out date1) || !DateTime.TryParse(DateSelect2.Text, out date2))
                    {
                        ErrorMes.Text = "Invalid Date Range.";
                        //RepRes.Rows.Clear();
                        //RepRes.Columns.Clear();
                        return;
                    }
                    else if (string.IsNullOrEmpty(DateSelect1.Text) || string.IsNullOrEmpty(DateSelect2.Text))
                    {
                        ErrorMes.Text = "Please enter a date range.";
                        //RepRes.Rows.Clear();
                        //RepRes.Columns.Clear();
                        return;
                    }
                    else if (date1 > date2)
                    {
                        ErrorMes.Text = "Invalid date range.";
                        //RepRes.Rows.Clear();
                        //RepRes.Columns.Clear();
                        return;
                    }
                    else
                    {
                        ErrorMes.Text = "";
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

                }
                else if (choice == 4) // Top 3 rented movies by an actor
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

                    if (string.IsNullOrWhiteSpace(actorID))
                    {
                        ErrorMes.Text = "Empty Actor ID.";
                        RepRes.Rows.Clear();
                        RepRes.Columns.Clear();

                    }
                    else
                    {
                        //check is actorID is valid
                        string Vquery = @"
                                        SELECT *
                                        FROM Actor
                                        WHERE ActorID = @VID;";


                        bool actorExists = db.VID_Param_query(Vquery, actorID);
                        if (!actorExists)
                        {
                            ErrorMes.Text = "Invalid Actor ID.";
                            RepRes.Rows.Clear();
                            RepRes.Columns.Clear();
                            db.myReader.Close();
                        }
                        else
                        {
                            ErrorMes.Text = "";
                            db.myReader.Close();

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
                    }
                }
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
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

        private void ErrorMes_TextChanged(object sender, EventArgs e)
        {

        }

        private void NavScreen_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dispenseButton_Click(object sender, EventArgs e)
        {

            try
            {
                if ((dgvRentalCustomers.CurrentRow != null) && (dgvRentalMovies.CurrentRow != null))
                {
                    int customerID = Convert.ToInt32(dgvRentalCustomers.CurrentRow.Cells["CustomerID"].Value);
                    int movieID = Convert.ToInt32(dgvRentalMovies.CurrentRow.Cells["MovieID"].Value);
                    MessageBox.Show("Selected CustomerID: " + customerID + "\nSelected MovieID: " + movieID);

                    // Check total number of copies for selected movie
                    db.myCommand.Parameters.Clear();
                    db.myCommand.Parameters.AddWithValue("@movieID", movieID);
                    db.query("SELECT NumberOfCopies FROM Movie WHERE MovieID = @movieID");
                    int totalCopies = 0;
                    if (db.myReader.Read())
                    {
                        totalCopies = Convert.ToInt32(db.myReader["NumberOfCopies"]);
                    }
                    db.myReader.Close();

                    // Determine how many copies are currently rented out
                    db.myCommand.Parameters.Clear();
                    db.myCommand.Parameters.AddWithValue("@movieID", movieID);
                    db.query("SELECT COUNT(*) AS NumRentedOut " +
                        "FROM RentalOrder " +
                        "WHERE MovieID = @movieID " +
                        "AND ReturnDateTime is NULL");
                    int numRentedOut = 0;
                    if (db.myReader.Read())
                    {
                        numRentedOut = Convert.ToInt32(db.myReader["NumRentedOut"]);
                    }
                    db.myReader.Close();

                    // Create new order if available
                    if (numRentedOut < totalCopies)
                    {
                        string insertRental = "INSERT INTO RentalOrder (MovieID, CustomerID, EmployeeID, CheckoutDateTime)" +
                            "VALUES (@movieID, @customerID, @employeeID, GETDATE())";
                        db.myCommand.Parameters.Clear();
                        db.myCommand.Parameters.AddWithValue("@movieID", movieID);
                        db.myCommand.Parameters.AddWithValue("@customerID", customerID);
                        db.myCommand.Parameters.AddWithValue("@employeeID", employeeID);
                        db.insert(insertRental);

                        MessageBox.Show("Movie successfully rented to customer.");
                    }
                    // Movie is not available
                    else
                    {
                        db.myCommand.Parameters.Clear();
                        db.myCommand.Parameters.AddWithValue("@movieID", movieID);
                        db.myCommand.Parameters.AddWithValue("@customerID", customerID);
                        db.query("SELECT COUNT(*) AS MovieCount " +
                            "WHERE MovieID = @movieID AND CustomerID = @customerID");
                        int movieCount = 0;

                        if (db.myReader.Read())
                        {
                            movieCount = Convert.ToInt32(db.myReader["MovieCount"]);
                        }
                        db.myReader.Close();

                        if (movieCount == 0)
                        {
                            // Determine the new sort order
                            db.myCommand.Parameters.Clear();
                            db.myCommand.Parameters.AddWithValue("@movieID", movieID);
                            db.query("SELECT ISNULL(MAX(SortOrder), 0) AS MaxQueue " +
                                "FROM MovieQueue WHERE MovieID = @movieID");
                            int maxQueue = 0;
                            if (db.myReader.Read())
                            {
                                maxQueue = Convert.ToInt32(db.myReader["MaxQueue"]);
                            }
                            db.myReader.Close();

                            int newSortOrder = maxQueue + 1;

                            db.myCommand.Parameters.Clear();
                            db.myCommand.Parameters.AddWithValue("@movieID", movieID);
                            db.myCommand.Parameters.AddWithValue("@customerID", customerID);
                            db.myCommand.Parameters.AddWithValue("@sortOrder", newSortOrder);
                            db.insert("INSERT INTO MovieQueue (MovieID, CustomerID, SortOrder) " +
                                "VALUES (@movieID, @customerID, @sortOrder");
                            MessageBox.Show("Movie is not available. Customer has been added to the queue.");
                        }
                        else
                        {
                            MessageBox.Show("Movie is not available and customer is already in the queue.");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error dispensing movie: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvRentalCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRentalMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void returnButton_Click(object sender, EventArgs e)
        {

        }
    }
}
   