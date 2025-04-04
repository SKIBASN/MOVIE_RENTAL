
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            Customer = new TabPage();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblAddress = new Label();
            lblCity = new Label();
            lblState = new Label();
            lblZip = new Label();
            lblEmail = new Label();
            lblAccount = new Label();
            lblCredit = new Label();
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
            rentalUpdateButton = new Button();
            rentalLabel2 = new Label();
            dgvRentalMovies = new DataGridView();
            movieIdColumn = new DataGridViewTextBoxColumn();
            movieNameColumn = new DataGridViewTextBoxColumn();
            movieTypeColumn = new DataGridViewTextBoxColumn();
            feeColumn = new DataGridViewTextBoxColumn();
            numCopiesColumn = new DataGridViewTextBoxColumn();
            dispenseButton = new Button();
            rentalLabel1 = new Label();
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
            label9 = new Label();
            txtSIN = new TextBox();
            BtnMovieUpdate = new Button();
            customerID = new DataGridViewTextBoxColumn();
            customerFirstName = new DataGridViewTextBoxColumn();
            customerLastName = new DataGridViewTextBoxColumn();
            showQueueBtn = new Button();
            tabControl1.SuspendLayout();
            Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            Movie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            Rental.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRentalMovies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRentalCustomers).BeginInit();
            Report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RepRes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // BtnMovieUpdate
            // 
            BtnMovieUpdate.Font = new Font("Segoe UI", 16F);
            BtnMovieUpdate.Location = new Point(507, 278);
            BtnMovieUpdate.Margin = new Padding(3, 2, 3, 2);
            BtnMovieUpdate.Name = "BtnMovieUpdate";
            BtnMovieUpdate.Size = new Size(106, 45);
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
            tabControl1.Location = new Point(9, 0);
            tabControl1.ItemSize = new Size(151, 50);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1191, 492);
            tabControl1.Size = new Size(1426, 656);
            tabControl1.TabIndex = 0;
            // 
            // Customer
            // 
            Customer.BackColor = Color.Firebrick;
            Customer.Controls.Add(txtSIN);
            Customer.Controls.Add(label9);
            Customer.Controls.Add(lblFirstName);
            Customer.Controls.Add(lblLastName);
            Customer.Controls.Add(lblAddress);
            Customer.Controls.Add(lblCity);
            Customer.Controls.Add(lblState);
            Customer.Controls.Add(lblZip);
            Customer.Controls.Add(lblEmail);
            Customer.Controls.Add(lblAccount);
            Customer.Controls.Add(lblCredit);
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
            Customer.Font = new Font("Segoe UI", 9F);
            Customer.Location = new Point(4, 54);
            Customer.Margin = new Padding(3, 4, 3, 4);
            Customer.Name = "Customer";
            Customer.Padding = new Padding(3);
            Customer.Size = new Size(1183, 442);
            Customer.Padding = new Padding(3, 4, 3, 4);
            Customer.Size = new Size(1418, 598);
            Customer.TabIndex = 0;
            Customer.Text = "Customer";
            Customer.Click += Customer_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.ForeColor = Color.White;
            lblFirstName.Location = new Point(19, 30);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.ForeColor = Color.White;
            lblLastName.Location = new Point(23, 74);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.ForeColor = Color.White;
            lblAddress.Location = new Point(27, 114);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.ForeColor = Color.White;
            lblCity.Location = new Point(38, 153);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(31, 15);
            lblCity.TabIndex = 3;
            lblCity.Text = "City:";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.ForeColor = Color.White;
            lblState.Location = new Point(24, 192);
            lblState.Name = "lblState";
            lblState.Size = new Size(56, 15);
            lblState.TabIndex = 4;
            lblState.Text = "Province:";
            // 
            // lblZip
            // 
            lblZip.AutoSize = true;
            lblZip.ForeColor = Color.White;
            lblZip.Location = new Point(27, 227);
            lblZip.Name = "lblZip";
            lblZip.Size = new Size(58, 15);
            lblZip.TabIndex = 5;
            lblZip.Text = "Zip Code:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(30, 272);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.ForeColor = Color.White;
            lblAccount.Location = new Point(24, 305);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(65, 15);
            lblAccount.TabIndex = 7;
            lblAccount.Text = "Account #:";
            // 
            // lblCredit
            // 
            lblCredit.AutoSize = true;
            lblCredit.ForeColor = Color.White;
            lblCredit.Location = new Point(19, 346);
            lblCredit.Name = "lblCredit";
            lblCredit.Size = new Size(70, 15);
            lblCredit.TabIndex = 8;
            lblCredit.Text = "Credit Card:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(154, 27);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(88, 23);
            txtFirstName.TabIndex = 9;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(154, 63);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(88, 23);
            txtLastName.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(154, 106);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(88, 23);
            txtAddress.TabIndex = 11;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(154, 150);
            txtCity.Margin = new Padding(3, 2, 3, 2);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(88, 23);
            txtCity.TabIndex = 12;
            txtCity.TextChanged += txtCity_TextChanged;
            // 
            // txtState
            // 
            txtState.Location = new Point(154, 189);
            txtState.Margin = new Padding(3, 2, 3, 2);
            txtState.Name = "txtState";
            txtState.Size = new Size(88, 23);
            txtState.TabIndex = 13;
            // 
            // txtZip
            // 
            txtZip.Location = new Point(154, 227);
            txtZip.Margin = new Padding(3, 2, 3, 2);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(88, 23);
            txtZip.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(154, 269);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(88, 23);
            txtEmail.TabIndex = 15;
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(154, 305);
            txtAccount.Margin = new Padding(3, 2, 3, 2);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(88, 23);
            txtAccount.TabIndex = 16;
            // 
            // txtCredit
            // 
            txtCredit.Location = new Point(154, 343);
            txtCredit.Margin = new Padding(3, 2, 3, 2);
            txtCredit.Name = "txtCredit";
            txtCredit.Size = new Size(88, 23);
            txtCredit.TabIndex = 17;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(261, 20);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(66, 33);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(261, 63);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(66, 31);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(261, 106);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(66, 33);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // dgvCustomers
            // 
            dgvCustomers.Location = new Point(406, 30);
            dgvCustomers.Margin = new Padding(3, 2, 3, 2);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.Size = new Size(751, 376);
            dgvCustomers.TabIndex = 21;
            dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;
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
            Movie.Location = new Point(4, 46);
            Movie.Location = new Point(4, 54);
            Movie.Margin = new Padding(3, 4, 3, 4);
            Movie.Name = "Movie";
            Movie.Padding = new Padding(3);
            Movie.Size = new Size(1183, 442);
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
            dgvActors.Location = new Point(748, 220);
            dgvActors.Margin = new Padding(3, 2, 3, 2);
            dgvActors.Name = "dgvActors";
            dgvActors.RowHeadersWidth = 51;
            dgvActors.Size = new Size(475, 188);
            dgvActors.TabIndex = 21;
            dgvActors.CellContentClick += dgvActors_CellContentClick;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(114, 158);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(119, 47);
            button1.TabIndex = 20;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // txtBoxActorIDAI
            // 
            txtBoxActorIDAI.Location = new Point(189, 97);
            txtBoxActorIDAI.Margin = new Padding(3, 2, 3, 2);
            txtBoxActorIDAI.Name = "txtBoxActorIDAI";
            txtBoxActorIDAI.Size = new Size(179, 43);
            txtBoxActorIDAI.TabIndex = 19;
            // 
            // txtBoxMovieIDActor
            // 
            txtBoxMovieIDActor.Location = new Point(189, 52);
            txtBoxMovieIDActor.Margin = new Padding(3, 2, 3, 2);
            txtBoxMovieIDActor.Name = "txtBoxMovieIDActor";
            txtBoxMovieIDActor.Size = new Size(179, 43);
            txtBoxMovieIDActor.TabIndex = 18;
            txtBoxMovieIDActor.TextChanged += textBox1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 97);
            label8.Name = "label8";
            label8.Size = new Size(113, 37);
            label8.TabIndex = 17;
            label8.Text = "Actor ID";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 52);
            label7.Name = "label7";
            label7.Size = new Size(117, 37);
            label7.TabIndex = 16;
            label7.Text = "MovieID";
            label7.Click += label7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 37);
            label1.TabIndex = 15;
            label1.Text = "Add An Actor";
            // 
            // txtBoxMovieID
            // 
            txtBoxMovieID.Location = new Point(544, 18);
            txtBoxMovieID.Margin = new Padding(3, 2, 3, 2);
            txtBoxMovieID.Name = "txtBoxMovieID";
            txtBoxMovieID.Size = new Size(179, 43);
            txtBoxMovieID.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(397, 22);
            label6.Name = "label6";
            label6.Size = new Size(117, 37);
            label6.TabIndex = 13;
            label6.Text = "MovieID";
            // 
            // BtnMovieDelete
            // 
            BtnMovieDelete.Font = new Font("Segoe UI", 16F);
            BtnMovieDelete.Location = new Point(635, 278);
            BtnMovieDelete.Margin = new Padding(3, 2, 3, 2);
            BtnMovieDelete.Name = "BtnMovieDelete";
            BtnMovieDelete.Size = new Size(99, 45);
            BtnMovieDelete.TabIndex = 12;
            BtnMovieDelete.Text = "Delete";
            BtnMovieDelete.UseVisualStyleBackColor = true;
            BtnMovieDelete.Click += BtnMovieDelete_Click;
            // 
            // BtnMovieAdd
            // 
            BtnMovieAdd.Font = new Font("Segoe UI", 16F);
            BtnMovieAdd.Location = new Point(382, 278);
            BtnMovieAdd.Margin = new Padding(3, 2, 3, 2);
            BtnMovieAdd.Name = "BtnMovieAdd";
            BtnMovieAdd.Size = new Size(99, 45);
            BtnMovieAdd.TabIndex = 10;
            BtnMovieAdd.Text = "Add";
            BtnMovieAdd.UseVisualStyleBackColor = true;
            BtnMovieAdd.Click += BtnMovieAdd_Click_1;
            // 
            // txtBoxCopies
            // 
            txtBoxCopies.Location = new Point(544, 220);
            txtBoxCopies.Margin = new Padding(3, 2, 3, 2);
            txtBoxCopies.Name = "txtBoxCopies";
            txtBoxCopies.Size = new Size(179, 43);
            txtBoxCopies.TabIndex = 9;
            txtBoxCopies.TextChanged += txtBoxCopies_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(397, 220);
            label5.Name = "label5";
            label5.Size = new Size(121, 37);
            label5.TabIndex = 8;
            label5.Text = "# Copies";
            label5.Click += label5_Click;
            // 
            // txtBoxDFee
            // 
            txtBoxDFee.Location = new Point(544, 171);
            txtBoxDFee.Margin = new Padding(3, 2, 3, 2);
            txtBoxDFee.Name = "txtBoxDFee";
            txtBoxDFee.Size = new Size(179, 43);
            txtBoxDFee.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 171);
            label4.Name = "label4";
            label4.Size = new Size(90, 37);
            label4.TabIndex = 6;
            label4.Text = "D. Fee";
            // 
            // txtBoxType
            // 
            txtBoxType.Location = new Point(544, 118);
            txtBoxType.Margin = new Padding(3, 2, 3, 2);
            txtBoxType.Name = "txtBoxType";
            txtBoxType.Size = new Size(179, 43);
            txtBoxType.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(397, 118);
            label3.Name = "label3";
            label3.Size = new Size(73, 37);
            label3.TabIndex = 4;
            label3.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 68);
            label2.Name = "label2";
            label2.Size = new Size(88, 37);
            label2.TabIndex = 3;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(544, 66);
            txtBoxName.Margin = new Padding(3, 2, 3, 2);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(179, 43);
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
            dgvMovies.Location = new Point(748, 9);
            dgvMovies.Margin = new Padding(3, 2, 3, 2);
            dgvMovies.Name = "dgvMovies";
            dgvMovies.RowHeadersWidth = 51;
            dgvMovies.Size = new Size(475, 188);
            dgvMovies.TabIndex = 1;
            dgvMovies.CellContentClick += dataGridView1_CellContentClick_3;
            // 
            // Rental
            // 
            Rental.BackColor = Color.Firebrick;
            Rental.Controls.Add(showQueueBtn);
            Rental.Controls.Add(rentalUpdateButton);
            Rental.Controls.Add(rentalLabel2);
            Rental.Controls.Add(dgvRentalMovies);
            Rental.Controls.Add(dispenseButton);
            Rental.Controls.Add(rentalLabel1);
            Rental.Controls.Add(dgvRentalCustomers);
            Rental.ForeColor = SystemColors.ControlLightLight;
            Rental.Location = new Point(4, 54);
            Rental.Margin = new Padding(3, 4, 3, 4);
            Rental.Name = "Rental";
            Rental.Padding = new Padding(3);
            Rental.Size = new Size(1183, 442);
            Rental.TabIndex = 2;
            Rental.Text = "Rental";
            // 
            // rentalUpdateButton
            // 
            rentalUpdateButton.BackColor = Color.White;
            rentalUpdateButton.ForeColor = SystemColors.ControlText;
            rentalUpdateButton.Location = new Point(1125, 510);
            rentalUpdateButton.Name = "rentalUpdateButton";
            rentalUpdateButton.Size = new Size(204, 54);
            rentalUpdateButton.TabIndex = 6;
            rentalUpdateButton.Text = "Update";
            rentalUpdateButton.UseVisualStyleBackColor = false;
            rentalUpdateButton.Click += rentalUpdateButton_Click;
            // 
            // rentalLabel2
            // 
            rentalLabel2.AutoSize = true;
            rentalLabel2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rentalLabel2.ForeColor = Color.White;
            rentalLabel2.Location = new Point(38, 30);
            rentalLabel2.Name = "rentalLabel2";
            rentalLabel2.Size = new Size(299, 46);
            rentalLabel2.TabIndex = 5;
            rentalLabel2.Text = "Select a customer";
            rentalLabel2.Click += label2_Click;
            // 
            // dgvRentalMovies
            // 
            dgvRentalMovies.AllowUserToAddRows = false;
            dgvRentalMovies.AllowUserToDeleteRows = false;
            dgvRentalMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle7.ForeColor = SystemColors.MenuText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvRentalMovies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvRentalMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalMovies.Columns.AddRange(new DataGridViewColumn[] { movieIdColumn, movieNameColumn, movieTypeColumn, feeColumn, numCopiesColumn });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvRentalMovies.DefaultCellStyle = dataGridViewCellStyle8;
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
            dispenseButton.Location = new Point(870, 510);
            dispenseButton.Name = "dispenseButton";
            dispenseButton.Size = new Size(204, 54);
            dispenseButton.TabIndex = 3;
            dispenseButton.Text = "Dispense";
            dispenseButton.UseVisualStyleBackColor = true;
            dispenseButton.Click += dispenseButton_Click;
            // 
            // rentalLabel1
            // 
            rentalLabel1.AutoSize = true;
            rentalLabel1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rentalLabel1.ForeColor = Color.White;
            rentalLabel1.Location = new Point(38, 276);
            rentalLabel1.Name = "rentalLabel1";
            rentalLabel1.Size = new Size(248, 46);
            rentalLabel1.TabIndex = 2;
            rentalLabel1.Text = "Select a movie";
            rentalLabel1.Click += label1_Click_1;
            // 
            // dgvRentalCustomers
            // 
            dgvRentalCustomers.AllowUserToAddRows = false;
            dgvRentalCustomers.AllowUserToDeleteRows = false;
            dgvRentalCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvRentalCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvRentalCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalCustomers.Columns.AddRange(new DataGridViewColumn[] { custIdColumn, ssnColumn, LastNameColumn, firstNameColumn, addressColumn, cityColumn, stateColumn, zipColumn, emailColumn, accountNumColumn, accCreatedColumn, creditNumColumn });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvRentalCustomers.DefaultCellStyle = dataGridViewCellStyle10;
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
            Report.Size = new Size(1183, 442);
            Report.TabIndex = 3;
            Report.Text = "Report";
            Report.Click += Report_Click;
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
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            RepRes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            RepRes.RowsDefaultCellStyle = dataGridViewCellStyle12;
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
            // databaseBindingSource
            // 
            databaseBindingSource.DataSource = typeof(Database);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(3, 391);
            label9.Name = "label9";
            label9.Size = new Size(133, 15);
            label9.TabIndex = 22;
            label9.Text = "Social Security Number:";
            label9.Click += label9_Click;
            // 
            // txtSIN
            // 
            txtSIN.Location = new Point(154, 388);
            txtSIN.Margin = new Padding(3, 2, 3, 2);
            txtSIN.Name = "txtSIN";
            txtSIN.Size = new Size(88, 23);
            txtSIN.TabIndex = 23;
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
            // showQueueBtn
            // 
            showQueueBtn.BackColor = SystemColors.Control;
            showQueueBtn.ForeColor = SystemColors.ControlText;
            showQueueBtn.Location = new Point(594, 510);
            showQueueBtn.Name = "showQueueBtn";
            showQueueBtn.Size = new Size(229, 54);
            showQueueBtn.TabIndex = 7;
            showQueueBtn.Text = "Show Queue";
            showQueueBtn.UseVisualStyleBackColor = true;
            showQueueBtn.Click += showQueueBtn_Click;
            // 
            // NavScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 522);
            ClientSize = new Size(1424, 696);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NavScreen";
            Text = "NavScreen";
            Load += NavScreen_Load;
            tabControl1.ResumeLayout(false);
            Customer.ResumeLayout(false);
            Customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            Movie.ResumeLayout(false);
            Movie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActors).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            Report.ResumeLayout(false);
            Report.PerformLayout();
            Rental.ResumeLayout(false);
            Rental.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRentalMovies).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRentalCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)RepRes).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        // Controls
        private TabControl tabControl1;
        private TabPage Customer;
        private TabPage Movie;
        private TabPage Rental;
        private TabPage Report;

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
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblAddress;
        private Label lblCity;
        private Label lblState;
        private Label lblZip;
        private Label lblEmail;
        private Label lblAccount;
        private Label lblCredit;
        private Label label9;
        private TextBox txtSIN;
        private Label rentalLabel1;
        private Button dispenseButton;
        private Label rentalLabel2;
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
        private Button showQueueBtn;
    }
}