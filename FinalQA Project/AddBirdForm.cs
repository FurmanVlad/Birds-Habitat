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
using System.Reflection;

namespace FinalQA_Project
{
    public partial class AddBirdForm : MaterialForm
    {
        public AddBirdForm()
        {
            InitializeComponent();
        }


        private void AddBirdButton_Click(object sender, EventArgs e)
        {
            // Capture the data entered by the user
            string serialNumber = SerialNumberTextBox.Text;
            string species = SpeciesTextBox.Text;
            string subspecies = SubspeciesTextBox.Text;
            DateTime hatchingDate = HatchingDateTimePicker.Value;
            string gender = GenderComboBox.Text;
            string cageSerialNumber = CageSerialNumberTextBox.Text;
            string fatherSerialNumber = FatherSerialNumberTextBox.Text;
            string motherSerialNumber = MotherSerialNumberTextBox.Text;
            string headColor = HeadColorTextBox.Text;
            string breastColor = BreastColorTextBox.Text;
            string bodyColor = BodyColorTextBox.Text;


            // Validate the input data
            bool inputValid = ValidateInput(serialNumber, species, subspecies, hatchingDate, gender, cageSerialNumber, fatherSerialNumber, motherSerialNumber, headColor, breastColor, bodyColor);
            if (!inputValid) { return; }

            try
            {
                // Create a new Excel Application object
                Application excelApp = new Application();

                // Open the Excel workbook containing the login information
                Workbook workbook = excelApp.Workbooks.Open(@"C:\לימודים\סמי שמעון שנה ב\בדיקות תוכנה\פרויקט בדיקות\Birds habitat.xlsx");

                // Get the Worksheet object for the sheet containing the login information
                Worksheet worksheet = (Worksheet)workbook.Worksheets["Birds"];


                // Check if the serial number already exists in the worksheet
                Range serialNumberRange = worksheet.Range["A:A"].Find(serialNumber, Missing.Value, XlFindLookIn.xlValues, XlLookAt.xlWhole, XlSearchOrder.xlByRows, XlSearchDirection.xlNext, false, Missing.Value, Missing.Value);
                if (serialNumberRange != null)
                {
                    MessageBox.Show("Error!\nSerial number already exists.", "Duplicate serial number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Add the new bird to the worksheet
                int lastRow = worksheet.UsedRange.Rows.Count + 1;

                worksheet.Cells[lastRow, 1] = serialNumber;
                worksheet.Cells[lastRow, 2] = species;
                worksheet.Cells[lastRow, 3] = subspecies;
                worksheet.Cells[lastRow, 4] = hatchingDate;
                worksheet.Cells[lastRow, 5] = gender;
                worksheet.Cells[lastRow, 6] = cageSerialNumber;
                worksheet.Cells[lastRow, 7] = fatherSerialNumber;
                worksheet.Cells[lastRow, 8] = motherSerialNumber;
                worksheet.Cells[lastRow, 9] = headColor;
                worksheet.Cells[lastRow, 10] = breastColor;
                worksheet.Cells[lastRow, 11] = bodyColor;


                // Close the workbook and the Excel application
                workbook.Save();
                workbook.Close();
                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);


                MessageBox.Show("New bird added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding new bird: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput(string serialNumber, string species, string subspecies, DateTime hatchingDate, string gender, string cageSerialNumber, string fatherSerialNumber, string motherSerialNumber, string headColor, string breastColor, string bodyColor)
        {

            /////////////////// serialNumber ///////////////////
            if (string.IsNullOrEmpty(serialNumber))
            {
                MessageBox.Show("Please enter serial number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the serial number is a valid integer
            if (!IsNumeric(serialNumber))
            {
                MessageBox.Show("Please enter valid serial number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }




            /////////////////// species ///////////////////
            if (string.IsNullOrEmpty(species))
            {
                MessageBox.Show("Please enter species.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the species is a valid string (only letters)
            if (!IsAlphabetic(species))
            {
                MessageBox.Show("Please enter valid species.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }




            /////////////////// subspecies ///////////////////
            if (string.IsNullOrEmpty(subspecies))
            {
                MessageBox.Show("Please enter subspecies.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the species is a valid string (only letters)
            if (!IsAlphabetic(subspecies))
            {
                MessageBox.Show("Please enter valid subspecies.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }




            /////////////////// hatchingDate ///////////////////





            /////////////////// gender ///////////////////
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please enter gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the gender is a valid input
            if (gender != "Male" && gender != "Female")
            {
                MessageBox.Show("Please enter valid gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }




            /////////////////// cageSerialNumber ///////////////////
            if (string.IsNullOrEmpty(cageSerialNumber))
            {
                MessageBox.Show("Please enter cageSerialNumber.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Check if the species is a valid string (only letters)
            if (!IsAlphabeticAndNumeric(cageSerialNumber))
            {
                MessageBox.Show("Please enter valid cageSerialNumber.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }




            /////////////////// fatherSerialNumber ///////////////////
            if (string.IsNullOrEmpty(fatherSerialNumber))
            {
                MessageBox.Show("Please enter father's serial number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the serial number is a valid integer
            if (!IsNumeric(fatherSerialNumber))
            {
                MessageBox.Show("Please enter valid father's serial number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }





            /////////////////// motherSerialNumber ///////////////////
            if (string.IsNullOrEmpty(motherSerialNumber))
            {
                MessageBox.Show("Please enter mother's serial number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the serial number is a valid integer
            if (!IsNumeric(motherSerialNumber))
            {
                MessageBox.Show("Please enter valid mother's serial number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }




            /////////////////// headColor ///////////////////
            if (string.IsNullOrEmpty(headColor))
            {
                MessageBox.Show("Please enter head color.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }





            /////////////////// breastColor ///////////////////
            if (string.IsNullOrEmpty(breastColor))
            {
                MessageBox.Show("Please enter breast color.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }





            /////////////////// bodyColor ///////////////////
            if (string.IsNullOrEmpty(bodyColor))
            {
                MessageBox.Show("Please enter body color.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }




            return true;
        }


        // Returns true if the input string contains only alphabetical characters
        public bool IsAlphabetic(string s)
        {
            if (s == null || s.Length == 0) return false;
            foreach (char c in s)
            {
                if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
                {
                    return false;
                }
            }
            return true;
        }

        // Returns true if the input string contains only numeric characters
        public bool IsNumeric(string s)
        {
            if (s == null || s.Length == 0) return false;
            foreach (char c in s)
            {
                if (!(c >= '0' && c <= '9'))
                {
                    return false;
                }
            }
            return true;
        }


        // Returns true if the input string contains only alphabetical characters and numeric characters
        public bool IsAlphabeticAndNumeric(string s)
        {
            if (s == null || s.Length < 1) return false;

            bool hasLetter = false;
            bool hasNumber = false;

            foreach (char c in s)
            {
                if (Char.IsLetter(c))
                {
                    hasLetter = true;
                }
                else if (Char.IsDigit(c))
                {
                    hasNumber = true;
                }
                else
                {
                    // If a character is not a letter or a number, the input is invalid
                    return false;
                }
            }

            return hasLetter && hasNumber;


            //if (s == null || s.Length < 1) return false;
            //foreach (char c in s)
            //{
            //    if (((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9')))
            //    {
            //        return false;
            //    }
            //}
            //return true;
        }


    }

}
