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
using System.Data.SqlClient;
//using Microsoft.VisualBasic.mitApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO.Pipes;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.PortableExecutable;
using System.Security.Principal;
using System.Transactions;
using System.Data.Common;

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
            db = new Database(); // Initialize the object and create the connection
            LoadCustomers();
            LoadMovies();
            LoadActors();
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        private void LoadCustomers()
        {
            try
            {
                string query = "SELECT * FROM Customer";
                SqlCommand cmd = new SqlCommand(query, db.myConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvCustomers.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading customers.");
            }
        }

        // New validation method to ensure all customer fields have input
        private bool ValidateCustomerInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtCity.Text) ||
                string.IsNullOrWhiteSpace(txtState.Text) ||
                string.IsNullOrWhiteSpace(txtZip.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtAccount.Text) ||
                string.IsNullOrWhiteSpace(txtCredit.Text))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error");
                return false;
            }
            return true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields before proceeding
                if (!ValidateCustomerInputs())
                    return;

                string insertQuery = "INSERT INTO Customer (FirstName, LastName, Address, City, State, ZipCode, EmailAddress, AccountNumber, CreditCardNumber) " +
                                     "VALUES (@FirstName, @LastName, @Address, @City, @State, @Zip, @Email, @Account, @Credit)";
                db.myCommand.CommandText = insertQuery;
                db.myCommand.Parameters.Clear();
                db.myCommand.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                db.myCommand.Parameters.AddWithValue("@LastName", txtLastName.Text);
                db.myCommand.Parameters.AddWithValue("@Address", txtAddress.Text);
                db.myCommand.Parameters.AddWithValue("@City", txtCity.Text);
                db.myCommand.Parameters.AddWithValue("@State", txtState.Text);
                db.myCommand.Parameters.AddWithValue("@Zip", txtZip.Text);
                db.myCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                db.myCommand.Parameters.AddWithValue("@Account", txtAccount.Text);
                db.myCommand.Parameters.AddWithValue("@Credit", txtCredit.Text);

                db.myCommand.ExecuteNonQuery();
                MessageBox.Show("Customer added successfully!");
                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null) return;

            try
            {
                // Validate input fields before updating
                if (!ValidateCustomerInputs())
                    return;

                int id = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["CustomerID"].Value);
                string updateQuery = "UPDATE Customer SET FirstName = @FirstName, LastName = @LastName, Address = @Address, City = @City, State = @State, " +
                                     "ZipCode = @Zip, EmailAddress = @Email, AccountNumber = @Account, CreditCardNumber = @Credit WHERE CustomerID = @ID";
                db.myCommand.CommandText = updateQuery;
                db.myCommand.Parameters.Clear();
                db.myCommand.Parameters.AddWithValue("@ID", id);
                db.myCommand.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                db.myCommand.Parameters.AddWithValue("@LastName", txtLastName.Text);
                db.myCommand.Parameters.AddWithValue("@Address", txtAddress.Text);
                db.myCommand.Parameters.AddWithValue("@City", txtCity.Text);
                db.myCommand.Parameters.AddWithValue("@State", txtState.Text);
                db.myCommand.Parameters.AddWithValue("@Zip", txtZip.Text);
                db.myCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                db.myCommand.Parameters.AddWithValue("@Account", txtAccount.Text);
                db.myCommand.Parameters.AddWithValue("@Credit", txtCredit.Text);

                db.myCommand.ExecuteNonQuery();
                MessageBox.Show("Customer updated successfully!");
                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null) return;

            try
            {
                int id = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["CustomerID"].Value);
                string deleteQuery = "DELETE FROM Customer WHERE CustomerID = @ID";
                db.myCommand.CommandText = deleteQuery;
                db.myCommand.Parameters.Clear();
                db.myCommand.Parameters.AddWithValue("@ID", id);
                db.myCommand.ExecuteNonQuery();

                MessageBox.Show("Customer deleted successfully!");
                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void LoadMovies()
        {
            try
            {
                if (db.myConnection.State == ConnectionState.Open)
                {
                    db.myConnection.Close();  // Close the connection if it's open
                }
                db.myConnection.Open();
                string query = "SELECT * FROM Movie";
                SqlCommand cmd = new SqlCommand(query, db.myConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                var filteredRows = table.AsEnumerable()
                .Where(row => row.Field<string>("MovieName") != "DeletedMovie3561")
                .CopyToDataTable();
                dgvMovies.DataSource = filteredRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading Movies.");
            }
            if (db.myConnection.State == ConnectionState.Open)
            {
                db.myConnection.Close();
            }

        }
        private void LoadActors()
        {
            try
            {
                if (db.myConnection.State == ConnectionState.Open)
                {
                    db.myConnection.Close();  // Close the connection if it's open
                }
                db.myConnection.Open();
                string query = "SELECT * FROM Actor";
                SqlCommand cmd = new SqlCommand(query, db.myConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvActors.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading Actors.");
            }
            if (db.myConnection.State == ConnectionState.Open)
            {
                db.myConnection.Close();
            }

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
                                        FROM RentalOrder 
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
                    try
                    {
                        string query = @"
                                        WITH RankedMovies AS (
                                        SELECT 
                                        M.MovieID, 
                                        M.MovieName, 
                                        COUNT(*) AS Numb_of_Rentals,
                                        DENSE_RANK() OVER (ORDER BY COUNT(*) DESC) AS rnk
                                        FROM RentalOrder R
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
                            RepRes.Rows.Clear();
                            RepRes.Columns.Clear();
                            return;
                        }
                        else if (string.IsNullOrEmpty(DateSelect1.Text) || string.IsNullOrEmpty(DateSelect2.Text))
                        {
                            ErrorMes.Text = "Please enter a date range.";
                            RepRes.Rows.Clear();
                            RepRes.Columns.Clear();
                        }
                        else if (date1 > date2)
                        {
                            ErrorMes.Text = "Invalid date range.";
                            RepRes.Rows.Clear();
                            RepRes.Columns.Clear();
                        }
                        else
                        {
                            ErrorMes.Text = "";

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
                                        FROM rentalOrder r, movie m
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
                                ErrorMes.Text = "";
                                db.myReader.Close();
                                db.ID_Param_query(query, empID);

                                RepRes.Columns.Add("MovieID", "Movie ID");
                                RepRes.Columns.Add("MovieName", "Movie Name");
                                RepRes.Columns.Add("Numb_of_rentals", "# of Rentals");

                                RepRes.Rows.Clear();
                                while (db.myReader.Read())
                                {
                                    RepRes.Rows.Add(db.myReader["MovieID"].ToString(), db.myReader["MovieName"].ToString(), db.myReader["numb_of_rentals"].ToString());
                                }

                                db.myReader.Close();
                            }
                        }
                    }
                    catch (Exception e3)
                    {
                        MessageBox.Show(e3.ToString(), "Error");
                    }
                }
                else if (choice == 3) // Top 3 rented movie types in date range
                {
                    DateTime date1, date2;

                    try
                    {
                        string query = @"
                                        WITH RankedMovies AS (
                                        SELECT m.MovieType, COUNT(*) AS numb_of_rentals,
                                        DENSE_RANK() OVER (ORDER BY COUNT(*) DESC) AS rank
                                        FROM rentalOrder r
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
                            RepRes.Rows.Clear();
                            RepRes.Columns.Clear();
                            return;
                        }
                        else if (string.IsNullOrEmpty(DateSelect1.Text) || string.IsNullOrEmpty(DateSelect2.Text))
                        {
                            ErrorMes.Text = "Please enter a date range.";
                            RepRes.Rows.Clear();
                            RepRes.Columns.Clear();
                        }
                        else if (date1 > date2)
                        {
                            ErrorMes.Text = "Invalid date range.";
                            RepRes.Rows.Clear();
                            RepRes.Columns.Clear();
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
                                RepRes.Rows.Add(db.myReader["MovieType"].ToString(), db.myReader["numb_of_rentals"].ToString());
                            }

                            db.myReader.Close();
                        }
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
                                        FROM RentalOrder r
                                        JOIN AppearedIn a ON r.MovieID = a.MovieID
                                        JOIN Movie m ON r.MovieID = m.MovieID
                                        WHERE a.ActorID = @ID
                                        GROUP BY r.MovieID, m.MovieName
                                         )
                                    SELECT MovieName, MovieID, numb_of_rentals
                                    FROM RankedMovies
                                    WHERE rank <= 3
                                    ORDER BY numb_of_rentals DESC;";
                        System.String actorID = Specif.Text;
                        if (string.IsNullOrWhiteSpace(actorID))
                        {
                            ErrorMes.Text = "Empty Actor ID.";
                            RepRes.Rows.Clear();
                            RepRes.Columns.Clear();
                        }
                        else
                        {
                            // Check if actorID is valid
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
                                    RepRes.Rows.Add(db.myReader["MovieID"].ToString(), db.myReader["MovieName"].ToString(), db.myReader["numb_of_rentals"].ToString());
                                }

                                db.myReader.Close();
                            }
                        }
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {
            dgvMovies.RowTemplate.Height = 30;
            dgvMovies.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxCopies_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnMovieAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (db.myConnection.State == ConnectionState.Open)
                {
                    db.myConnection.Close();  // Close the connection if it's open
                }
                db.myConnection.Open();
                string insertQuery = "INSERT INTO Movie(MovieName, MovieType, DistributionFee, NumberOfCopies) " +
                                     "VALUES (@MovieName, @MovieType, @DistributionFee, @NumberOfCopies)";
                db.myCommand.CommandText = insertQuery;
                db.myCommand.Parameters.Clear();
                db.myCommand.Parameters.AddWithValue("@MovieName", txtBoxName.Text);
                db.myCommand.Parameters.AddWithValue("@MovieType", txtBoxType.Text);
                db.myCommand.Parameters.AddWithValue("@DistributionFee", txtBoxDFee.Text);
                db.myCommand.Parameters.AddWithValue("@NumberOfCopies", txtBoxCopies.Text);


                db.myCommand.ExecuteNonQuery();
                MessageBox.Show("Movies added successfully!");
                LoadMovies();
                if (db.myConnection.State == ConnectionState.Open)
                {
                    db.myConnection.Close();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Error converting data type nvarchar to numeric"))
                {

                    MessageBox.Show("Please make sure that the Dsitribution Fee and/or the # Copies are an int.",
                                    "Data Conversion Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    // Handle other SQL errors
                    MessageBox.Show("An unexpected error occurred. Please try again later.",
                                    "Database Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void BtnMovieUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMovies.CurrentRow == null) return;

            try
            {
                if (db.myConnection.State == ConnectionState.Open)
                {
                    db.myConnection.Close();  // Close the connection if it's open
                }
                db.myConnection.Open();
                int id = Convert.ToInt32(dgvMovies.CurrentRow.Cells["MovieID"].Value);
                string updateQuery = "UPDATE Movie SET MovieName = @MovieName, MovieType = @MovieType, DistributionFee = @DistributionFee, NumberOfCopies = @NumberOfCopies WHERE MovieID = @ID";
                db.myCommand.CommandText = updateQuery;
                db.myCommand.Parameters.Clear();
                db.myCommand.Parameters.AddWithValue("@ID", txtBoxMovieID.Text);
                db.myCommand.Parameters.AddWithValue("@MovieName", txtBoxName.Text);
                db.myCommand.Parameters.AddWithValue("@MovieType", txtBoxType.Text);
                db.myCommand.Parameters.AddWithValue("@DistributionFee", txtBoxDFee.Text);
                db.myCommand.Parameters.AddWithValue("@NumberOfCopies", txtBoxCopies.Text);

                db.myCommand.ExecuteNonQuery();
                MessageBox.Show("Movie updated successfully!");
                LoadMovies();
                if (db.myConnection.State == ConnectionState.Open)
                {
                    db.myConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void BtnMovieDelete_Click(object sender, EventArgs e)
        {
            if (dgvMovies.CurrentRow == null) return;

            try
            {
                if (db.myConnection.State == ConnectionState.Open)
                {
                    db.myConnection.Close();  // Close the connection if it's open
                }
                db.myConnection.Open();
                string replacedTextName = "DeletedMovie3561";
                string replacedTextType = "Comedy";
                int replacedTextFee = 0;
                int id = Convert.ToInt32(dgvMovies.CurrentRow.Cells["MovieID"].Value);
                string updateQuery = "UPDATE Movie SET MovieName = @MovieName, MovieType = @MovieType, DistributionFee = @DistributionFee, NumberOfCopies = @NumberOfCopies WHERE MovieID = @ID";
                db.myCommand.CommandText = updateQuery;
                db.myCommand.Parameters.Clear();
                db.myCommand.Parameters.AddWithValue("@ID", txtBoxMovieID.Text);
                db.myCommand.Parameters.AddWithValue("@MovieName", replacedTextName);
                db.myCommand.Parameters.AddWithValue("@MovieType", replacedTextType);
                db.myCommand.Parameters.AddWithValue("@DistributionFee", replacedTextFee);
                db.myCommand.Parameters.AddWithValue("@NumberOfCopies", replacedTextFee);

                db.myCommand.ExecuteNonQuery();
                MessageBox.Show("Movie deleted successfully!");
                LoadMovies();
                if (db.myConnection.State == ConnectionState.Open)
                {
                    db.myConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (db.myConnection.State == ConnectionState.Open)
                {
                    db.myConnection.Close();  // Close the connection if it's open
                }
                db.myConnection.Open();
                string insertQuery = "INSERT INTO AppearedIn(MovieID, ActorID) " +
                                     "VALUES (@MovieID, @ActorID)";
                db.myCommand.CommandText = insertQuery;
                db.myCommand.Parameters.Clear();
                db.myCommand.Parameters.AddWithValue("@MovieID", txtBoxMovieIDActor.Text);
                db.myCommand.Parameters.AddWithValue("@ActorID", txtBoxActorIDAI.Text);



                db.myCommand.ExecuteNonQuery();
                MessageBox.Show("Actor added successfully!");
                if (db.myConnection.State == ConnectionState.Open)
                {
                    db.myConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void dgvActors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMovies.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMovies.RowTemplate.Height = 30;
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

