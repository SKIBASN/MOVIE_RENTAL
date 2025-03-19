using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainAppWindow : Form
    {
        private string userType;

        public MainAppWindow(string userType)
        {
            InitializeComponent();
            this.userType = userType;
            WelcomeMessage();
        }

        private void WelcomeMessage()
        {
            MessageBox.Show($"Welcome, {userType}!");
        }
    }
}