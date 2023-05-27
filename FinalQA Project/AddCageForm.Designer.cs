namespace FinalQA_Project
{
    partial class AddCageForm
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
            this.AddCageFormPanel = new System.Windows.Forms.Panel();
            this.AddCageButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SerialNumberTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cageMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.SerialNumberAddCageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CageSizeAddCageLabel = new System.Windows.Forms.Label();
            this.hightNumeric = new System.Windows.Forms.NumericUpDown();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthNumeric = new System.Windows.Forms.NumericUpDown();
            this.widthLabel = new System.Windows.Forms.Label();
            this.lengthNumeric = new System.Windows.Forms.NumericUpDown();
            this.hightLabel = new System.Windows.Forms.Label();
            this.AddCageFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCageFormPanel
            // 
            this.AddCageFormPanel.BackColor = System.Drawing.Color.White;
            this.AddCageFormPanel.BackgroundImage = global::FinalQA_Project.Properties.Resources.Add_Cage1;
            this.AddCageFormPanel.Controls.Add(this.AddCageButton);
            this.AddCageFormPanel.Controls.Add(this.SerialNumberTextBox);
            this.AddCageFormPanel.Controls.Add(this.cageMaterialComboBox);
            this.AddCageFormPanel.Controls.Add(this.SerialNumberAddCageLabel);
            this.AddCageFormPanel.Controls.Add(this.label1);
            this.AddCageFormPanel.Controls.Add(this.CageSizeAddCageLabel);
            this.AddCageFormPanel.Controls.Add(this.hightNumeric);
            this.AddCageFormPanel.Controls.Add(this.lengthLabel);
            this.AddCageFormPanel.Controls.Add(this.widthNumeric);
            this.AddCageFormPanel.Controls.Add(this.widthLabel);
            this.AddCageFormPanel.Controls.Add(this.lengthNumeric);
            this.AddCageFormPanel.Controls.Add(this.hightLabel);
            this.AddCageFormPanel.Location = new System.Drawing.Point(0, 64);
            this.AddCageFormPanel.Margin = new System.Windows.Forms.Padding(4);
            this.AddCageFormPanel.Name = "AddCageFormPanel";
            this.AddCageFormPanel.Size = new System.Drawing.Size(945, 1000);
            this.AddCageFormPanel.TabIndex = 32;
            // 
            // AddCageButton
            // 
            this.AddCageButton.AutoSize = true;
            this.AddCageButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddCageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCageButton.Depth = 0;
            this.AddCageButton.Icon = null;
            this.AddCageButton.Location = new System.Drawing.Point(806, 125);
            this.AddCageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddCageButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddCageButton.Name = "AddCageButton";
            this.AddCageButton.Primary = true;
            this.AddCageButton.Size = new System.Drawing.Size(104, 36);
            this.AddCageButton.TabIndex = 31;
            this.AddCageButton.Text = "Add cage";
            this.AddCageButton.UseVisualStyleBackColor = true;
            this.AddCageButton.Click += new System.EventHandler(this.AddCageButton_Click);
            // 
            // SerialNumberTextBox
            // 
            this.SerialNumberTextBox.BackColor = System.Drawing.Color.White;
            this.SerialNumberTextBox.Depth = 0;
            this.SerialNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialNumberTextBox.Hint = "";
            this.SerialNumberTextBox.Location = new System.Drawing.Point(32, 127);
            this.SerialNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SerialNumberTextBox.MaxLength = 32767;
            this.SerialNumberTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.SerialNumberTextBox.Name = "SerialNumberTextBox";
            this.SerialNumberTextBox.PasswordChar = '\0';
            this.SerialNumberTextBox.SelectedText = "";
            this.SerialNumberTextBox.SelectionLength = 0;
            this.SerialNumberTextBox.SelectionStart = 0;
            this.SerialNumberTextBox.Size = new System.Drawing.Size(201, 28);
            this.SerialNumberTextBox.TabIndex = 17;
            this.SerialNumberTextBox.TabStop = false;
            this.SerialNumberTextBox.UseSystemPasswordChar = false;
            // 
            // cageMaterialComboBox
            // 
            this.cageMaterialComboBox.BackColor = System.Drawing.Color.White;
            this.cageMaterialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cageMaterialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cageMaterialComboBox.FormattingEnabled = true;
            this.cageMaterialComboBox.Items.AddRange(new object[] {
            "Iron",
            "Wood",
            "Plastic"});
            this.cageMaterialComboBox.Location = new System.Drawing.Point(618, 127);
            this.cageMaterialComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cageMaterialComboBox.Name = "cageMaterialComboBox";
            this.cageMaterialComboBox.Size = new System.Drawing.Size(121, 28);
            this.cageMaterialComboBox.TabIndex = 30;
            // 
            // SerialNumberAddCageLabel
            // 
            this.SerialNumberAddCageLabel.AutoSize = true;
            this.SerialNumberAddCageLabel.BackColor = System.Drawing.Color.Transparent;
            this.SerialNumberAddCageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialNumberAddCageLabel.ForeColor = System.Drawing.Color.White;
            this.SerialNumberAddCageLabel.Location = new System.Drawing.Point(37, 62);
            this.SerialNumberAddCageLabel.Name = "SerialNumberAddCageLabel";
            this.SerialNumberAddCageLabel.Size = new System.Drawing.Size(150, 24);
            this.SerialNumberAddCageLabel.TabIndex = 18;
            this.SerialNumberAddCageLabel.Text = "Serial Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(614, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Cage Material:";
            // 
            // CageSizeAddCageLabel
            // 
            this.CageSizeAddCageLabel.AutoSize = true;
            this.CageSizeAddCageLabel.BackColor = System.Drawing.Color.Transparent;
            this.CageSizeAddCageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CageSizeAddCageLabel.ForeColor = System.Drawing.Color.White;
            this.CageSizeAddCageLabel.Location = new System.Drawing.Point(277, 58);
            this.CageSizeAddCageLabel.Name = "CageSizeAddCageLabel";
            this.CageSizeAddCageLabel.Size = new System.Drawing.Size(108, 24);
            this.CageSizeAddCageLabel.TabIndex = 19;
            this.CageSizeAddCageLabel.Text = "Cage size:";
            // 
            // hightNumeric
            // 
            this.hightNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hightNumeric.Location = new System.Drawing.Point(487, 133);
            this.hightNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hightNumeric.Name = "hightNumeric";
            this.hightNumeric.Size = new System.Drawing.Size(76, 26);
            this.hightNumeric.TabIndex = 28;
            this.hightNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.lengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.ForeColor = System.Drawing.Color.White;
            this.lengthLabel.Location = new System.Drawing.Point(281, 94);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(80, 24);
            this.lengthLabel.TabIndex = 23;
            this.lengthLabel.Text = "Length:";
            // 
            // widthNumeric
            // 
            this.widthNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthNumeric.Location = new System.Drawing.Point(383, 133);
            this.widthNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.widthNumeric.Name = "widthNumeric";
            this.widthNumeric.Size = new System.Drawing.Size(76, 26);
            this.widthNumeric.TabIndex = 27;
            this.widthNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.BackColor = System.Drawing.Color.Transparent;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.ForeColor = System.Drawing.Color.White;
            this.widthLabel.Location = new System.Drawing.Point(379, 94);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(69, 24);
            this.widthLabel.TabIndex = 24;
            this.widthLabel.Text = "Width:";
            // 
            // lengthNumeric
            // 
            this.lengthNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthNumeric.Location = new System.Drawing.Point(285, 133);
            this.lengthNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lengthNumeric.Name = "lengthNumeric";
            this.lengthNumeric.Size = new System.Drawing.Size(76, 26);
            this.lengthNumeric.TabIndex = 26;
            this.lengthNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // hightLabel
            // 
            this.hightLabel.AutoSize = true;
            this.hightLabel.BackColor = System.Drawing.Color.Transparent;
            this.hightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hightLabel.ForeColor = System.Drawing.Color.White;
            this.hightLabel.Location = new System.Drawing.Point(483, 94);
            this.hightLabel.Name = "hightLabel";
            this.hightLabel.Size = new System.Drawing.Size(77, 24);
            this.hightLabel.TabIndex = 25;
            this.hightLabel.Text = "Height:";
            // 
            // AddCageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 1000);
            this.Controls.Add(this.AddCageFormPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCageForm";
            this.Sizable = false;
            this.Text = "AddCageForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YourForm_FormClosing);
            this.AddCageFormPanel.ResumeLayout(false);
            this.AddCageFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SerialNumberAddCageLabel;
        public MaterialSkin.Controls.MaterialSingleLineTextField SerialNumberTextBox;
        private System.Windows.Forms.Label CageSizeAddCageLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label hightLabel;
        public System.Windows.Forms.NumericUpDown lengthNumeric;
        public System.Windows.Forms.NumericUpDown widthNumeric;
        public System.Windows.Forms.NumericUpDown hightNumeric;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cageMaterialComboBox;
        public MaterialSkin.Controls.MaterialRaisedButton AddCageButton;
        private System.Windows.Forms.Panel AddCageFormPanel;
    }
}