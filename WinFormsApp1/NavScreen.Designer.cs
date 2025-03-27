
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
            SpecifTitle = new Label();
            Specif = new TextBox();
            ReportSelection = new ComboBox();
            RepRes = new TextBox();
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
            Report.Controls.Add(DateSelect);
            Report.Controls.Add(Enter);
            Report.Controls.Add(cal);
            Report.Controls.Add(PickReportTitle);
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
            // RepRes
            // 
            RepRes.Location = new Point(513, 108);
            RepRes.Name = "RepRes";
            RepRes.Size = new Size(252, 43);
            RepRes.TabIndex = 8;
            RepRes.Text = "RepRes";
            RepRes.Visible = true;
            RepRes.TextChanged += RepRes_TextChanged;
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
        private Label SpecifTitle;
        private Label PickReportTitle;
        private MonthCalendar cal;
        private Button Enter;
        private Label DateSelect;
        private TextBox RepRes;
    }
}