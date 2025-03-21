namespace WinFormsApp1
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            PasswordTitle = new Label();
            button1 = new Button();
            user = new TextBox();
            password = new TextBox();
            status = new Label();
            tabControl1 = new TabControl();
            Customer = new TabPage();
            Movie = new TabPage();
            Rental = new TabPage();
            Report = new TabPage();
            tabControl2 = new TabControl();
            tabPage1 = new TabPage();
            tabPage5 = new TabPage();
            tabControl1.SuspendLayout();
            Customer.SuspendLayout();
            tabControl2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(166, 76);
            label1.Name = "label1";
            label1.Size = new Size(152, 54);
            label1.TabIndex = 0;
            label1.Text = "User ID";
            label1.Click += label1_Click;
            // 
            // PasswordTitle
            // 
            PasswordTitle.AutoSize = true;
            PasswordTitle.Font = new Font("Segoe UI", 30F);
            PasswordTitle.Location = new Point(152, 137);
            PasswordTitle.Name = "PasswordTitle";
            PasswordTitle.Size = new Size(188, 54);
            PasswordTitle.TabIndex = 1;
            PasswordTitle.Text = "Password";
            PasswordTitle.Click += PasswordTitle_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(166, 309);
            button1.Name = "button1";
            button1.Size = new Size(109, 47);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += login_Click;
            // 
            // user
            // 
            user.Font = new Font("Segoe UI", 20F);
            user.Location = new Point(399, 87);
            user.Name = "user";
            user.Size = new Size(192, 43);
            user.TabIndex = 3;
            user.TextChanged += user_TextChanged;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 20F);
            password.Location = new Point(399, 148);
            password.Name = "password";
            password.Size = new Size(192, 43);
            password.TabIndex = 4;
            password.TextChanged += password_TextChanged;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Segoe UI", 10F);
            status.Location = new Point(379, 330);
            status.Name = "status";
            status.Size = new Size(83, 19);
            status.TabIndex = 7;
            status.Text = "LOADING ...";
            status.Visible = false;
            status.Click += label2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Customer);
            tabControl1.Controls.Add(Movie);
            tabControl1.Controls.Add(Rental);
            tabControl1.Controls.Add(Report);
            tabControl1.Location = new Point(-1, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(801, 444);
            tabControl1.TabIndex = 8;
            // 
            // Customer
            // 
            Customer.Controls.Add(tabControl2);
            Customer.Location = new Point(4, 24);
            Customer.Name = "Customer";
            Customer.Padding = new Padding(3);
            Customer.Size = new Size(793, 416);
            Customer.TabIndex = 0;
            Customer.Text = "Customer";
            Customer.UseVisualStyleBackColor = true;
            // 
            // Movie
            // 
            Movie.AccessibleName = "Movie";
            Movie.Location = new Point(4, 24);
            Movie.Name = "Movie";
            Movie.Padding = new Padding(3);
            Movie.Size = new Size(793, 416);
            Movie.TabIndex = 1;
            Movie.Text = "Movie";
            Movie.UseVisualStyleBackColor = true;
            // 
            // Rental
            // 
            Rental.Location = new Point(4, 24);
            Rental.Name = "Rental";
            Rental.Padding = new Padding(3);
            Rental.Size = new Size(793, 416);
            Rental.TabIndex = 2;
            Rental.Text = "Rental";
            Rental.UseVisualStyleBackColor = true;
            // 
            // Report
            // 
            Report.Location = new Point(4, 24);
            Report.Name = "Report";
            Report.Padding = new Padding(3);
            Report.Size = new Size(793, 416);
            Report.TabIndex = 3;
            Report.Text = "Report";
            Report.UseVisualStyleBackColor = true;
            Report.Click += Report_Click;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Controls.Add(tabPage5);
            tabControl2.Location = new Point(765, 374);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(200, 100);
            tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(192, 72);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(192, 72);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(status);
            Controls.Add(password);
            Controls.Add(user);
            Controls.Add(button1);
            Controls.Add(PasswordTitle);
            Controls.Add(label1);
            Name = "Window";
            Text = "Form1";
            Load += UserTitle_Load;
            tabControl1.ResumeLayout(false);
            Customer.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label PasswordTitle;
        private Button button1;
        private TextBox user;
        private TextBox password;
        private RadioButton employee;
        private RadioButton cust;
        private Label status;
        private TabControl tabControl1;
        private TabPage Customer;
        private TabControl tabControl2;
        private TabPage tabPage1;
        private TabPage tabPage5;
        private TabPage Movie;
        private TabPage Rental;
        private TabPage Report;
    }
}
