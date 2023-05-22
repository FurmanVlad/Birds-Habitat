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
    public partial class ShowResultBirdSearch : MaterialForm
    {
        public string SelectedSerialNumber { get; private set; }
        public event EventHandler<string> SerialNumberSelected;
        int ClickedRow;
        String EditRowSN;
        bool GenderSearch;
        int cageSearch = -1;
        public ShowResultBirdSearch(int cagesearch)
        {
            InitializeComponent();
            dataGridView2.CellContentClick += DataGridView_CellContentClick;
            this.GenderSearch = false;
            cageSearch = cagesearch;
        }
        public ShowResultBirdSearch()
        {
             InitializeComponent();          
            dataGridView2.CellContentClick += DataGridView_CellContentClick;
            this.GenderSearch = false;
            cageSearch = -1;
        }
        public ShowResultBirdSearch(bool genderSearch)
        {
            InitializeComponent();
            dataGridView2.CellContentClick += DataGridView_CellContentClick;
            this.GenderSearch = genderSearch;
            cageSearch = -1;
        }
        public void AddRowToDataGridViewFromCage(object[] rowdata)
        {
            dataGridView2.Rows.Add(rowdata);
            dataGridView2.Sort(dataGridView2.Columns["SerialNumber"], ListSortDirection.Ascending);
        }
        public void AddRowToDataGridView(object[] rowData)
        {
            if (cageSearch == -1)
            {
                if (GenderSearch)
                {
                    if (!dataGridView2.Columns.Contains("Select"))
                    {
                        DataGridViewButtonColumn selectButtonColumn = new DataGridViewButtonColumn();
                        selectButtonColumn.Name = "Select";
                        selectButtonColumn.HeaderText = "Select";
                        dataGridView2.Columns.Add(selectButtonColumn);
                    }
                }
                else
                {
                    if (!dataGridView2.Columns.Contains("Edit"))
                    {
                        DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                        editButtonColumn.Name = "Edit";
                        editButtonColumn.HeaderText = "Edit";
                        dataGridView2.Columns.Add(editButtonColumn);
                    }

                    if (!dataGridView2.Columns.Contains("AddChick"))
                    {
                        DataGridViewButtonColumn addBabyBirdButtonColumn = new DataGridViewButtonColumn();
                        addBabyBirdButtonColumn.Name = "AddChick";
                        addBabyBirdButtonColumn.HeaderText = "Add Chick";
                        dataGridView2.Columns.Add(addBabyBirdButtonColumn);
                    }
                }
                int rowIndex = dataGridView2.Rows.Add(rowData);
                if (GenderSearch)
                {
                    dataGridView2.Rows[rowIndex].Cells["Select"].Value = "Select";
                }
                else
                {
                    dataGridView2.Rows[rowIndex].Cells["Edit"].Value = "Edit";
                    dataGridView2.Rows[rowIndex].Cells["AddChick"].Value = "Add Chick";
                }

                dataGridView2.Sort(dataGridView2.Columns["SerialNumber"], ListSortDirection.Ascending);
            }
            else if (cageSearch == 1)
            {
                dataGridView2.Rows.Add(rowData);
                dataGridView2.Sort(dataGridView2.Columns["SerialNumber"], ListSortDirection.Ascending);
            }
        }
        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow clickedRow = dataGridView2.Rows[e.RowIndex];
            object[] rowData = clickedRow.Cells.Cast<DataGridViewCell>()

                                    .Select(cell => cell.Value)
                                    .ToArray();
            if (!GenderSearch)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView2.Columns.Count - 2)
                {                  
                    EditRowSN = rowData[0].ToString();
                    ClickedRow = e.RowIndex;

                    // Open the EditBirdForm and pass the row data
                    EditBirdForm editForm = new EditBirdForm(rowData, this);
                    editForm.FormClosed += EditForm_FormClosed;
                    editForm.ShowDialog();
                }
                else if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView2.Columns.Count - 1)
                {                   
                    AddChickForm chickForm = new AddChickForm(rowData);
                    chickForm.Show();
                }
            }
            else
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView2.Columns["Select"].Index)
                {
                    
                    clickedRow = dataGridView2.Rows[e.RowIndex];
                    string serialNumber = clickedRow.Cells["SerialNumber"].Value.ToString();                  
                    SelectedSerialNumber = serialNumber;
                    SerialNumberSelected?.Invoke(this, SelectedSerialNumber);                  
                    Close();

                }
            }            
        }        
        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
       {
            // Create a new Excel Application object
            Application excelApp = new Application();

            // Open the Excel workbook containing the login information
            Workbook workbook = excelApp.Workbooks.Open(@"C:\Users\gaiso\OneDrive\Desktop\Birds_Habitat-master\Birds_Habitat-master\FinalQA Project\Birds habitat.xlsx");
            //
            // Get the Worksheet object for the sheet containing the login information
            Worksheet worksheet = (Worksheet)workbook.Worksheets["Birds"];
            Range serialNumberRange = worksheet.Range["A:A"].Find(EditRowSN, Missing.Value, XlFindLookIn.xlValues, XlLookAt.xlWhole, XlSearchOrder.xlByRows, XlSearchDirection.xlNext, false, Missing.Value, Missing.Value);
            int columnCount = worksheet.UsedRange.Columns.Count;
            object[] rowData = new object[columnCount];
            for (int i = 1; i <= columnCount; i++)
            {
                Range cell = worksheet.Cells[serialNumberRange.Row, i];
                dataGridView2.Rows[ClickedRow].Cells[i-1].Value = cell.Value;
            }
            workbook.Close();
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);

        }
      
    }
}
