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
            this.SearchBirdImg = new System.Windows.Forms.PictureBox();
            this.AddCageImg = new System.Windows.Forms.PictureBox();
            this.SearchCageImg = new System.Windows.Forms.PictureBox();
            this.AddBirdImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBirdImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCageImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchCageImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBirdImg)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBirdImg
            // 
            this.SearchBirdImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBirdImg.Image = global::FinalQA_Project.Properties.Resources.Search_Bird;
            this.SearchBirdImg.Location = new System.Drawing.Point(456, 79);
            this.SearchBirdImg.Name = "SearchBirdImg";
            this.SearchBirdImg.Size = new System.Drawing.Size(192, 165);
            this.SearchBirdImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchBirdImg.TabIndex = 3;
            this.SearchBirdImg.TabStop = false;
            // 
            // AddCageImg
            // 
            this.AddCageImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCageImg.Image = global::FinalQA_Project.Properties.Resources.Add_Cage;
            this.AddCageImg.Location = new System.Drawing.Point(121, 264);
            this.AddCageImg.Name = "AddCageImg";
            this.AddCageImg.Size = new System.Drawing.Size(192, 165);
            this.AddCageImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddCageImg.TabIndex = 2;
            this.AddCageImg.TabStop = false;
            // 
            // SearchCageImg
            // 
            this.SearchCageImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchCageImg.Image = global::FinalQA_Project.Properties.Resources.Search_Cage;
            this.SearchCageImg.Location = new System.Drawing.Point(456, 264);
            this.SearchCageImg.Name = "SearchCageImg";
            this.SearchCageImg.Size = new System.Drawing.Size(192, 165);
            this.SearchCageImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchCageImg.TabIndex = 1;
            this.SearchCageImg.TabStop = false;
            this.SearchCageImg.Click += new System.EventHandler(this.SearchCageImg_Click);
            // 
            // AddBirdImg
            // 
            this.AddBirdImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBirdImg.Image = global::FinalQA_Project.Properties.Resources.Add_Bird;
            this.AddBirdImg.Location = new System.Drawing.Point(121, 79);
            this.AddBirdImg.Name = "AddBirdImg";
            this.AddBirdImg.Size = new System.Drawing.Size(192, 165);
            this.AddBirdImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddBirdImg.TabIndex = 0;
            this.AddBirdImg.TabStop = false;
            this.AddBirdImg.Click += new System.EventHandler(this.AddBirdImg_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(809, 469);
            this.Controls.Add(this.SearchBirdImg);
            this.Controls.Add(this.AddCageImg);
            this.Controls.Add(this.SearchCageImg);
            this.Controls.Add(this.AddBirdImg);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.SearchBirdImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCageImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchCageImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBirdImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AddBirdImg;
        private System.Windows.Forms.PictureBox SearchCageImg;
        private System.Windows.Forms.PictureBox AddCageImg;
        private System.Windows.Forms.PictureBox SearchBirdImg;
    }
}