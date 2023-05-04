namespace FinalQA_Project
{
    partial class LoginForm
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
            this.usernameBoxLogin = new System.Windows.Forms.TextBox();
            this.passwordBoxLogin = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.usernameLoginLabel = new System.Windows.Forms.Label();
            this.passwordLoginLabel = new System.Windows.Forms.Label();
            this.loginButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // usernameBoxLogin
            // 
            this.usernameBoxLogin.Location = new System.Drawing.Point(134, 158);
            this.usernameBoxLogin.Name = "usernameBoxLogin";
            this.usernameBoxLogin.Size = new System.Drawing.Size(321, 22);
            this.usernameBoxLogin.TabIndex = 0;
            // 
            // passwordBoxLogin
            // 
            this.passwordBoxLogin.Location = new System.Drawing.Point(134, 247);
            this.passwordBoxLogin.Name = "passwordBoxLogin";
            this.passwordBoxLogin.Size = new System.Drawing.Size(321, 22);
            this.passwordBoxLogin.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.linkLabel1.Location = new System.Drawing.Point(131, 284);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(221, 16);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Dont have an account? register now.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // usernameLoginLabel
            // 
            this.usernameLoginLabel.AutoSize = true;
            this.usernameLoginLabel.BackColor = System.Drawing.SystemColors.Window;
            this.usernameLoginLabel.Location = new System.Drawing.Point(131, 139);
            this.usernameLoginLabel.Name = "usernameLoginLabel";
            this.usernameLoginLabel.Size = new System.Drawing.Size(70, 16);
            this.usernameLoginLabel.TabIndex = 4;
            this.usernameLoginLabel.Text = "Username";
            // 
            // passwordLoginLabel
            // 
            this.passwordLoginLabel.AutoSize = true;
            this.passwordLoginLabel.BackColor = System.Drawing.SystemColors.Window;
            this.passwordLoginLabel.Location = new System.Drawing.Point(131, 228);
            this.passwordLoginLabel.Name = "passwordLoginLabel";
            this.passwordLoginLabel.Size = new System.Drawing.Size(67, 16);
            this.passwordLoginLabel.TabIndex = 5;
            this.passwordLoginLabel.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = true;
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Depth = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Icon = null;
            this.loginButton.Location = new System.Drawing.Point(195, 353);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.Primary = true;
            this.loginButton.Size = new System.Drawing.Size(72, 36);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(911, 626);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLoginLabel);
            this.Controls.Add(this.usernameLoginLabel);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.passwordBoxLogin);
            this.Controls.Add(this.usernameBoxLogin);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameBoxLogin;
        private System.Windows.Forms.TextBox passwordBoxLogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label usernameLoginLabel;
        private System.Windows.Forms.Label passwordLoginLabel;
        private MaterialSkin.Controls.MaterialRaisedButton loginButton;
    }
}

