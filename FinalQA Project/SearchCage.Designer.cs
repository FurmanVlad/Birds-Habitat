namespace FinalQA_Project
{
    partial class SearchCage
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
            this.SearchCagebutton = new System.Windows.Forms.Button();
            this.SearchCageComboBox = new System.Windows.Forms.ComboBox();
            this.SearchCageLabel = new System.Windows.Forms.Label();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SerialNumberTextBox = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // SearchCagebutton
            // 
            this.SearchCagebutton.Location = new System.Drawing.Point(636, 351);
            this.SearchCagebutton.Name = "SearchCagebutton";
            this.SearchCagebutton.Size = new System.Drawing.Size(96, 39);
            this.SearchCagebutton.TabIndex = 0;
            this.SearchCagebutton.Text = "Search";
            this.SearchCagebutton.UseVisualStyleBackColor = true;
            this.SearchCagebutton.Click += new System.EventHandler(this.Search_Click);
            // 
            // SearchCageComboBox
            // 
            this.SearchCageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchCageComboBox.FormattingEnabled = true;
            this.SearchCageComboBox.Items.AddRange(new object[] {
            "Serial Search",
            "Material Search"});
            this.SearchCageComboBox.Location = new System.Drawing.Point(21, 123);
            this.SearchCageComboBox.Name = "SearchCageComboBox";
            this.SearchCageComboBox.Size = new System.Drawing.Size(149, 24);
            this.SearchCageComboBox.TabIndex = 1;
            this.SearchCageComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // SearchCageLabel
            // 
            this.SearchCageLabel.AutoSize = true;
            this.SearchCageLabel.Location = new System.Drawing.Point(18, 88);
            this.SearchCageLabel.Name = "SearchCageLabel";
            this.SearchCageLabel.Size = new System.Drawing.Size(86, 16);
            this.SearchCageLabel.TabIndex = 2;
            this.SearchCageLabel.Text = "Search Cage";
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Items.AddRange(new object[] {
            "Iron",
            "Wood",
            "Plastic"});
            this.MaterialComboBox.Location = new System.Drawing.Point(248, 123);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(147, 24);
            this.MaterialComboBox.TabIndex = 3;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(247, 88);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(148, 24);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Choose Material";
            // 
            // SerialNumberTextBox
            // 
            this.SerialNumberTextBox.Location = new System.Drawing.Point(241, 125);
            this.SerialNumberTextBox.Name = "SerialNumberTextBox";
            this.SerialNumberTextBox.Size = new System.Drawing.Size(225, 22);
            this.SerialNumberTextBox.TabIndex = 5;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(237, 89);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(178, 24);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Enter Serial Number";
            // 
            // SearchCage
            // 
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YourForm_FormClosing);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.SerialNumberTextBox);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.MaterialComboBox);
            this.Controls.Add(this.SearchCageLabel);
            this.Controls.Add(this.SearchCageComboBox);
            this.Controls.Add(this.SearchCagebutton);
            this.Name = "SearchCage";
            this.Text = "SearchCage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchCagebutton;
        private System.Windows.Forms.ComboBox SearchCageComboBox;
        private System.Windows.Forms.Label SearchCageLabel;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox SerialNumberTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}