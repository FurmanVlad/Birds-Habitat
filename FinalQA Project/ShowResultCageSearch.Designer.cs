namespace FinalQA_Project
{
    partial class ShowResultCageSearch
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SerialNumberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LengthCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WidthCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeightCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CageMaterialCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNumberCol,
            this.LengthCol,
            this.WidthCol,
            this.HeightCol,
            this.CageMaterialCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 524);
            this.dataGridView1.TabIndex = 0;
            // 
            // SerialNumberCol
            // 
            this.SerialNumberCol.HeaderText = "Serial Number";
            this.SerialNumberCol.MinimumWidth = 6;
            this.SerialNumberCol.Name = "SerialNumberCol";
            this.SerialNumberCol.ReadOnly = true;
            this.SerialNumberCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SerialNumberCol.Width = 120;
            // 
            // LengthCol
            // 
            this.LengthCol.HeaderText = "Length";
            this.LengthCol.MinimumWidth = 6;
            this.LengthCol.Name = "LengthCol";
            this.LengthCol.ReadOnly = true;
            this.LengthCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LengthCol.Width = 70;
            // 
            // WidthCol
            // 
            this.WidthCol.HeaderText = "Width";
            this.WidthCol.MinimumWidth = 6;
            this.WidthCol.Name = "WidthCol";
            this.WidthCol.ReadOnly = true;
            this.WidthCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.WidthCol.Width = 61;
            // 
            // HeightCol
            // 
            this.HeightCol.HeaderText = "Height";
            this.HeightCol.MinimumWidth = 6;
            this.HeightCol.Name = "HeightCol";
            this.HeightCol.ReadOnly = true;
            this.HeightCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HeightCol.Width = 68;
            // 
            // CageMaterialCol
            // 
            this.CageMaterialCol.HeaderText = "CageMaterial";
            this.CageMaterialCol.MinimumWidth = 6;
            this.CageMaterialCol.Name = "CageMaterialCol";
            this.CageMaterialCol.ReadOnly = true;
            this.CageMaterialCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CageMaterialCol.Width = 124;
            // 
            // ShowResultCageSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 587);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowResultCageSearch";
            this.Text = "ShowResultCageSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumberCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LengthCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn WidthCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeightCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CageMaterialCol;
    }
}