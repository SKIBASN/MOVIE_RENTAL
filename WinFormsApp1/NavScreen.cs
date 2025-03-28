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
        public Database db;
        private int choice = 0;
        
        public NavScreen(Database DT)
        {
            InitializeComponent();
            db = DT;
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
                Specif.Text = "";
                DateSelect.Text = "No Date Selected";
                result.Visible = false;
                cal.Visible = true;
                Enter.Visible = false;
                DateSelect.Visible = true;
                Specif.Visible = false;
                SpecifTitle.Visible = true;
                SpecifTitle.Text = "Pick a Date: ";
                Enter.Visible = true;

            }
            else if (ReportSelection.SelectedItem.ToString() == "What movies has a specific employee rented?")
            {
                Specif.Text = "";
                DateSelect.Text = "No Date Selected";
                result.Visible = false;
                Specif.Visible = true;
                Enter.Visible = false;
                DateSelect.Visible = false;
                cal.Visible = false;
                SpecifTitle.Visible = true;
                SpecifTitle.Text = "Enter an Employee ID:";
                Enter.Visible = true;

            }
            else if (ReportSelection.SelectedItem.ToString() == "What Actors appear in a Movie?")
            {
                Specif.Text = "";
                DateSelect.Text = "No Date Selected";
                result.Visible = false;
                cal.Visible = false;
                Enter.Visible = false;
                DateSelect.Visible = false;
                Specif.Visible = true;
                SpecifTitle.Visible = true;
                SpecifTitle.Text = "Enter a Movie ID:";
                Enter.Visible = true;

            }
            else if (ReportSelection.SelectedItem.ToString() == "How many times has a movie with a specific actor been rented?")
            {
                Specif.Text = "";
                DateSelect.Text = "No Date Selected";
                result.Visible = false;
                cal.Visible = false;
                Enter.Visible = false;
                Specif.Visible = true;
                DateSelect.Visible = false;
                SpecifTitle.Visible = true;
                SpecifTitle.Text = "Enter an Actor ID: ";
                Enter.Visible = true;

            }
            else if (ReportSelection.SelectedItem.ToString() == "Which Customer has the most rentals?")
            {
                Specif.Text = "";
                DateSelect.Text = "No Date Selected";
                Enter.Visible = true;
                result.Visible = true;
                result.Visible = false;
                cal.Visible = false;
                Specif.Visible = false;
                DateSelect.Visible = false;
                SpecifTitle.Visible = false;

            }
            else
            {
                Specif.Text = "";
                DateSelect.Text = "No Date Selected";
                Enter.Visible = false;
                cal.Visible = false;
                Specif.Visible = false;
                DateSelect.Visible = false;
                SpecifTitle.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DateSelect_Click(object sender, EventArgs e)
        {

        }

        private void cal_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateSelect.Text = cal.SelectionStart.ToShortDateString();
        }
        private void cal_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateSelect.Text = cal.SelectionStart.ToShortDateString();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if ((Specif.Text == "") && (DateSelect.Text == "No Date Selected") && (ReportSelection.SelectedItem?.ToString() != "Which Customer has the most rentals?"))
            {
                result.Text = "Error: Missing Information";
            }
            else
            {
                result.Text = "RESULT EXECUTED";
            }
                result.Visible = true;
        }
    }
}
