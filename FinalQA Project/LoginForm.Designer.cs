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
            this.LoginButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.togglePictureBox = new System.Windows.Forms.PictureBox();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.togglePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameBoxLogin
            // 
            this.usernameBoxLogin.Location = new System.Drawing.Point(35, 105);
            this.usernameBoxLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameBoxLogin.Name = "usernameBoxLogin";
            this.usernameBoxLogin.Size = new System.Drawing.Size(321, 22);
            this.usernameBoxLogin.TabIndex = 0;
            // 
            // passwordBoxLogin
            // 
            this.passwordBoxLogin.Location = new System.Drawing.Point(35, 204);
            this.passwordBoxLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordBoxLogin.Name = "passwordBoxLogin";
            this.passwordBoxLogin.PasswordChar = '*';
            this.passwordBoxLogin.Size = new System.Drawing.Size(321, 22);
            this.passwordBoxLogin.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(32, 249);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(275, 17);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Dont have an account? register now.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // usernameLoginLabel
            // 
            this.usernameLoginLabel.AutoSize = true;
            this.usernameLoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.usernameLoginLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.usernameLoginLabel.Location = new System.Drawing.Point(31, 68);
            this.usernameLoginLabel.Name = "usernameLoginLabel";
            this.usernameLoginLabel.Size = new System.Drawing.Size(105, 24);
            this.usernameLoginLabel.TabIndex = 4;
            this.usernameLoginLabel.Text = "Username";
            // 
            // passwordLoginLabel
            // 
            this.passwordLoginLabel.AutoSize = true;
            this.passwordLoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.passwordLoginLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.passwordLoginLabel.Location = new System.Drawing.Point(32, 169);
            this.passwordLoginLabel.Name = "passwordLoginLabel";
            this.passwordLoginLabel.Size = new System.Drawing.Size(100, 24);
            this.passwordLoginLabel.TabIndex = 5;
            this.passwordLoginLabel.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSize = true;
            this.LoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Depth = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Icon = null;
            this.LoginButton.Location = new System.Drawing.Point(35, 313);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Primary = true;
            this.LoginButton.Size = new System.Drawing.Size(72, 36);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackgroundImage = global::FinalQA_Project.Properties.Resources.Login;
            this.LoginPanel.Controls.Add(this.togglePictureBox);
            this.LoginPanel.Controls.Add(this.passwordBoxLogin);
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.usernameBoxLogin);
            this.LoginPanel.Controls.Add(this.passwordLoginLabel);
            this.LoginPanel.Controls.Add(this.linkLabel1);
            this.LoginPanel.Controls.Add(this.usernameLoginLabel);
            this.LoginPanel.Location = new System.Drawing.Point(-2, 63);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(829, 773);
            this.LoginPanel.TabIndex = 7;
            // 
            // togglePictureBox
            // 
            this.togglePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.togglePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.togglePictureBox.Location = new System.Drawing.Point(523, 237);
            this.togglePictureBox.Name = "togglePictureBox";
            this.togglePictureBox.Size = new System.Drawing.Size(72, 63);
            this.togglePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.togglePictureBox.TabIndex = 10;
            this.togglePictureBox.TabStop = false;
            this.togglePictureBox.Click += new System.EventHandler(this.togglePictureBox_Click);
            // 
            // LoginForm
            // 
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(824, 773);
            this.Controls.Add(this.LoginPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.Sizable = false;
            this.Text = "Login";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.togglePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox usernameBoxLogin;
        public System.Windows.Forms.TextBox passwordBoxLogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label usernameLoginLabel;
        private System.Windows.Forms.Label passwordLoginLabel;
        private MaterialSkin.Controls.MaterialRaisedButton LoginButton;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.PictureBox togglePictureBox;
    }
}

