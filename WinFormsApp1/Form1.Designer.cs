namespace WinFormsApp1
{
    partial class EnterUP
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
            employee = new RadioButton();
            cust = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(108, 134);
            label1.Name = "label1";
            label1.Size = new Size(200, 54);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // PasswordTitle
            // 
            PasswordTitle.AutoSize = true;
            PasswordTitle.Font = new Font("Segoe UI", 30F);
            PasswordTitle.Location = new Point(108, 202);
            PasswordTitle.Name = "PasswordTitle";
            PasswordTitle.Size = new Size(188, 54);
            PasswordTitle.TabIndex = 1;
            PasswordTitle.Text = "Password";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(137, 374);
            button1.Name = "button1";
            button1.Size = new Size(109, 47);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // user
            // 
            user.Font = new Font("Segoe UI", 20F);
            user.Location = new Point(355, 152);
            user.Name = "user";
            user.Size = new Size(192, 43);
            user.TabIndex = 3;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 20F);
            password.Location = new Point(355, 213);
            password.Name = "password";
            password.Size = new Size(192, 43);
            password.TabIndex = 4;
            // 
            // employee
            // 
            employee.AutoSize = true;
            employee.Checked = true;
            employee.Font = new Font("Segoe UI", 20F);
            employee.Location = new Point(126, 299);
            employee.Name = "employee";
            employee.Size = new Size(152, 41);
            employee.TabIndex = 5;
            employee.TabStop = true;
            employee.Text = "Employee";
            employee.UseVisualStyleBackColor = true;
            employee.CheckedChanged += employee_CheckedChanged;
            // 
            // cust
            // 
            cust.AutoSize = true;
            cust.Font = new Font("Segoe UI", 20F);
            cust.Location = new Point(309, 299);
            cust.Name = "cust";
            cust.Size = new Size(149, 41);
            cust.TabIndex = 6;
            cust.Text = "Customer";
            cust.UseVisualStyleBackColor = true;
            // 
            // EnterUP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(800, 450);
            Controls.Add(cust);
            Controls.Add(employee);
            Controls.Add(password);
            Controls.Add(user);
            Controls.Add(button1);
            Controls.Add(PasswordTitle);
            Controls.Add(label1);
            Name = "EnterUP";
            Text = "Form1";
            Load += UserTitle_Load;
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
    }
}
