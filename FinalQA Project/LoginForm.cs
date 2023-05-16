using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using MaterialSkin;
using MaterialSkin.Controls;

namespace FinalQA_Project
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();

            
        }


        // Event handler for the login button
        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Get the entered username and password
            string username = usernameBoxLogin.Text;
            string password = passwordBoxLogin.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new Excel Application object
            Application excelApp = new Application();

            // Open the Excel workbook containing the login information
            Workbook workbook = excelApp.Workbooks.Open(@"C:\Users\vladi\source\repos\FinalQA Project\FinalQA Project\Users.xlsx");

            // Get the Worksheet object for the sheet containing the login information
            Worksheet worksheet = (Worksheet)workbook.Worksheets["Main"];

            // Loop through the rows of the worksheet and check each row's username and password
            bool loginSuccessful = false;
            for (int row = 2; row <= worksheet.UsedRange.Rows.Count; row++)
            {
                string rowUsername = ((Range)worksheet.Cells[row, 1]).Value;
                string rowPassword = ((Range)worksheet.Cells[row, 2]).Value;
                if (rowUsername == username && rowPassword == password)
                {
                    loginSuccessful = true;
                    break;
                }
            }

            // Display a message indicating whether the login was successful or not
            if (loginSuccessful)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed. Please try again.");
            }

            // Close the workbook and the Excel application
            workbook.Save();
            workbook.Close();
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
        }

    }
}
