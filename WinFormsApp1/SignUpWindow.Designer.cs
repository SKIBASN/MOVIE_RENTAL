namespace WinFormsApp1
{
    partial class SignUpWindow
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

        private void InitializeComponent()
        {
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // First Name
            this.txtFirstName.Location = new System.Drawing.Point(100, 20);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 20);
            this.txtFirstName.PlaceholderText = "First Name";

            // Last Name
            this.txtLastName.Location = new System.Drawing.Point(100, 50);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 20);
            this.txtLastName.PlaceholderText = "Last Name";

            // Username
            this.txtUsername.Location = new System.Drawing.Point(100, 80);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.PlaceholderText = "Username";

            // Password
            this.txtPassword.Location = new System.Drawing.Point(100, 110);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.PasswordChar = '*';

            // User Type
            this.cmbUserType.Items.AddRange(new object[] { "customer", "employee" });
            this.cmbUserType.Location = new System.Drawing.Point(100, 140);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(200, 20);
            this.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Sign Up Button
            this.btnSignUp.Location = new System.Drawing.Point(100, 170);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(200, 30);
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cmbUserType);
            this.Controls.Add(this.btnSignUp);
            this.Text = "Sign Up";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Button btnSignUp;
    }
}