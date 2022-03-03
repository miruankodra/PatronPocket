namespace PatronPocket
{
    partial class addIncome
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
            this.label1 = new System.Windows.Forms.Label();
            this.incomeName = new System.Windows.Forms.TextBox();
            this.value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.currency = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.incomeDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Income Name";
            // 
            // incomeName
            // 
            this.incomeName.Location = new System.Drawing.Point(105, 80);
            this.incomeName.Multiline = true;
            this.incomeName.Name = "incomeName";
            this.incomeName.Size = new System.Drawing.Size(249, 32);
            this.incomeName.TabIndex = 1;
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(105, 191);
            this.value.Multiline = true;
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(183, 32);
            this.value.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Value";
            // 
            // currency
            // 
            this.currency.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currency.FormattingEnabled = true;
            this.currency.Items.AddRange(new object[] {
            "ALL"});
            this.currency.Location = new System.Drawing.Point(294, 191);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(60, 32);
            this.currency.TabIndex = 20;
            this.currency.Text = "ALL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 27);
            this.label3.TabIndex = 21;
            this.label3.Text = "Date";
            // 
            // incomeDate
            // 
            this.incomeDate.Location = new System.Drawing.Point(105, 321);
            this.incomeDate.Name = "incomeDate";
            this.incomeDate.Size = new System.Drawing.Size(249, 28);
            this.incomeDate.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.button1.Font = new System.Drawing.Font("Montserrat Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(105, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 49);
            this.button1.TabIndex = 23;
            this.button1.Text = "ADD INCOME";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 624);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.incomeDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currency);
            this.Controls.Add(this.value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.incomeName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addIncome";
            this.Text = "ADD INCOME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox incomeName;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox currency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker incomeDate;
        private System.Windows.Forms.Button button1;
    }
}