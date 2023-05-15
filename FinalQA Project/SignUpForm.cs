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
    public partial class SignUpForm : MaterialForm
    {
        public SignUpForm()
        {
            InitializeComponent();
        }


        // Event handler for the registration button
        private void signUpButton_Click(object sender, EventArgs e)
        {
            // Get the entered registration information
            string username = usernameBoxSignUp.Text;
            string password = passwordBoxSignUp.Text;  
            string id = idBoxSignUp.Text;

            //Cheking input validation
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (username.Length < 6 || username.Length > 8 || !username.All(c => char.IsLetter(c) || char.IsDigit(c)) || username.Count(c => char.IsDigit(c)) > 2)
            {
                MessageBox.Show("Username must be between 6 and 8 characters, contain at most 2 digits, and only contain letters and digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password.Length < 8 || password.Length > 10 || !password.Any(c => char.IsLetter(c)) || !password.Any(c => "!@#$%^&*()_+[]{};':<>,.?/".Contains(c)))
            {
                MessageBox.Show("Password must be between 8 and 10 characters, contain at least one letter, and one special character\n(! @ # $ % ^ & * ( ) _ + [ ] { } ; ' : < > , . ? / ).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (id.Length != 9 || !id.All(c => char.IsDigit(c)))
            {
                MessageBox.Show("ID number must be 9 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Create a new Excel Application object
            Application excelApp = new Application();

            // Open the Excel workbook containing the user information
            Workbook workbook = excelApp.Workbooks.Open(@"C:\Users\vladi\Source\Repos\FinalQA Project\FinalQA Project\Users.xlsx");

            // Get the Worksheet object for the sheet containing the user information
            Worksheet worksheet = (Worksheet)workbook.Worksheets["Main"];

            // Check if the entered username already exists in the worksheet
            bool usernameTaken = false;
            for (int row = 2; row <= worksheet.UsedRange.Rows.Count; row++)
            {
                string rowUsername = ((Range)worksheet.Cells[row, 1]).Value;
                if (rowUsername == username)
                {
                    usernameTaken = true;
                    break;
                }
            }

            // If the entered username is already taken, display a message and prompt the user to enter a different username
            if (usernameTaken)
            {
                MessageBox.Show("Username is already taken. Please choose a different username.");
            }
            else
            {
                // Add a new row to the worksheet with the user's registration information
                int newRow = worksheet.UsedRange.Rows.Count + 1;
                ((Range)worksheet.Cells[newRow, 1]).Value = username;
                ((Range)worksheet.Cells[newRow, 2]).Value = password;
                ((Range)worksheet.Cells[newRow, 3]).Value = id;

                // Display a message indicating that the registration was successful
                MessageBox.Show("Registration successful!");

                // Close the registration form
                this.Close();
            }

            // Close the workbook and the Excel application
            workbook.Save();
            workbook.Close();
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);

        }


    }
}
