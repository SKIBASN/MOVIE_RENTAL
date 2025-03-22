namespace WinFormsApp1
{
    partial class LoginScreen
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
            fileSystemWatcher1 = new FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
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
            PasswordTitle.Visible = true;
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
            password.Visible = true;
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
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(800, 450);
            Controls.Add(status);
            Controls.Add(password);
            Controls.Add(user);
            Controls.Add(button1);
            Controls.Add(PasswordTitle);
            Controls.Add(label1);
            Name = "LoginScreen";
            Text = "LoginScreen";
            Load += UserTitle_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
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
        private FileSystemWatcher fileSystemWatcher1;
    }
}
