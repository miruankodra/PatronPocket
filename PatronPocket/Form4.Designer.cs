namespace PatronPocket
{
    partial class PPdashboard
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
            this.balancePanel = new System.Windows.Forms.Panel();
            this.outCurrencyLbl = new System.Windows.Forms.Label();
            this.inCurrencyLbl = new System.Windows.Forms.Label();
            this.outcomeLbl = new System.Windows.Forms.Label();
            this.incomeLbl = new System.Windows.Forms.Label();
            this.outcomeTitleLbl = new System.Windows.Forms.Label();
            this.incomeTitleLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToCurrencyLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.totalTitleLbl = new System.Windows.Forms.Label();
            this.addInBtn = new System.Windows.Forms.Button();
            this.addOutBtn = new System.Windows.Forms.Button();
            this.inoutDG = new System.Windows.Forms.DataGridView();
            this.userLbl = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.balancePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inoutDG)).BeginInit();
            this.SuspendLayout();
            // 
            // balancePanel
            // 
            this.balancePanel.BackColor = System.Drawing.SystemColors.Control;
            this.balancePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balancePanel.Controls.Add(this.outCurrencyLbl);
            this.balancePanel.Controls.Add(this.inCurrencyLbl);
            this.balancePanel.Controls.Add(this.outcomeLbl);
            this.balancePanel.Controls.Add(this.incomeLbl);
            this.balancePanel.Controls.Add(this.outcomeTitleLbl);
            this.balancePanel.Controls.Add(this.incomeTitleLbl);
            this.balancePanel.Location = new System.Drawing.Point(732, 93);
            this.balancePanel.Name = "balancePanel";
            this.balancePanel.Size = new System.Drawing.Size(325, 345);
            this.balancePanel.TabIndex = 0;
            // 
            // outCurrencyLbl
            // 
            this.outCurrencyLbl.AutoSize = true;
            this.outCurrencyLbl.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outCurrencyLbl.Location = new System.Drawing.Point(262, 143);
            this.outCurrencyLbl.Name = "outCurrencyLbl";
            this.outCurrencyLbl.Size = new System.Drawing.Size(51, 27);
            this.outCurrencyLbl.TabIndex = 7;
            this.outCurrencyLbl.Text = "ALL";
            // 
            // inCurrencyLbl
            // 
            this.inCurrencyLbl.AutoSize = true;
            this.inCurrencyLbl.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inCurrencyLbl.Location = new System.Drawing.Point(263, 33);
            this.inCurrencyLbl.Name = "inCurrencyLbl";
            this.inCurrencyLbl.Size = new System.Drawing.Size(51, 27);
            this.inCurrencyLbl.TabIndex = 6;
            this.inCurrencyLbl.Text = "ALL";
            // 
            // outcomeLbl
            // 
            this.outcomeLbl.AutoSize = true;
            this.outcomeLbl.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outcomeLbl.Location = new System.Drawing.Point(176, 143);
            this.outcomeLbl.Name = "outcomeLbl";
            this.outcomeLbl.Size = new System.Drawing.Size(29, 32);
            this.outcomeLbl.TabIndex = 5;
            this.outcomeLbl.Text = "0";
            // 
            // incomeLbl
            // 
            this.incomeLbl.AutoSize = true;
            this.incomeLbl.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeLbl.Location = new System.Drawing.Point(176, 33);
            this.incomeLbl.Name = "incomeLbl";
            this.incomeLbl.Size = new System.Drawing.Size(29, 32);
            this.incomeLbl.TabIndex = 4;
            this.incomeLbl.Text = "0";
            // 
            // outcomeTitleLbl
            // 
            this.outcomeTitleLbl.AutoSize = true;
            this.outcomeTitleLbl.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outcomeTitleLbl.Location = new System.Drawing.Point(21, 143);
            this.outcomeTitleLbl.Name = "outcomeTitleLbl";
            this.outcomeTitleLbl.Size = new System.Drawing.Size(149, 32);
            this.outcomeTitleLbl.TabIndex = 3;
            this.outcomeTitleLbl.Text = "Outcomes :";
            // 
            // incomeTitleLbl
            // 
            this.incomeTitleLbl.AutoSize = true;
            this.incomeTitleLbl.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeTitleLbl.Location = new System.Drawing.Point(43, 33);
            this.incomeTitleLbl.Name = "incomeTitleLbl";
            this.incomeTitleLbl.Size = new System.Drawing.Size(127, 32);
            this.incomeTitleLbl.TabIndex = 2;
            this.incomeTitleLbl.Text = "Incomes :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ToCurrencyLbl);
            this.panel1.Controls.Add(this.totalLbl);
            this.panel1.Controls.Add(this.totalTitleLbl);
            this.panel1.Location = new System.Drawing.Point(732, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 81);
            this.panel1.TabIndex = 1;
            // 
            // ToCurrencyLbl
            // 
            this.ToCurrencyLbl.AutoSize = true;
            this.ToCurrencyLbl.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToCurrencyLbl.Location = new System.Drawing.Point(263, 23);
            this.ToCurrencyLbl.Name = "ToCurrencyLbl";
            this.ToCurrencyLbl.Size = new System.Drawing.Size(51, 27);
            this.ToCurrencyLbl.TabIndex = 7;
            this.ToCurrencyLbl.Text = "ALL";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.Location = new System.Drawing.Point(176, 23);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(29, 32);
            this.totalLbl.TabIndex = 6;
            this.totalLbl.Text = "0";
            // 
            // totalTitleLbl
            // 
            this.totalTitleLbl.AutoSize = true;
            this.totalTitleLbl.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTitleLbl.Location = new System.Drawing.Point(85, 23);
            this.totalTitleLbl.Name = "totalTitleLbl";
            this.totalTitleLbl.Size = new System.Drawing.Size(85, 32);
            this.totalTitleLbl.TabIndex = 3;
            this.totalTitleLbl.Text = "Total :";
            // 
            // addInBtn
            // 
            this.addInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.addInBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addInBtn.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addInBtn.Location = new System.Drawing.Point(37, 582);
            this.addInBtn.Name = "addInBtn";
            this.addInBtn.Size = new System.Drawing.Size(208, 62);
            this.addInBtn.TabIndex = 2;
            this.addInBtn.Text = "ADD INCOME";
            this.addInBtn.UseVisualStyleBackColor = false;
            this.addInBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // addOutBtn
            // 
            this.addOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.addOutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addOutBtn.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOutBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addOutBtn.Location = new System.Drawing.Point(257, 582);
            this.addOutBtn.Name = "addOutBtn";
            this.addOutBtn.Size = new System.Drawing.Size(208, 62);
            this.addOutBtn.TabIndex = 3;
            this.addOutBtn.Text = "ADD OUTCOME";
            this.addOutBtn.UseVisualStyleBackColor = false;
            this.addOutBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // inoutDG
            // 
            this.inoutDG.AllowUserToAddRows = false;
            this.inoutDG.AllowUserToOrderColumns = true;
            this.inoutDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inoutDG.BackgroundColor = System.Drawing.SystemColors.Control;
            this.inoutDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inoutDG.Location = new System.Drawing.Point(37, 93);
            this.inoutDG.Name = "inoutDG";
            this.inoutDG.RowHeadersWidth = 51;
            this.inoutDG.RowTemplate.Height = 24;
            this.inoutDG.Size = new System.Drawing.Size(648, 470);
            this.inoutDG.TabIndex = 4;
            this.inoutDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inoutDG_CellContentClick);
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Font = new System.Drawing.Font("Montserrat SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbl.Location = new System.Drawing.Point(29, 33);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(319, 46);
            this.userLbl.TabIndex = 7;
            this.userLbl.Text = "User\'s Dashboard";
            this.userLbl.Click += new System.EventHandler(this.userLbl_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteBtn.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteBtn.Location = new System.Drawing.Point(477, 582);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(208, 62);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "DELETE INOUT";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // PPdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.inoutDG);
            this.Controls.Add(this.addOutBtn);
            this.Controls.Add(this.addInBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.balancePanel);
            this.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PPdashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.PPdashboard_Load);
            this.balancePanel.ResumeLayout(false);
            this.balancePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inoutDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel balancePanel;
        private System.Windows.Forms.Label outcomeTitleLbl;
        private System.Windows.Forms.Label incomeTitleLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label totalTitleLbl;
        private System.Windows.Forms.Label incomeLbl;
        private System.Windows.Forms.Label outCurrencyLbl;
        private System.Windows.Forms.Label inCurrencyLbl;
        private System.Windows.Forms.Label outcomeLbl;
        private System.Windows.Forms.Label ToCurrencyLbl;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Button addInBtn;
        private System.Windows.Forms.Button addOutBtn;
        private System.Windows.Forms.DataGridView inoutDG;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Button deleteBtn;
    }
}