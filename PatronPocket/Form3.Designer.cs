namespace PatronPocket
{
    partial class mainPage
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
            this.PPWlcmTitle = new System.Windows.Forms.Label();
            this.welcomePagePic = new System.Windows.Forms.PictureBox();
            this.quote = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.welcomePagePic)).BeginInit();
            this.SuspendLayout();
            // 
            // PPWlcmTitle
            // 
            this.PPWlcmTitle.AutoSize = true;
            this.PPWlcmTitle.Font = new System.Drawing.Font("Montserrat", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPWlcmTitle.Location = new System.Drawing.Point(30, 29);
            this.PPWlcmTitle.Name = "PPWlcmTitle";
            this.PPWlcmTitle.Size = new System.Drawing.Size(384, 60);
            this.PPWlcmTitle.TabIndex = 0;
            this.PPWlcmTitle.Text = "Pocket PATRON";
            // 
            // welcomePagePic
            // 
            this.welcomePagePic.ImageLocation = "C:\\Users\\Miruan\\source\\repos\\PatronPocket\\assets\\img\\money.jpg";
            this.welcomePagePic.Location = new System.Drawing.Point(476, 178);
            this.welcomePagePic.Name = "welcomePagePic";
            this.welcomePagePic.Size = new System.Drawing.Size(612, 408);
            this.welcomePagePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.welcomePagePic.TabIndex = 2;
            this.welcomePagePic.TabStop = false;
            // 
            // quote
            // 
            this.quote.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quote.Location = new System.Drawing.Point(12, 90);
            this.quote.Name = "quote";
            this.quote.Size = new System.Drawing.Size(950, 137);
            this.quote.TabIndex = 3;
            this.quote.Text = "Many people take no care of their money till they come nearly to the end of it, a" +
    "nd others do just the same with their time. --Johann Wolfgang von Goethe";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(72, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "LOG IN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 137);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to PocketPATRON, your wallet menager.\r\nIf you already have an account pre" +
    "ss the Log In button to continue to your account";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 137);
            this.label2.TabIndex = 6;
            this.label2.Text = "If you are new to PatronPOCKET then press the button below to create your PatronP" +
    "OCKET account";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(72, 552);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(282, 47);
            this.button2.TabIndex = 7;
            this.button2.Text = "NEW ACCOUNT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quote);
            this.Controls.Add(this.welcomePagePic);
            this.Controls.Add(this.PPWlcmTitle);
            this.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PocketPATRON";
            ((System.ComponentModel.ISupportInitialize)(this.welcomePagePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PPWlcmTitle;
        private System.Windows.Forms.PictureBox welcomePagePic;
        private System.Windows.Forms.Label quote;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}