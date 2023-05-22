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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNumberCol,
            this.LengthCol,
            this.WidthCol,
            this.HeightCol,
            this.CageMaterialCol});
            this.dataGridView1.Location = new System.Drawing.Point(0, 65);
            this.dataGridView1.Name = "dataGridView1";
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
            this.SerialNumberCol.Width = 125;
            // 
            // LengthCol
            // 
            this.LengthCol.HeaderText = "Length";
            this.LengthCol.MinimumWidth = 6;
            this.LengthCol.Name = "LengthCol";
            this.LengthCol.Width = 125;
            // 
            // WidthCol
            // 
            this.WidthCol.HeaderText = "Width";
            this.WidthCol.MinimumWidth = 6;
            this.WidthCol.Name = "WidthCol";
            this.WidthCol.Width = 125;
            // 
            // HeightCol
            // 
            this.HeightCol.HeaderText = "Height";
            this.HeightCol.MinimumWidth = 6;
            this.HeightCol.Name = "HeightCol";
            this.HeightCol.Width = 125;
            // 
            // CageMaterialCol
            // 
            this.CageMaterialCol.HeaderText = "CageMaterial";
            this.CageMaterialCol.MinimumWidth = 6;
            this.CageMaterialCol.Name = "CageMaterialCol";
            this.CageMaterialCol.Width = 125;
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