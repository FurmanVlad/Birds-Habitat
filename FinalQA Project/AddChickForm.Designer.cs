namespace FinalQA_Project
{
    partial class AddChickForm
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
        public void InitializeComponent()
        {
            this.SerialNumberEditBirdLabel = new System.Windows.Forms.Label();
            this.SubspeciesComboBox = new System.Windows.Forms.ComboBox();
            this.AddBirdButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SpeciesComboBox = new System.Windows.Forms.ComboBox();
            this.SerialNumberTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CageSerialNumberTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.FatherSerialNumberTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MotherSerialNumberTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MotherSerialNumberAddBirdLabel = new System.Windows.Forms.Label();
            this.FatherSerialNumberAddBirdLabel = new System.Windows.Forms.Label();
            this.CageSerialNumberAddBirdLabel = new System.Windows.Forms.Label();
            this.GenderAddBirdLabel = new System.Windows.Forms.Label();
            this.HatchingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HatchingDateAddBirdLabel = new System.Windows.Forms.Label();
            this.SubspeciesAddBirdLabel = new System.Windows.Forms.Label();
            this.SpeciesAddBirdLabel = new System.Windows.Forms.Label();
            this.SearchFather = new System.Windows.Forms.Button();
            this.SerachMother = new System.Windows.Forms.Button();
            this.BodyColorComboBox = new System.Windows.Forms.ComboBox();
            this.BreastColorComboBox = new System.Windows.Forms.ComboBox();
            this.HeadColorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SerialNumberEditBirdLabel
            // 
            this.SerialNumberEditBirdLabel.AutoSize = true;
            this.SerialNumberEditBirdLabel.BackColor = System.Drawing.SystemColors.Window;
            this.SerialNumberEditBirdLabel.Location = new System.Drawing.Point(74, 104);
            this.SerialNumberEditBirdLabel.Name = "SerialNumberEditBirdLabel";
            this.SerialNumberEditBirdLabel.Size = new System.Drawing.Size(96, 16);
            this.SerialNumberEditBirdLabel.TabIndex = 39;
            this.SerialNumberEditBirdLabel.Text = "Serial Number:";
            // 
            // SubspeciesComboBox
            // 
            this.SubspeciesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubspeciesComboBox.FormattingEnabled = true;
            this.SubspeciesComboBox.Location = new System.Drawing.Point(78, 251);
            this.SubspeciesComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubspeciesComboBox.Name = "SubspeciesComboBox";
            this.SubspeciesComboBox.Size = new System.Drawing.Size(183, 24);
            this.SubspeciesComboBox.TabIndex = 51;
            // 
            // AddBirdButton
            // 
            this.AddBirdButton.AutoSize = true;
            this.AddBirdButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddBirdButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBirdButton.Depth = 0;
            this.AddBirdButton.Icon = null;
            this.AddBirdButton.Location = new System.Drawing.Point(792, 445);
            this.AddBirdButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBirdButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddBirdButton.Name = "AddBirdButton";
            this.AddBirdButton.Primary = true;
            this.AddBirdButton.Size = new System.Drawing.Size(110, 36);
            this.AddBirdButton.TabIndex = 29;
            this.AddBirdButton.Text = "Add Chick";
            this.AddBirdButton.UseVisualStyleBackColor = true;
            this.AddBirdButton.Click += new System.EventHandler(this.AddChickButton_Click);
            // 
            // SpeciesComboBox
            // 
            this.SpeciesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpeciesComboBox.FormattingEnabled = true;
            this.SpeciesComboBox.Items.AddRange(new object[] {
            "American Gouldian",
            "European Gouldian",
            "Australian Gouldian"});
            this.SpeciesComboBox.Location = new System.Drawing.Point(78, 191);
            this.SpeciesComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpeciesComboBox.Name = "SpeciesComboBox";
            this.SpeciesComboBox.Size = new System.Drawing.Size(183, 24);
            this.SpeciesComboBox.TabIndex = 50;
            // 
            // SerialNumberTextBox
            // 
            this.SerialNumberTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SerialNumberTextBox.Depth = 0;
            this.SerialNumberTextBox.Hint = "";
            this.SerialNumberTextBox.Location = new System.Drawing.Point(74, 126);
            this.SerialNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SerialNumberTextBox.MaxLength = 32767;
            this.SerialNumberTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.SerialNumberTextBox.Name = "SerialNumberTextBox";
            this.SerialNumberTextBox.PasswordChar = '\0';
            this.SerialNumberTextBox.SelectedText = "";
            this.SerialNumberTextBox.SelectionLength = 0;
            this.SerialNumberTextBox.SelectionStart = 0;
            this.SerialNumberTextBox.Size = new System.Drawing.Size(259, 28);
            this.SerialNumberTextBox.TabIndex = 30;
            this.SerialNumberTextBox.TabStop = false;
            this.SerialNumberTextBox.UseSystemPasswordChar = false;
            // 
            // CageSerialNumberTextBox
            // 
            this.CageSerialNumberTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CageSerialNumberTextBox.Depth = 0;
            this.CageSerialNumberTextBox.Hint = "";
            this.CageSerialNumberTextBox.Location = new System.Drawing.Point(74, 410);
            this.CageSerialNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CageSerialNumberTextBox.MaxLength = 32767;
            this.CageSerialNumberTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.CageSerialNumberTextBox.Name = "CageSerialNumberTextBox";
            this.CageSerialNumberTextBox.PasswordChar = '\0';
            this.CageSerialNumberTextBox.SelectedText = "";
            this.CageSerialNumberTextBox.SelectionLength = 0;
            this.CageSerialNumberTextBox.SelectionStart = 0;
            this.CageSerialNumberTextBox.Size = new System.Drawing.Size(259, 28);
            this.CageSerialNumberTextBox.TabIndex = 31;
            this.CageSerialNumberTextBox.TabStop = false;
            this.CageSerialNumberTextBox.UseSystemPasswordChar = false;
            // 
            // FatherSerialNumberTextBox
            // 
            this.FatherSerialNumberTextBox.AccessibleName = "FatherSerialNumberTextBox";
            this.FatherSerialNumberTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.FatherSerialNumberTextBox.Depth = 0;
            this.FatherSerialNumberTextBox.Hint = "";
            this.FatherSerialNumberTextBox.Location = new System.Drawing.Point(510, 126);
            this.FatherSerialNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FatherSerialNumberTextBox.MaxLength = 32767;
            this.FatherSerialNumberTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.FatherSerialNumberTextBox.Name = "FatherSerialNumberTextBox";
            this.FatherSerialNumberTextBox.PasswordChar = '\0';
            this.FatherSerialNumberTextBox.SelectedText = "";
            this.FatherSerialNumberTextBox.SelectionLength = 0;
            this.FatherSerialNumberTextBox.SelectionStart = 0;
            this.FatherSerialNumberTextBox.Size = new System.Drawing.Size(259, 28);
            this.FatherSerialNumberTextBox.TabIndex = 32;
            this.FatherSerialNumberTextBox.TabStop = false;
            this.FatherSerialNumberTextBox.UseSystemPasswordChar = false;
            // 
            // MotherSerialNumberTextBox
            // 
            this.MotherSerialNumberTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.MotherSerialNumberTextBox.Depth = 0;
            this.MotherSerialNumberTextBox.Hint = "";
            this.MotherSerialNumberTextBox.Location = new System.Drawing.Point(510, 186);
            this.MotherSerialNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MotherSerialNumberTextBox.MaxLength = 32767;
            this.MotherSerialNumberTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.MotherSerialNumberTextBox.Name = "MotherSerialNumberTextBox";
            this.MotherSerialNumberTextBox.PasswordChar = '\0';
            this.MotherSerialNumberTextBox.SelectedText = "";
            this.MotherSerialNumberTextBox.SelectionLength = 0;
            this.MotherSerialNumberTextBox.SelectionStart = 0;
            this.MotherSerialNumberTextBox.Size = new System.Drawing.Size(259, 28);
            this.MotherSerialNumberTextBox.TabIndex = 33;
            this.MotherSerialNumberTextBox.TabStop = false;
            this.MotherSerialNumberTextBox.UseSystemPasswordChar = false;
            // 
            // MotherSerialNumberAddBirdLabel
            // 
            this.MotherSerialNumberAddBirdLabel.AutoSize = true;
            this.MotherSerialNumberAddBirdLabel.BackColor = System.Drawing.SystemColors.Window;
            this.MotherSerialNumberAddBirdLabel.Location = new System.Drawing.Point(510, 168);
            this.MotherSerialNumberAddBirdLabel.Name = "MotherSerialNumberAddBirdLabel";
            this.MotherSerialNumberAddBirdLabel.Size = new System.Drawing.Size(150, 16);
            this.MotherSerialNumberAddBirdLabel.TabIndex = 46;
            this.MotherSerialNumberAddBirdLabel.Text = "Mother\'s Serial Number:";
            // 
            // FatherSerialNumberAddBirdLabel
            // 
            this.FatherSerialNumberAddBirdLabel.AutoSize = true;
            this.FatherSerialNumberAddBirdLabel.BackColor = System.Drawing.SystemColors.Window;
            this.FatherSerialNumberAddBirdLabel.Location = new System.Drawing.Point(510, 104);
            this.FatherSerialNumberAddBirdLabel.Name = "FatherSerialNumberAddBirdLabel";
            this.FatherSerialNumberAddBirdLabel.Size = new System.Drawing.Size(147, 16);
            this.FatherSerialNumberAddBirdLabel.TabIndex = 45;
            this.FatherSerialNumberAddBirdLabel.Text = "Father\'s Serial Number:";
            // 
            // CageSerialNumberAddBirdLabel
            // 
            this.CageSerialNumberAddBirdLabel.AutoSize = true;
            this.CageSerialNumberAddBirdLabel.BackColor = System.Drawing.SystemColors.Window;
            this.CageSerialNumberAddBirdLabel.Location = new System.Drawing.Point(74, 390);
            this.CageSerialNumberAddBirdLabel.Name = "CageSerialNumberAddBirdLabel";
            this.CageSerialNumberAddBirdLabel.Size = new System.Drawing.Size(132, 16);
            this.CageSerialNumberAddBirdLabel.TabIndex = 44;
            this.CageSerialNumberAddBirdLabel.Text = "Cage Serial Number:";
            // 
            // GenderAddBirdLabel
            // 
            this.GenderAddBirdLabel.AutoSize = true;
            this.GenderAddBirdLabel.BackColor = System.Drawing.SystemColors.Window;
            this.GenderAddBirdLabel.Location = new System.Drawing.Point(74, 340);
            this.GenderAddBirdLabel.Name = "GenderAddBirdLabel";
            this.GenderAddBirdLabel.Size = new System.Drawing.Size(55, 16);
            this.GenderAddBirdLabel.TabIndex = 43;
            this.GenderAddBirdLabel.Text = "Gender:";
            // 
            // HatchingDateTimePicker
            // 
            this.HatchingDateTimePicker.CustomFormat = "";
            this.HatchingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HatchingDateTimePicker.Location = new System.Drawing.Point(74, 309);
            this.HatchingDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HatchingDateTimePicker.Name = "HatchingDateTimePicker";
            this.HatchingDateTimePicker.Size = new System.Drawing.Size(259, 22);
            this.HatchingDateTimePicker.TabIndex = 37;
            this.HatchingDateTimePicker.Value = new System.DateTime(2023, 5, 16, 0, 0, 0, 0);
            // 
            // HatchingDateAddBirdLabel
            // 
            this.HatchingDateAddBirdLabel.AutoSize = true;
            this.HatchingDateAddBirdLabel.BackColor = System.Drawing.SystemColors.Window;
            this.HatchingDateAddBirdLabel.Location = new System.Drawing.Point(74, 289);
            this.HatchingDateAddBirdLabel.Name = "HatchingDateAddBirdLabel";
            this.HatchingDateAddBirdLabel.Size = new System.Drawing.Size(95, 16);
            this.HatchingDateAddBirdLabel.TabIndex = 42;
            this.HatchingDateAddBirdLabel.Text = "Hatching Date:";
            // 
            // SubspeciesAddBirdLabel
            // 
            this.SubspeciesAddBirdLabel.AutoSize = true;
            this.SubspeciesAddBirdLabel.BackColor = System.Drawing.SystemColors.Window;
            this.SubspeciesAddBirdLabel.Location = new System.Drawing.Point(74, 230);
            this.SubspeciesAddBirdLabel.Name = "SubspeciesAddBirdLabel";
            this.SubspeciesAddBirdLabel.Size = new System.Drawing.Size(82, 16);
            this.SubspeciesAddBirdLabel.TabIndex = 41;
            this.SubspeciesAddBirdLabel.Text = "Subspecies:";
            // 
            // SpeciesAddBirdLabel
            // 
            this.SpeciesAddBirdLabel.AutoSize = true;
            this.SpeciesAddBirdLabel.BackColor = System.Drawing.SystemColors.Window;
            this.SpeciesAddBirdLabel.Location = new System.Drawing.Point(74, 168);
            this.SpeciesAddBirdLabel.Name = "SpeciesAddBirdLabel";
            this.SpeciesAddBirdLabel.Size = new System.Drawing.Size(60, 16);
            this.SpeciesAddBirdLabel.TabIndex = 40;
            this.SpeciesAddBirdLabel.Text = "Species:";
            // 
            // SearchFather
            // 
            this.SearchFather.Location = new System.Drawing.Point(792, 126);
            this.SearchFather.Name = "SearchFather";
            this.SearchFather.Size = new System.Drawing.Size(117, 28);
            this.SearchFather.TabIndex = 52;
            this.SearchFather.Text = "Search ";
            this.SearchFather.UseVisualStyleBackColor = true;
            // 
            // SerachMother
            // 
            this.SerachMother.Location = new System.Drawing.Point(792, 186);
            this.SerachMother.Name = "SerachMother";
            this.SerachMother.Size = new System.Drawing.Size(117, 28);
            this.SerachMother.TabIndex = 53;
            this.SerachMother.Text = "Search ";
            this.SerachMother.UseVisualStyleBackColor = true;
            // 
            // BodyColorComboBox
            // 
            this.BodyColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BodyColorComboBox.FormattingEnabled = true;
            this.BodyColorComboBox.Location = new System.Drawing.Point(510, 370);
            this.BodyColorComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BodyColorComboBox.Name = "BodyColorComboBox";
            this.BodyColorComboBox.Size = new System.Drawing.Size(198, 24);
            this.BodyColorComboBox.TabIndex = 59;
            // 
            // BreastColorComboBox
            // 
            this.BreastColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BreastColorComboBox.FormattingEnabled = true;
            this.BreastColorComboBox.Items.AddRange(new object[] {
            "White",
            "Lilac",
            "Purple"});
            this.BreastColorComboBox.Location = new System.Drawing.Point(510, 311);
            this.BreastColorComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BreastColorComboBox.Name = "BreastColorComboBox";
            this.BreastColorComboBox.Size = new System.Drawing.Size(198, 24);
            this.BreastColorComboBox.TabIndex = 58;
            // 
            // HeadColorComboBox
            // 
            this.HeadColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HeadColorComboBox.FormattingEnabled = true;
            this.HeadColorComboBox.Items.AddRange(new object[] {
            "Red",
            "Black",
            "Yellow(Orange)"});
            this.HeadColorComboBox.Location = new System.Drawing.Point(510, 251);
            this.HeadColorComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeadColorComboBox.Name = "HeadColorComboBox";
            this.HeadColorComboBox.Size = new System.Drawing.Size(198, 24);
            this.HeadColorComboBox.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(510, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "Body Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(510, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Breast Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(510, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "Head Color:";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderComboBox.Location = new System.Drawing.Point(78, 364);
            this.GenderComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(121, 24);
            this.GenderComboBox.TabIndex = 60;
            // 
            // AddChickForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 572);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.BodyColorComboBox);
            this.Controls.Add(this.BreastColorComboBox);
            this.Controls.Add(this.HeadColorComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SerachMother);
            this.Controls.Add(this.SearchFather);
            this.Controls.Add(this.SerialNumberEditBirdLabel);
            this.Controls.Add(this.SubspeciesComboBox);
            this.Controls.Add(this.AddBirdButton);
            this.Controls.Add(this.SpeciesComboBox);
            this.Controls.Add(this.SerialNumberTextBox);
            this.Controls.Add(this.CageSerialNumberTextBox);
            this.Controls.Add(this.FatherSerialNumberTextBox);
            this.Controls.Add(this.MotherSerialNumberTextBox);
            this.Controls.Add(this.MotherSerialNumberAddBirdLabel);
            this.Controls.Add(this.FatherSerialNumberAddBirdLabel);
            this.Controls.Add(this.CageSerialNumberAddBirdLabel);
            this.Controls.Add(this.GenderAddBirdLabel);
            this.Controls.Add(this.HatchingDateTimePicker);
            this.Controls.Add(this.HatchingDateAddBirdLabel);
            this.Controls.Add(this.SubspeciesAddBirdLabel);
            this.Controls.Add(this.SpeciesAddBirdLabel);
            this.Name = "AddChickForm";
            this.Text = "AddChickForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SerialNumberEditBirdLabel;
        private System.Windows.Forms.ComboBox SubspeciesComboBox;
        private MaterialSkin.Controls.MaterialRaisedButton AddBirdButton;
        private System.Windows.Forms.ComboBox SpeciesComboBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField SerialNumberTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField CageSerialNumberTextBox;
        public MaterialSkin.Controls.MaterialSingleLineTextField FatherSerialNumberTextBox;
        public MaterialSkin.Controls.MaterialSingleLineTextField MotherSerialNumberTextBox;
        private System.Windows.Forms.Label MotherSerialNumberAddBirdLabel;
        private System.Windows.Forms.Label FatherSerialNumberAddBirdLabel;
        private System.Windows.Forms.Label CageSerialNumberAddBirdLabel;
        private System.Windows.Forms.Label GenderAddBirdLabel;
        private System.Windows.Forms.DateTimePicker HatchingDateTimePicker;
        private System.Windows.Forms.Label HatchingDateAddBirdLabel;
        private System.Windows.Forms.Label SubspeciesAddBirdLabel;
        private System.Windows.Forms.Label SpeciesAddBirdLabel;
        private System.Windows.Forms.Button SearchFather;
        private System.Windows.Forms.Button SerachMother;
        private System.Windows.Forms.ComboBox BodyColorComboBox;
        private System.Windows.Forms.ComboBox BreastColorComboBox;
        private System.Windows.Forms.ComboBox HeadColorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox GenderComboBox;
    }
}