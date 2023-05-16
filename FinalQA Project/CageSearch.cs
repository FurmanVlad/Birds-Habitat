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
using System.Windows.Media.Media3D;

namespace FinalQA_Project
{

    public partial class CageSearch : MaterialForm
    {
        private Microsoft.Office.Interop.Excel.Application excelApp;
        private Microsoft.Office.Interop.Excel.Workbook workbook;
        private Microsoft.Office.Interop.Excel.Worksheet worksheet;
        private string Material;
        private string SerialNum;


        public CageSearch()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Material = comboBox1.Text;
            SerialNum = comboBox1.Text;
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            excelApp = new Microsoft.Office.Interop.Excel.Application();
            workbook = excelApp.Workbooks.Open(@"C:\לימודים\סמי שמעון שנה ב\בדיקות תוכנה\פרויקט בדיקות\Birds habitat.xlsx");
            worksheet = workbook.Sheets["Cage"];
            if (Material != null)
            {
                string searchTerm = comboBox2.Text;
                Microsoft.Office.Interop.Excel.Range searchRange = worksheet.UsedRange;
                Microsoft.Office.Interop.Excel.Range resultRange = searchRange.Find(searchTerm);

                if (resultRange != null)
                {
                    // You can access the result value using resultRange.Value
                    // For example, you can display it in a MessageBox:
                    MessageBox.Show(resultRange.Value.ToString());
                }
                else
                {
                    MessageBox.Show("Result not found!");
                }
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            workbook.Close();
            excelApp.Quit();

            ReleaseObject(worksheet);
            ReleaseObject(workbook);
            ReleaseObject(excelApp);
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object: " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }


    }
}
