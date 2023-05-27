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
            this.PanelSearchBird = new System.Windows.Forms.Panel();
            this.PanelSearchBird.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchBirdSerialTextBox
            // 
            this.SearchBirdSerialTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBirdSerialTextBox.Location = new System.Drawing.Point(350, 79);
            this.SearchBirdSerialTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBirdSerialTextBox.Name = "SearchBirdSerialTextBox";
            this.SearchBirdSerialTextBox.Size = new System.Drawing.Size(219, 26);
            this.SearchBirdSerialTextBox.TabIndex = 1;
            this.SearchBirdSerialTextBox.Visible = false;
            // 
            // serialNumberSearchBirdLabel
            // 
            this.serialNumberSearchBirdLabel.AutoSize = true;
            this.serialNumberSearchBirdLabel.BackColor = System.Drawing.Color.Transparent;
            this.serialNumberSearchBirdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialNumberSearchBirdLabel.ForeColor = System.Drawing.Color.White;
            this.serialNumberSearchBirdLabel.Location = new System.Drawing.Point(350, 49);
            this.serialNumberSearchBirdLabel.Name = "serialNumberSearchBirdLabel";
            this.serialNumberSearchBirdLabel.Size = new System.Drawing.Size(200, 24);
            this.serialNumberSearchBirdLabel.TabIndex = 2;
            this.serialNumberSearchBirdLabel.Text = "Enter Serial Number";
            this.serialNumberSearchBirdLabel.Visible = false;
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderComboBox.Location = new System.Drawing.Point(350, 79);
            this.GenderComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(121, 28);
            this.GenderComboBox.TabIndex = 3;
            this.GenderComboBox.Visible = false;
            // 
            // SpeciesSearchBirdComboBox
            // 
            this.SpeciesSearchBirdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpeciesSearchBirdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeciesSearchBirdComboBox.FormattingEnabled = true;
            this.SpeciesSearchBirdComboBox.Items.AddRange(new object[] {
            "American Gouldian",
            "European Gouldian",
            "Australian  Gouldian"});
            this.SpeciesSearchBirdComboBox.Location = new System.Drawing.Point(350, 79);
            this.SpeciesSearchBirdComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpeciesSearchBirdComboBox.Name = "SpeciesSearchBirdComboBox";
            this.SpeciesSearchBirdComboBox.Size = new System.Drawing.Size(198, 28);
            this.SpeciesSearchBirdComboBox.TabIndex = 4;
            this.SpeciesSearchBirdComboBox.Visible = false;
            // 
            // dateTimePickerSearchBird
            // 
            this.dateTimePickerSearchBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSearchBird.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSearchBird.Location = new System.Drawing.Point(350, 79);
            this.dateTimePickerSearchBird.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerSearchBird.Name = "dateTimePickerSearchBird";
            this.dateTimePickerSearchBird.Size = new System.Drawing.Size(215, 26);
            this.dateTimePickerSearchBird.TabIndex = 5;
            this.dateTimePickerSearchBird.Value = new System.DateTime(2023, 5, 23, 0, 0, 0, 0);
            this.dateTimePickerSearchBird.Visible = false;
            // 
            // genderSearchBirdLabel
            // 
            this.genderSearchBirdLabel.AutoSize = true;
            this.genderSearchBirdLabel.BackColor = System.Drawing.Color.Transparent;
            this.genderSearchBirdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderSearchBirdLabel.ForeColor = System.Drawing.Color.White;
            this.genderSearchBirdLabel.Location = new System.Drawing.Point(350, 49);
            this.genderSearchBirdLabel.Name = "genderSearchBirdLabel";
            this.genderSearchBirdLabel.Size = new System.Drawing.Size(80, 24);
            this.genderSearchBirdLabel.TabIndex = 6;
            this.genderSearchBirdLabel.Text = "Gender";
            this.genderSearchBirdLabel.Visible = false;
            // 
            // speciesSearchBirdLabel
            // 
            this.speciesSearchBirdLabel.AutoSize = true;
            this.speciesSearchBirdLabel.BackColor = System.Drawing.Color.Transparent;
            this.speciesSearchBirdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speciesSearchBirdLabel.ForeColor = System.Drawing.Color.White;
            this.speciesSearchBirdLabel.Location = new System.Drawing.Point(350, 49);
            this.speciesSearchBirdLabel.Name = "speciesSearchBirdLabel";
            this.speciesSearchBirdLabel.Size = new System.Drawing.Size(85, 24);
            this.speciesSearchBirdLabel.TabIndex = 7;
            this.speciesSearchBirdLabel.Text = "Species";
            this.speciesSearchBirdLabel.Visible = false;
            // 
            // hatchDateSearchBirdLabel
            // 
            this.hatchDateSearchBirdLabel.AutoSize = true;
            this.hatchDateSearchBirdLabel.BackColor = System.Drawing.Color.Transparent;
            this.hatchDateSearchBirdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hatchDateSearchBirdLabel.ForeColor = System.Drawing.Color.White;
            this.hatchDateSearchBirdLabel.Location = new System.Drawing.Point(350, 49);
            this.hatchDateSearchBirdLabel.Name = "hatchDateSearchBirdLabel";
            this.hatchDateSearchBirdLabel.Size = new System.Drawing.Size(112, 24);
            this.hatchDateSearchBirdLabel.TabIndex = 8;
            this.hatchDateSearchBirdLabel.Text = "Hatch Date";
            this.hatchDateSearchBirdLabel.Visible = false;
            // 
            // searchBirdButton
            // 
            this.searchBirdButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchBirdButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.searchBirdButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchBirdButton.Location = new System.Drawing.Point(612, 67);
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
            this.searchOptionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchOptionComboBox.FormattingEnabled = true;
            this.searchOptionComboBox.Items.AddRange(new object[] {
            "Serial Number",
            "Gender",
            "Hatch Date",
            "Species"});
            this.searchOptionComboBox.Location = new System.Drawing.Point(25, 79);
            this.searchOptionComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchOptionComboBox.Name = "searchOptionComboBox";
            this.searchOptionComboBox.Size = new System.Drawing.Size(199, 28);
            this.searchOptionComboBox.TabIndex = 10;
            this.searchOptionComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // chooseSerachOption
            // 
            this.chooseSerachOption.AutoSize = true;
            this.chooseSerachOption.BackColor = System.Drawing.Color.Transparent;
            this.chooseSerachOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseSerachOption.ForeColor = System.Drawing.Color.White;
            this.chooseSerachOption.Location = new System.Drawing.Point(22, 49);
            this.chooseSerachOption.Name = "chooseSerachOption";
            this.chooseSerachOption.Size = new System.Drawing.Size(110, 24);
            this.chooseSerachOption.TabIndex = 11;
            this.chooseSerachOption.Text = "Search by:";
            // 
            // PanelSearchBird
            // 
            this.PanelSearchBird.BackgroundImage = global::FinalQA_Project.Properties.Resources.Search_bird1;
            this.PanelSearchBird.Controls.Add(this.dateTimePickerSearchBird);
            this.PanelSearchBird.Controls.Add(this.chooseSerachOption);
            this.PanelSearchBird.Controls.Add(this.SearchBirdSerialTextBox);
            this.PanelSearchBird.Controls.Add(this.searchOptionComboBox);
            this.PanelSearchBird.Controls.Add(this.serialNumberSearchBirdLabel);
            this.PanelSearchBird.Controls.Add(this.searchBirdButton);
            this.PanelSearchBird.Controls.Add(this.GenderComboBox);
            this.PanelSearchBird.Controls.Add(this.hatchDateSearchBirdLabel);
            this.PanelSearchBird.Controls.Add(this.SpeciesSearchBirdComboBox);
            this.PanelSearchBird.Controls.Add(this.speciesSearchBirdLabel);
            this.PanelSearchBird.Controls.Add(this.genderSearchBirdLabel);
            this.PanelSearchBird.Location = new System.Drawing.Point(0, 63);
            this.PanelSearchBird.Name = "PanelSearchBird";
            this.PanelSearchBird.Size = new System.Drawing.Size(912, 687);
            this.PanelSearchBird.TabIndex = 12;
            // 
            // SearchBirdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 751);
            this.Controls.Add(this.PanelSearchBird);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchBirdForm";
            this.Sizable = false;
            this.Text = "Search bird";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchBirdForm_FormClosing);
            this.PanelSearchBird.ResumeLayout(false);
            this.PanelSearchBird.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox SearchBirdSerialTextBox;
        private System.Windows.Forms.Label serialNumberSearchBirdLabel;
        public System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.ComboBox SpeciesSearchBirdComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePickerSearchBird;
        private System.Windows.Forms.Label genderSearchBirdLabel;
        private System.Windows.Forms.Label speciesSearchBirdLabel;
        private System.Windows.Forms.Label hatchDateSearchBirdLabel;
        private System.Windows.Forms.Button searchBirdButton;
        public System.Windows.Forms.ComboBox searchOptionComboBox;
        private System.Windows.Forms.Label chooseSerachOption;
        private System.Windows.Forms.Panel PanelSearchBird;
    }
}