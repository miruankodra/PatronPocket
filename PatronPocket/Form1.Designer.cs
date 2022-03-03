namespace PatronPocket
{
    partial class PPLogin
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
            this.usrLbl = new System.Windows.Forms.Label();
            this.passLbl = new System.Windows.Forms.Label();
            this.loginTitle = new System.Windows.Forms.Label();
            this.sloganLbl = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.passkey = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.vault = new System.Windows.Forms.PictureBox();
            this.stPartScentence = new System.Windows.Forms.Label();
            this.scPartSentence = new System.Windows.Forms.Label();
            this.signupLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.vault)).BeginInit();
            this.SuspendLayout();
            // 
            // usrLbl
            // 
            this.usrLbl.AutoSize = true;
            this.usrLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrLbl.Location = new System.Drawing.Point(70, 64);
            this.usrLbl.Name = "usrLbl";
            this.usrLbl.Size = new System.Drawing.Size(117, 27);
            this.usrLbl.TabIndex = 0;
            this.usrLbl.Text = "Username";
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLbl.Location = new System.Drawing.Point(70, 174);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(111, 27);
            this.passLbl.TabIndex = 1;
            this.passLbl.Text = "Password";
            // 
            // loginTitle
            // 
            this.loginTitle.AutoSize = true;
            this.loginTitle.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitle.Location = new System.Drawing.Point(433, 25);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(198, 32);
            this.loginTitle.TabIndex = 2;
            this.loginTitle.Text = "PocketPATRON";
            // 
            // sloganLbl
            // 
            this.sloganLbl.AutoSize = true;
            this.sloganLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sloganLbl.Location = new System.Drawing.Point(343, 64);
            this.sloganLbl.Name = "sloganLbl";
            this.sloganLbl.Size = new System.Drawing.Size(346, 27);
            this.sloganLbl.TabIndex = 3;
            this.sloganLbl.Text = "For people who tend to go broke";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(56, 98);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(148, 28);
            this.username.TabIndex = 4;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passkey
            // 
            this.passkey.AcceptsReturn = true;
            this.passkey.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passkey.Location = new System.Drawing.Point(56, 208);
            this.passkey.Name = "passkey";
            this.passkey.PasswordChar = '*';
            this.passkey.Size = new System.Drawing.Size(148, 28);
            this.passkey.TabIndex = 5;
            this.passkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passkey.TextChanged += new System.EventHandler(this.passkey_TextChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginBtn.Location = new System.Drawing.Point(56, 284);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(148, 38);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // vault
            // 
            this.vault.ImageLocation = "C:\\Users\\Miruan\\source\\repos\\PatronPocket\\assets\\img\\vault.jpg";
            this.vault.Location = new System.Drawing.Point(322, 98);
            this.vault.Name = "vault";
            this.vault.Size = new System.Drawing.Size(424, 273);
            this.vault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.vault.TabIndex = 7;
            this.vault.TabStop = false;
            // 
            // stPartScentence
            // 
            this.stPartScentence.AutoSize = true;
            this.stPartScentence.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stPartScentence.Location = new System.Drawing.Point(51, 363);
            this.stPartScentence.Name = "stPartScentence";
            this.stPartScentence.Size = new System.Drawing.Size(37, 27);
            this.stPartScentence.TabIndex = 8;
            this.stPartScentence.Text = "Or";
            // 
            // scPartSentence
            // 
            this.scPartSentence.AutoSize = true;
            this.scPartSentence.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scPartSentence.Location = new System.Drawing.Point(51, 394);
            this.scPartSentence.Name = "scPartSentence";
            this.scPartSentence.Size = new System.Drawing.Size(296, 27);
            this.scPartSentence.TabIndex = 9;
            this.scPartSentence.Text = "if you don\'t have an account";
            // 
            // signupLink
            // 
            this.signupLink.AutoSize = true;
            this.signupLink.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupLink.Location = new System.Drawing.Point(88, 363);
            this.signupLink.Name = "signupLink";
            this.signupLink.Size = new System.Drawing.Size(92, 27);
            this.signupLink.TabIndex = 10;
            this.signupLink.TabStop = true;
            this.signupLink.Text = "Sign Up";
            this.signupLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signupLink_LinkClicked);
            // 
            // PPLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.signupLink);
            this.Controls.Add(this.scPartSentence);
            this.Controls.Add(this.stPartScentence);
            this.Controls.Add(this.vault);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passkey);
            this.Controls.Add(this.username);
            this.Controls.Add(this.sloganLbl);
            this.Controls.Add(this.loginTitle);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.usrLbl);
            this.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PPLogin";
            this.Text = "PocketPATRON";
            this.Load += new System.EventHandler(this.PPLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vault)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usrLbl;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.Label loginTitle;
        private System.Windows.Forms.Label sloganLbl;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox passkey;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.PictureBox vault;
        private System.Windows.Forms.Label stPartScentence;
        private System.Windows.Forms.Label scPartSentence;
        private System.Windows.Forms.LinkLabel signupLink;
    }
}

