namespace PatronPocket
{
    partial class addOutput
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
            this.addOutcome = new System.Windows.Forms.Button();
            this.outcomeDate = new System.Windows.Forms.DateTimePicker();
            this.dateLbl = new System.Windows.Forms.Label();
            this.currency = new System.Windows.Forms.ComboBox();
            this.value = new System.Windows.Forms.TextBox();
            this.valueLbl = new System.Windows.Forms.Label();
            this.outcomeName = new System.Windows.Forms.TextBox();
            this.outcomeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addOutcome
            // 
            this.addOutcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.addOutcome.Font = new System.Drawing.Font("Montserrat Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOutcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addOutcome.Location = new System.Drawing.Point(117, 500);
            this.addOutcome.Name = "addOutcome";
            this.addOutcome.Size = new System.Drawing.Size(249, 49);
            this.addOutcome.TabIndex = 31;
            this.addOutcome.Text = "ADD OUTCOME";
            this.addOutcome.UseVisualStyleBackColor = false;
            this.addOutcome.Click += new System.EventHandler(this.addIncome_Click);
            // 
            // outcomeDate
            // 
            this.outcomeDate.Location = new System.Drawing.Point(117, 355);
            this.outcomeDate.Name = "outcomeDate";
            this.outcomeDate.Size = new System.Drawing.Size(249, 28);
            this.outcomeDate.TabIndex = 30;
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(213, 314);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(61, 27);
            this.dateLbl.TabIndex = 29;
            this.dateLbl.Text = "Date";
            // 
            // currency
            // 
            this.currency.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currency.FormattingEnabled = true;
            this.currency.Items.AddRange(new object[] {
            "ALL"});
            this.currency.Location = new System.Drawing.Point(306, 225);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(60, 32);
            this.currency.TabIndex = 28;
            this.currency.Text = "ALL";
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(117, 225);
            this.value.Multiline = true;
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(183, 32);
            this.value.TabIndex = 27;
            // 
            // valueLbl
            // 
            this.valueLbl.AutoSize = true;
            this.valueLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLbl.Location = new System.Drawing.Point(213, 183);
            this.valueLbl.Name = "valueLbl";
            this.valueLbl.Size = new System.Drawing.Size(67, 27);
            this.valueLbl.TabIndex = 26;
            this.valueLbl.Text = "Value";
            // 
            // outcomeName
            // 
            this.outcomeName.Location = new System.Drawing.Point(117, 114);
            this.outcomeName.Multiline = true;
            this.outcomeName.Name = "outcomeName";
            this.outcomeName.Size = new System.Drawing.Size(249, 32);
            this.outcomeName.TabIndex = 25;
            // 
            // outcomeLbl
            // 
            this.outcomeLbl.AutoSize = true;
            this.outcomeLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outcomeLbl.Location = new System.Drawing.Point(159, 75);
            this.outcomeLbl.Name = "outcomeLbl";
            this.outcomeLbl.Size = new System.Drawing.Size(173, 27);
            this.outcomeLbl.TabIndex = 24;
            this.outcomeLbl.Text = "Outcome Name";
            // 
            // addOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 624);
            this.Controls.Add(this.addOutcome);
            this.Controls.Add(this.outcomeDate);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.currency);
            this.Controls.Add(this.value);
            this.Controls.Add(this.valueLbl);
            this.Controls.Add(this.outcomeName);
            this.Controls.Add(this.outcomeLbl);
            this.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addOutput";
            this.Text = "ADD OUTPUT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addOutcome;
        private System.Windows.Forms.DateTimePicker outcomeDate;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.ComboBox currency;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.Label valueLbl;
        private System.Windows.Forms.TextBox outcomeName;
        private System.Windows.Forms.Label outcomeLbl;
    }
}