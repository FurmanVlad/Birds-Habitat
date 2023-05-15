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
            this.SerialNumberAddCageLabel = new System.Windows.Forms.Label();
            this.SerialNumberTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CageSizeAddCageLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.hightLabel = new System.Windows.Forms.Label();
            this.lengthNumeric = new System.Windows.Forms.NumericUpDown();
            this.widthNumeric = new System.Windows.Forms.NumericUpDown();
            this.hightNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cageMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.AddCageButton = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.lengthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hightNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // SerialNumberAddCageLabel
            // 
            this.SerialNumberAddCageLabel.AutoSize = true;
            this.SerialNumberAddCageLabel.BackColor = System.Drawing.SystemColors.Window;
            this.SerialNumberAddCageLabel.Location = new System.Drawing.Point(36, 109);
            this.SerialNumberAddCageLabel.Name = "SerialNumberAddCageLabel";
            this.SerialNumberAddCageLabel.Size = new System.Drawing.Size(96, 16);
            this.SerialNumberAddCageLabel.TabIndex = 18;
            this.SerialNumberAddCageLabel.Text = "Serial Number:";
            // 
            // SerialNumberTextBox
            // 
            this.SerialNumberTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SerialNumberTextBox.Depth = 0;
            this.SerialNumberTextBox.Hint = "";
            this.SerialNumberTextBox.Location = new System.Drawing.Point(39, 140);
            this.SerialNumberTextBox.MaxLength = 32767;
            this.SerialNumberTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.SerialNumberTextBox.Name = "SerialNumberTextBox";
            this.SerialNumberTextBox.PasswordChar = '\0';
            this.SerialNumberTextBox.SelectedText = "";
            this.SerialNumberTextBox.SelectionLength = 0;
            this.SerialNumberTextBox.SelectionStart = 0;
            this.SerialNumberTextBox.Size = new System.Drawing.Size(187, 28);
            this.SerialNumberTextBox.TabIndex = 17;
            this.SerialNumberTextBox.TabStop = false;
            this.SerialNumberTextBox.UseSystemPasswordChar = false;
            // 
            // CageSizeAddCageLabel
            // 
            this.CageSizeAddCageLabel.AutoSize = true;
            this.CageSizeAddCageLabel.BackColor = System.Drawing.SystemColors.Window;
            this.CageSizeAddCageLabel.Location = new System.Drawing.Point(276, 106);
            this.CageSizeAddCageLabel.Name = "CageSizeAddCageLabel";
            this.CageSizeAddCageLabel.Size = new System.Drawing.Size(70, 16);
            this.CageSizeAddCageLabel.TabIndex = 19;
            this.CageSizeAddCageLabel.Text = "Cage size:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.BackColor = System.Drawing.SystemColors.Window;
            this.lengthLabel.Location = new System.Drawing.Point(280, 127);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(50, 16);
            this.lengthLabel.TabIndex = 23;
            this.lengthLabel.Text = "Length:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.BackColor = System.Drawing.SystemColors.Window;
            this.widthLabel.Location = new System.Drawing.Point(379, 127);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(44, 16);
            this.widthLabel.TabIndex = 24;
            this.widthLabel.Text = "Width:";
            // 
            // hightLabel
            // 
            this.hightLabel.AutoSize = true;
            this.hightLabel.BackColor = System.Drawing.SystemColors.Window;
            this.hightLabel.Location = new System.Drawing.Point(482, 127);
            this.hightLabel.Name = "hightLabel";
            this.hightLabel.Size = new System.Drawing.Size(49, 16);
            this.hightLabel.TabIndex = 25;
            this.hightLabel.Text = "Height:";
            // 
            // lengthNumeric
            // 
            this.lengthNumeric.Location = new System.Drawing.Point(283, 146);
            this.lengthNumeric.Name = "lengthNumeric";
            this.lengthNumeric.Size = new System.Drawing.Size(76, 22);
            this.lengthNumeric.TabIndex = 26;
            this.lengthNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // widthNumeric
            // 
            this.widthNumeric.Location = new System.Drawing.Point(382, 146);
            this.widthNumeric.Name = "widthNumeric";
            this.widthNumeric.Size = new System.Drawing.Size(76, 22);
            this.widthNumeric.TabIndex = 27;
            this.widthNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // hightNumeric
            // 
            this.hightNumeric.Location = new System.Drawing.Point(485, 146);
            this.hightNumeric.Name = "hightNumeric";
            this.hightNumeric.Size = new System.Drawing.Size(76, 22);
            this.hightNumeric.TabIndex = 28;
            this.hightNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(613, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Cage Material:";
            // 
            // cageMaterialComboBox
            // 
            this.cageMaterialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cageMaterialComboBox.FormattingEnabled = true;
            this.cageMaterialComboBox.Items.AddRange(new object[] {
            "Iron",
            "Wood",
            "Plastic"});
            this.cageMaterialComboBox.Location = new System.Drawing.Point(616, 140);
            this.cageMaterialComboBox.Name = "cageMaterialComboBox";
            this.cageMaterialComboBox.Size = new System.Drawing.Size(121, 24);
            this.cageMaterialComboBox.TabIndex = 30;
            // 
            // AddCageButton
            // 
            this.AddCageButton.AutoSize = true;
            this.AddCageButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddCageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCageButton.Depth = 0;
            this.AddCageButton.Icon = null;
            this.AddCageButton.Location = new System.Drawing.Point(654, 336);
            this.AddCageButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddCageButton.Name = "AddCageButton";
            this.AddCageButton.Primary = true;
            this.AddCageButton.Size = new System.Drawing.Size(104, 36);
            this.AddCageButton.TabIndex = 31;
            this.AddCageButton.Text = "Add cage";
            this.AddCageButton.UseVisualStyleBackColor = true;
            this.AddCageButton.Click += new System.EventHandler(this.AddCageButton_Click);
            // 
            // AddCageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 467);
            this.Controls.Add(this.AddCageButton);
            this.Controls.Add(this.cageMaterialComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hightNumeric);
            this.Controls.Add(this.widthNumeric);
            this.Controls.Add(this.lengthNumeric);
            this.Controls.Add(this.hightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.CageSizeAddCageLabel);
            this.Controls.Add(this.SerialNumberAddCageLabel);
            this.Controls.Add(this.SerialNumberTextBox);
            this.Name = "AddCageForm";
            this.Text = "AddCageForm";
            ((System.ComponentModel.ISupportInitialize)(this.lengthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hightNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SerialNumberAddCageLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField SerialNumberTextBox;
        private System.Windows.Forms.Label CageSizeAddCageLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label hightLabel;
        private System.Windows.Forms.NumericUpDown lengthNumeric;
        private System.Windows.Forms.NumericUpDown widthNumeric;
        private System.Windows.Forms.NumericUpDown hightNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cageMaterialComboBox;
        private MaterialSkin.Controls.MaterialRaisedButton AddCageButton;
    }
}