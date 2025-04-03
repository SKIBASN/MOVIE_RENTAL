
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
            components = new System.ComponentModel.Container();
            Button BtnMovieUpdate;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            Customer = new TabPage();
            Movie = new TabPage();
            dgvActors = new DataGridView();
            button1 = new Button();
            txtBoxActorIDAI = new TextBox();
            txtBoxMovieIDActor = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label1 = new Label();
            txtBoxMovieID = new TextBox();
            label6 = new Label();
            BtnMovieDelete = new Button();
            BtnMovieAdd = new Button();
            txtBoxCopies = new TextBox();
            label5 = new Label();
            txtBoxDFee = new TextBox();
            label4 = new Label();
            txtBoxType = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtBoxName = new TextBox();
            dgvMovies = new DataGridView();
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
            databaseBindingSource = new BindingSource(components);
            BtnMovieUpdate = new Button();
            tabControl1.SuspendLayout();
            Movie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            Report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RepRes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // BtnMovieUpdate
            // 
            BtnMovieUpdate.Font = new Font("Segoe UI", 16F);
            BtnMovieUpdate.Location = new Point(579, 370);
            BtnMovieUpdate.Name = "BtnMovieUpdate";
            BtnMovieUpdate.Size = new Size(121, 60);
            BtnMovieUpdate.TabIndex = 11;
            BtnMovieUpdate.Text = "Update";
            BtnMovieUpdate.UseVisualStyleBackColor = true;
            BtnMovieUpdate.Click += BtnMovieUpdate_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Customer);
            tabControl1.Controls.Add(Movie);
            tabControl1.Controls.Add(Rental);
            tabControl1.Controls.Add(Report);
            tabControl1.Font = new Font("Segoe UI", 20F);
            tabControl1.Location = new Point(10, 0);
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
            Movie.Controls.Add(dgvActors);
            Movie.Controls.Add(button1);
            Movie.Controls.Add(txtBoxActorIDAI);
            Movie.Controls.Add(txtBoxMovieIDActor);
            Movie.Controls.Add(label8);
            Movie.Controls.Add(label7);
            Movie.Controls.Add(label1);
            Movie.Controls.Add(txtBoxMovieID);
            Movie.Controls.Add(label6);
            Movie.Controls.Add(BtnMovieDelete);
            Movie.Controls.Add(BtnMovieUpdate);
            Movie.Controls.Add(BtnMovieAdd);
            Movie.Controls.Add(txtBoxCopies);
            Movie.Controls.Add(label5);
            Movie.Controls.Add(txtBoxDFee);
            Movie.Controls.Add(label4);
            Movie.Controls.Add(txtBoxType);
            Movie.Controls.Add(label3);
            Movie.Controls.Add(label2);
            Movie.Controls.Add(txtBoxName);
            Movie.Controls.Add(dgvMovies);
            Movie.Location = new Point(4, 54);
            Movie.Margin = new Padding(3, 4, 3, 4);
            Movie.Name = "Movie";
            Movie.Padding = new Padding(3, 4, 3, 4);
            Movie.Size = new Size(1418, 598);
            Movie.TabIndex = 1;
            Movie.Text = "Movie";
            Movie.Click += Movie_Click;
            // 
            // dgvActors
            // 
            dgvActors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 20F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvActors.DefaultCellStyle = dataGridViewCellStyle1;
            dgvActors.Location = new Point(855, 294);
            dgvActors.Name = "dgvActors";
            dgvActors.RowHeadersWidth = 51;
            dgvActors.Size = new Size(543, 251);
            dgvActors.TabIndex = 21;
            dgvActors.CellContentClick += dgvActors_CellContentClick;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(130, 211);
            button1.Name = "button1";
            button1.Size = new Size(136, 63);
            button1.TabIndex = 20;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // txtBoxActorIDAI
            // 
            txtBoxActorIDAI.Location = new Point(216, 129);
            txtBoxActorIDAI.Name = "txtBoxActorIDAI";
            txtBoxActorIDAI.Size = new Size(204, 52);
            txtBoxActorIDAI.TabIndex = 19;
            // 
            // txtBoxMovieIDActor
            // 
            txtBoxMovieIDActor.Location = new Point(216, 70);
            txtBoxMovieIDActor.Name = "txtBoxMovieIDActor";
            txtBoxMovieIDActor.Size = new Size(204, 52);
            txtBoxMovieIDActor.TabIndex = 18;
            txtBoxMovieIDActor.TextChanged += textBox1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 129);
            label8.Name = "label8";
            label8.Size = new Size(200, 46);
            label8.TabIndex = 17;
            label8.Text = "Actor Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 70);
            label7.Name = "label7";
            label7.Size = new Size(146, 46);
            label7.TabIndex = 16;
            label7.Text = "MovieID";
            label7.Click += label7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 12);
            label1.Name = "label1";
            label1.Size = new Size(223, 46);
            label1.TabIndex = 15;
            label1.Text = "Add An Actor";
            // 
            // txtBoxMovieID
            // 
            txtBoxMovieID.Location = new Point(622, 24);
            txtBoxMovieID.Name = "txtBoxMovieID";
            txtBoxMovieID.Size = new Size(204, 52);
            txtBoxMovieID.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(454, 30);
            label6.Name = "label6";
            label6.Size = new Size(146, 46);
            label6.TabIndex = 13;
            label6.Text = "MovieID";
            // 
            // BtnMovieDelete
            // 
            BtnMovieDelete.Font = new Font("Segoe UI", 16F);
            BtnMovieDelete.Location = new Point(726, 370);
            BtnMovieDelete.Name = "BtnMovieDelete";
            BtnMovieDelete.Size = new Size(113, 60);
            BtnMovieDelete.TabIndex = 12;
            BtnMovieDelete.Text = "Delete";
            BtnMovieDelete.UseVisualStyleBackColor = true;
            BtnMovieDelete.Click += BtnMovieDelete_Click;
            // 
            // BtnMovieAdd
            // 
            BtnMovieAdd.Font = new Font("Segoe UI", 16F);
            BtnMovieAdd.Location = new Point(436, 370);
            BtnMovieAdd.Name = "BtnMovieAdd";
            BtnMovieAdd.Size = new Size(113, 60);
            BtnMovieAdd.TabIndex = 10;
            BtnMovieAdd.Text = "Add";
            BtnMovieAdd.UseVisualStyleBackColor = true;
            BtnMovieAdd.Click += BtnMovieAdd_Click_1;
            // 
            // txtBoxCopies
            // 
            txtBoxCopies.Location = new Point(622, 294);
            txtBoxCopies.Name = "txtBoxCopies";
            txtBoxCopies.Size = new Size(204, 52);
            txtBoxCopies.TabIndex = 9;
            txtBoxCopies.TextChanged += txtBoxCopies_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(454, 294);
            label5.Name = "label5";
            label5.Size = new Size(150, 46);
            label5.TabIndex = 8;
            label5.Text = "# Copies";
            label5.Click += label5_Click;
            // 
            // txtBoxDFee
            // 
            txtBoxDFee.Location = new Point(622, 228);
            txtBoxDFee.Name = "txtBoxDFee";
            txtBoxDFee.Size = new Size(204, 52);
            txtBoxDFee.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 228);
            label4.Name = "label4";
            label4.Size = new Size(113, 46);
            label4.TabIndex = 6;
            label4.Text = "D. Fee";
            // 
            // txtBoxType
            // 
            txtBoxType.Location = new Point(622, 157);
            txtBoxType.Name = "txtBoxType";
            txtBoxType.Size = new Size(204, 52);
            txtBoxType.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(454, 157);
            label3.Name = "label3";
            label3.Size = new Size(90, 46);
            label3.TabIndex = 4;
            label3.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(454, 91);
            label2.Name = "label2";
            label2.Size = new Size(109, 46);
            label2.TabIndex = 3;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(622, 88);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(204, 52);
            txtBoxName.TabIndex = 2;
            // 
            // dgvMovies
            // 
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 20F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMovies.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMovies.Location = new Point(855, 12);
            dgvMovies.Name = "dgvMovies";
            dgvMovies.RowHeadersWidth = 51;
            dgvMovies.Size = new Size(543, 251);
            dgvMovies.TabIndex = 1;
            dgvMovies.CellContentClick += dataGridView1_CellContentClick_3;
            // 
            // Rental
            // 
            Rental.BackColor = Color.Firebrick;
            Rental.Location = new Point(4, 54);
            Rental.Margin = new Padding(3, 4, 3, 4);
            Rental.Name = "Rental";
            Rental.Padding = new Padding(3, 4, 3, 4);
            Rental.Size = new Size(1418, 598);
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
            Report.Location = new Point(4, 54);
            Report.Margin = new Padding(0);
            Report.Name = "Report";
            Report.Padding = new Padding(3, 4, 3, 4);
            Report.Size = new Size(1418, 598);
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
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            RepRes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            RepRes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            RepRes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            RepRes.BackgroundColor = SystemColors.ButtonHighlight;
            RepRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RepRes.Location = new Point(624, 124);
            RepRes.Margin = new Padding(3, 4, 3, 4);
            RepRes.Name = "RepRes";
            RepRes.ReadOnly = true;
            RepRes.RowHeadersWidth = 10;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            RepRes.RowsDefaultCellStyle = dataGridViewCellStyle4;
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
            PickReportTitle.Size = new Size(189, 35);
            PickReportTitle.TabIndex = 4;
            PickReportTitle.Text = "Select A Report:";
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
            // databaseBindingSource
            // 
            databaseBindingSource.DataSource = typeof(Database);
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
            Movie.ResumeLayout(false);
            Movie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActors).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            Report.ResumeLayout(false);
            Report.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RepRes).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).EndInit();
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
        private BindingSource databaseBindingSource;
        private DataGridView dgvMovies;
        private Label label2;
        private TextBox txtBoxName;
        private Label label5;
        private TextBox txtBoxDFee;
        private Label label4;
        private TextBox txtBoxType;
        private Label label3;
        private TextBox txtBoxCopies;
        private Button BtnMovieDelete;
        private Button BtnMovieUpdate;
        private Button BtnMovieAdd;
        private TextBox txtBoxMovieID;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label1;
        private Button button1;
        private TextBox txtBoxActorIDAI;
        private TextBox txtBoxMovieIDActor;
        private DataGridView dgvActors;
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