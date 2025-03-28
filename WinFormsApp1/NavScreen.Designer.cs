
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
            tabControl1.Size = new Size(801, 446);
            tabControl1.TabIndex = 0;
            // 
            // Customer
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
            // 
            // Movie
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
            // Rental
            // 
            Rental.BackColor = Color.Firebrick;
            Rental.Location = new Point(4, 46);
            Rental.Name = "Rental";
            Rental.Padding = new Padding(3);
            Rental.Size = new Size(793, 396);
            Rental.TabIndex = 2;
            Rental.Text = "Rental";
            // 
            // Report
            // 
            Report.BackColor = Color.Firebrick;
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
            Report.Name = "Report";
            Report.Padding = new Padding(3);
            Report.Size = new Size(793, 396);
            Report.TabIndex = 3;
            Report.Text = "Report";
            Report.Click += Report_Click;
            // 
            // RepRes
            // 
            RepRes.AllowUserToAddRows = false;
            RepRes.AllowUserToDeleteRows = false;
            RepRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RepRes.Location = new Point(578, 191);
            RepRes.Name = "RepRes";
            RepRes.ReadOnly = true;
            RepRes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RepRes.Size = new Size(240, 150);
            RepRes.TabIndex = 13;
            RepRes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // EnterR
            // 
            EnterR.Font = new Font("Segoe UI", 10F);
            EnterR.Location = new Point(619, 145);
            EnterR.Name = "EnterR";
            EnterR.Size = new Size(168, 30);
            EnterR.TabIndex = 12;
            EnterR.Text = "Enter";
            EnterR.UseVisualStyleBackColor = true;
            EnterR.Click += EnterR_Click;
            // 
            // SpecifTitle2
            // 
            SpecifTitle2.AutoSize = true;
            SpecifTitle2.Font = new Font("Segoe UI", 15F);
            SpecifTitle2.ForeColor = SystemColors.ActiveCaptionText;
            SpecifTitle2.Location = new Point(329, 108);
            SpecifTitle2.Name = "SpecifTitle2";
            SpecifTitle2.Size = new Size(76, 28);
            SpecifTitle2.TabIndex = 10;
            SpecifTitle2.Text = "Specif2";
            SpecifTitle2.Visible = false;
            // 
            // cal2
            // 
            cal2.Location = new Point(339, 179);
            cal2.Name = "cal2";
            cal2.TabIndex = 9;
            cal2.Visible = false;
            cal2.DateSelected += cal2_DateSelected;
            // 
            // DateSelect2
            // 
            DateSelect2.AutoSize = true;
            DateSelect2.BackColor = Color.White;
            DateSelect2.Font = new Font("Segoe UI", 15F);
            DateSelect2.ForeColor = SystemColors.ActiveCaptionText;
            DateSelect2.Location = new Point(370, 145);
            DateSelect2.Name = "DateSelect2";
            DateSelect2.Size = new Size(180, 28);
            DateSelect2.TabIndex = 8;
            DateSelect2.Text = "No Date Selected 2";
            DateSelect2.Visible = false;
            // 
            // DateSelect1
            // 
            DateSelect1.AutoSize = true;
            DateSelect1.BackColor = Color.White;
            DateSelect1.Font = new Font("Segoe UI", 15F);
            DateSelect1.ForeColor = SystemColors.ActiveCaptionText;
            DateSelect1.Location = new Point(79, 139);
            DateSelect1.Name = "DateSelect1";
            DateSelect1.Size = new Size(180, 28);
            DateSelect1.TabIndex = 7;
            DateSelect1.Text = "No Date Selected 1";
            DateSelect1.Visible = false;
            DateSelect1.Click += DateSelect_Click;
            // 
            // cal1
            // 
            cal1.Location = new Point(45, 179);
            cal1.Name = "cal1";
            cal1.TabIndex = 5;
            cal1.Visible = false;
            cal1.DateChanged += cal_DateChanged;
            cal1.DateSelected += cal_DateSelected;
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
            // SpecifTitle1
            // 
            SpecifTitle1.AutoSize = true;
            SpecifTitle1.Font = new Font("Segoe UI", 15F);
            SpecifTitle1.ForeColor = SystemColors.ActiveCaptionText;
            SpecifTitle1.Location = new Point(45, 99);
            SpecifTitle1.Name = "SpecifTitle1";
            SpecifTitle1.Size = new Size(76, 28);
            SpecifTitle1.TabIndex = 2;
            SpecifTitle1.Text = "Specif1";
            SpecifTitle1.Visible = false;
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
            ReportSelection.Items.AddRange(new object[] { "Who are the top 3 customers with the most rentals?", "What are the top 3 movies that have been rented between two specific days?", "What are the 3 top movies a specific employee rented?", "What are the top 3 rented genre between two specific days?", "What are the top 3 rented movies with a specfic actor?" });
            ReportSelection.Location = new Point(37, 48);
            ReportSelection.Name = "ReportSelection";
            ReportSelection.Size = new Size(692, 36);
            ReportSelection.TabIndex = 0;
            ReportSelection.Text = "Who are the top 3 customers with the most rentals?";
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
    }
}