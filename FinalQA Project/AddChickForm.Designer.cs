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
            this.AddChickFormPanel = new System.Windows.Forms.Panel();
            this.AddChickFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SerialNumberEditBirdLabel
            // 
            this.SerialNumberEditBirdLabel.AutoSize = true;
            this.SerialNumberEditBirdLabel.BackColor = System.Drawing.Color.Transparent;
            this.SerialNumberEditBirdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialNumberEditBirdLabel.ForeColor = System.Drawing.Color.White;
            this.SerialNumberEditBirdLabel.Location = new System.Drawing.Point(31, 30);
            this.SerialNumberEditBirdLabel.Name = "SerialNumberEditBirdLabel";
            this.SerialNumberEditBirdLabel.Size = new System.Drawing.Size(150, 24);
            this.SerialNumberEditBirdLabel.TabIndex = 39;
            this.SerialNumberEditBirdLabel.Text = "Serial Number:";
            // 
            // SubspeciesComboBox
            // 
            this.SubspeciesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubspeciesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubspeciesComboBox.FormattingEnabled = true;
            this.SubspeciesComboBox.Location = new System.Drawing.Point(31, 187);
            this.SubspeciesComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubspeciesComboBox.Name = "SubspeciesComboBox";
            this.SubspeciesComboBox.Size = new System.Drawing.Size(183, 28);
            this.SubspeciesComboBox.TabIndex = 51;
            // 
            // AddBirdButton
            // 
            this.AddBirdButton.AutoSize = true;
            this.AddBirdButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddBirdButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBirdButton.Depth = 0;
            this.AddBirdButton.Icon = null;
            this.AddBirdButton.Location = new System.Drawing.Point(792, 426);
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
            this.SpeciesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeciesComboBox.FormattingEnabled = true;
            this.SpeciesComboBox.Items.AddRange(new object[] {
            "American Gouldian",
            "European Gouldian",
            "Australian Gouldian"});
            this.SpeciesComboBox.Location = new System.Drawing.Point(31, 120);
            this.SpeciesComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpeciesComboBox.Name = "SpeciesComboBox";
            this.SpeciesComboBox.Size = new System.Drawing.Size(183, 28);
            this.SpeciesComboBox.TabIndex = 50;
            // 
            // SerialNumberTextBox
            // 
            this.SerialNumberTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SerialNumberTextBox.Depth = 0;
            this.SerialNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialNumberTextBox.Hint = "";
            this.SerialNumberTextBox.Location = new System.Drawing.Point(31, 57);
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
            this.CageSerialNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CageSerialNumberTextBox.Hint = "";
            this.CageSerialNumberTextBox.Location = new System.Drawing.Point(31, 400);
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
            this.FatherSerialNumberTextBox.Enabled = false;
            this.FatherSerialNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatherSerialNumberTextBox.Hint = "";
            this.FatherSerialNumberTextBox.Location = new System.Drawing.Point(530, 57);
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
            this.MotherSerialNumberTextBox.Enabled = false;
            this.MotherSerialNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotherSerialNumberTextBox.Hint = "";
            this.MotherSerialNumberTextBox.Location = new System.Drawing.Point(530, 120);
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
            this.MotherSerialNumberAddBirdLabel.BackColor = System.Drawing.Color.Transparent;
            this.MotherSerialNumberAddBirdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotherSerialNumberAddBirdLabel.ForeColor = System.Drawing.Color.White;
            this.MotherSerialNumberAddBirdLabel.Location = new System.Drawing.Point(530, 94);
            this.MotherSerialNumberAddBirdLabel.Name = "MotherSerialNumberAddBirdLabel";
            this.MotherSerialNumberAddBirdLabel.Size = new System.Drawing.Size(236, 24);
            this.MotherSerialNumberAddBirdLabel.TabIndex = 46;
            this.MotherSerialNumberAddBirdLabel.Text = "Mother\'s Serial Number:";
            // 
            // FatherSerialNumberAddBirdLabel
            // 
            this.FatherSerialNumberAddBirdLabel.AutoSize = true;
            this.FatherSerialNumberAddBirdLabel.BackColor = System.Drawing.Color.Transparent;
            this.FatherSerialNumberAddBirdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatherSerialNumberAddBirdLabel.ForeColor = System.Drawing.Color.White;
            this.FatherSerialNumberAddBirdLabel.Location = new System.Drawing.Point(530, 30);
            this.FatherSerialNumberAddBirdLabel.Name = "FatherSerialNumberAddBirdLabel";
            this.FatherSerialNumberAddBirdLabel.Size = new System.Drawing.Size(231, 24);
            this.FatherSerialNumberAddBirdLabel.TabIndex = 45;
            this.FatherSerialNumberAddBirdLabel.Text = "Father\'s Serial Number:";
            // 
            // CageSerialNumberAddBirdLabel
            // 
            this.CageSerialNumberAddBirdLabel.AutoSize = true;
            this.CageSerialNumberAddBirdLabel.BackColor = System.Drawing.Color.Transparent;
            this.CageSerialNumberAddBirdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CageSerialNumberAddBirdLabel.ForeColor = System.Drawing.Color.White;
            this.CageSerialNumberAddBirdLabel.Location = new System.Drawing.Point(31, 365);
            this.CageSerialNumberAddBirdLabel.Name = "CageSerialNumberAddBirdLabel";
            this.CageSerialNumberAddBirdLabel.Size = new System.Drawing.Size(205, 24);
            this.CageSerialNumberAddBirdLabel.TabIndex = 44;
            this.CageSerialNumberAddBirdLabel.Text = "Cage Serial Number:";
            // 
            // GenderAddBirdLabel
            // 
            this.GenderAddBirdLabel.AutoSize = true;
            this.GenderAddBirdLabel.BackColor = System.Drawing.Color.Transparent;
            this.GenderAddBirdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderAddBirdLabel.ForeColor = System.Drawing.Color.White;
            this.GenderAddBirdLabel.Location = new System.Drawing.Point(31, 295);
            this.GenderAddBirdLabel.Name = "GenderAddBirdLabel";
            this.GenderAddBirdLabel.Size = new System.Drawing.Size(86, 24);
            this.GenderAddBirdLabel.TabIndex = 43;
            this.GenderAddBirdLabel.Text = "Gender:";
            // 
            // HatchingDateTimePicker
            // 
            this.HatchingDateTimePicker.CustomFormat = "";
            this.HatchingDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HatchingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HatchingDateTimePicker.Location = new System.Drawing.Point(31, 255);
            this.HatchingDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HatchingDateTimePicker.Name = "HatchingDateTimePicker";
            this.HatchingDateTimePicker.Size = new System.Drawing.Size(259, 26);
            this.HatchingDateTimePicker.TabIndex = 37;
            this.HatchingDateTimePicker.Value = new System.DateTime(2023, 5, 23, 0, 0, 0, 0);
            // 
            // HatchingDateAddBirdLabel
            // 
            this.HatchingDateAddBirdLabel.AutoSize = true;
            this.HatchingDateAddBirdLabel.BackColor = System.Drawing.Color.Transparent;
            this.HatchingDateAddBirdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HatchingDateAddBirdLabel.ForeColor = System.Drawing.Color.White;
            this.HatchingDateAddBirdLabel.Location = new System.Drawing.Point(31, 225);
            this.HatchingDateAddBirdLabel.Name = "HatchingDateAddBirdLabel";
            this.HatchingDateAddBirdLabel.Size = new System.Drawing.Size(147, 24);
            this.HatchingDateAddBirdLabel.TabIndex = 42;
            this.HatchingDateAddBirdLabel.Text = "Hatching Date:";
            // 
            // SubspeciesAddBirdLabel
            // 
            this.SubspeciesAddBirdLabel.AutoSize = true;
            this.SubspeciesAddBirdLabel.BackColor = System.Drawing.Color.Transparent;
            this.SubspeciesAddBirdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubspeciesAddBirdLabel.ForeColor = System.Drawing.Color.White;
            this.SubspeciesAddBirdLabel.Location = new System.Drawing.Point(31, 160);
            this.SubspeciesAddBirdLabel.Name = "SubspeciesAddBirdLabel";
            this.SubspeciesAddBirdLabel.Size = new System.Drawing.Size(125, 24);
            this.SubspeciesAddBirdLabel.TabIndex = 41;
            this.SubspeciesAddBirdLabel.Text = "Subspecies:";
            // 
            // SpeciesAddBirdLabel
            // 
            this.SpeciesAddBirdLabel.AutoSize = true;
            this.SpeciesAddBirdLabel.BackColor = System.Drawing.Color.Transparent;
            this.SpeciesAddBirdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeciesAddBirdLabel.ForeColor = System.Drawing.Color.White;
            this.SpeciesAddBirdLabel.Location = new System.Drawing.Point(31, 94);
            this.SpeciesAddBirdLabel.Name = "SpeciesAddBirdLabel";
            this.SpeciesAddBirdLabel.Size = new System.Drawing.Size(91, 24);
            this.SpeciesAddBirdLabel.TabIndex = 40;
            this.SpeciesAddBirdLabel.Text = "Species:";
            // 
            // SearchFather
            // 
            this.SearchFather.Location = new System.Drawing.Point(795, 57);
            this.SearchFather.Name = "SearchFather";
            this.SearchFather.Size = new System.Drawing.Size(117, 28);
            this.SearchFather.TabIndex = 52;
            this.SearchFather.Text = "Search ";
            this.SearchFather.UseVisualStyleBackColor = true;
            // 
            // SerachMother
            // 
            this.SerachMother.Location = new System.Drawing.Point(795, 120);
            this.SerachMother.Name = "SerachMother";
            this.SerachMother.Size = new System.Drawing.Size(117, 28);
            this.SerachMother.TabIndex = 53;
            this.SerachMother.Text = "Search ";
            this.SerachMother.UseVisualStyleBackColor = true;
            // 
            // BodyColorComboBox
            // 
            this.BodyColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BodyColorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BodyColorComboBox.FormattingEnabled = true;
            this.BodyColorComboBox.Location = new System.Drawing.Point(530, 325);
            this.BodyColorComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BodyColorComboBox.Name = "BodyColorComboBox";
            this.BodyColorComboBox.Size = new System.Drawing.Size(198, 28);
            this.BodyColorComboBox.TabIndex = 59;
            // 
            // BreastColorComboBox
            // 
            this.BreastColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BreastColorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreastColorComboBox.FormattingEnabled = true;
            this.BreastColorComboBox.Items.AddRange(new object[] {
            "White",
            "Lilac",
            "Purple"});
            this.BreastColorComboBox.Location = new System.Drawing.Point(530, 255);
            this.BreastColorComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BreastColorComboBox.Name = "BreastColorComboBox";
            this.BreastColorComboBox.Size = new System.Drawing.Size(198, 28);
            this.BreastColorComboBox.TabIndex = 58;
            // 
            // HeadColorComboBox
            // 
            this.HeadColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HeadColorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadColorComboBox.FormattingEnabled = true;
            this.HeadColorComboBox.Items.AddRange(new object[] {
            "Red",
            "Black",
            "Yellow(Orange)"});
            this.HeadColorComboBox.Location = new System.Drawing.Point(530, 187);
            this.HeadColorComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeadColorComboBox.Name = "HeadColorComboBox";
            this.HeadColorComboBox.Size = new System.Drawing.Size(198, 28);
            this.HeadColorComboBox.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(530, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 56;
            this.label1.Text = "Body Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(530, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 55;
            this.label2.Text = "Breast Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(530, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 54;
            this.label3.Text = "Head Color:";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderComboBox.Location = new System.Drawing.Point(31, 325);
            this.GenderComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(121, 28);
            this.GenderComboBox.TabIndex = 60;
            // 
            // AddChickFormPanel
            // 
            this.AddChickFormPanel.BackgroundImage = global::FinalQA_Project.Properties.Resources.AddBirdForm;
            this.AddChickFormPanel.Controls.Add(this.SpeciesComboBox);
            this.AddChickFormPanel.Controls.Add(this.GenderComboBox);
            this.AddChickFormPanel.Controls.Add(this.SpeciesAddBirdLabel);
            this.AddChickFormPanel.Controls.Add(this.BodyColorComboBox);
            this.AddChickFormPanel.Controls.Add(this.SubspeciesAddBirdLabel);
            this.AddChickFormPanel.Controls.Add(this.BreastColorComboBox);
            this.AddChickFormPanel.Controls.Add(this.HatchingDateAddBirdLabel);
            this.AddChickFormPanel.Controls.Add(this.HeadColorComboBox);
            this.AddChickFormPanel.Controls.Add(this.HatchingDateTimePicker);
            this.AddChickFormPanel.Controls.Add(this.label1);
            this.AddChickFormPanel.Controls.Add(this.GenderAddBirdLabel);
            this.AddChickFormPanel.Controls.Add(this.label2);
            this.AddChickFormPanel.Controls.Add(this.CageSerialNumberAddBirdLabel);
            this.AddChickFormPanel.Controls.Add(this.label3);
            this.AddChickFormPanel.Controls.Add(this.FatherSerialNumberAddBirdLabel);
            this.AddChickFormPanel.Controls.Add(this.SerachMother);
            this.AddChickFormPanel.Controls.Add(this.MotherSerialNumberAddBirdLabel);
            this.AddChickFormPanel.Controls.Add(this.SearchFather);
            this.AddChickFormPanel.Controls.Add(this.MotherSerialNumberTextBox);
            this.AddChickFormPanel.Controls.Add(this.SerialNumberEditBirdLabel);
            this.AddChickFormPanel.Controls.Add(this.FatherSerialNumberTextBox);
            this.AddChickFormPanel.Controls.Add(this.SubspeciesComboBox);
            this.AddChickFormPanel.Controls.Add(this.CageSerialNumberTextBox);
            this.AddChickFormPanel.Controls.Add(this.AddBirdButton);
            this.AddChickFormPanel.Controls.Add(this.SerialNumberTextBox);
            this.AddChickFormPanel.Location = new System.Drawing.Point(0, 64);
            this.AddChickFormPanel.Margin = new System.Windows.Forms.Padding(4);
            this.AddChickFormPanel.Name = "AddChickFormPanel";
            this.AddChickFormPanel.Size = new System.Drawing.Size(960, 514);
            this.AddChickFormPanel.TabIndex = 61;
            // 
            // AddChickForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 576);
            this.Controls.Add(this.AddChickFormPanel);
            this.Name = "AddChickForm";
            this.Text = "AddChickForm";
            this.AddChickFormPanel.ResumeLayout(false);
            this.AddChickFormPanel.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel AddChickFormPanel;
    }
}