
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            Customer = new TabPage();
            Movie = new TabPage();
            Rental = new TabPage();
            Report = new TabPage();
            ErrorMes = new TextBox();
            RepRes = new DataGridView();
            EnterR = new Button();
            SpecifTitle2 = new Label();
            cal2 = new MonthCalendar();
            DateSelect2 = new Label();
            DateSelect1 = new Label();
            cal1 = new MonthCalendar();
            PickReportTitle = new Label();
            SpecifTitle1 = new Label();
            Specif = new TextBox();
            ReportSelection = new ComboBox();
            tabControl1.SuspendLayout();
            Report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RepRes).BeginInit();
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
            tabControl1.Size = new Size(1248, 492);
            tabControl1.TabIndex = 0;
            // 
            // Customer
            // 
            Customer.BackColor = Color.Firebrick;
            Customer.Font = new Font("Segoe UI", 9F);
            Customer.Location = new Point(4, 46);
            Customer.Name = "Customer";
            Customer.Padding = new Padding(3);
            Customer.Size = new Size(1240, 442);
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
            // Movie
            // 
            Movie.BackColor = Color.Firebrick;
            Movie.Location = new Point(4, 46);
            Movie.Name = "Movie";
            Movie.Padding = new Padding(3);
            Movie.Size = new Size(1240, 442);
            Movie.TabIndex = 1;
            Movie.Text = "Movie";
            Movie.Click += Movie_Click;
            // 
            // Rental
            // 
            Rental.BackColor = Color.Firebrick;
            Rental.Location = new Point(4, 46);
            Rental.Name = "Rental";
            Rental.Padding = new Padding(3);
            Rental.Size = new Size(1240, 442);
            Rental.TabIndex = 2;
            Rental.Text = "Rental";
            // 
            // Report
            // 
            Report.BackColor = Color.Firebrick;
            Report.Controls.Add(ErrorMes);
            Report.Controls.Add(RepRes);
            Report.Controls.Add(EnterR);
            Report.Controls.Add(SpecifTitle2);
            Report.Controls.Add(cal2);
            Report.Controls.Add(DateSelect2);
            Report.Controls.Add(DateSelect1);
            Report.Controls.Add(cal1);
            Report.Controls.Add(PickReportTitle);
            Report.Controls.Add(SpecifTitle1);
            Report.Controls.Add(Specif);
            Report.Controls.Add(ReportSelection);
            Report.Font = new Font("Segoe UI", 20F);
            Report.ForeColor = SystemColors.ActiveBorder;
            Report.Location = new Point(4, 46);
            Report.Margin = new Padding(0);
            Report.Name = "Report";
            Report.Padding = new Padding(3);
            Report.Size = new Size(1240, 442);
            Report.TabIndex = 3;
            Report.Text = "Report";
            Report.Click += Report_Click;
            // 
            // ErrorMes
            // 
            ErrorMes.BackColor = Color.Firebrick;
            ErrorMes.BorderStyle = BorderStyle.None;
            ErrorMes.Font = new Font("Segoe UI", 20F);
            ErrorMes.ForeColor = Color.Yellow;
            ErrorMes.Location = new Point(24, 385);
            ErrorMes.Name = "ErrorMes";
            ErrorMes.Size = new Size(455, 36);
            ErrorMes.TabIndex = 14;
            ErrorMes.TextAlign = HorizontalAlignment.Center;
            ErrorMes.TextChanged += ErrorMes_TextChanged;
            // 
            // RepRes
            // 
            RepRes.AllowUserToAddRows = false;
            RepRes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            RepRes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            RepRes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            RepRes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            RepRes.BackgroundColor = SystemColors.ButtonHighlight;
            RepRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RepRes.Location = new Point(546, 93);
            RepRes.Name = "RepRes";
            RepRes.ReadOnly = true;
            RepRes.RowHeadersWidth = 10;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            RepRes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            RepRes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RepRes.ShowCellToolTips = false;
            RepRes.Size = new Size(678, 282);
            RepRes.TabIndex = 13;
            RepRes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // EnterR
            // 
            EnterR.BackColor = Color.FromArgb(255, 224, 192);
            EnterR.FlatStyle = FlatStyle.Popup;
            EnterR.Font = new Font("Segoe UI", 20F);
            EnterR.ForeColor = Color.Black;
            EnterR.Location = new Point(546, 385);
            EnterR.Name = "EnterR";
            EnterR.Size = new Size(168, 45);
            EnterR.TabIndex = 12;
            EnterR.Text = "Enter";
            EnterR.UseVisualStyleBackColor = false;
            EnterR.Click += EnterR_Click;
            // 
            // SpecifTitle2
            // 
            SpecifTitle2.AutoSize = true;
            SpecifTitle2.Font = new Font("Segoe UI", 15F);
            SpecifTitle2.ForeColor = SystemColors.ActiveCaptionText;
            SpecifTitle2.Location = new Point(280, 116);
            SpecifTitle2.Name = "SpecifTitle2";
            SpecifTitle2.Size = new Size(76, 28);
            SpecifTitle2.TabIndex = 10;
            SpecifTitle2.Text = "Specif2";
            SpecifTitle2.Visible = false;
            // 
            // cal2
            // 
            cal2.Location = new Point(280, 164);
            cal2.Name = "cal2";
            cal2.TabIndex = 9;
            cal2.Visible = false;
            cal2.DateSelected += cal2_DateSelected;
            // 
            // DateSelect2
            // 
            DateSelect2.AutoSize = true;
            DateSelect2.BackColor = Color.Firebrick;
            DateSelect2.Font = new Font("Segoe UI", 15F);
            DateSelect2.ForeColor = SystemColors.ActiveCaptionText;
            DateSelect2.Location = new Point(280, 335);
            DateSelect2.Name = "DateSelect2";
            DateSelect2.Size = new Size(180, 28);
            DateSelect2.TabIndex = 8;
            DateSelect2.Text = "No Date Selected 2";
            DateSelect2.Visible = false;
            // 
            // DateSelect1
            // 
            DateSelect1.AutoSize = true;
            DateSelect1.BackColor = Color.Firebrick;
            DateSelect1.Font = new Font("Segoe UI", 15F);
            DateSelect1.ForeColor = SystemColors.ActiveCaptionText;
            DateSelect1.Location = new Point(14, 335);
            DateSelect1.Name = "DateSelect1";
            DateSelect1.Size = new Size(180, 28);
            DateSelect1.TabIndex = 7;
            DateSelect1.Text = "No Date Selected 1";
            DateSelect1.Visible = false;
            DateSelect1.Click += DateSelect_Click;
            // 
            // cal1
            // 
            cal1.Location = new Point(14, 164);
            cal1.Name = "cal1";
            cal1.TabIndex = 5;
            cal1.Visible = false;
            cal1.DateChanged += cal_DateChanged;
            cal1.DateSelected += cal_DateSelected;
            // 
            // PickReportTitle
            // 
            PickReportTitle.AutoSize = true;
            PickReportTitle.Font = new Font("Segoe UI", 15F);
            PickReportTitle.ForeColor = SystemColors.ActiveCaptionText;
            PickReportTitle.Location = new Point(24, 38);
            PickReportTitle.Name = "PickReportTitle";
            PickReportTitle.Size = new Size(150, 28);
            PickReportTitle.TabIndex = 4;
            PickReportTitle.Text = "Select A Report:";
            PickReportTitle.Click += label1_Click;
            // 
            // SpecifTitle1
            // 
            SpecifTitle1.AutoSize = true;
            SpecifTitle1.Font = new Font("Segoe UI", 15F);
            SpecifTitle1.ForeColor = SystemColors.ActiveCaptionText;
            SpecifTitle1.Location = new Point(6, 116);
            SpecifTitle1.Name = "SpecifTitle1";
            SpecifTitle1.Size = new Size(76, 28);
            SpecifTitle1.TabIndex = 2;
            SpecifTitle1.Text = "Specif1";
            SpecifTitle1.Visible = false;
            // 
            // Specif
            // 
            Specif.Font = new Font("Segoe UI", 15F);
            Specif.Location = new Point(14, 164);
            Specif.Name = "Specif";
            Specif.Size = new Size(184, 34);
            Specif.TabIndex = 1;
            Specif.Visible = false;
            // 
            // ReportSelection
            // 
            ReportSelection.Font = new Font("Segoe UI", 15F);
            ReportSelection.FormattingEnabled = true;
            ReportSelection.Items.AddRange(new object[] { "Who are the top 3 customers with the most rentals?", "What are the top 3 movies that have been rented between two specific days?", "What are the 3 top movies a specific employee rented?", "What are the top 3 rented genre between two specific days?", "What are the top 3 rented movies with a specfic actor?" });
            ReportSelection.Location = new Point(220, 30);
            ReportSelection.Name = "ReportSelection";
            ReportSelection.Size = new Size(711, 36);
            ReportSelection.TabIndex = 0;
            ReportSelection.Text = "Who are the top 3 customers with the most rentals?";
            ReportSelection.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // NavScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 522);
            Controls.Add(tabControl1);
            Name = "NavScreen";
            Text = "NavScreen";
            Load += NavScreen_Load;
            tabControl1.ResumeLayout(false);
            Report.ResumeLayout(false);
            Report.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RepRes).EndInit();
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
        private Label SpecifTitle1;
        private Label PickReportTitle;
        private MonthCalendar cal1;
        private Label DateSelect1;
        private Label SpecifTitle2;
        private MonthCalendar cal2;
        private Label DateSelect2;
        private Button EnterR;
        private DataGridView RepRes;
        private TextBox ErrorMes;
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