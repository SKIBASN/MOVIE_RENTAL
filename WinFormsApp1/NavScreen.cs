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
            }
            else if (ReportSelection.SelectedIndex==1)
            {
                SpecifTitle1.Text = "Date 1";
                SpecifTitle2.Text = "Date 2";
                SpecifTitle1.Visible = true;
                SpecifTitle2.Visible = true;
                DateSelect1.Visible = true;
                DateSelect2.Visible = true;
                cal1.Visible = true;
                cal2.Visible = true;
                EnterR.Visible = true;

                Specif.Visible = false;
            }
            else if (ReportSelection.SelectedIndex == 2)
            {
                SpecifTitle1.Text = "Employee ID";
                SpecifTitle1.Visible = true;
                Specif.Visible = true;
                EnterR.Visible = true;


                SpecifTitle2.Visible = false;
                DateSelect1.Visible = false;
                DateSelect2.Visible = false;
                cal1.Visible = false;
                cal2.Visible = false;

            }
            else if (ReportSelection.SelectedIndex == 3)
            {
                SpecifTitle1.Text = "Date 1";
                SpecifTitle2.Text = "Date 2";
                SpecifTitle1.Visible = true;
                SpecifTitle2.Visible = true;
                DateSelect1.Visible = true;
                DateSelect2.Visible = true;
                cal1.Visible = true;
                cal2.Visible = true;
                EnterR.Visible = true;

                Specif.Visible = false;
            }
            else if (ReportSelection.SelectedIndex == 4)
            {
                SpecifTitle1.Text = "Actor ID";
                SpecifTitle1.Visible = true;
                Specif.Visible = true;
                EnterR.Visible = true;

                SpecifTitle2.Visible = false;
                DateSelect1.Visible = false;
                DateSelect2.Visible = false;
                cal1.Visible = false;
                cal2.Visible = false;

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

        private void Enter_Click(object sender, EventArgs e)
        {
            if (choice == 1) // What Movies haven't been rented since a specific date?
            {
                try
                {
                    //db.myCommand.CommandText = "SELECT Username, firstName FROM Employee WHERE Username = @user AND password = @pass";
                    //db.myCommand.Parameters.Clear();
                    //db.myCommand.Parameters.AddWithValue("@user", user.Text);
                    //db.myReader = db.myCommand.ExecuteReader();

                    // Check if any row is returned
                    if (db.myReader.Read())
                    {


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
                    //db.myReader = db.myCommand.ExecuteReader();

                    // Check if any row is returned
                    if (db.myReader.Read())
                    {


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
                    //db.myReader = db.myCommand.ExecuteReader();

                    // Check if any row is returned
                    if (db.myReader.Read())
                    {

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
                    //db.myReader = db.myCommand.ExecuteReader();

                    // Check if any row is returned
                    if (db.myReader.Read())
                    {


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


                if (db.myReader.HasRows)
                {
                    while (db.myReader.Read())
                    {
                        string firstName = db.myReader["FirstName"]?.ToString() ?? "Unknown";
                        string lastName = db.myReader["LastName"]?.ToString() ?? "Unknown";
                        //output.AppendLine($"{firstName} {lastName}");
                    }
                }
            }
            else
            {
                MessageBox.Show("No rental records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
