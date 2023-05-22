namespace FinalQA_Project
{
    partial class SearchBirdForm
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
            this.SearchBirdSerialTextBox = new System.Windows.Forms.TextBox();
            this.serialNumberSearchBirdLabel = new System.Windows.Forms.Label();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.SpeciesSearchBirdComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePickerSearchBird = new System.Windows.Forms.DateTimePicker();
            this.genderSearchBirdLabel = new System.Windows.Forms.Label();
            this.speciesSearchBirdLabel = new System.Windows.Forms.Label();
            this.hatchDateSearchBirdLabel = new System.Windows.Forms.Label();
            this.searchBirdButton = new System.Windows.Forms.Button();
            this.searchOptionComboBox = new System.Windows.Forms.ComboBox();
            this.chooseSerachOption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchBirdSerialTextBox
            // 
            this.SearchBirdSerialTextBox.Location = new System.Drawing.Point(469, 123);
            this.SearchBirdSerialTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBirdSerialTextBox.Name = "SearchBirdSerialTextBox";
            this.SearchBirdSerialTextBox.Size = new System.Drawing.Size(204, 22);
            this.SearchBirdSerialTextBox.TabIndex = 1;
            this.SearchBirdSerialTextBox.Visible = false;
            // 
            // serialNumberSearchBirdLabel
            // 
            this.serialNumberSearchBirdLabel.AutoSize = true;
            this.serialNumberSearchBirdLabel.Location = new System.Drawing.Point(309, 126);
            this.serialNumberSearchBirdLabel.Name = "serialNumberSearchBirdLabel";
            this.serialNumberSearchBirdLabel.Size = new System.Drawing.Size(127, 16);
            this.serialNumberSearchBirdLabel.TabIndex = 2;
            this.serialNumberSearchBirdLabel.Text = "Enter Serial Number";
            this.serialNumberSearchBirdLabel.Visible = false;
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderComboBox.Location = new System.Drawing.Point(419, 121);
            this.GenderComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(121, 24);
            this.GenderComboBox.TabIndex = 3;
            this.GenderComboBox.Visible = false;
            // 
            // SpeciesSearchBirdComboBox
            // 
            this.SpeciesSearchBirdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpeciesSearchBirdComboBox.FormattingEnabled = true;
            this.SpeciesSearchBirdComboBox.Items.AddRange(new object[] {
            "American Gouldian",
            "European Gouldian",
            "Australian  Gouldian"});
            this.SpeciesSearchBirdComboBox.Location = new System.Drawing.Point(405, 121);
            this.SpeciesSearchBirdComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpeciesSearchBirdComboBox.Name = "SpeciesSearchBirdComboBox";
            this.SpeciesSearchBirdComboBox.Size = new System.Drawing.Size(183, 24);
            this.SpeciesSearchBirdComboBox.TabIndex = 4;
            this.SpeciesSearchBirdComboBox.Visible = false;
            // 
            // dateTimePickerSearchBird
            // 
            this.dateTimePickerSearchBird.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSearchBird.Location = new System.Drawing.Point(405, 123);
            this.dateTimePickerSearchBird.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerSearchBird.Name = "dateTimePickerSearchBird";
            this.dateTimePickerSearchBird.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerSearchBird.TabIndex = 5;
            this.dateTimePickerSearchBird.Value = new System.DateTime(2023, 5, 16, 0, 0, 0, 0);
            this.dateTimePickerSearchBird.Visible = false;
            // 
            // genderSearchBirdLabel
            // 
            this.genderSearchBirdLabel.AutoSize = true;
            this.genderSearchBirdLabel.Location = new System.Drawing.Point(429, 103);
            this.genderSearchBirdLabel.Name = "genderSearchBirdLabel";
            this.genderSearchBirdLabel.Size = new System.Drawing.Size(52, 16);
            this.genderSearchBirdLabel.TabIndex = 6;
            this.genderSearchBirdLabel.Text = "Gender";
            this.genderSearchBirdLabel.Visible = false;
            // 
            // speciesSearchBirdLabel
            // 
            this.speciesSearchBirdLabel.AutoSize = true;
            this.speciesSearchBirdLabel.Location = new System.Drawing.Point(429, 102);
            this.speciesSearchBirdLabel.Name = "speciesSearchBirdLabel";
            this.speciesSearchBirdLabel.Size = new System.Drawing.Size(57, 16);
            this.speciesSearchBirdLabel.TabIndex = 7;
            this.speciesSearchBirdLabel.Text = "Species";
            this.speciesSearchBirdLabel.Visible = false;
            // 
            // hatchDateSearchBirdLabel
            // 
            this.hatchDateSearchBirdLabel.AutoSize = true;
            this.hatchDateSearchBirdLabel.Location = new System.Drawing.Point(429, 103);
            this.hatchDateSearchBirdLabel.Name = "hatchDateSearchBirdLabel";
            this.hatchDateSearchBirdLabel.Size = new System.Drawing.Size(74, 16);
            this.hatchDateSearchBirdLabel.TabIndex = 8;
            this.hatchDateSearchBirdLabel.Text = "Hatch Date";
            this.hatchDateSearchBirdLabel.Visible = false;
            // 
            // searchBirdButton
            // 
            this.searchBirdButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchBirdButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.searchBirdButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchBirdButton.Location = new System.Drawing.Point(323, 313);
            this.searchBirdButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBirdButton.Name = "searchBirdButton";
            this.searchBirdButton.Size = new System.Drawing.Size(128, 46);
            this.searchBirdButton.TabIndex = 9;
            this.searchBirdButton.Text = "Search";
            this.searchBirdButton.UseVisualStyleBackColor = false;
            this.searchBirdButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchOptionComboBox
            // 
            this.searchOptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchOptionComboBox.FormattingEnabled = true;
            this.searchOptionComboBox.Items.AddRange(new object[] {
            "Serial Number",
            "Gender",
            "Hatch Date",
            "Species"});
            this.searchOptionComboBox.Location = new System.Drawing.Point(24, 121);
            this.searchOptionComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchOptionComboBox.Name = "searchOptionComboBox";
            this.searchOptionComboBox.Size = new System.Drawing.Size(199, 24);
            this.searchOptionComboBox.TabIndex = 10;
            this.searchOptionComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // chooseSerachOption
            // 
            this.chooseSerachOption.AutoSize = true;
            this.chooseSerachOption.Location = new System.Drawing.Point(21, 91);
            this.chooseSerachOption.Name = "chooseSerachOption";
            this.chooseSerachOption.Size = new System.Drawing.Size(71, 16);
            this.chooseSerachOption.TabIndex = 11;
            this.chooseSerachOption.Text = "Search by:";
            // 
            // SearchBirdForm
            // 
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YourForm_FormClosing);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chooseSerachOption);
            this.Controls.Add(this.searchOptionComboBox);
            this.Controls.Add(this.searchBirdButton);
            this.Controls.Add(this.hatchDateSearchBirdLabel);
            this.Controls.Add(this.speciesSearchBirdLabel);
            this.Controls.Add(this.genderSearchBirdLabel);
            this.Controls.Add(this.dateTimePickerSearchBird);
            this.Controls.Add(this.SpeciesSearchBirdComboBox);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.serialNumberSearchBirdLabel);
            this.Controls.Add(this.SearchBirdSerialTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchBirdForm";
            this.Sizable = false;
            this.Text = "\'";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchBirdSerialTextBox;
        private System.Windows.Forms.Label serialNumberSearchBirdLabel;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.ComboBox SpeciesSearchBirdComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePickerSearchBird;
        private System.Windows.Forms.Label genderSearchBirdLabel;
        private System.Windows.Forms.Label speciesSearchBirdLabel;
        private System.Windows.Forms.Label hatchDateSearchBirdLabel;
        private System.Windows.Forms.Button searchBirdButton;
        private System.Windows.Forms.ComboBox searchOptionComboBox;
        private System.Windows.Forms.Label chooseSerachOption;
    }
}