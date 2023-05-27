using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using System.Diagnostics;

namespace FinalQA_Project
{
    public partial class SearchBirdForm : MaterialForm
    {
        public ShowResultBirdSearch resultForm;
        private bool isFatherSearch = false;
        //public DataGridView dataGridView2 = new DataGridView();
        
        public SearchBirdForm()
        {
            InitializeComponent();
            serialNumberSearchBirdLabel.Visible = false;
            SearchBirdSerialTextBox.Visible = false;
            genderSearchBirdLabel.Visible = false;
            GenderComboBox.Visible = false;
            speciesSearchBirdLabel.Visible = false;
            SpeciesSearchBirdComboBox.Visible = false;
            hatchDateSearchBirdLabel.Visible = false;
            dateTimePickerSearchBird.Visible = false;

        }
        public SearchBirdForm(bool IsFatherSearch)
        {
            InitializeComponent();
            serialNumberSearchBirdLabel.Visible = false;
            SearchBirdSerialTextBox.Visible = false;
            genderSearchBirdLabel.Visible = false;
            GenderComboBox.Visible = false;
            speciesSearchBirdLabel.Visible = false;
            SpeciesSearchBirdComboBox.Visible = false;
            hatchDateSearchBirdLabel.Visible = false;
            dateTimePickerSearchBird.Visible = false;
            this.isFatherSearch = IsFatherSearch;
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = searchOptionComboBox.SelectedItem.ToString();
            serialNumberSearchBirdLabel.Visible = false;
            SearchBirdSerialTextBox.Visible = false;
            genderSearchBirdLabel.Visible = false;
            GenderComboBox.Visible = false;
            speciesSearchBirdLabel.Visible = false;
            SpeciesSearchBirdComboBox.Visible = false;
            hatchDateSearchBirdLabel.Visible = false;
            dateTimePickerSearchBird.Visible = false;
           
            if (selectedOption == "Serial Number")
            {
                serialNumberSearchBirdLabel.Visible = true;
                SearchBirdSerialTextBox.Visible = true;             
            }
            else if (selectedOption == "Gender")
            {
                // Show the gender combo box
                genderSearchBirdLabel.Visible = true;
                GenderComboBox.Visible = true;              
            }
            else if (selectedOption == "Species")
            {
               
                speciesSearchBirdLabel.Visible = true;
                SpeciesSearchBirdComboBox.Visible = true;         
            }
            else if (selectedOption == "Hatch Date")
            {         
                hatchDateSearchBirdLabel.Visible = true;
                dateTimePickerSearchBird.Visible = true;
            }
        }
        public void button1_Click(object sender, EventArgs e)
        {
            // Create a new Excel Application object
            Application excelApp = new Application();

            // Open the Excel workbook containing the login information
            Workbook workbook = excelApp.Workbooks.Open(@"C:\Users\vladi\source\repos\FinalQA Project\FinalQA Project\Birds habitat.xlsx");
            //
            // Get the Worksheet object for the sheet containing the login information
            Worksheet worksheet = (Worksheet)workbook.Worksheets["Birds"];
            string selectedOption = searchOptionComboBox.Text;
            if (string.IsNullOrEmpty(selectedOption))
            {
                MessageBox.Show("Please choose search option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClosingAll(excelApp, workbook, worksheet);
                return;
            }
            if (selectedOption == "Serial Number")
            {
                string serialnum = SearchBirdSerialTextBox.Text;

                if (string.IsNullOrEmpty(serialnum))
                {
                    MessageBox.Show("Please enter serial number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClosingAll(excelApp, workbook, worksheet);
                    return;
                }
                Range serialNumberRange = worksheet.Range["A:A"].Find(serialnum, Missing.Value, XlFindLookIn.xlValues, XlLookAt.xlWhole, XlSearchOrder.xlByRows, XlSearchDirection.xlNext, false, Missing.Value, Missing.Value);
                if (serialNumberRange == null)
                {
                    MessageBox.Show("Bird does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClosingAll(excelApp, workbook, worksheet);
                    return;
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
                        ShowResultBirdSearch resultForm = new ShowResultBirdSearch();
                        resultForm.AddRowToDataGridView(rowData);
                        resultForm.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Row data is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClosingAll(excelApp, workbook, worksheet);
                        return;
                    }
                }
            }
            if (selectedOption == "Gender")
            {
                string selectedGender = GenderComboBox.Text;
                if (string.IsNullOrEmpty(selectedGender))
                {
                    MessageBox.Show("Please choose gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClosingAll(excelApp, workbook, worksheet);
                    return;
                }
                SearchBirdFromSheet(worksheet, selectedGender, "E:E");

            }
            if (selectedOption == "Hatch Date")
            {

                string selectedDate = dateTimePickerSearchBird.Text;
                SearchBirdFromSheet(worksheet, selectedDate, "D:D");


            }
            if (selectedOption == "Species")
            {

                string selectedSpecies = SpeciesSearchBirdComboBox.Text;
                if (string.IsNullOrEmpty(selectedSpecies))
                {
                    MessageBox.Show("Please choose species.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClosingAll(excelApp, workbook, worksheet);
                    return;
                }

                SearchBirdFromSheet(worksheet, selectedSpecies, "B:B");
            }

            ClosingAll(excelApp, workbook, worksheet);          
        }
        public void ClosingAll(Application excelApp, Workbook workbook, Worksheet worksheet )
        {
            workbook.Close();
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
        }
        public void SearchBirdFromSheet(Worksheet worksheet, string comboBoxPick,string col) {
            resultForm = new ShowResultBirdSearch();

            Range range = worksheet.Range[col]; 

            Range foundRange = range.Find(comboBoxPick, Missing.Value, XlFindLookIn.xlValues, XlLookAt.xlWhole, XlSearchOrder.xlByRows, XlSearchDirection.xlNext, false, Missing.Value, Missing.Value);
            
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
            }
            else
            {
                MessageBox.Show("No birds found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            resultForm.ShowDialog();           
        }
        private void SearchBirdForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseExcelProcesses();
        }

        private void CloseExcelProcesses()
        {
            // Get all running Excel processes
            Process[] processes = Process.GetProcessesByName("EXCEL");

            // Close each Excel process
            foreach (Process process in processes)
            {
                process.CloseMainWindow();
                process.Close();
            }
        }
    }
 }

