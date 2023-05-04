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
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {       
                    // close any open files or connections, etc.
                    // ...

                    // exit the application
                    Environment.Exit(0);
                }
            }
        }

        private void AddBirdImg_Click(object sender, EventArgs e)
        {
            AddBirdForm addBirdForm = new AddBirdForm();
            addBirdForm.Show();
        }    
    }
}
