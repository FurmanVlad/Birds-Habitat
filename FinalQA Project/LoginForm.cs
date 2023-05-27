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

    private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = true;
            Environment.Exit(0);

        }



        public bool loginSuccessful;

        // Event handler for the login button
        public void LoginButton_Click(object sender, EventArgs e)
        {
            // Get the entered username and password
            string username = usernameBoxLogin.Text;
            string password = passwordBoxLogin.Text;


            // Create a new Excel Application object
            Application excelApp = new Application();

            // Open the Excel workbook containing the login information
            Workbook workbook = excelApp.Workbooks.Open(@"C:\Users\vladi\source\repos\FinalQA Project\FinalQA Project\Users.xlsx");

            // Get the Worksheet object for the sheet containing the login information
            Worksheet worksheet = (Worksheet)workbook.Worksheets["Main"];


            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClosingAll(excelApp, workbook, worksheet);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClosingAll(excelApp, workbook, worksheet);
                return;
            }
            

            // Loop through the rows of the worksheet and check each row's username and password
            loginSuccessful = false;
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
                MessageBox.Show("Login successful");
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed. Please try again.");
            }

            ClosingAll(excelApp, workbook, worksheet);

        }

        // Close the workbook and the Excel application
        private void ClosingAll(Application excelApp, Workbook workbook, Worksheet worksheet)
        {
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
            signUpForm.ShowDialog();
        }


        bool passwordVisible = false; // Variable to track the password visibility state

        private void togglePictureBox_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible; // Toggle the password visibility state

            if (passwordVisible)
            {
                passwordBoxLogin.PasswordChar = '\0'; // Show the password
            }
            else
            {
                passwordBoxLogin.PasswordChar = '*'; // Hide the password
            }
        }

    }
}
