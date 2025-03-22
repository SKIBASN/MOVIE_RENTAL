using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class NavScreen : Form
    {
        public NavScreen()
        {
            InitializeComponent();
        }

        private void Report_Click(object sender, EventArgs e)
        {

        }

        private void Movie_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReportSelection.SelectedItem.ToString() == "What Movies haven't been rented since a specific date?")
            {
                cal.Visible = true;
                DateSelect.Visible = true;
                Specif.Visible = false;
                SpecifTitle.Visible = true;
                SpecifTitle.Text = "Pick a Date";
            }
            else if (ReportSelection.SelectedItem.ToString() == "What movies has a specific employee rented?")
            {
                Specif.Visible = true;
                DateSelect.Visible = false;
                cal.Visible = false;
                SpecifTitle.Visible = true;
                SpecifTitle.Text = "Enter an Employee ID";
            }
            else if (ReportSelection.SelectedItem.ToString() == "What Actors appear in a Movie?")
            {
                cal.Visible = false;
                DateSelect.Visible = false;
                Specif.Visible = true;
                SpecifTitle.Visible = true;
                SpecifTitle.Text = "Enter a Movie ID";
            }
            else if (ReportSelection.SelectedItem.ToString() == "How many times has a movie with a specific actor been rented?")
            {
                cal.Visible = false;
                Specif.Visible = true;
                DateSelect.Visible = false;
                SpecifTitle.Visible = true;
                SpecifTitle.Text = "Enter an Actor ID";
            }
            else
            {
                cal.Visible = false;
                Specif.Visible = false;
                DateSelect.Visible = false;
                SpecifTitle.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }      
}
