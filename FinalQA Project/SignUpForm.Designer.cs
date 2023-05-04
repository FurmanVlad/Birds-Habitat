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
            this.usernameBoxSignUp = new System.Windows.Forms.TextBox();
            this.passwordBoxSignUp = new System.Windows.Forms.TextBox();
            this.idBoxSignUp = new System.Windows.Forms.TextBox();
            this.usernameSignUpLabel = new System.Windows.Forms.Label();
            this.passwordSignUpLabel = new System.Windows.Forms.Label();
            this.idSignUpLabel = new System.Windows.Forms.Label();
            this.signUpButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // usernameBoxSignUp
            // 
            this.usernameBoxSignUp.Location = new System.Drawing.Point(90, 118);
            this.usernameBoxSignUp.Name = "usernameBoxSignUp";
            this.usernameBoxSignUp.Size = new System.Drawing.Size(216, 22);
            this.usernameBoxSignUp.TabIndex = 1;
            // 
            // passwordBoxSignUp
            // 
            this.passwordBoxSignUp.Location = new System.Drawing.Point(90, 215);
            this.passwordBoxSignUp.Name = "passwordBoxSignUp";
            this.passwordBoxSignUp.Size = new System.Drawing.Size(216, 22);
            this.passwordBoxSignUp.TabIndex = 2;
            // 
            // idBoxSignUp
            // 
            this.idBoxSignUp.Location = new System.Drawing.Point(90, 319);
            this.idBoxSignUp.Name = "idBoxSignUp";
            this.idBoxSignUp.Size = new System.Drawing.Size(230, 22);
            this.idBoxSignUp.TabIndex = 3;
            // 
            // usernameSignUpLabel
            // 
            this.usernameSignUpLabel.AutoSize = true;
            this.usernameSignUpLabel.BackColor = System.Drawing.SystemColors.Window;
            this.usernameSignUpLabel.Location = new System.Drawing.Point(87, 89);
            this.usernameSignUpLabel.Name = "usernameSignUpLabel";
            this.usernameSignUpLabel.Size = new System.Drawing.Size(70, 16);
            this.usernameSignUpLabel.TabIndex = 4;
            this.usernameSignUpLabel.Text = "Username";
            // 
            // passwordSignUpLabel
            // 
            this.passwordSignUpLabel.AutoSize = true;
            this.passwordSignUpLabel.BackColor = System.Drawing.SystemColors.Window;
            this.passwordSignUpLabel.Location = new System.Drawing.Point(87, 196);
            this.passwordSignUpLabel.Name = "passwordSignUpLabel";
            this.passwordSignUpLabel.Size = new System.Drawing.Size(67, 16);
            this.passwordSignUpLabel.TabIndex = 5;
            this.passwordSignUpLabel.Text = "Password";
            // 
            // idSignUpLabel
            // 
            this.idSignUpLabel.AutoSize = true;
            this.idSignUpLabel.BackColor = System.Drawing.SystemColors.Window;
            this.idSignUpLabel.Location = new System.Drawing.Point(87, 300);
            this.idSignUpLabel.Name = "idSignUpLabel";
            this.idSignUpLabel.Size = new System.Drawing.Size(20, 16);
            this.idSignUpLabel.TabIndex = 6;
            this.idSignUpLabel.Text = "ID";
            // 
            // signUpButton
            // 
            this.signUpButton.AutoSize = true;
            this.signUpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.Depth = 0;
            this.signUpButton.Icon = null;
            this.signUpButton.Location = new System.Drawing.Point(90, 375);
            this.signUpButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Primary = true;
            this.signUpButton.Size = new System.Drawing.Size(100, 36);
            this.signUpButton.TabIndex = 8;
            this.signUpButton.Text = "Register";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.idSignUpLabel);
            this.Controls.Add(this.passwordSignUpLabel);
            this.Controls.Add(this.usernameSignUpLabel);
            this.Controls.Add(this.idBoxSignUp);
            this.Controls.Add(this.passwordBoxSignUp);
            this.Controls.Add(this.usernameBoxSignUp);
            this.Name = "SignUpForm";
            this.ShowIcon = false;
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameBoxSignUp;
        private System.Windows.Forms.TextBox passwordBoxSignUp;
        private System.Windows.Forms.TextBox idBoxSignUp;
        private System.Windows.Forms.Label usernameSignUpLabel;
        private System.Windows.Forms.Label passwordSignUpLabel;
        private System.Windows.Forms.Label idSignUpLabel;
        private MaterialSkin.Controls.MaterialRaisedButton signUpButton;
    }
}