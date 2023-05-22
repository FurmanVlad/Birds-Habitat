namespace FinalQA_Project
{
    partial class SignUpForm
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
            this.SignUpPanel = new System.Windows.Forms.Panel();
            this.togglePictureBox = new System.Windows.Forms.PictureBox();
            this.signUpButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.usernameBoxSignUp = new System.Windows.Forms.TextBox();
            this.idSignUpLabel = new System.Windows.Forms.Label();
            this.passwordBoxSignUp = new System.Windows.Forms.TextBox();
            this.passwordSignUpLabel = new System.Windows.Forms.Label();
            this.idBoxSignUp = new System.Windows.Forms.TextBox();
            this.usernameSignUpLabel = new System.Windows.Forms.Label();
            this.SignUpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.togglePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SignUpPanel
            // 
            this.SignUpPanel.BackColor = System.Drawing.SystemColors.Window;
            this.SignUpPanel.BackgroundImage = global::FinalQA_Project.Properties.Resources.Sign_up;
            this.SignUpPanel.Controls.Add(this.togglePictureBox);
            this.SignUpPanel.Controls.Add(this.signUpButton);
            this.SignUpPanel.Controls.Add(this.usernameBoxSignUp);
            this.SignUpPanel.Controls.Add(this.idSignUpLabel);
            this.SignUpPanel.Controls.Add(this.passwordBoxSignUp);
            this.SignUpPanel.Controls.Add(this.passwordSignUpLabel);
            this.SignUpPanel.Controls.Add(this.idBoxSignUp);
            this.SignUpPanel.Controls.Add(this.usernameSignUpLabel);
            this.SignUpPanel.Location = new System.Drawing.Point(0, 78);
            this.SignUpPanel.Margin = new System.Windows.Forms.Padding(4);
            this.SignUpPanel.Name = "SignUpPanel";
            this.SignUpPanel.Size = new System.Drawing.Size(915, 778);
            this.SignUpPanel.TabIndex = 9;
            // 
            // togglePictureBox
            // 
            this.togglePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.togglePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.togglePictureBox.Location = new System.Drawing.Point(451, 244);
            this.togglePictureBox.Name = "togglePictureBox";
            this.togglePictureBox.Size = new System.Drawing.Size(72, 63);
            this.togglePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.togglePictureBox.TabIndex = 9;
            this.togglePictureBox.TabStop = false;
            this.togglePictureBox.Click += new System.EventHandler(this.togglePictureBox_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.AutoSize = true;
            this.signUpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.Depth = 0;
            this.signUpButton.Icon = null;
            this.signUpButton.Location = new System.Drawing.Point(45, 318);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signUpButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Primary = true;
            this.signUpButton.Size = new System.Drawing.Size(100, 36);
            this.signUpButton.TabIndex = 8;
            this.signUpButton.Text = "Register";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // usernameBoxSignUp
            // 
            this.usernameBoxSignUp.Location = new System.Drawing.Point(45, 78);
            this.usernameBoxSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameBoxSignUp.Name = "usernameBoxSignUp";
            this.usernameBoxSignUp.Size = new System.Drawing.Size(216, 22);
            this.usernameBoxSignUp.TabIndex = 1;
            // 
            // idSignUpLabel
            // 
            this.idSignUpLabel.AutoSize = true;
            this.idSignUpLabel.BackColor = System.Drawing.Color.Transparent;
            this.idSignUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.idSignUpLabel.ForeColor = System.Drawing.Color.White;
            this.idSignUpLabel.Location = new System.Drawing.Point(41, 225);
            this.idSignUpLabel.Name = "idSignUpLabel";
            this.idSignUpLabel.Size = new System.Drawing.Size(29, 24);
            this.idSignUpLabel.TabIndex = 6;
            this.idSignUpLabel.Text = "ID";
            // 
            // passwordBoxSignUp
            // 
            this.passwordBoxSignUp.Location = new System.Drawing.Point(45, 175);
            this.passwordBoxSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordBoxSignUp.Name = "passwordBoxSignUp";
            this.passwordBoxSignUp.PasswordChar = '*';
            this.passwordBoxSignUp.Size = new System.Drawing.Size(216, 22);
            this.passwordBoxSignUp.TabIndex = 2;
            // 
            // passwordSignUpLabel
            // 
            this.passwordSignUpLabel.AutoSize = true;
            this.passwordSignUpLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordSignUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.passwordSignUpLabel.ForeColor = System.Drawing.Color.White;
            this.passwordSignUpLabel.Location = new System.Drawing.Point(41, 133);
            this.passwordSignUpLabel.Name = "passwordSignUpLabel";
            this.passwordSignUpLabel.Size = new System.Drawing.Size(100, 24);
            this.passwordSignUpLabel.TabIndex = 5;
            this.passwordSignUpLabel.Text = "Password";
            // 
            // idBoxSignUp
            // 
            this.idBoxSignUp.Location = new System.Drawing.Point(45, 261);
            this.idBoxSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idBoxSignUp.Name = "idBoxSignUp";
            this.idBoxSignUp.Size = new System.Drawing.Size(231, 22);
            this.idBoxSignUp.TabIndex = 3;
            // 
            // usernameSignUpLabel
            // 
            this.usernameSignUpLabel.AutoSize = true;
            this.usernameSignUpLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameSignUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.usernameSignUpLabel.ForeColor = System.Drawing.Color.White;
            this.usernameSignUpLabel.Location = new System.Drawing.Point(41, 42);
            this.usernameSignUpLabel.Name = "usernameSignUpLabel";
            this.usernameSignUpLabel.Size = new System.Drawing.Size(105, 24);
            this.usernameSignUpLabel.TabIndex = 4;
            this.usernameSignUpLabel.Text = "Username";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 855);
            this.Controls.Add(this.SignUpPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUpForm";
            this.ShowIcon = false;
            this.Sizable = false;
            this.Text = "Sign Up";
            this.SignUpPanel.ResumeLayout(false);
            this.SignUpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.togglePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox usernameBoxSignUp;
        private System.Windows.Forms.TextBox passwordBoxSignUp;
        private System.Windows.Forms.TextBox idBoxSignUp;
        private System.Windows.Forms.Label usernameSignUpLabel;
        private System.Windows.Forms.Label passwordSignUpLabel;
        private System.Windows.Forms.Label idSignUpLabel;
        private MaterialSkin.Controls.MaterialRaisedButton signUpButton;
        private System.Windows.Forms.Panel SignUpPanel;
        private System.Windows.Forms.PictureBox togglePictureBox;
    }
}