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
    public partial class AddCageForm : MaterialForm
    {
        public AddCageForm()
        {
            InitializeComponent();
        }

        private void AddCageButton_Click(object sender, EventArgs e)
        {
            // Capture the data entered by the user
            string cageSerialNumber = SerialNumberTextBox.Text;
            int cageLength = ((int)lengthNumeric.Value);
            int cageWidth = ((int)widthNumeric.Value);
            int cageHight = ((int)hightNumeric.Value);
            string cageMaterial = cageMaterialComboBox.Text;



            // Validate the input data
            bool inputValid = ValidateInputAddCage(cageSerialNumber, cageLength, cageWidth, cageHight, cageMaterial);
            if (!inputValid) { return; }  

            try
            {
                // Create a new Excel Application object
                Application excelApp = new Application();

                // Open the Excel workbook containing the login information
                Workbook workbook = excelApp.Workbooks.Open(@"C:\Users\vladi\Source\Repos\FinalQA Project\FinalQA Project\Birds habitat.xlsx");

                // Get the Worksheet object for the sheet containing the login information
                Worksheet worksheet = (Worksheet)workbook.Worksheets["Cages"];


                // Check if the cage serial number already exists in the worksheet
                Range serialNumberRange = worksheet.Range["A:A"].Find(cageSerialNumber, Missing.Value, XlFindLookIn.xlValues, XlLookAt.xlWhole, XlSearchOrder.xlByRows, XlSearchDirection.xlNext, false, Missing.Value, Missing.Value);
                if (serialNumberRange != null)
                {
                    MessageBox.Show("Error!\nCage Serial number already exists.", "Duplicate cage serial number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Add the new cage to the worksheet
                int lastRow = worksheet.UsedRange.Rows.Count + 1;

                worksheet.Cells[lastRow, 1] = cageSerialNumber;
                worksheet.Cells[lastRow, 2] = cageLength;
                worksheet.Cells[lastRow, 3] = cageWidth;
                worksheet.Cells[lastRow, 4] = cageHight;
                worksheet.Cells[lastRow, 5] = cageMaterial;
  

                // Close the workbook and the Excel application
                workbook.Save();
                workbook.Close();
                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);


                MessageBox.Show("New cage added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding new cage: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private bool ValidateInputAddCage(string cageSerialNumber, int cageLength, int cageWidth, int cageHight, string cageMaterial)
        {

            /////////////////// cageSerialNumber ///////////////////
            if (string.IsNullOrEmpty(cageSerialNumber))
            {
                MessageBox.Show("Please enter cage serial number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Check if the cageSerialNumber is a valid string (letters and numbers)
            if (!AddBirdForm.IsAlphabeticAndNumeric(cageSerialNumber))
            {
                MessageBox.Show("Please enter valid cage serial number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            /////////////////// Cage Size ///////////////////
            if (cageLength.GetType() != typeof(int) || cageWidth.GetType() != typeof(int) || cageHight.GetType() != typeof(int))
            {
                MessageBox.Show("Please enter valid cage size (positive integer).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cageLength==0 || cageWidth==0 || cageHight==0)
            {
                MessageBox.Show("Please enter valid cage size (positive integer).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            /////////////////// Cage Material ///////////////////
            if (string.IsNullOrEmpty(cageMaterial))
            {
                MessageBox.Show("Please enter gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the gender is a valid input
            if (cageMaterial != "Iron" && cageMaterial != "Plastic" && cageMaterial != "Wood")
            {
                MessageBox.Show("Please enter cage material.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



            return true;
        }
    }
}
