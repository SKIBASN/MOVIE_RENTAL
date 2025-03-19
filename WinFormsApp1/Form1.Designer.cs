namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            PasswordTitle = new Label();
            btnLogin = new Button();
            user = new TextBox();
            password = new TextBox();
            employee = new RadioButton();
            cust = new RadioButton();
            status = new Label();
            btnSignUp = new Button();
            SuspendLayout();

            // Username Label
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(50, 40);
            label1.Name = "label1";
            label1.Size = new Size(140, 37);
            label1.Text = "Username";

            // Password Label
            PasswordTitle.AutoSize = true;
            PasswordTitle.Font = new Font("Segoe UI", 20F);
            PasswordTitle.Location = new Point(50, 100);
            PasswordTitle.Name = "PasswordTitle";
            PasswordTitle.Size = new Size(130, 37);
            PasswordTitle.Text = "Password";

            // Username TextBox
            user.Font = new Font("Segoe UI", 14F);
            user.Location = new Point(250, 50);
            user.Name = "user";
            user.Size = new Size(200, 32);

            // Password TextBox
            password.Font = new Font("Segoe UI", 14F);
            password.Location = new Point(250, 110);
            password.Name = "password";
            password.Size = new Size(200, 32);
            password.PasswordChar = '*'; // Mask password input

            // Employee Radio Button
            employee.AutoSize = true;
            employee.Checked = true;
            employee.Font = new Font("Segoe UI", 12F);
            employee.Location = new Point(250, 160);
            employee.Name = "employee";
            employee.Size = new Size(95, 25);
            employee.Text = "Employee";
            employee.CheckedChanged += employee_CheckedChanged;

            // Customer Radio Button
            cust.AutoSize = true;
            cust.Font = new Font("Segoe UI", 12F);
            cust.Location = new Point(350, 160);
            cust.Name = "cust";
            cust.Size = new Size(92, 25);
            cust.Text = "Customer";
            cust.CheckedChanged += cust_CheckedChanged;

            // Status Label
            status.AutoSize = true;
            status.Font = new Font("Segoe UI", 12F);
            status.ForeColor = Color.White;
            status.Location = new Point(250, 230);
            status.Name = "status";
            status.Size = new Size(0, 21);
            status.Visible = false;

            // Login Button
            btnLogin.Font = new Font("Segoe UI", 14F);
            btnLogin.Location = new Point(250, 270);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 40);
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += login_Click;

            // Sign-Up Button
            btnSignUp.Font = new Font("Segoe UI", 14F);
            btnSignUp.Location = new Point(360, 270);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(100, 40);
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;

            // Main Form Settings
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(600, 400);
            Controls.Add(status);
            Controls.Add(cust);
            Controls.Add(employee);
            Controls.Add(password);
            Controls.Add(user);
            Controls.Add(btnLogin);
            Controls.Add(btnSignUp);
            Controls.Add(PasswordTitle);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label PasswordTitle;
        private Button btnLogin;
        private Button btnSignUp;
        private TextBox user;
        private TextBox password;
        private RadioButton employee;
        private RadioButton cust;
        private Label status;
    }
}
