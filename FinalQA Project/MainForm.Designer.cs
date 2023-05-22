namespace FinalQA_Project
{
    partial class MainForm
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
            this.MainFormPanel = new System.Windows.Forms.Panel();
            this.SearchCageMainFormLabel = new System.Windows.Forms.Label();
            this.AddCageMainFormLabel = new System.Windows.Forms.Label();
            this.SearchBirdMainFormLabel = new System.Windows.Forms.Label();
            this.AddBirdlMainFormLabel = new System.Windows.Forms.Label();
            this.AddBirdImg = new System.Windows.Forms.PictureBox();
            this.SearchBirdImg = new System.Windows.Forms.PictureBox();
            this.SearchCageImg = new System.Windows.Forms.PictureBox();
            this.AddCageImg = new System.Windows.Forms.PictureBox();
            this.LogoutButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MainFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBirdImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBirdImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchCageImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCageImg)).BeginInit();
            this.SuspendLayout();
            // 
            // MainFormPanel
            // 
            this.MainFormPanel.BackColor = System.Drawing.Color.DimGray;
            this.MainFormPanel.Controls.Add(this.LogoutButton);
            this.MainFormPanel.Controls.Add(this.SearchCageMainFormLabel);
            this.MainFormPanel.Controls.Add(this.AddCageMainFormLabel);
            this.MainFormPanel.Controls.Add(this.SearchBirdMainFormLabel);
            this.MainFormPanel.Controls.Add(this.AddBirdlMainFormLabel);
            this.MainFormPanel.Controls.Add(this.AddBirdImg);
            this.MainFormPanel.Controls.Add(this.SearchBirdImg);
            this.MainFormPanel.Controls.Add(this.SearchCageImg);
            this.MainFormPanel.Controls.Add(this.AddCageImg);
            this.MainFormPanel.Location = new System.Drawing.Point(0, 78);
            this.MainFormPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainFormPanel.Name = "MainFormPanel";
            this.MainFormPanel.Size = new System.Drawing.Size(967, 505);
            this.MainFormPanel.TabIndex = 4;
            // 
            // SearchCageMainFormLabel
            // 
            this.SearchCageMainFormLabel.AutoSize = true;
            this.SearchCageMainFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.SearchCageMainFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.SearchCageMainFormLabel.ForeColor = System.Drawing.Color.White;
            this.SearchCageMainFormLabel.Location = new System.Drawing.Point(565, 444);
            this.SearchCageMainFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchCageMainFormLabel.Name = "SearchCageMainFormLabel";
            this.SearchCageMainFormLabel.Size = new System.Drawing.Size(114, 20);
            this.SearchCageMainFormLabel.TabIndex = 7;
            this.SearchCageMainFormLabel.Text = "Search cage";
            // 
            // AddCageMainFormLabel
            // 
            this.AddCageMainFormLabel.AutoSize = true;
            this.AddCageMainFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddCageMainFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.AddCageMainFormLabel.ForeColor = System.Drawing.Color.White;
            this.AddCageMainFormLabel.Location = new System.Drawing.Point(159, 444);
            this.AddCageMainFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCageMainFormLabel.Name = "AddCageMainFormLabel";
            this.AddCageMainFormLabel.Size = new System.Drawing.Size(87, 20);
            this.AddCageMainFormLabel.TabIndex = 6;
            this.AddCageMainFormLabel.Text = "Add cage";
            // 
            // SearchBirdMainFormLabel
            // 
            this.SearchBirdMainFormLabel.AutoSize = true;
            this.SearchBirdMainFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.SearchBirdMainFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.SearchBirdMainFormLabel.ForeColor = System.Drawing.Color.White;
            this.SearchBirdMainFormLabel.Location = new System.Drawing.Point(565, 210);
            this.SearchBirdMainFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchBirdMainFormLabel.Name = "SearchBirdMainFormLabel";
            this.SearchBirdMainFormLabel.Size = new System.Drawing.Size(106, 20);
            this.SearchBirdMainFormLabel.TabIndex = 5;
            this.SearchBirdMainFormLabel.Text = "Serach bird";
            // 
            // AddBirdlMainFormLabel
            // 
            this.AddBirdlMainFormLabel.AutoSize = true;
            this.AddBirdlMainFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddBirdlMainFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddBirdlMainFormLabel.ForeColor = System.Drawing.Color.White;
            this.AddBirdlMainFormLabel.Location = new System.Drawing.Point(155, 210);
            this.AddBirdlMainFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddBirdlMainFormLabel.Name = "AddBirdlMainFormLabel";
            this.AddBirdlMainFormLabel.Size = new System.Drawing.Size(79, 20);
            this.AddBirdlMainFormLabel.TabIndex = 4;
            this.AddBirdlMainFormLabel.Text = "Add bird";
            // 
            // AddBirdImg
            // 
            this.AddBirdImg.BackColor = System.Drawing.Color.Transparent;
            this.AddBirdImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBirdImg.Image = global::FinalQA_Project.Properties.Resources.Add_Bird;
            this.AddBirdImg.Location = new System.Drawing.Point(155, 38);
            this.AddBirdImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBirdImg.Name = "AddBirdImg";
            this.AddBirdImg.Size = new System.Drawing.Size(192, 165);
            this.AddBirdImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddBirdImg.TabIndex = 0;
            this.AddBirdImg.TabStop = false;
            this.AddBirdImg.Click += new System.EventHandler(this.AddBirdImg_Click);
            // 
            // SearchBirdImg
            // 
            this.SearchBirdImg.BackColor = System.Drawing.Color.Transparent;
            this.SearchBirdImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBirdImg.Image = global::FinalQA_Project.Properties.Resources.Search_Bird;
            this.SearchBirdImg.Location = new System.Drawing.Point(565, 38);
            this.SearchBirdImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBirdImg.Name = "SearchBirdImg";
            this.SearchBirdImg.Size = new System.Drawing.Size(192, 165);
            this.SearchBirdImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchBirdImg.TabIndex = 3;
            this.SearchBirdImg.TabStop = false;
            this.SearchBirdImg.Click += new System.EventHandler(this.SearchBirdImg_Click);
            // 
            // SearchCageImg
            // 
            this.SearchCageImg.BackColor = System.Drawing.Color.Transparent;
            this.SearchCageImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchCageImg.Image = global::FinalQA_Project.Properties.Resources.Search_Cage;
            this.SearchCageImg.Location = new System.Drawing.Point(565, 272);
            this.SearchCageImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchCageImg.Name = "SearchCageImg";
            this.SearchCageImg.Size = new System.Drawing.Size(192, 165);
            this.SearchCageImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchCageImg.TabIndex = 1;
            this.SearchCageImg.TabStop = false;
            this.SearchCageImg.Click += new System.EventHandler(this.SearchCaveImg_Click);
            // 
            // AddCageImg
            // 
            this.AddCageImg.BackColor = System.Drawing.Color.Transparent;
            this.AddCageImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCageImg.Image = global::FinalQA_Project.Properties.Resources.Add_Cage;
            this.AddCageImg.Location = new System.Drawing.Point(155, 272);
            this.AddCageImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddCageImg.Name = "AddCageImg";
            this.AddCageImg.Size = new System.Drawing.Size(192, 165);
            this.AddCageImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddCageImg.TabIndex = 2;
            this.AddCageImg.TabStop = false;
            this.AddCageImg.Click += new System.EventHandler(this.AddCageImg_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.AutoSize = true;
            this.LogoutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LogoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutButton.Depth = 0;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Icon = null;
            this.LogoutButton.Location = new System.Drawing.Point(876, 2);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Primary = true;
            this.LogoutButton.Size = new System.Drawing.Size(88, 36);
            this.LogoutButton.TabIndex = 8;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(964, 582);
            this.Controls.Add(this.MainFormPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Sizable = false;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainFormPanel.ResumeLayout(false);
            this.MainFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBirdImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBirdImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchCageImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCageImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AddBirdImg;
        private System.Windows.Forms.PictureBox SearchCageImg;
        private System.Windows.Forms.PictureBox AddCageImg;
        private System.Windows.Forms.PictureBox SearchBirdImg;
        private System.Windows.Forms.Panel MainFormPanel;
        private System.Windows.Forms.Label SearchCageMainFormLabel;
        private System.Windows.Forms.Label AddCageMainFormLabel;
        private System.Windows.Forms.Label SearchBirdMainFormLabel;
        private System.Windows.Forms.Label AddBirdlMainFormLabel;
        private MaterialSkin.Controls.MaterialRaisedButton LogoutButton;
    }
}