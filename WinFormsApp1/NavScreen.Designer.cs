namespace WinFormsApp1
{
    partial class NavScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            Customer = new TabPage();
            Movie = new TabPage();
            Rental = new TabPage();
            Report = new TabPage();
            DateSelect = new Label();
            Enter = new Button();
            cal = new MonthCalendar();
            PickReportTitle = new Label();
            result = new Label();
            SpecifTitle = new Label();
            Specif = new TextBox();
            ReportSelection = new ComboBox();
            tabControl1.SuspendLayout();
            Report.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Customer);
            tabControl1.Controls.Add(Movie);
            tabControl1.Controls.Add(Rental);
            tabControl1.Controls.Add(Report);
            tabControl1.Font = new Font("Segoe UI", 20F);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(801, 446);
            tabControl1.TabIndex = 0;
            // 
            // Customer tab
            // 
            Customer.BackColor = Color.Firebrick;
            Customer.Font = new Font("Segoe UI", 9F);
            Customer.Location = new Point(4, 46);
            Customer.Name = "Customer";
            Customer.Padding = new Padding(3);
            Customer.Size = new Size(793, 396);
            Customer.TabIndex = 0;
            Customer.Text = "Customer";
            Customer.Click += Customer_Click;

            // Text Box
            Label lblFirstName = new Label();
            Label lblLastName = new Label();
            Label lblAddress = new Label();
            Label lblCity = new Label();
            Label lblState = new Label();
            Label lblZip = new Label();
            Label lblEmail = new Label();
            Label lblAccount = new Label();
            Label lblCredit = new Label();

            // Label Text
            lblFirstName.Text = "First Name:";
            lblLastName.Text = "Last Name:";
            lblAddress.Text = "Address:";
            lblCity.Text = "City:";
            lblState.Text = "Province:";
            lblZip.Text = "Zip Code:";
            lblEmail.Text = "Email:";
            lblAccount.Text = "Account #:";
            lblCredit.Text = "Credit Card:";

            // Label Positions
            int topPadding = 20;
            lblFirstName.Location = new Point(20, topPadding + 0);
            lblLastName.Location = new Point(20, topPadding + 30);
            lblAddress.Location = new Point(20, topPadding + 60);
            lblCity.Location = new Point(20, topPadding + 90);
            lblState.Location = new Point(20, topPadding + 120);
            lblZip.Location = new Point(20, topPadding + 150);
            lblEmail.Location = new Point(20, topPadding + 180);
            lblAccount.Location = new Point(20, topPadding + 210);
            lblCredit.Location = new Point(20, topPadding + 240);

            // Add this right after defining label positions
            lblFirstName.AutoSize = true;
            lblLastName.AutoSize = true;
            lblAddress.AutoSize = true;
            lblCity.AutoSize = true;
            lblState.AutoSize = true;
            lblZip.AutoSize = true;
            lblEmail.AutoSize = true;
            lblAccount.AutoSize = true;
            lblCredit.AutoSize = true;

            lblFirstName.ForeColor = Color.White;
            lblLastName.ForeColor = Color.White;
            lblAddress.ForeColor = Color.White;
            lblCity.ForeColor = Color.White;
            lblState.ForeColor = Color.White;
            lblZip.ForeColor = Color.White;
            lblEmail.ForeColor = Color.White;
            lblAccount.ForeColor = Color.White;
            lblCredit.ForeColor = Color.White;

            // Instantiate controls
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAddress = new TextBox();
            txtCity = new TextBox();
            txtState = new TextBox();
            txtZip = new TextBox();
            txtEmail = new TextBox();
            txtAccount = new TextBox();
            txtCredit = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvCustomers = new DataGridView();

            // Customer Controls
            Customer.Controls.Add(lblFirstName);
            Customer.Controls.Add(lblLastName);
            Customer.Controls.Add(lblAddress);
            Customer.Controls.Add(lblCity);
            Customer.Controls.Add(lblState);
            Customer.Controls.Add(lblZip);
            Customer.Controls.Add(lblEmail);
            Customer.Controls.Add(lblAccount);
            Customer.Controls.Add(lblCredit);

            // color for buttons + styling
            btnAdd.BackColor = Color.White;
            btnAdd.ForeColor = Color.Black;

            btnUpdate.BackColor = Color.White;
            btnUpdate.ForeColor = Color.Black;

            btnDelete.BackColor = Color.White;
            btnDelete.ForeColor = Color.Black;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatStyle = FlatStyle.Flat;

            txtFirstName.Location = new Point(120, topPadding + 0);
            txtLastName.Location = new Point(120, topPadding + 30);
            txtAddress.Location = new Point(120, topPadding + 60);
            txtCity.Location = new Point(120, topPadding + 90);
            txtState.Location = new Point(120, topPadding + 120);
            txtZip.Location = new Point(120, topPadding + 150);
            txtEmail.Location = new Point(120, topPadding + 180);
            txtAccount.Location = new Point(120, topPadding + 210);
            txtCredit.Location = new Point(120, topPadding + 240);
            btnAdd.Location = new Point(20, topPadding + 300);
            btnUpdate.Location = new Point(100, topPadding + 300);
            btnDelete.Location = new Point(180, topPadding + 300);
            btnAdd.Text = "Add";
            btnUpdate.Text = "Update";
            btnDelete.Text = "Delete";
            dgvCustomers.Location = new Point(250, 20);
            dgvCustomers.Size = new Size(520, 340);

            // Add controls to Customer tab
            Customer.Controls.Add(txtFirstName);
            Customer.Controls.Add(txtLastName);
            Customer.Controls.Add(txtAddress);
            Customer.Controls.Add(txtCity);
            Customer.Controls.Add(txtState);
            Customer.Controls.Add(txtZip);
            Customer.Controls.Add(txtEmail);
            Customer.Controls.Add(txtAccount);
            Customer.Controls.Add(txtCredit);
            Customer.Controls.Add(btnAdd);
            Customer.Controls.Add(btnUpdate);
            Customer.Controls.Add(btnDelete);
            Customer.Controls.Add(dgvCustomers);
            // 
            // Movie tab
            // 
            Movie.BackColor = Color.Firebrick;
            Movie.Location = new Point(4, 46);
            Movie.Name = "Movie";
            Movie.Padding = new Padding(3);
            Movie.Size = new Size(793, 396);
            Movie.TabIndex = 1;
            Movie.Text = "Movie";
            Movie.Click += Movie_Click;
            // 
            // Rental tab
            // 
            Rental.BackColor = Color.Firebrick;
            Rental.Location = new Point(4, 46);
            Rental.Name = "Rental";
            Rental.Padding = new Padding(3);
            Rental.Size = new Size(793, 396);
            Rental.TabIndex = 2;
            Rental.Text = "Rental";
            
            
            
            // 
            // Report tab
            // 
            Report.BackColor = Color.Firebrick;
            Report.Controls.Add(DateSelect);
            Report.Controls.Add(Enter);
            Report.Controls.Add(cal);
            Report.Controls.Add(PickReportTitle);
            Report.Controls.Add(result);
            Report.Controls.Add(SpecifTitle);
            Report.Controls.Add(Specif);
            Report.Controls.Add(ReportSelection);
            Report.Font = new Font("Segoe UI", 20F);
            Report.ForeColor = SystemColors.ActiveBorder;
            Report.Location = new Point(4, 46);
            Report.Name = "Report";
            Report.Padding = new Padding(3);
            Report.Size = new Size(793, 396);
            Report.TabIndex = 3;
            Report.Text = "Report";
            Report.Click += Report_Click;
            // 
            // DateSelect
            // 
            DateSelect.AutoSize = true;
            DateSelect.BackColor = Color.White;
            DateSelect.Font = new Font("Segoe UI", 15F);
            DateSelect.ForeColor = SystemColors.ActiveCaptionText;
            DateSelect.Location = new Point(45, 142);
            DateSelect.Name = "DateSelect";
            DateSelect.Size = new Size(164, 28);
            DateSelect.TabIndex = 7;
            DateSelect.Text = "No Date Selected";
            DateSelect.Visible = false;
            DateSelect.Click += DateSelect_Click;
            // 
            // Enter
            // 
            Enter.ForeColor = SystemColors.ActiveCaptionText;
            Enter.Location = new Point(45, 250);
            Enter.Name = "Enter";
            Enter.Size = new Size(129, 51);
            Enter.TabIndex = 6;
            Enter.Text = "Enter";
            Enter.UseVisualStyleBackColor = true;
            Enter.Click += Enter_Click;
            // 
            // cal
            // 
            cal.Location = new Point(241, 139);
            cal.Name = "cal";
            cal.TabIndex = 5;
            cal.Visible = false;
            cal.DateChanged += cal_DateChanged;
            cal.DateSelected += cal_DateSelected;
            // 
            // PickReportTitle
            // 
            PickReportTitle.AutoSize = true;
            PickReportTitle.ForeColor = SystemColors.ActiveCaptionText;
            PickReportTitle.Location = new Point(26, 8);
            PickReportTitle.Name = "PickReportTitle";
            PickReportTitle.Size = new Size(203, 37);
            PickReportTitle.TabIndex = 4;
            PickReportTitle.Text = "Select A Report:";
            PickReportTitle.Click += label1_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.ForeColor = SystemColors.ActiveCaptionText;
            result.Location = new Point(588, 135);
            result.Name = "result";
            result.Size = new Size(88, 37);
            result.TabIndex = 3;
            result.Text = "Result";
            result.Visible = false;
            // 
            // SpecifTitle
            // 
            SpecifTitle.AutoSize = true;
            SpecifTitle.Font = new Font("Segoe UI", 15F);
            SpecifTitle.ForeColor = SystemColors.ActiveCaptionText;
            SpecifTitle.Location = new Point(37, 108);
            SpecifTitle.Name = "SpecifTitle";
            SpecifTitle.Size = new Size(65, 28);
            SpecifTitle.TabIndex = 2;
            SpecifTitle.Text = "Specif";
            SpecifTitle.Visible = false;
            // 
            // Specif
            // 
            Specif.Font = new Font("Segoe UI", 15F);
            Specif.Location = new Point(45, 139);
            Specif.Name = "Specif";
            Specif.Size = new Size(184, 34);
            Specif.TabIndex = 1;
            Specif.Visible = false;
            // 
            // ReportSelection
            // 
            ReportSelection.Font = new Font("Segoe UI", 15F);
            ReportSelection.FormattingEnabled = true;
            ReportSelection.Items.AddRange(new object[] { "Which Customer has the most rentals?", "What Movies haven't been rented since a specific date?", "What movies has a specific employee rented?", "What Actors appear in a Movie?", "How many times has a movie with a specific actor been rented?" });
            ReportSelection.Location = new Point(37, 48);
            ReportSelection.Name = "ReportSelection";
            ReportSelection.Size = new Size(692, 36);
            ReportSelection.TabIndex = 0;
            ReportSelection.Text = "Which Customer has the most rentals?";
            ReportSelection.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // NavScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "NavScreen";
            Text = "NavScreen";
            tabControl1.ResumeLayout(false);
            Report.ResumeLayout(false);
            Report.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Customer;
        private TabPage Movie;
        private TabPage Rental;
        private TabPage Report;
        private ComboBox ReportSelection;
        private TextBox Specif;
        private Label result;
        private Label SpecifTitle;
        private Label PickReportTitle;
        private MonthCalendar cal;
        private Button Enter;
        private Label DateSelect;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAddress;
        private TextBox txtCity;
        private TextBox txtState;
        private TextBox txtZip;
        private TextBox txtEmail;
        private TextBox txtAccount;
        private TextBox txtCredit;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvCustomers;
    }
}