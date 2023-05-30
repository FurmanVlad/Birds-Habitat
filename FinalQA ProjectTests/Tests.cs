using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using FinalQA_Project;
using System;
using System.IO;
using System.Reflection;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

using System.Collections.Generic;
using System.Linq;

namespace FinalQA_Project.Tests
{
    [TestClass]
    public class LoginFormTestsFUNCTIONALITYandGUI
    {
        [TestMethod]
        // Ensures that when the login button is clicked with valid credentials, the login operation is successful.
        public void LoginButton_Click_WithValidCredentials_ShouldSucceed()
        {
            // Arrange
            var loginForm = new LoginForm();
            loginForm.usernameBoxLogin.Text = "a";
            loginForm.passwordBoxLogin.Text = "a";

            // Act
            loginForm.LoginButton_Click(null, null);

            // Assert
            // Verify that the login was successful
            Assert.IsTrue(loginForm.loginSuccessful);
        }

        [TestMethod]
        // Verifies that when the login button is clicked with an empty username, an error message is shown indicating the invalid input.
        public void LoginButton_Click_WithEmptyUsername_ShouldShowErrorMessage()
        {
            // Arrange
            var loginForm = new LoginForm();
            loginForm.usernameBoxLogin.Text = "";
            loginForm.passwordBoxLogin.Text = "123123!a";

            // Act
            loginForm.LoginButton_Click(null, null);

            // Assert
            // Verify that an error message is shown for empty username
            Assert.IsFalse(loginForm.loginSuccessful);

        }
    }



    [TestClass]
    public class AddCageFormTestsFUNCTIONALITY
    {
        [TestMethod]
        public void AddCageButton_Click_WithValidInput_ShouldAddCageToWorksheet()
        {
            // Arrange
            var addCageForm = new AddCageForm();
            addCageForm.SerialNumberTextBox.Text = "123abdeeeeeee";
            addCageForm.lengthNumeric.Value = 10;
            addCageForm.widthNumeric.Value = 5;
            addCageForm.hightNumeric.Value = 7;
            addCageForm.cageMaterialComboBox.Text = "Iron";
            Range serialNumberRange = null;

            // Act
            addCageForm.AddCageButton_Click(null, null);

            if (addCageForm.serialNumberRange == null)
            {

                
                Application excelApp = new Application();
                Workbook workbook = excelApp.Workbooks.Open(@"C:\Users\vladi\source\repos\FinalQA Project\FinalQA Project\Birds habitat.xlsx");
                Worksheet worksheet = (Worksheet)workbook.Worksheets["Cages"];

                // Verify that the new cage is added to the worksheet
                serialNumberRange = worksheet.Range["A:A"].Find(addCageForm.SerialNumberTextBox.Text, Missing.Value, XlFindLookIn.xlValues, XlLookAt.xlWhole, XlSearchOrder.xlByRows, XlSearchDirection.xlNext, false, Missing.Value, Missing.Value);


                // Get the last used row in the worksheet
                int lastRow = worksheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell).Row;

                // Delete the last row
                Range deleteRange = worksheet.Rows[lastRow];
                deleteRange.Delete(XlDeleteShiftDirection.xlShiftUp);

                // Clean up - close the workbook and release resources
                workbook.Save();
                workbook.Close();
                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);


            }

            // Assert
            Assert.IsNotNull(serialNumberRange, "Cage not found in worksheet");

        }

    }

    [TestClass]
    public class SearchBirdFormTestsFUNCTIONALITY
    {
        [TestMethod]
        // In order to make this test work, we must already have a female bird in the sheet
        // This test simulates a search for birds by gender (female) and asserts that the gender value is equal to "Female".
        public void SearchBirdByGender_Female_ReturnsCorrectResults()
        {
            // Arrange
            SearchBirdForm searchBirdForm = new SearchBirdForm();

            // Simulate selecting the "Gender" option and choosing "Female"
            searchBirdForm.searchOptionComboBox.SelectedItem = "Gender";
            searchBirdForm.GenderComboBox.SelectedItem = "Female";


            // Act
            searchBirdForm.button1_Click(null, null);

            // Assert
            foreach (DataGridViewRow row in searchBirdForm.resultForm.dataGridView2.Rows)
            {
                Assert.AreEqual("Female", row.Cells[4].Value);
            }
        }
    }


    [TestClass()]
    public class SignUpFormTestsGUI
    {
        [TestMethod]
        public void SignUpForm_SignUpButton_Click_InvalidUsername_ErrorMessageBoxShown()
        {
            // Arrange
            var signUpForm = new SignUpForm();

            // Set invalid username and valid password
            signUpForm.usernameBoxSignUp.Text = "aaa";
            signUpForm.passwordBoxSignUp.Text = "aaaaaa2!";

            // Act
            signUpForm.signUpButton_Click(null, null);

            Assert.IsTrue(signUpForm.IsMsg);
        }
    }

    [TestClass()]
    public class AddCageFormTestsGUI
    {
        [TestMethod]
        public void AddCageForm_AddCageButton_Click_NonPositiveLength_ErrorMessageBoxShown()
        {
            // Arrange
            var addCageForm = new AddCageForm();

            addCageForm.SerialNumberTextBox.Text = "1256abcde";
            addCageForm.hightNumeric.Value = 1;
            addCageForm.widthNumeric.Value = 2;
            addCageForm.lengthNumeric.Value = 0;
            addCageForm.cageMaterialComboBox.Text = "Iron";

            // Act
            addCageForm.AddCageButton_Click(null, null);

            // Assert
            Assert.IsTrue(addCageForm.IsMsg);
        }

    }
}