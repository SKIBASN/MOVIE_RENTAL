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
        private int choice = 5;
        // Change the type of 'result' from 'object' to 'Control' to access the 'Visible' property
        private Control result;

        public NavScreen()
        {
            InitializeComponent();
            db = new Database(); // Initialize the object and create the connection
            // Initialize result with a TextBox instance
            this.Controls.Add(RepRes); // Add result to the form's controls
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
            int choice = 4;
            if (ReportSelection.SelectedItem.ToString() == "What Movies haven't been rented since a specific date?")
            {
                Specif.Text = "";
                DateSelect.Text = "No Date Selected";
                RepRes.Visible = false;
                cal.Visible = true;
                Enter.Visible = false;
                DateSelect.Visible = true;
                Specif.Visible = false;
                SpecifTitle.Visible = true;
                SpecifTitle.Text = "Pick a Date: ";
                Enter.Visible = true;
                choice = 5;

            }
            else if (ReportSelection.SelectedItem.ToString() == "What movies has a specific employee rented?")
            {
                Specif.Text = "";
                DateSelect.Text = "No Date Selected";
                RepRes.Visible = false;
                Specif.Visible = true;
                Enter.Visible = false;
                DateSelect.Visible = false;
                cal.Visible = false;
                SpecifTitle.Visible = true;
                SpecifTitle.Text = "Enter an Employee ID:";
                Enter.Visible = true;
                choice = 5;
            }
            else if (ReportSelection.SelectedItem.ToString() == "What Actors appear in a Movie?")
            {
                Specif.Text = "";
                DateSelect.Text = "No Date Selected";
                RepRes.Visible = false;
                cal.Visible = false;
                Enter.Visible = false;
                DateSelect.Visible = false;
                Specif.Visible = true;
                SpecifTitle.Visible = true;
                SpecifTitle.Text = "Enter a Movie ID:";
                Enter.Visible = true;
                choice = 5;
            }
            else if (ReportSelection.SelectedItem.ToString() == "How many times has a movie with a specific actor been rented?")
            {
                Specif.Text = "";
                DateSelect.Text = "No Date Selected";
                RepRes.Visible = false;
                cal.Visible = false;
                Enter.Visible = false;
                Specif.Visible = true;
                DateSelect.Visible = false;
                SpecifTitle.Visible = true;
                SpecifTitle.Text = "Enter an Actor ID: ";
                Enter.Visible = true;
                choice = 5;
            }
            else if (ReportSelection.SelectedItem.ToString() == "Which Customer has the most rentals?")
            {
                Specif.Text = "";
                DateSelect.Text = "No Date Selected";
                Enter.Visible = true;
                RepRes.Visible = false;
                cal.Visible = false;
                Specif.Visible = false;
                DateSelect.Visible = false;
                SpecifTitle.Visible = false;
                choice = 5;
            }
            else
            {
                Specif.Text = "";
                RepRes.Visible = false;
                DateSelect.Text = "No Date Selected";
                Enter.Visible = false;
                cal.Visible = false;
                Specif.Visible = false;
                DateSelect.Visible = false;
                SpecifTitle.Visible = false;
                choice = 5;
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
            DateSelect.Text = cal.SelectionStart.ToShortDateString();
        }
        private void cal_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateSelect.Text = cal.SelectionStart.ToShortDateString();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (choice == 1) // What Movies haven't been rented since a specific date?
            {
                try
                {
                    //db.myCommand.CommandText = "SELECT Username, firstName FROM Employee WHERE Username = @user AND password = @pass";
                    //db.myCommand.Parameters.Clear();
                    //db.myCommand.Parameters.AddWithValue("@user", user.Text);
                    db.myReader = db.myCommand.ExecuteReader();

                    // Check if any row is returned
                    if (db.myReader.Read())
                    {
                        RepRes.Text = "Success";
                        RepRes.Visible = true;

                    }
                    else
                    {
                        MessageBox.Show("Invalid employeeID or password.");
                    }
                    db.myReader.Close();
                }

                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
            else if (choice == 2) //
            {
                try
                {
                    //db.myCommand.CommandText = "SELECT Username, firstName FROM Employee WHERE Username = @user AND password = @pass";
                    //db.myCommand.Parameters.Clear();
                    //db.myCommand.Parameters.AddWithValue("@user", user.Text);
                    db.myReader = db.myCommand.ExecuteReader();

                    // Check if any row is returned
                    if (db.myReader.Read())
                    {
                        RepRes.Text = "Success";
                        RepRes.Visible = true;

                    }
                    else
                    {
                        MessageBox.Show("Invalid employeeID or password.");
                    }
                    db.myReader.Close();
                }

                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
            else if (choice == 3)
            {
                try
                {
                    //db.myCommand.CommandText = "SELECT Username, firstName FROM Employee WHERE Username = @user AND password = @pass";
                    //db.myCommand.Parameters.Clear();
                    //db.myCommand.Parameters.AddWithValue("@user", user.Text);
                    db.myReader = db.myCommand.ExecuteReader();

                    // Check if any row is returned
                    if (db.myReader.Read())
                    {
                        RepRes.Text = "Success";
                        RepRes.Visible = true;

                    }
                    else
                    {
                        MessageBox.Show("Invalid employeeID or password.");
                    }
                    db.myReader.Close();
                }

                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
            else if (choice == 4)
            {
                try
                {
                    //db.myCommand.CommandText = "SELECT Username, firstName FROM Employee WHERE Username = @user AND password = @pass";
                    //db.myCommand.Parameters.Clear();
                    //db.myCommand.Parameters.AddWithValue("@user", user.Text);
                    db.myReader = db.myCommand.ExecuteReader();

                    // Check if any row is returned
                    if (db.myReader.Read())
                    {
                        RepRes.Text = "Success";
                        RepRes.Visible = true;

                    }
                    else
                    {
                        MessageBox.Show("Invalid employeeID or password.");
                    }
                    db.myReader.Close();
                }

                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
            else if (choice == 5)
            {
                try
                {
                    db.myCommand.CommandText = @"
                            SELECT C.FirstName, C.LastName, R.Numb_of_rentals
                            FROM Customer C
                            INNER JOIN (
                            SELECT CustomerID, COUNT(*) AS Numb_of_rentals
                            FROM Rental
                            GROUP BY CustomerID
                            ) R ON C.CustomerID = R.CustomerID
                            ORDER BY R.Numb_of_rentals DESC;
                            ";

                    db.myCommand.Parameters.Clear();
                    db.myReader = db.myCommand.ExecuteReader();

                    // Display all results
                    if (db.myReader.HasRows)
                    {
                        StringBuilder output = new StringBuilder();
                        while (db.myReader.Read())
                        {
                            string firstName = Convert.ToString(db.myReader["FirstName"]);
                            string lastName = Convert.ToString(db.myReader["LastName"]);
                            output.AppendLine($"{firstName} {lastName}");
                        }

                        RepRes.Text = output.ToString().Trim();
                        RepRes.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("No rental records found.");
                    }

                    db.myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }


        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void Result_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Res_TextChanged(object sender, EventArgs e)
        {

        }

        private void RepRes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
