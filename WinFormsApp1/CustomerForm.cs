using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class CustomerForm : Form
    {
        // Controls
        TextBox txtFirstName, txtLastName, txtAddress, txtCity, txtState, txtZipCode, txtEmail, txtAccountNumber, txtCreditCard;
        Button btnAddCustomer, btnUpdate, btnDelete;
        DataGridView dgvCustomers;

        public CustomerForm()
        {
            this.Text = "Customer Management";
            this.Width = 400;
            this.Height = 700;

            InitializeControls();
            LoadCustomers();
        }

        private void InitializeControls()
        {
            Label[] labels = new Label[]
            {
                CreateLabel("First Name:", 20),
                CreateLabel("Last Name:", 60),
                CreateLabel("Address:", 100),
                CreateLabel("City:", 140),
                CreateLabel("State:", 180),
                CreateLabel("Zip Code:", 220),
                CreateLabel("Email:", 260),
                CreateLabel("Account #:", 300),
                CreateLabel("Credit Card:", 340)
            };

            txtFirstName = CreateTextbox(20);
            txtLastName = CreateTextbox(60);
            txtAddress = CreateTextbox(100);
            txtCity = CreateTextbox(140);
            txtState = CreateTextbox(180);
            txtZipCode = CreateTextbox(220);
            txtEmail = CreateTextbox(260);
            txtAccountNumber = CreateTextbox(300);
            txtCreditCard = CreateTextbox(340);

            btnAddCustomer = new Button();
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.Top = 380;
            btnAddCustomer.Left = 130;
            btnAddCustomer.Click += BtnAddCustomer_Click;

            btnUpdate = new Button();
            btnUpdate.Text = "Update";
            btnUpdate.Top = 380;
            btnUpdate.Left = 20;
            btnUpdate.Click += BtnUpdate_Click;

            btnDelete = new Button();
            btnDelete.Text = "Delete";
            btnDelete.Top = 380;
            btnDelete.Left = 280;
            btnDelete.Click += BtnDelete_Click;

            dgvCustomers = new DataGridView();
            dgvCustomers.Top = 430;
            dgvCustomers.Left = 20;
            dgvCustomers.Width = 340;
            dgvCustomers.Height = 200;
            dgvCustomers.ReadOnly = true;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.CellClick += DgvCustomers_CellClick;

            this.Controls.Add(btnAddCustomer);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);
            this.Controls.Add(dgvCustomers);

            foreach (var label in labels) this.Controls.Add(label);
            this.Controls.AddRange(new Control[]
            {
                txtFirstName, txtLastName, txtAddress, txtCity, txtState, txtZipCode,
                txtEmail, txtAccountNumber, txtCreditCard
            });
        }

        private Label CreateLabel(string text, int top)
        {
            return new Label
            {
                Text = text,
                Top = top,
                Left = 20,
                Width = 100
            };
        }

        private TextBox CreateTextbox(int top)
        {
            return new TextBox
            {
                Top = top,
                Left = 130,
                Width = 200
            };
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            //db.AddCustomer(
            //    txtSIN.Text,
            //    txtFirstName.Text,
            //    txtLastName.Text,
            //    txtAddress.Text,
            //    txtCity.Text,
            //    txtState.Text,
            //    txtZipCode.Text,
            //    txtEmail.Text,
            //    txtAccountNumber.Text,
            //    txtCreditCard.Text
            //);
            MessageBox.Show("Customer added successfully!");
            LoadCustomers();
            ClearForm();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["CustomerID"].Value);
                Database db = new Database();

                string query = @"UPDATE Customer SET 
                    FirstName = @FirstName, LastName = @LastName, Address = @Address,
                    City = @City, State = @State, ZipCode = @Zip, EmailAddress = @Email,
                    AccountNumber = @Account, CreditCardNumber = @CC
                    WHERE CustomerID = @ID";

                SqlCommand cmd = new SqlCommand(query, db.myConnection);
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@City", txtCity.Text);
                cmd.Parameters.AddWithValue("@State", txtState.Text);
                cmd.Parameters.AddWithValue("@Zip", txtZipCode.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Account", txtAccountNumber.Text);
                cmd.Parameters.AddWithValue("@CC", txtCreditCard.Text);
                cmd.Parameters.AddWithValue("@ID", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Customer updated!");
                LoadCustomers();
                ClearForm();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["CustomerID"].Value);
                Database db = new Database();

                SqlCommand cmd = new SqlCommand("DELETE FROM Customer WHERE CustomerID = @ID", db.myConnection);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Customer deleted.");
                LoadCustomers();
                ClearForm();
            }
        }

        private void DgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtCity.Text = row.Cells["City"].Value.ToString();
                txtState.Text = row.Cells["State"].Value.ToString();
                txtZipCode.Text = row.Cells["ZipCode"].Value.ToString();
                txtEmail.Text = row.Cells["EmailAddress"].Value.ToString();
                txtAccountNumber.Text = row.Cells["AccountNumber"].Value.ToString();
                txtCreditCard.Text = row.Cells["CreditCardNumber"].Value.ToString();
            }
        }

        private void LoadCustomers()
        {
            Database db = new Database();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", db.myConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dgvCustomers.DataSource = table;
        }

        private void InitializeComponent()
        {

        }

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtZipCode.Clear();
            txtEmail.Clear();
            txtAccountNumber.Clear();
            txtCreditCard.Clear();
        }
    }
}