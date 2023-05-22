using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using MaterialSkin;
using MaterialSkin.Controls;

namespace FinalQA_Project
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // close any open files or connections, etc.
                    // ...

                    // exit the application
                    Environment.Exit(0);
                }
            }
        }



        private void AddBirdImg_Click(object sender, EventArgs e)
        {
            AddBirdForm addBirdForm = new AddBirdForm();
            addBirdForm.Show();
        }

        private void AddCageImg_Click(object sender, EventArgs e)
        {
            AddCageForm addCageForm = new AddCageForm();
            addCageForm.Show();
        }

        private void SearchBirdImg_Click(object sender, EventArgs e)
        {
            SearchBirdForm searchBirdForm = new SearchBirdForm();
            searchBirdForm.Show();
        }
        private void SearchCaveImg_Click(object sender,EventArgs e)
        {
            SearchCage searchCage = new SearchCage();
            searchCage.Show();

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
