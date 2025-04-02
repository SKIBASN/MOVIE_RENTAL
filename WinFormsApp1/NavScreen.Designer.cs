
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            Customer = new TabPage();
            Movie = new TabPage();
            Rental = new TabPage();
            rentalUpdateButton = new Button();
            label2 = new Label();
            dgvRentalMovies = new DataGridView();
            movieIdColumn = new DataGridViewTextBoxColumn();
            movieNameColumn = new DataGridViewTextBoxColumn();
            movieTypeColumn = new DataGridViewTextBoxColumn();
            feeColumn = new DataGridViewTextBoxColumn();
            numCopiesColumn = new DataGridViewTextBoxColumn();
            dispenseButton = new Button();
            label1 = new Label();
            dgvRentalCustomers = new DataGridView();
            custIdColumn = new DataGridViewTextBoxColumn();
            ssnColumn = new DataGridViewTextBoxColumn();
            LastNameColumn = new DataGridViewTextBoxColumn();
            firstNameColumn = new DataGridViewTextBoxColumn();
            addressColumn = new DataGridViewTextBoxColumn();
            cityColumn = new DataGridViewTextBoxColumn();
            stateColumn = new DataGridViewTextBoxColumn();
            zipColumn = new DataGridViewTextBoxColumn();
            emailColumn = new DataGridViewTextBoxColumn();
            accountNumColumn = new DataGridViewTextBoxColumn();
            accCreatedColumn = new DataGridViewTextBoxColumn();
            creditNumColumn = new DataGridViewTextBoxColumn();
            ReportPage = new TabPage();
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
            customerID = new DataGridViewTextBoxColumn();
            customerFirstName = new DataGridViewTextBoxColumn();
            customerLastName = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            Rental.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRentalMovies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRentalCustomers).BeginInit();
            ReportPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RepRes).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Customer);
            tabControl1.Controls.Add(Movie);
            tabControl1.Controls.Add(Rental);
            tabControl1.Controls.Add(ReportPage);
            tabControl1.Font = new Font("Segoe UI", 20F);
            tabControl1.ItemSize = new Size(151, 50);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1426, 656);
            tabControl1.TabIndex = 0;
            // 
            // Customer
            // 
            Customer.BackColor = Color.Firebrick;
            Customer.Font = new Font("Segoe UI", 9F);
            Customer.Location = new Point(4, 54);
            Customer.Margin = new Padding(3, 4, 3, 4);
            Customer.Name = "Customer";
            Customer.Padding = new Padding(3, 4, 3, 4);
            Customer.Size = new Size(1418, 598);
            Customer.TabIndex = 0;
            Customer.Text = "Customer";
            Customer.Click += Customer_Click;
            // 
            // Movie
            // 
            Movie.BackColor = Color.Firebrick;
            Movie.Location = new Point(4, 54);
            Movie.Margin = new Padding(3, 4, 3, 4);
            Movie.Name = "Movie";
            Movie.Padding = new Padding(3, 4, 3, 4);
            Movie.Size = new Size(1418, 598);
            Movie.TabIndex = 1;
            Movie.Text = "Movie";
            Movie.Click += Movie_Click;
            // 
            // Rental
            // 
            Rental.BackColor = Color.Firebrick;
            Rental.Controls.Add(rentalUpdateButton);
            Rental.Controls.Add(label2);
            Rental.Controls.Add(dgvRentalMovies);
            Rental.Controls.Add(dispenseButton);
            Rental.Controls.Add(label1);
            Rental.Controls.Add(dgvRentalCustomers);
            Rental.ForeColor = SystemColors.ControlLightLight;
            Rental.Location = new Point(4, 54);
            Rental.Margin = new Padding(3, 4, 3, 4);
            Rental.Name = "Rental";
            Rental.Padding = new Padding(3, 4, 3, 4);
            Rental.RightToLeft = RightToLeft.No;
            Rental.Size = new Size(1418, 598);
            Rental.TabIndex = 2;
            Rental.Text = "Rental";
            // 
            // rentalUpdateButton
            // 
            rentalUpdateButton.BackColor = Color.White;
            rentalUpdateButton.ForeColor = SystemColors.ControlText;
            rentalUpdateButton.Location = new Point(594, 510);
            rentalUpdateButton.Name = "rentalUpdateButton";
            rentalUpdateButton.Size = new Size(204, 54);
            rentalUpdateButton.TabIndex = 6;
            rentalUpdateButton.Text = "Update";
            rentalUpdateButton.UseVisualStyleBackColor = false;
            rentalUpdateButton.Click += rentalUpdateButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(38, 30);
            label2.Name = "label2";
            label2.Size = new Size(299, 46);
            label2.TabIndex = 5;
            label2.Text = "Select a customer";
            label2.Click += label2_Click;
            // 
            // dgvRentalMovies
            // 
            dgvRentalMovies.AllowUserToAddRows = false;
            dgvRentalMovies.AllowUserToDeleteRows = false;
            dgvRentalMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRentalMovies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRentalMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalMovies.Columns.AddRange(new DataGridViewColumn[] { movieIdColumn, movieNameColumn, movieTypeColumn, feeColumn, numCopiesColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRentalMovies.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRentalMovies.Location = new Point(442, 276);
            dgvRentalMovies.MultiSelect = false;
            dgvRentalMovies.Name = "dgvRentalMovies";
            dgvRentalMovies.ReadOnly = true;
            dgvRentalMovies.RowHeadersWidth = 51;
            dgvRentalMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRentalMovies.Size = new Size(949, 215);
            dgvRentalMovies.TabIndex = 4;
            dgvRentalMovies.CellContentClick += dgvRentalMovies_CellContentClick;
            // 
            // movieIdColumn
            // 
            movieIdColumn.HeaderText = "Movie ID";
            movieIdColumn.MinimumWidth = 6;
            movieIdColumn.Name = "movieIdColumn";
            movieIdColumn.ReadOnly = true;
            // 
            // movieNameColumn
            // 
            movieNameColumn.HeaderText = "Name";
            movieNameColumn.MinimumWidth = 6;
            movieNameColumn.Name = "movieNameColumn";
            movieNameColumn.ReadOnly = true;
            // 
            // movieTypeColumn
            // 
            movieTypeColumn.HeaderText = "Type";
            movieTypeColumn.MinimumWidth = 6;
            movieTypeColumn.Name = "movieTypeColumn";
            movieTypeColumn.ReadOnly = true;
            // 
            // feeColumn
            // 
            feeColumn.HeaderText = "Distribution Fee";
            feeColumn.MinimumWidth = 6;
            feeColumn.Name = "feeColumn";
            feeColumn.ReadOnly = true;
            // 
            // numCopiesColumn
            // 
            numCopiesColumn.HeaderText = "Number of Copies";
            numCopiesColumn.MinimumWidth = 6;
            numCopiesColumn.Name = "numCopiesColumn";
            numCopiesColumn.ReadOnly = true;
            // 
            // dispenseButton
            // 
            dispenseButton.BackColor = SystemColors.Control;
            dispenseButton.ForeColor = SystemColors.ControlText;
            dispenseButton.Location = new Point(1029, 510);
            dispenseButton.Name = "dispenseButton";
            dispenseButton.Size = new Size(204, 54);
            dispenseButton.TabIndex = 3;
            dispenseButton.Text = "Dispense";
            dispenseButton.UseVisualStyleBackColor = true;
            dispenseButton.Click += dispenseButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 276);
            label1.Name = "label1";
            label1.Size = new Size(248, 46);
            label1.TabIndex = 2;
            label1.Text = "Select a movie";
            label1.Click += label1_Click_1;
            // 
            // dgvRentalCustomers
            // 
            dgvRentalCustomers.AllowUserToAddRows = false;
            dgvRentalCustomers.AllowUserToDeleteRows = false;
            dgvRentalCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRentalCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRentalCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalCustomers.Columns.AddRange(new DataGridViewColumn[] { custIdColumn, ssnColumn, LastNameColumn, firstNameColumn, addressColumn, cityColumn, stateColumn, zipColumn, emailColumn, accountNumColumn, accCreatedColumn, creditNumColumn });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvRentalCustomers.DefaultCellStyle = dataGridViewCellStyle4;
            dgvRentalCustomers.Location = new Point(442, 30);
            dgvRentalCustomers.MultiSelect = false;
            dgvRentalCustomers.Name = "dgvRentalCustomers";
            dgvRentalCustomers.ReadOnly = true;
            dgvRentalCustomers.RowHeadersWidth = 51;
            dgvRentalCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRentalCustomers.Size = new Size(949, 214);
            dgvRentalCustomers.TabIndex = 0;
            dgvRentalCustomers.CellContentClick += dgvRentalCustomers_CellContentClick;
            // 
            // custIdColumn
            // 
            custIdColumn.HeaderText = "Customer ID";
            custIdColumn.MinimumWidth = 6;
            custIdColumn.Name = "custIdColumn";
            custIdColumn.ReadOnly = true;
            custIdColumn.Width = 161;
            // 
            // ssnColumn
            // 
            ssnColumn.HeaderText = "SSN";
            ssnColumn.MinimumWidth = 6;
            ssnColumn.Name = "ssnColumn";
            ssnColumn.ReadOnly = true;
            ssnColumn.Width = 87;
            // 
            // LastNameColumn
            // 
            LastNameColumn.HeaderText = "Last Name";
            LastNameColumn.MinimumWidth = 6;
            LastNameColumn.Name = "LastNameColumn";
            LastNameColumn.ReadOnly = true;
            LastNameColumn.Width = 142;
            // 
            // firstNameColumn
            // 
            firstNameColumn.HeaderText = "First Name";
            firstNameColumn.MinimumWidth = 6;
            firstNameColumn.Name = "firstNameColumn";
            firstNameColumn.ReadOnly = true;
            firstNameColumn.Width = 145;
            // 
            // addressColumn
            // 
            addressColumn.HeaderText = "Address";
            addressColumn.MinimumWidth = 6;
            addressColumn.Name = "addressColumn";
            addressColumn.ReadOnly = true;
            addressColumn.Width = 127;
            // 
            // cityColumn
            // 
            cityColumn.HeaderText = "City";
            cityColumn.MinimumWidth = 6;
            cityColumn.Name = "cityColumn";
            cityColumn.ReadOnly = true;
            cityColumn.Width = 84;
            // 
            // stateColumn
            // 
            stateColumn.HeaderText = "State";
            stateColumn.MinimumWidth = 6;
            stateColumn.Name = "stateColumn";
            stateColumn.ReadOnly = true;
            stateColumn.Width = 96;
            // 
            // zipColumn
            // 
            zipColumn.HeaderText = "Zip Code";
            zipColumn.MinimumWidth = 6;
            zipColumn.Name = "zipColumn";
            zipColumn.ReadOnly = true;
            zipColumn.Width = 128;
            // 
            // emailColumn
            // 
            emailColumn.HeaderText = "Email";
            emailColumn.MinimumWidth = 6;
            emailColumn.Name = "emailColumn";
            emailColumn.ReadOnly = true;
            // 
            // accountNumColumn
            // 
            accountNumColumn.HeaderText = "Account Number";
            accountNumColumn.MinimumWidth = 6;
            accountNumColumn.Name = "accountNumColumn";
            accountNumColumn.ReadOnly = true;
            accountNumColumn.Width = 205;
            // 
            // accCreatedColumn
            // 
            accCreatedColumn.HeaderText = "Date Joined";
            accCreatedColumn.MinimumWidth = 6;
            accCreatedColumn.Name = "accCreatedColumn";
            accCreatedColumn.ReadOnly = true;
            accCreatedColumn.Width = 155;
            // 
            // creditNumColumn
            // 
            creditNumColumn.HeaderText = "Credit Card Number";
            creditNumColumn.MinimumWidth = 6;
            creditNumColumn.Name = "creditNumColumn";
            creditNumColumn.ReadOnly = true;
            creditNumColumn.Width = 235;
            // 
            // ReportPage
            // 
            ReportPage.BackColor = Color.Firebrick;
            ReportPage.Controls.Add(ErrorMes);
            ReportPage.Controls.Add(RepRes);
            ReportPage.Controls.Add(EnterR);
            ReportPage.Controls.Add(SpecifTitle2);
            ReportPage.Controls.Add(cal2);
            ReportPage.Controls.Add(DateSelect2);
            ReportPage.Controls.Add(DateSelect1);
            ReportPage.Controls.Add(cal1);
            ReportPage.Controls.Add(PickReportTitle);
            ReportPage.Controls.Add(SpecifTitle1);
            ReportPage.Controls.Add(Specif);
            ReportPage.Controls.Add(ReportSelection);
            ReportPage.Font = new Font("Segoe UI", 20F);
            ReportPage.ForeColor = SystemColors.ActiveBorder;
            ReportPage.Location = new Point(4, 54);
            ReportPage.Margin = new Padding(0);
            ReportPage.Name = "ReportPage";
            ReportPage.Padding = new Padding(3, 4, 3, 4);
            ReportPage.Size = new Size(1418, 598);
            ReportPage.TabIndex = 3;
            ReportPage.Text = "Report";
            ReportPage.Click += Report_Click;
            // 
            // ErrorMes
            // 
            ErrorMes.BackColor = Color.Firebrick;
            ErrorMes.BorderStyle = BorderStyle.None;
            ErrorMes.Font = new Font("Segoe UI", 20F);
            ErrorMes.ForeColor = Color.Yellow;
            ErrorMes.Location = new Point(27, 513);
            ErrorMes.Margin = new Padding(3, 4, 3, 4);
            ErrorMes.Name = "ErrorMes";
            ErrorMes.Size = new Size(520, 45);
            ErrorMes.TabIndex = 14;
            ErrorMes.TextAlign = HorizontalAlignment.Center;
            ErrorMes.TextChanged += ErrorMes_TextChanged;
            // 
            // RepRes
            // 
            RepRes.AllowUserToAddRows = false;
            RepRes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            RepRes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            RepRes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            RepRes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            RepRes.BackgroundColor = SystemColors.ButtonHighlight;
            RepRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RepRes.Location = new Point(624, 124);
            RepRes.Margin = new Padding(3, 4, 3, 4);
            RepRes.Name = "RepRes";
            RepRes.ReadOnly = true;
            RepRes.RowHeadersWidth = 10;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            RepRes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            RepRes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RepRes.ShowCellToolTips = false;
            RepRes.Size = new Size(775, 376);
            RepRes.TabIndex = 13;
            RepRes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // EnterR
            // 
            EnterR.BackColor = Color.FromArgb(255, 224, 192);
            EnterR.FlatStyle = FlatStyle.Popup;
            EnterR.Font = new Font("Segoe UI", 20F);
            EnterR.ForeColor = Color.Black;
            EnterR.Location = new Point(624, 513);
            EnterR.Margin = new Padding(3, 4, 3, 4);
            EnterR.Name = "EnterR";
            EnterR.Size = new Size(192, 60);
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
            SpecifTitle2.Location = new Point(320, 155);
            SpecifTitle2.Name = "SpecifTitle2";
            SpecifTitle2.Size = new Size(95, 35);
            SpecifTitle2.TabIndex = 10;
            SpecifTitle2.Text = "Specif2";
            SpecifTitle2.Visible = false;
            // 
            // cal2
            // 
            cal2.Location = new Point(320, 219);
            cal2.Margin = new Padding(10, 12, 10, 12);
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
            DateSelect2.Location = new Point(320, 447);
            DateSelect2.Name = "DateSelect2";
            DateSelect2.Size = new Size(228, 35);
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
            DateSelect1.Location = new Point(16, 447);
            DateSelect1.Name = "DateSelect1";
            DateSelect1.Size = new Size(228, 35);
            DateSelect1.TabIndex = 7;
            DateSelect1.Text = "No Date Selected 1";
            DateSelect1.Visible = false;
            DateSelect1.Click += DateSelect_Click;
            // 
            // cal1
            // 
            cal1.Location = new Point(16, 219);
            cal1.Margin = new Padding(10, 12, 10, 12);
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
            PickReportTitle.Location = new Point(27, 51);
            PickReportTitle.Name = "PickReportTitle";
            PickReportTitle.Size = new Size(186, 35);
            PickReportTitle.TabIndex = 4;
            PickReportTitle.Text = "Select a Report:";
            PickReportTitle.Click += label1_Click;
            // 
            // SpecifTitle1
            // 
            SpecifTitle1.AutoSize = true;
            SpecifTitle1.Font = new Font("Segoe UI", 15F);
            SpecifTitle1.ForeColor = SystemColors.ActiveCaptionText;
            SpecifTitle1.Location = new Point(7, 155);
            SpecifTitle1.Name = "SpecifTitle1";
            SpecifTitle1.Size = new Size(95, 35);
            SpecifTitle1.TabIndex = 2;
            SpecifTitle1.Text = "Specif1";
            SpecifTitle1.Visible = false;
            // 
            // Specif
            // 
            Specif.Font = new Font("Segoe UI", 15F);
            Specif.Location = new Point(16, 219);
            Specif.Margin = new Padding(3, 4, 3, 4);
            Specif.Name = "Specif";
            Specif.Size = new Size(210, 41);
            Specif.TabIndex = 1;
            Specif.Visible = false;
            // 
            // ReportSelection
            // 
            ReportSelection.Font = new Font("Segoe UI", 15F);
            ReportSelection.FormattingEnabled = true;
            ReportSelection.Items.AddRange(new object[] { "Who are the top 3 customers with the most rentals?", "What are the top 3 movies that have been rented between two specific days?", "What are the 3 top movies a specific employee rented?", "What are the top 3 rented genre between two specific days?", "What are the top 3 rented movies with a specfic actor?" });
            ReportSelection.Location = new Point(251, 40);
            ReportSelection.Margin = new Padding(3, 4, 3, 4);
            ReportSelection.Name = "ReportSelection";
            ReportSelection.Size = new Size(812, 43);
            ReportSelection.TabIndex = 0;
            ReportSelection.Text = "Who are the top 3 customers with the most rentals?";
            ReportSelection.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // customerID
            // 
            customerID.MinimumWidth = 6;
            customerID.Name = "customerID";
            customerID.Width = 125;
            // 
            // customerFirstName
            // 
            customerFirstName.MinimumWidth = 6;
            customerFirstName.Name = "customerFirstName";
            customerFirstName.Width = 125;
            // 
            // customerLastName
            // 
            customerLastName.MinimumWidth = 6;
            customerLastName.Name = "customerLastName";
            customerLastName.Width = 125;
            // 
            // NavScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 696);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NavScreen";
            Text = "NavScreen";
            Load += NavScreen_Load;
            tabControl1.ResumeLayout(false);
            Rental.ResumeLayout(false);
            Rental.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRentalMovies).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRentalCustomers).EndInit();
            ReportPage.ResumeLayout(false);
            ReportPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RepRes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        // Controls
        private TabControl tabControl1;
        private TabPage Customer;
        private TabPage Movie;
        private TabPage Rental;
        private TabPage ReportPage;

        /* Controls for Rental page */
        private DataGridView dgvRentalCustomers;
        private DataGridViewTextBoxColumn customerID;
        private DataGridViewTextBoxColumn customerFirstName;
        private DataGridViewTextBoxColumn customerLastName;

        // Controls for Report page 
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
        private Label label1;
        private Button dispenseButton;
        private Label label2;
        private DataGridView dgvRentalMovies;
        private DataGridViewTextBoxColumn custIdColumn;
        private DataGridViewTextBoxColumn ssnColumn;
        private DataGridViewTextBoxColumn LastNameColumn;
        private DataGridViewTextBoxColumn firstNameColumn;
        private DataGridViewTextBoxColumn addressColumn;
        private DataGridViewTextBoxColumn cityColumn;
        private DataGridViewTextBoxColumn stateColumn;
        private DataGridViewTextBoxColumn zipColumn;
        private DataGridViewTextBoxColumn emailColumn;
        private DataGridViewTextBoxColumn accountNumColumn;
        private DataGridViewTextBoxColumn accCreatedColumn;
        private DataGridViewTextBoxColumn creditNumColumn;
        private DataGridViewTextBoxColumn movieIdColumn;
        private DataGridViewTextBoxColumn movieNameColumn;
        private DataGridViewTextBoxColumn movieTypeColumn;
        private DataGridViewTextBoxColumn feeColumn;
        private DataGridViewTextBoxColumn numCopiesColumn;
        private Button rentalUpdateButton;
    }
}