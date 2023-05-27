using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using System.Reflection;


namespace FinalQA_Project
{
    public partial class AddChickForm : MaterialForm
    {
        string GenderToSearch;
        public AddChickForm(object[] birdData)
        {
            InitializeComponent();
            SearchFather.Visible = false;
            SerachMother.Visible = false;
            if (birdData[4].ToString() == "Female")
            {
                MotherSerialNumberTextBox.Text = birdData[0].ToString();
                MotherSerialNumberTextBox.Enabled = false;
                SearchFather.Visible = true;
                GenderToSearch = "Male";
                SearchFather.Click += SearchFather_MotherButton_Click;
            }
            else if (birdData[4].ToString() == "Male")
            {
                FatherSerialNumberTextBox.Text = birdData[0].ToString();
                FatherSerialNumberTextBox.Enabled = false;
                SerachMother.Visible = true;
                GenderToSearch = "Female";
                SerachMother.Click += SearchFather_MotherButton_Click;
            }
            CageSerialNumberTextBox.Text = birdData[5].ToString();
            CageSerialNumberTextBox.Enabled = false;
            SpeciesComboBox.SelectedItem = birdData[1]?.ToString();
            SubspeciesComboBox.Items.Add(birdData[2]?.ToString());
            SubspeciesComboBox.Text = birdData[2]?.ToString();
            SubspeciesComboBox.SelectedItem = birdData[2]?.ToString();
            SpeciesComboBox.Enabled = false;
            SubspeciesComboBox.Enabled = false;
            FatherSerialNumberTextBox.TextChanged += FatherMotherTextBox_TextChanged;
            MotherSerialNumberTextBox.TextChanged += FatherMotherTextBox_TextChanged;
            GenderComboBox.SelectedIndexChanged += FatherMotherTextBox_TextChanged;

        }
        Dictionary<string, List<string>> BodyColorMapping = new Dictionary<string, List<string>>() {
            {"Female",new List<string> { "Green","Yellow","Silver","Blue"} },
            {"Male",new List<string>{"Green","Silver","Yellow","Blue","Pastel", "Diluted" } }
        };
        Dictionary<string, List<string>> subspeciesMapping = new Dictionary<string, List<string>>() {
            { "American Gouldian", new List<string> { "North America", "Central America", "South America" } },
            { "European Gouldian", new List<string> { "Eastern Europe", "Western Europe" } },
            { "Australian Gouldian", new List<string> { "Central Australia", "Coastal cities" } }
        };
        private void SearchFather_MotherButton_Click(object sender, EventArgs e)
        {
            // Create a new Excel Application object
            Application excelApp = new Application();

            // Open the Excel workbook containing the login information
            Workbook workbook = excelApp.Workbooks.Open(@"C:\Users\vladi\source\repos\FinalQA Project\FinalQA Project\Birds habitat.xlsx");
            //
            // Get the Worksheet object for the sheet containing the login information
            Worksheet worksheet = (Worksheet)workbook.Worksheets["Birds"];

            ShowResultBirdSearch resultForm = new ShowResultBirdSearch(true);

            Range range = worksheet.Range["E:E"];

            Range foundRange = range.Find(GenderToSearch, Missing.Value, XlFindLookIn.xlValues, XlLookAt.xlWhole, XlSearchOrder.xlByRows, XlSearchDirection.xlNext, false, Missing.Value, Missing.Value);

            if (foundRange != null)
            {
                Range firstCell = foundRange;
                List<object[]> matchingRows = new List<object[]>();

                do
                {
                    int row = firstCell.Row;
                    int columnCount = worksheet.UsedRange.Columns.Count;
                    object[] rowData = new object[columnCount];

                    for (int i = 1; i <= columnCount; i++)
                    {
                        Range dataCell = worksheet.Cells[row, i];
                        rowData[i - 1] = dataCell.Value;
                    }

                    matchingRows.Add(rowData);

                    firstCell = range.FindNext(firstCell);
                }
                while (firstCell != null && firstCell.Address != foundRange.Address);

                foreach (object[] rowData in matchingRows)
                {
                    resultForm.AddRowToDataGridView(rowData);
                }
                ClosingAll(excelApp, workbook, worksheet);
            }
            else
            {
                MessageBox.Show("No birds found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClosingAll(excelApp, workbook, worksheet);
                return;
            }

            resultForm.SerialNumberSelected += (s, serialNumber) =>
            {
                if (SerachMother.Visible)
                {

                    MotherSerialNumberTextBox.Invoke((MethodInvoker)delegate
                    {
                        MotherSerialNumberTextBox.Text = serialNumber;
                    });
                }
                else if (SearchFather.Visible)
                {

                    FatherSerialNumberTextBox.Invoke((MethodInvoker)delegate
                    {
                        FatherSerialNumberTextBox.Text = serialNumber;
                    });
                }

            };
            resultForm.ShowDialog();
            
        }
        private void SpeciesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the items in the "Subspecies" ComboBox
            SubspeciesComboBox.Items.Clear();

            // Get the selected species from the "Species" ComboBox
            string selectedSpecies = SpeciesComboBox.SelectedItem.ToString();

            // Check if the selected species exists in the mapping dictionary
            if (subspeciesMapping.ContainsKey(selectedSpecies))
            {
                // Populate the "Subspecies" ComboBox with the corresponding subspecies
                List<string> subspecies = subspeciesMapping[selectedSpecies];
                SubspeciesComboBox.Items.AddRange(subspecies.ToArray());
            }
        }
        private void FatherMotherTextBox_TextChanged(object sender, EventArgs e)
        {
            object[] FatherRowData;
            object[] MotherRowData;
            string selectedFather = FatherSerialNumberTextBox.Text;
            string selectedMother = MotherSerialNumberTextBox.Text;
            string chickGender = GenderComboBox.SelectedItem?.ToString();
            if (String.IsNullOrEmpty(selectedFather))
            {
                MessageBox.Show("Father is null/empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else if (String.IsNullOrEmpty(selectedFather))
            {
                MessageBox.Show("Mother is null/empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else
            {
                 FatherRowData = SearchForMother_FathersData(selectedFather);
                 MotherRowData = SearchForMother_FathersData(selectedMother);
            }

            if (!string.IsNullOrEmpty(selectedFather) && !string.IsNullOrEmpty(selectedMother) && !string.IsNullOrEmpty(chickGender))
            {
                string fatherHeadColor = FatherRowData[8].ToString();
                string fatherBreastColor = FatherRowData[9].ToString();
                string fatherBodyColor = FatherRowData[10].ToString();
                string motherHeadColor = MotherRowData[8].ToString();
                string motherBreastColor = MotherRowData[9].ToString();
                string motherBodyColor = MotherRowData[10].ToString();

                // Calculate the possible head color options for the chick
                string[] headColors = CalculateHeadColor(fatherHeadColor, motherHeadColor, chickGender);
                string[] breastColors = CalculateBreastColor(fatherBreastColor, motherBreastColor, chickGender);
                string[] bodyColors = CalculateBodyColor(fatherBodyColor, motherBodyColor, chickGender);

                // Clear and populate the ComboBox with the calculated head color options
                HeadColorComboBox.Items.Clear();
                HeadColorComboBox.Items.AddRange(headColors);

                BreastColorComboBox.Items.Clear();
                BreastColorComboBox.Items.AddRange(breastColors);

                BodyColorComboBox.Items.Clear();
                BodyColorComboBox.Items.AddRange(bodyColors);
            }
            else
            {
                // Clear the ComboBoxes if any input is missing
                HeadColorComboBox.Items.Clear();
                BreastColorComboBox.Items.Clear();
                BodyColorComboBox.Items.Clear();
            }

        }
        //but for the fatherBodycolor :  "Green","Silver","Yellow","Blue","Pastel", "Diluted"
        //motherBodycolor : "Green","Yellow","Silver","Blue"
        private string[] CalculateBodyColor(string fatherBodyColor, string motherBodyColor, string chickGender)
        {
            List<string> possibleBodyColors = new List<string>();

            if (chickGender == "Male")
            {
                if (fatherBodyColor == "Green" && motherBodyColor == "Green")
                {
                    possibleBodyColors.Add("Green");
                }
                else if (fatherBodyColor == "Silver" && motherBodyColor == "Silver")
                {
                    possibleBodyColors.Add("Silver");
                }
                else if (fatherBodyColor == "Yellow" && motherBodyColor == "Yellow")
                {
                    possibleBodyColors.Add("Yellow");
                }
                else if (fatherBodyColor == "Blue" && motherBodyColor == "Blue")
                {
                    possibleBodyColors.Add("Blue");
                }
                //Green
                
                else if (fatherBodyColor == "Green" && motherBodyColor == "Silver" || fatherBodyColor == "Silver" && motherBodyColor == "Green")
                {
                    possibleBodyColors.Add("Green");
                    possibleBodyColors.Add("Silver");
                }
                else if (fatherBodyColor == "Green" && motherBodyColor == "Yellow" || fatherBodyColor == "Yellow" && motherBodyColor == "Green")
                {
                    possibleBodyColors.Add("Green");
                    possibleBodyColors.Add("Yellow");
                }
                else if (fatherBodyColor == "Green" && motherBodyColor == "Blue" || fatherBodyColor == "Blue" && motherBodyColor == "Green")
                {
                    possibleBodyColors.Add("Green");
                    possibleBodyColors.Add("Blue");
                }
                
                
                else if (fatherBodyColor == "Silver" && motherBodyColor == "Yellow" || fatherBodyColor == "Yellow" && motherBodyColor == "Silver")
                {
                    possibleBodyColors.Add("Silver");
                    possibleBodyColors.Add("Yellow");
                }
                else if (fatherBodyColor == "Silver" && motherBodyColor == "Blue" || fatherBodyColor == "Blue" && motherBodyColor == "Silver")
                {
                    possibleBodyColors.Add("Silver");
                    possibleBodyColors.Add("Blue");
                }                            
                else if (fatherBodyColor == "Yellow" && motherBodyColor == "Blue" || fatherBodyColor == "Blue" && motherBodyColor == "Yellow")
                {
                    possibleBodyColors.Add("Yellow");
                    possibleBodyColors.Add("Blue");
                }
                
                //Pastel               
                else if (fatherBodyColor == "Pastel" && motherBodyColor == "Green")
                {
                    possibleBodyColors.Add("Green");
                    possibleBodyColors.Add("Pastel");
                }
                else if (fatherBodyColor == "Pastel" && motherBodyColor == "Silver")
                {
                    possibleBodyColors.Add("Silver");
                    possibleBodyColors.Add("Pastel");
                }
                else if (fatherBodyColor == "Pastel" && motherBodyColor == "Yellow")
                {
                    possibleBodyColors.Add("Yellow");
                    possibleBodyColors.Add("Pastel");
                }
                else if (fatherBodyColor == "Pastel" && motherBodyColor == "Blue")
                {
                    possibleBodyColors.Add("Blue");
                    possibleBodyColors.Add("Pastel");
                }
                //Diluted
                else if (fatherBodyColor == "Diluted" && motherBodyColor == "Green")
                {
                    possibleBodyColors.Add("Diluted");
                    possibleBodyColors.Add("Green");
                }              
                else if (fatherBodyColor == "Diluted" && motherBodyColor == "Silver")
                {
                    possibleBodyColors.Add("Diluted");
                    possibleBodyColors.Add("Silver");
                }
                else if (fatherBodyColor == "Diluted" && motherBodyColor == "Yellow")
                {
                    possibleBodyColors.Add("Diluted");
                    possibleBodyColors.Add("Yellow");
                }
                else if (fatherBodyColor == "Diluted" && motherBodyColor == "Blue")
                {
                    possibleBodyColors.Add("Diluted");
                    possibleBodyColors.Add("Blue");
                }
            }
            else if (chickGender == "Female")
            {
                if (fatherBodyColor == "Green")
                {
                    possibleBodyColors.Add("Green");
                }
                else if (fatherBodyColor == "Silver")
                {
                    possibleBodyColors.Add("Silver");
                }
                else if (fatherBodyColor == "Yellow")
                {
                    possibleBodyColors.Add("Yellow");
                }
                else if (fatherBodyColor == "Blue")
                {
                    possibleBodyColors.Add("Blue");
                }
                else if (fatherBodyColor == "Pastel")
                {
                    possibleBodyColors.Add("Pastel");
                }
                else if (fatherBodyColor == "Diluted")
                {
                    possibleBodyColors.Add("Diluted");
                }
            }

            return possibleBodyColors.ToArray();
        }
        private string[] CalculateBreastColor(string fatherChestColor, string motherChestColor, string chickGender)
        {
            List<string> possibleChestColors = new List<string>();

            if (chickGender == "Male")
            {
                if (fatherChestColor == "White" && motherChestColor == "White")
                {
                    possibleChestColors.Add("White");
                }
                else if (fatherChestColor == "Lilac" && motherChestColor == "Lilac")
                {
                    possibleChestColors.Add("Lilac");
                }
                else if (fatherChestColor == "Purple" && motherChestColor == "Purple")
                {
                    possibleChestColors.Add("Purple");
                }
                else if (fatherChestColor == "White" && motherChestColor == "Lilac")
                {
                    possibleChestColors.Add("White");
                    possibleChestColors.Add("Lilac");
                }
                else if (fatherChestColor == "White" && motherChestColor == "Purple")
                {
                    possibleChestColors.Add("White");
                    possibleChestColors.Add("Purple");
                }
                else if (fatherChestColor == "Lilac" && motherChestColor == "White")
                {
                    possibleChestColors.Add("White");
                    possibleChestColors.Add("Lilac");
                }
                else if (fatherChestColor == "Lilac" && motherChestColor == "Purple")
                {
                    possibleChestColors.Add("Lilac");
                    possibleChestColors.Add("Purple");
                }
                else if (fatherChestColor == "Purple" && motherChestColor == "White")
                {
                    possibleChestColors.Add("White");
                    possibleChestColors.Add("Purple");
                }
                else if (fatherChestColor == "Purple" && motherChestColor == "Lilac")
                {
                    possibleChestColors.Add("Lilac");
                    possibleChestColors.Add("Purple");
                }
            }
            else if (chickGender == "Female")
            {
                if (fatherChestColor == "White" && motherChestColor == "White")
                {
                    possibleChestColors.Add("White");
                }
                else if (fatherChestColor == "Lilac" && motherChestColor == "Lilac")
                {
                    possibleChestColors.Add("Lilac");
                }
                else if (fatherChestColor == "Purple" && motherChestColor == "Purple")
                {
                    possibleChestColors.Add("Purple");
                }
                else if (fatherChestColor == "White" && motherChestColor == "Lilac")
                {
                    possibleChestColors.Add("White");
                }
                else if (fatherChestColor == "White" && motherChestColor == "Purple")
                {
                    possibleChestColors.Add("White");
                }
                else if (fatherChestColor == "Lilac" && motherChestColor == "White")
                {
                    possibleChestColors.Add("Lilac");
                }
                else if (fatherChestColor == "Lilac" && motherChestColor == "Purple")
                {
                    possibleChestColors.Add("Lilac");
                }
                else if (fatherChestColor == "Purple" && motherChestColor == "White")
                {
                    possibleChestColors.Add("Purple");
                }
                else if (fatherChestColor == "Purple" && motherChestColor == "Lilac")
                {
                    possibleChestColors.Add("Purple");
                }
            }

            return possibleChestColors.ToArray();
        }
        private string[] CalculateHeadColor(string fatherHeadColor, string motherHeadColor, string chickGender)
        {
            List<string> possibleHeadColors = new List<string>();

            if (chickGender == "Male")
            {
                if (fatherHeadColor == "Black" && motherHeadColor == "Black")
                {
                    possibleHeadColors.Add("Black");
                }
                else if (fatherHeadColor == "Red" && motherHeadColor == "Red")
                {
                    possibleHeadColors.Add("Red");
                }
                else if (fatherHeadColor == "Yellow" && motherHeadColor == "Yellow")
                {
                    possibleHeadColors.Add("Yellow");
                }
                else if ((fatherHeadColor == "Black" && motherHeadColor == "Red") || (fatherHeadColor == "Red" && motherHeadColor == "Black"))
                {
                    possibleHeadColors.Add("Black");
                    possibleHeadColors.Add("Red");
                }
                else if ((fatherHeadColor == "Black" && motherHeadColor == "Yellow") || (fatherHeadColor == "Yellow" && motherHeadColor == "Black"))
                {
                    possibleHeadColors.Add("Black");
                    possibleHeadColors.Add("Yellow");
                }
                else if ((fatherHeadColor == "Red" && motherHeadColor == "Yellow") || (fatherHeadColor == "Yellow" && motherHeadColor == "Red"))
                {
                    possibleHeadColors.Add("Red");
                    possibleHeadColors.Add("Yellow");
                }
            }
            else if (chickGender == "Female")
            {
                if (fatherHeadColor == "Black" && motherHeadColor == "Black")
                {
                    possibleHeadColors.Add("Black");
                }
                else if (fatherHeadColor == "Red" && motherHeadColor == "Red")
                {
                    possibleHeadColors.Add("Red");
                }
                else if (fatherHeadColor == "Yellow" && motherHeadColor == "Yellow")
                {
                    possibleHeadColors.Add("Yellow");
                }
                else if ((fatherHeadColor == "Black" && motherHeadColor == "Red") || (fatherHeadColor == "Red" && motherHeadColor == "Black"))
                {
                    possibleHeadColors.Add("Black");
                }
                else if ((fatherHeadColor == "Black" && motherHeadColor == "Yellow") || (fatherHeadColor == "Yellow" && motherHeadColor == "Black"))
                {
                    possibleHeadColors.Add("Black");
                }
                else if ((fatherHeadColor == "Red" && motherHeadColor == "Yellow") || (fatherHeadColor == "Yellow" && motherHeadColor == "Red"))
                {
                    possibleHeadColors.Add("Red");
                }
            }

            return possibleHeadColors.ToArray();
        }

        public void ClosingAll(Application excelApp, Workbook workbook, Worksheet worksheet)
        {
            workbook.Close();
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);

        }
        public object[] SearchForMother_FathersData(string SerialNumber)
        {
            // Create a new Excel Application object
            Application excelApp = new Application();

            // Open the Excel workbook containing the login information
            Workbook workbook = excelApp.Workbooks.Open(@"C:\Users\vladi\source\repos\FinalQA Project\FinalQA Project\Birds habitat.xlsx");
            //
            // Get the Worksheet object for the sheet containing the login information
            Worksheet worksheet = (Worksheet)workbook.Worksheets["Birds"];

            Range serialNumberRange = worksheet.Range["A:A"].Find(SerialNumber, Missing.Value, XlFindLookIn.xlValues, XlLookAt.xlWhole, XlSearchOrder.xlByRows, XlSearchDirection.xlNext, false, Missing.Value, Missing.Value);
            if (serialNumberRange == null)
            {
                MessageBox.Show("Bird does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClosingAll(excelApp, workbook, worksheet);
                return null;
            }
            else
            {
                int columnCount = worksheet.UsedRange.Columns.Count;
                object[] rowData = new object[columnCount];
                for (int i = 1; i <= columnCount; i++)
                {
                    Range cell = worksheet.Cells[serialNumberRange.Row, i];
                    rowData[i - 1] = cell.Value;
                }

                if (rowData != null)
                {
                    ClosingAll(excelApp, workbook, worksheet);
                    return rowData;
                }
                else
                {
                    MessageBox.Show("Row data is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClosingAll(excelApp, workbook, worksheet);
                    return null;
                }               
            }
        }

        public void AddChickButton_Click(object sender, EventArgs e)
        {
            // Capture the data entered by the user
            string serialNumber = SerialNumberTextBox.Text;
            string species = SpeciesComboBox.Text;
            string subspecies = SubspeciesComboBox.Text;
            DateTime hatchingDate = HatchingDateTimePicker.Value;
            string gender = GenderComboBox.Text;
            string cageSerialNumber = CageSerialNumberTextBox.Text;
            string fatherSerialNumber = FatherSerialNumberTextBox.Text;
            string motherSerialNumber = MotherSerialNumberTextBox.Text;
            string headColor = HeadColorComboBox.Text;
            string breastColor = BreastColorComboBox.Text;
            string bodyColor = BodyColorComboBox.Text;


            // Validate the input data
            bool inputValid = ValidateInput(serialNumber, species, subspecies, gender, cageSerialNumber, fatherSerialNumber, motherSerialNumber, headColor, breastColor, bodyColor);
            if (!inputValid) { return; }

            try
            {
                // Create a new Excel Application object
                Application excelApp = new Application();

                // Open the Excel workbook containing the habitat information
                Workbook workbook = excelApp.Workbooks.Open(@"C:\Users\vladi\source\repos\FinalQA Project\FinalQA Project\Birds habitat.xlsx");

                // Get the Worksheet object for the sheet containing the habitat information
                Worksheet worksheetBird = (Worksheet)workbook.Worksheets["Birds"];
                Worksheet worksheetCage = (Worksheet)workbook.Worksheets["Cages"];



                // Check if the serial number already exists in the worksheet
                Range serialNumberRange = worksheetBird.Range["A:A"].Find(serialNumber, Missing.Value, XlFindLookIn.xlValues, XlLookAt.xlWhole, XlSearchOrder.xlByRows, XlSearchDirection.xlNext, false, Missing.Value, Missing.Value);
                Range cageSerialNumberRange = worksheetCage.Range["A:A"].Find(cageSerialNumber, Missing.Value, XlFindLookIn.xlValues, XlLookAt.xlWhole, XlSearchOrder.xlByRows, XlSearchDirection.xlNext, false, Missing.Value, Missing.Value);

                if (serialNumberRange != null)
                {
                    MessageBox.Show("Error!\nSerial number already exists.", "Duplicate serial number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClosingAll(excelApp, workbook, worksheetBird, worksheetCage);
                    return;
                }

                // Check if the cage serial number exists in the worksheet
                if (cageSerialNumberRange == null)
                {
                    MessageBox.Show("Error!\nCage serial number not exists.", "Invalid cage serial number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClosingAll(excelApp, workbook, worksheetBird, worksheetCage);
                    return;
                }

                // Add the new bird to the worksheet
                int lastRow = worksheetBird.UsedRange.Rows.Count + 1;

                worksheetBird.Cells[lastRow, 1] = serialNumber;
                worksheetBird.Cells[lastRow, 2] = species;
                worksheetBird.Cells[lastRow, 3] = subspecies;
                worksheetBird.Cells[lastRow, 4] = hatchingDate;
                worksheetBird.Cells[lastRow, 5] = gender;
                worksheetBird.Cells[lastRow, 6] = cageSerialNumber;
                worksheetBird.Cells[lastRow, 7] = fatherSerialNumber;
                worksheetBird.Cells[lastRow, 8] = motherSerialNumber;
                worksheetBird.Cells[lastRow, 9] = headColor;
                worksheetBird.Cells[lastRow, 10] = breastColor;
                worksheetBird.Cells[lastRow, 11] = bodyColor;



                // Close the workbook and the Excel application
                ClosingAll(excelApp, workbook, worksheetBird, worksheetCage);


                MessageBox.Show("New bird added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding new bird: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClosingAll(Application excelApp, Workbook workbook, Worksheet worksheetBird, Worksheet worksheetCage)
        {
            workbook.Save();
            workbook.Close();
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheetBird);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheetCage);

        }
       
        private bool ValidateInput(string serialNumber, string species, string subspecies, string gender, string cageSerialNumber, string fatherSerialNumber, string motherSerialNumber, string headColor, string breastColor, string bodyColor)
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
                MessageBox.Show("Please enter valid serial number (numbers only).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            /////////////////// species ///////////////////
            if (string.IsNullOrEmpty(species))
            {
                MessageBox.Show("Please enter species.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            /////////////////// subspecies ///////////////////
            if (string.IsNullOrEmpty(subspecies))
            {
                MessageBox.Show("Please enter subspecies.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }






            /////////////////// hatchingDate ///////////////////





            /////////////////// gender ///////////////////
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please enter gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            /////////////////// cageSerialNumber ///////////////////
            if (string.IsNullOrEmpty(cageSerialNumber))
            {
                MessageBox.Show("Please enter cage serial number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Check if the cageSerialNumber is a valid string (letters and numbers)
            if (!IsAlphabeticAndNumeric(cageSerialNumber))
            {
                MessageBox.Show("Please enter valid cage serial number (letters and numbers only).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please enter valid father's serial number (numbers only).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please enter valid mother's serial number (numbers only).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            // Check if the mothers or fathers serial number different from the bird itself
            if (motherSerialNumber == serialNumber || serialNumber == fatherSerialNumber)
            {
                MessageBox.Show("Parent's serial numbers cannot be the same the as the bird you want to add.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the mothers and the fathers serial number not the same
            if (motherSerialNumber == fatherSerialNumber)
            {
                MessageBox.Show("Parents' serial numbers cannot be the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public static bool IsAlphabeticAndNumeric(string s)
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
        }      
    }
}


// Bird Genetics
// Head Color -> if the Chick is Male( can be the color of Mother/Father) if the chick is Female(the color is of the Father)
// Body Color -> 
// Breast color -> 
