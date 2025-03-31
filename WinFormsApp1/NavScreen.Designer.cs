
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
            tabControl1 = new TabControl();
            Customer = new TabPage();
            Movie = new TabPage();
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
            label1 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            Report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RepRes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // BtnMovieUpdate
            // 
            BtnMovieUpdate.Location = new Point(480, 386);
            BtnMovieUpdate.Name = "BtnMovieUpdate";
            BtnMovieUpdate.Size = new Size(144, 63);
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
            // 
            // Movie
            // 
            Movie.BackColor = Color.Firebrick;
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
            Movie.Controls.Add(label1);
            Movie.Location = new Point(4, 54);
            Movie.Margin = new Padding(3, 4, 3, 4);
            Movie.Name = "Movie";
            Movie.Padding = new Padding(3, 4, 3, 4);
            Movie.Size = new Size(1418, 598);
            Movie.TabIndex = 1;
            Movie.Text = "Movie";
            Movie.Click += Movie_Click;
            // 
            // txtBoxMovieID
            // 
            txtBoxMovieID.Location = new Point(448, 24);
            txtBoxMovieID.Name = "txtBoxMovieID";
            txtBoxMovieID.Size = new Size(378, 52);
            txtBoxMovieID.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(290, 30);
            label6.Name = "label6";
            label6.Size = new Size(146, 46);
            label6.TabIndex = 13;
            label6.Text = "MovieID";
            // 
            // BtnMovieDelete
            // 
            BtnMovieDelete.Location = new Point(672, 386);
            BtnMovieDelete.Name = "BtnMovieDelete";
            BtnMovieDelete.Size = new Size(136, 63);
            BtnMovieDelete.TabIndex = 12;
            BtnMovieDelete.Text = "Delete";
            BtnMovieDelete.UseVisualStyleBackColor = true;
            BtnMovieDelete.Click += BtnMovieDelete_Click;
            // 
            // BtnMovieAdd
            // 
            BtnMovieAdd.Location = new Point(304, 386);
            BtnMovieAdd.Name = "BtnMovieAdd";
            BtnMovieAdd.Size = new Size(136, 63);
            BtnMovieAdd.TabIndex = 10;
            BtnMovieAdd.Text = "Add";
            BtnMovieAdd.UseVisualStyleBackColor = true;
            BtnMovieAdd.Click += BtnMovieAdd_Click_1;
            // 
            // txtBoxCopies
            // 
            txtBoxCopies.Location = new Point(448, 294);
            txtBoxCopies.Name = "txtBoxCopies";
            txtBoxCopies.Size = new Size(378, 52);
            txtBoxCopies.TabIndex = 9;
            txtBoxCopies.TextChanged += txtBoxCopies_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(290, 294);
            label5.Name = "label5";
            label5.Size = new Size(150, 46);
            label5.TabIndex = 8;
            label5.Text = "# Copies";
            label5.Click += label5_Click;
            // 
            // txtBoxDFee
            // 
            txtBoxDFee.Location = new Point(448, 228);
            txtBoxDFee.Name = "txtBoxDFee";
            txtBoxDFee.Size = new Size(378, 52);
            txtBoxDFee.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(290, 228);
            label4.Name = "label4";
            label4.Size = new Size(113, 46);
            label4.TabIndex = 6;
            label4.Text = "D. Fee";
            // 
            // txtBoxType
            // 
            txtBoxType.Location = new Point(448, 157);
            txtBoxType.Name = "txtBoxType";
            txtBoxType.Size = new Size(378, 52);
            txtBoxType.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 157);
            label3.Name = "label3";
            label3.Size = new Size(90, 46);
            label3.TabIndex = 4;
            label3.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 91);
            label2.Name = "label2";
            label2.Size = new Size(109, 46);
            label2.TabIndex = 3;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(448, 88);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(378, 52);
            txtBoxName.TabIndex = 2;
            // 
            // dgvMovies
            // 
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 20F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvMovies.DefaultCellStyle = dataGridViewCellStyle1;
            dgvMovies.Location = new Point(855, 12);
            dgvMovies.Name = "dgvMovies";
            dgvMovies.RowHeadersWidth = 51;
            dgvMovies.Size = new Size(543, 327);
            dgvMovies.TabIndex = 1;
            dgvMovies.CellContentClick += dataGridView1_CellContentClick_3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 14);
            label1.Name = "label1";
            label1.Size = new Size(127, 46);
            label1.TabIndex = 0;
            label1.Text = "Movies";
            label1.Click += label1_Click_1;
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
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            RepRes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            RepRes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            RepRes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            RepRes.BackgroundColor = SystemColors.ButtonHighlight;
            RepRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RepRes.Location = new Point(624, 124);
            RepRes.Margin = new Padding(3, 4, 3, 4);
            RepRes.Name = "RepRes";
            RepRes.ReadOnly = true;
            RepRes.RowHeadersWidth = 10;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            RepRes.RowsDefaultCellStyle = dataGridViewCellStyle3;
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
        private Label label1;
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
    }
}