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
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class NavScreen : Form
    {
        public Database db;
        private int choice;

        public NavScreen()
        {
            InitializeComponent();
            db = new Database(); // Initialize the object and create the connection
            LoadCustomers();
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
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
                result.Visible = false;
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
                result.Visible = false;
                Specif.Visible = true;
                Enter.Visible = false;
                DateSelect.Visible = false;
                cal.Visible = false;
                SpecifTitle.Visible = true;
                SpecifTitle.Text = "Enter an Employee ID:";
                Enter.Visible = true;
                choice= 2;
            }
            else if (ReportSelection.SelectedItem.ToString() == "What Actors appear in a Movie?")
            {
                Specif.Text = "";
                DateSelect.Text = "No Date Selected";
                result.Visible = false;
                cal.Visible = false;
                Enter.Visible = false;
                DateSelect.Visible = false;
                Specif.Visible = true;
                SpecifTitle.Visible = true;
                SpecifTitle.Text = "Enter a Movie ID:";
                Enter.Visible = true;
                choice = 3;
            }
            else if (ReportSelection.SelectedItem.ToString() == "How many times has a movie with a specific actor been rented?")
            {
                Specif.Text = "";
                DateSelect.Text = "No Date Selected";
                result.Visible = false;
                cal.Visible = false;
                Enter.Visible = false;
                Specif.Visible = true;
                DateSelect.Visible = false;
                SpecifTitle.Visible = true;
                SpecifTitle.Text = "Enter an Actor ID: ";
                Enter.Visible = true;
                choice = 4;
            }
            else if (ReportSelection.SelectedItem.ToString() == "Which Customer has the most rentals?")
            {
                Specif.Text = "";
                DateSelect.Text = "No Date Selected";
                Enter.Visible = true;
                result.Visible = true;
                result.Visible = false;
                cal.Visible = false;
                Specif.Visible = false;
                DateSelect.Visible = false;
                SpecifTitle.Visible = false;
                choice = 5;
            }
            else
            {
                Specif.Text = "";
                DateSelect.Text = "No Date Selected";
                Enter.Visible = false;
                cal.Visible = false;
                Specif.Visible = false;
                DateSelect.Visible = false;
                SpecifTitle.Visible = false;
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
            if (choice == 1)
            {
                try
                {
                    db.myCommand.CommandText = "SELECT Username, firstName FROM Employee WHERE Username = @user AND password = @pass";
                    db.myCommand.Parameters.Clear();
                    //db.myCommand.Parameters.AddWithValue("@user", user.Text);
                    db.myReader = db.myCommand.ExecuteReader();

                    // Check if any row is returned
                    if (db.myReader.Read())
                    {
                        result.Text = "Success";
                        result.Visible = true;

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
            else if (choice == 2)
            {
                try
                {
                    db.myCommand.CommandText = "SELECT Username, firstName FROM Employee WHERE Username = @user AND password = @pass";
                    db.myCommand.Parameters.Clear();
                    //db.myCommand.Parameters.AddWithValue("@user", user.Text);
                    db.myReader = db.myCommand.ExecuteReader();

                    // Check if any row is returned
                    if (db.myReader.Read())
                    {
                        result.Text = "Success";
                        result.Visible = true;

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
                    db.myCommand.CommandText = "SELECT Username, firstName FROM Employee WHERE Username = @user AND password = @pass";
                    db.myCommand.Parameters.Clear();
                    //db.myCommand.Parameters.AddWithValue("@user", user.Text);
                    db.myReader = db.myCommand.ExecuteReader();

                    // Check if any row is returned
                    if (db.myReader.Read())
                    {
                        result.Text = "Success";
                        result.Visible = true;

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
                    db.myCommand.CommandText = "SELECT Username, firstName FROM Employee WHERE Username = @user AND password = @pass";
                    db.myCommand.Parameters.Clear();
                    //db.myCommand.Parameters.AddWithValue("@user", user.Text);
                    db.myReader = db.myCommand.ExecuteReader();

                    // Check if any row is returned
                    if (db.myReader.Read())
                    {
                        result.Text = "Success";
                        result.Visible = true;

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
                    db.myCommand.CommandText = "SELECT Username, firstName FROM Employee WHERE Username = @user AND password = @pass";
                    db.myCommand.Parameters.Clear();
                    //db.myCommand.Parameters.AddWithValue("@user", user.Text);
                    db.myReader = db.myCommand.ExecuteReader();

                    // Check if any row is returned
                    if (db.myReader.Read())
                    {
                        result.Text = "Success";
                        result.Visible = true;

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

        }
    }
}
