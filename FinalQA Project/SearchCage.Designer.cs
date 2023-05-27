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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SerialNumberTextBox = new System.Windows.Forms.TextBox();
            this.SearchCagebutton = new System.Windows.Forms.Button();
            this.SearchCageComboBox = new System.Windows.Forms.ComboBox();
            this.SerialNumberSearchCageLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SearchCageLabel = new System.Windows.Forms.Label();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FinalQA_Project.Properties.Resources.Search_cage_form;
            this.panel1.Controls.Add(this.SerialNumberTextBox);
            this.panel1.Controls.Add(this.SearchCagebutton);
            this.panel1.Controls.Add(this.SearchCageComboBox);
            this.panel1.Controls.Add(this.SerialNumberSearchCageLabel);
            this.panel1.Controls.Add(this.SearchCageLabel);
            this.panel1.Controls.Add(this.MaterialComboBox);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Location = new System.Drawing.Point(1, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 688);
            this.panel1.TabIndex = 11;
            // 
            // SerialNumberTextBox
            // 
            this.SerialNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialNumberTextBox.Location = new System.Drawing.Point(366, 104);
            this.SerialNumberTextBox.Name = "SerialNumberTextBox";
            this.SerialNumberTextBox.Size = new System.Drawing.Size(225, 26);
            this.SerialNumberTextBox.TabIndex = 5;
            // 
            // SearchCagebutton
            // 
            this.SearchCagebutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SearchCagebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SearchCagebutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchCagebutton.Location = new System.Drawing.Point(640, 97);
            this.SearchCagebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchCagebutton.Name = "SearchCagebutton";
            this.SearchCagebutton.Size = new System.Drawing.Size(128, 46);
            this.SearchCagebutton.TabIndex = 10;
            this.SearchCagebutton.Text = "Search";
            this.SearchCagebutton.UseVisualStyleBackColor = false;
            this.SearchCagebutton.Click += new System.EventHandler(this.SearchCagebutton_Click);
            // 
            // SearchCageComboBox
            // 
            this.SearchCageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchCageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCageComboBox.FormattingEnabled = true;
            this.SearchCageComboBox.Items.AddRange(new object[] {
            "Serial Search",
            "Material Search"});
            this.SearchCageComboBox.Location = new System.Drawing.Point(140, 104);
            this.SearchCageComboBox.Name = "SearchCageComboBox";
            this.SearchCageComboBox.Size = new System.Drawing.Size(149, 28);
            this.SearchCageComboBox.TabIndex = 1;
            this.SearchCageComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // SerialNumberSearchCageLabel
            // 
            this.SerialNumberSearchCageLabel.AutoSize = true;
            this.SerialNumberSearchCageLabel.BackColor = System.Drawing.Color.Transparent;
            this.SerialNumberSearchCageLabel.Depth = 0;
            this.SerialNumberSearchCageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.SerialNumberSearchCageLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.SerialNumberSearchCageLabel.Location = new System.Drawing.Point(366, 69);
            this.SerialNumberSearchCageLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.SerialNumberSearchCageLabel.Name = "SerialNumberSearchCageLabel";
            this.SerialNumberSearchCageLabel.Size = new System.Drawing.Size(200, 24);
            this.SerialNumberSearchCageLabel.TabIndex = 6;
            this.SerialNumberSearchCageLabel.Text = "Enter Serial Number";
            // 
            // SearchCageLabel
            // 
            this.SearchCageLabel.AutoSize = true;
            this.SearchCageLabel.BackColor = System.Drawing.Color.Transparent;
            this.SearchCageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCageLabel.ForeColor = System.Drawing.Color.White;
            this.SearchCageLabel.Location = new System.Drawing.Point(137, 69);
            this.SearchCageLabel.Name = "SearchCageLabel";
            this.SearchCageLabel.Size = new System.Drawing.Size(131, 24);
            this.SearchCageLabel.TabIndex = 2;
            this.SearchCageLabel.Text = "Search Cage";
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Items.AddRange(new object[] {
            "Iron",
            "Wood",
            "Plastic"});
            this.MaterialComboBox.Location = new System.Drawing.Point(366, 104);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(147, 28);
            this.MaterialComboBox.TabIndex = 3;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.materialLabel1.ForeColor = System.Drawing.SystemColors.Window;
            this.materialLabel1.Location = new System.Drawing.Point(366, 69);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(161, 24);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Choose Material";
            // 
            // SearchCage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 752);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchCage";
            this.Sizable = false;
            this.Text = "Search cage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YourForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox SearchCageComboBox;
        private System.Windows.Forms.Label SearchCageLabel;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox SerialNumberTextBox;
        private MaterialSkin.Controls.MaterialLabel SerialNumberSearchCageLabel;
        private System.Windows.Forms.Button SearchCagebutton;
        private System.Windows.Forms.Panel panel1;
    }
}