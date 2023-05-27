namespace FinalQA_Project
{
    partial class ShowResultBirdSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Species = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subspecies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_of_hatching = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cage_serial_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Father_serial_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mothers_serial_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Head_Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Breast_Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Body_Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNumber,
            this.Species,
            this.Subspecies,
            this.Date_of_hatching,
            this.Gender,
            this.Cage_serial_number,
            this.Father_serial_number,
            this.Mothers_serial_number,
            this.Head_Color,
            this.Breast_Color,
            this.Body_Color});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(1, 63);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1452, 527);
            this.dataGridView2.TabIndex = 0;
            // 
            // SerialNumber
            // 
            this.SerialNumber.HeaderText = "SerialNumber";
            this.SerialNumber.MinimumWidth = 6;
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            this.SerialNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SerialNumber.Width = 127;
            // 
            // Species
            // 
            this.Species.HeaderText = "Species";
            this.Species.MinimumWidth = 6;
            this.Species.Name = "Species";
            this.Species.ReadOnly = true;
            this.Species.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Species.Width = 80;
            // 
            // Subspecies
            // 
            this.Subspecies.HeaderText = "Subspecies";
            this.Subspecies.MinimumWidth = 6;
            this.Subspecies.Name = "Subspecies";
            this.Subspecies.ReadOnly = true;
            this.Subspecies.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Subspecies.Width = 110;
            // 
            // Date_of_hatching
            // 
            this.Date_of_hatching.HeaderText = "Date_of_hatching";
            this.Date_of_hatching.MinimumWidth = 6;
            this.Date_of_hatching.Name = "Date_of_hatching";
            this.Date_of_hatching.ReadOnly = true;
            this.Date_of_hatching.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Date_of_hatching.Width = 160;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Gender.Width = 74;
            // 
            // Cage_serial_number
            // 
            this.Cage_serial_number.HeaderText = "Cage_serial_number";
            this.Cage_serial_number.MinimumWidth = 6;
            this.Cage_serial_number.Name = "Cage_serial_number";
            this.Cage_serial_number.ReadOnly = true;
            this.Cage_serial_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cage_serial_number.Width = 185;
            // 
            // Father_serial_number
            // 
            this.Father_serial_number.HeaderText = "Father_serial_number";
            this.Father_serial_number.MinimumWidth = 6;
            this.Father_serial_number.Name = "Father_serial_number";
            this.Father_serial_number.ReadOnly = true;
            this.Father_serial_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Father_serial_number.Width = 196;
            // 
            // Mothers_serial_number
            // 
            this.Mothers_serial_number.HeaderText = "Mothers_serial_number";
            this.Mothers_serial_number.MinimumWidth = 6;
            this.Mothers_serial_number.Name = "Mothers_serial_number";
            this.Mothers_serial_number.ReadOnly = true;
            this.Mothers_serial_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Mothers_serial_number.Width = 210;
            // 
            // Head_Color
            // 
            this.Head_Color.HeaderText = "Head_Color";
            this.Head_Color.MinimumWidth = 6;
            this.Head_Color.Name = "Head_Color";
            this.Head_Color.ReadOnly = true;
            this.Head_Color.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Head_Color.Width = 112;
            // 
            // Breast_Color
            // 
            this.Breast_Color.HeaderText = "Breast_Color";
            this.Breast_Color.MinimumWidth = 6;
            this.Breast_Color.Name = "Breast_Color";
            this.Breast_Color.ReadOnly = true;
            this.Breast_Color.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Breast_Color.Width = 124;
            // 
            // Body_Color
            // 
            this.Body_Color.HeaderText = "Body_Color";
            this.Body_Color.MinimumWidth = 6;
            this.Body_Color.Name = "Body_Color";
            this.Body_Color.ReadOnly = true;
            this.Body_Color.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Body_Color.Width = 110;
            // 
            // ShowResultBirdSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 588);
            this.Controls.Add(this.dataGridView2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowResultBirdSearch";
            this.Sizable = false;
            this.Text = "ShowResultBirdSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Species;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subspecies;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_of_hatching;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cage_serial_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Father_serial_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mothers_serial_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Head_Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Breast_Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Body_Color;
    }
}