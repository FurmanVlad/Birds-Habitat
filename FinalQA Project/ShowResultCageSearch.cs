using MaterialSkin.Controls;
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
using System.Reflection;

namespace FinalQA_Project
{
    public partial class ShowResultCageSearch : MaterialForm
    {
        public ShowResultCageSearch()
        {
            InitializeComponent();
            dataGridView1.CellContentClick += DataGridView_CellContentClick;
        }
        public void AddRowToDataGridView(object[] rowData)
        {

            if (!dataGridView1.Columns.Contains("Select"))
            {
                DataGridViewButtonColumn selectButtonColumn = new DataGridViewButtonColumn();
                
                selectButtonColumn.Name = "Select";
                selectButtonColumn.HeaderText = "Select";
                dataGridView1.Columns.Add(selectButtonColumn);
            }
            int rowIndex = dataGridView1.Rows.Add(rowData);
            
            dataGridView1.Rows[rowIndex].Cells["Select"].Value = "Select";
            
            
            dataGridView1.Sort(dataGridView1.Columns["SerialNumberCol"], ListSortDirection.Ascending);
        }
        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow clickedRow = dataGridView1.Rows[e.RowIndex];
            object[] rowData = clickedRow.Cells.Cast<DataGridViewCell>()

                                    .Select(cell => cell.Value)
                                    .ToArray();
            
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Select"].Index)
            {
                Console.WriteLine("12345555");
                clickedRow = dataGridView1.Rows[e.RowIndex];
                string serialNumber = clickedRow.Cells["SerialNumberCol"].Value.ToString();
                try
                {
                    // Create a new Excel Application object
                    Application excelApp = new Application();

                    // Open the Excel workbook containing the login information
                    Workbook workbook = excelApp.Workbooks.Open(@"C:\Users\gaiso\OneDrive\Desktop\Birds_Habitat-master\Birds_Habitat-master\FinalQA Project\Birds habitat.xlsx");
                    //
                    // Get the Worksheet object for the sheet containing the login information
                    Worksheet worksheet = (Worksheet)workbook.Worksheets["Birds"];
                    SearchBirdForm searchBirdForm = new SearchBirdForm();
                    SearchBirdFromSheet(worksheet,serialNumber, "F:F");
                    searchBirdForm.ClosingAll(excelApp, workbook, worksheet);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Searching cage: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        }
        public void SearchBirdFromSheet(Worksheet worksheet, string comboBoxPick, string col)
        {
            ShowResultBirdSearch resultForm = new ShowResultBirdSearch(1);

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

            resultForm.Show();
        }
    }
}
