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
using System.Diagnostics;

namespace FinalQA_Project
{
    public partial class SearchCage : MaterialForm
    {

        public SearchCage()
        {
            InitializeComponent();
            materialLabel1.Visible = false;
            materialLabel2.Visible = false;
            SerialNumberTextBox.Visible = false;
            MaterialComboBox.Visible = false;

        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedOption = SearchCageComboBox.SelectedItem.ToString();
            materialLabel1.Visible = false;
            materialLabel2.Visible = false;
            SerialNumberTextBox.Visible = false;
            MaterialComboBox.Visible = false;
            if(selectedOption == "Serial Search")
            {
                materialLabel2.Visible = true;
                SerialNumberTextBox.Visible = true;
            }
            else if (selectedOption == "Material Search")
            {
                materialLabel1.Visible = true;
                MaterialComboBox.Visible = true;
            }

        }
        private void Search_Click(object sender, EventArgs e)
        {
            
            try
            {
                // Create a new Excel Application object
                Application excelApp = new Application();

                // Open the Excel workbook containing the login information
                Workbook workbook = excelApp.Workbooks.Open(@"C:\Users\gaiso\OneDrive\Desktop\Birds_Habitat-master\Birds_Habitat-master\FinalQA Project\Birds habitat.xlsx");
                //
                // Get the Worksheet object for the sheet containing the login information
                Worksheet worksheet = (Worksheet)workbook.Worksheets["Cages"];
                string selectedOption = SearchCageComboBox.Text;
                
                if (string.IsNullOrEmpty(selectedOption))
                {
                    MessageBox.Show("Please choose search option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClosingAll(excelApp, workbook, worksheet);
                    return;
                }
                if(selectedOption == "Serial Search")
                {
                    string serialnum = SerialNumberTextBox.Text;

                    if (string.IsNullOrEmpty(serialnum))
                    {
                        MessageBox.Show("Please enter serial number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClosingAll(excelApp, workbook, worksheet);
                        return;
                    }
                    Range serialNumberRange = worksheet.Range["A:A"].Find(serialnum, Missing.Value, XlFindLookIn.xlValues, XlLookAt.xlWhole, XlSearchOrder.xlByRows, XlSearchDirection.xlNext, false, Missing.Value, Missing.Value);
                    if (serialNumberRange == null)
                    {
                        MessageBox.Show("Cage does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            ShowResultCageSearch resultForm = new ShowResultCageSearch();
                            resultForm.AddRowToDataGridView(rowData);
                            resultForm.Show();

                        }
                        else
                        {
                            MessageBox.Show("Row data is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClosingAll(excelApp, workbook, worksheet);
                            return;
                        }
                    }
                }
                else if(selectedOption == "Material Search")
                {
                    string Materialselctedoption = MaterialComboBox.Text;
                    if (string.IsNullOrEmpty(Materialselctedoption))
                    {
                        MessageBox.Show("Please choose search option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClosingAll(excelApp, workbook, worksheet);
                        return;
                    }
                    else
                    {
                        SearchCageFromSheet(worksheet, Materialselctedoption, "E:E");
                        ClosingAll(excelApp, workbook, worksheet);
                    }
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Searching cage: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void SearchCageFromSheet(Worksheet worksheet, string comboBoxPick, string col)
        {
            ShowResultCageSearch resultForm = new ShowResultCageSearch();

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
                MessageBox.Show("No Cages found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }

            resultForm.Show();
        }
        public void ClosingAll(Application excelApp, Workbook workbook, Worksheet worksheet)
        {
            workbook.Close();
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
        }
        private void YourForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseExcelProcesses();
        }

        private void CloseExcelProcesses()
        {
            MessageBox.Show("Are you sure you want to exit?");
            // Get all running Excel processes
            Process[] processes = Process.GetProcessesByName("EXCEL");

            // Close each Excel process
            foreach (Process process in processes)
            {
                process.CloseMainWindow();
                process.Close();
            }
        }
        //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YourForm_FormClosing);
        //using System.Diagnostics;

    }
}
