namespace calculator_simple
{
    partial class FormCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelStack1 = new Label();
            labelStack2 = new Label();
            NumPad0 = new ButtonEX();
            NumPad1 = new ButtonEX();
            NumPad2 = new ButtonEX();
            NumPad3 = new ButtonEX();
            NumPad4 = new ButtonEX();
            NumPad5 = new ButtonEX();
            NumPad6 = new ButtonEX();
            NumPad7 = new ButtonEX();
            NumPad8 = new ButtonEX();
            NumPad9 = new ButtonEX();
            Decimal = new ButtonEX();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Yu Gothic UI", 18F);
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(389, 65);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "calculator-simple";
            // 
            // labelStack1
            // 
            labelStack1.AutoSize = true;
            labelStack1.Font = new Font("Yu Gothic UI", 12F);
            labelStack1.Location = new Point(43, 110);
            labelStack1.Name = "labelStack1";
            labelStack1.Size = new Size(94, 45);
            labelStack1.TabIndex = 1;
            labelStack1.Text = "input";
            // 
            // labelStack2
            // 
            labelStack2.BackColor = SystemColors.ButtonHighlight;
            labelStack2.Font = new Font("Yu Gothic UI", 12F);
            labelStack2.Location = new Point(163, 110);
            labelStack2.Name = "labelStack2";
            labelStack2.Size = new Size(404, 45);
            labelStack2.TabIndex = 2;
            labelStack2.Text = "0";
            labelStack2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NumPad0
            // 
            NumPad0.Location = new Point(159, 437);
            NumPad0.Name = "NumPad0";
            NumPad0.Size = new Size(130, 59);
            NumPad0.TabIndex = 3;
            NumPad0.Text = "0";
            NumPad0.UseVisualStyleBackColor = true;
            // 
            // NumPad1
            // 
            NumPad1.Location = new Point(159, 372);
            NumPad1.Name = "NumPad1";
            NumPad1.Size = new Size(62, 59);
            NumPad1.TabIndex = 4;
            NumPad1.Text = "1";
            NumPad1.UseVisualStyleBackColor = true;
            // 
            // NumPad2
            // 
            NumPad2.Location = new Point(227, 372);
            NumPad2.Name = "NumPad2";
            NumPad2.Size = new Size(62, 59);
            NumPad2.TabIndex = 5;
            NumPad2.Text = "2";
            NumPad2.UseVisualStyleBackColor = true;
            // 
            // NumPad3
            // 
            NumPad3.Location = new Point(295, 372);
            NumPad3.Name = "NumPad3";
            NumPad3.Size = new Size(62, 59);
            NumPad3.TabIndex = 6;
            NumPad3.Text = "3";
            NumPad3.UseVisualStyleBackColor = true;
            // 
            // NumPad4
            // 
            NumPad4.Location = new Point(159, 307);
            NumPad4.Name = "NumPad4";
            NumPad4.Size = new Size(62, 59);
            NumPad4.TabIndex = 7;
            NumPad4.Text = "4";
            NumPad4.UseVisualStyleBackColor = true;
            // 
            // NumPad5
            // 
            NumPad5.Location = new Point(227, 307);
            NumPad5.Name = "NumPad5";
            NumPad5.Size = new Size(62, 59);
            NumPad5.TabIndex = 8;
            NumPad5.Text = "5";
            NumPad5.UseVisualStyleBackColor = true;
            // 
            // NumPad6
            // 
            NumPad6.Location = new Point(295, 307);
            NumPad6.Name = "NumPad6";
            NumPad6.Size = new Size(62, 59);
            NumPad6.TabIndex = 9;
            NumPad6.Text = "6";
            NumPad6.UseVisualStyleBackColor = true;
            // 
            // NumPad7
            // 
            NumPad7.Location = new Point(159, 242);
            NumPad7.Name = "NumPad7";
            NumPad7.Size = new Size(62, 59);
            NumPad7.TabIndex = 10;
            NumPad7.Text = "7";
            NumPad7.UseVisualStyleBackColor = true;
            // 
            // NumPad8
            // 
            NumPad8.Location = new Point(227, 242);
            NumPad8.Name = "NumPad8";
            NumPad8.Size = new Size(62, 59);
            NumPad8.TabIndex = 11;
            NumPad8.Text = "8";
            NumPad8.UseVisualStyleBackColor = true;
            // 
            // NumPad9
            // 
            NumPad9.Location = new Point(295, 242);
            NumPad9.Name = "NumPad9";
            NumPad9.Size = new Size(62, 59);
            NumPad9.TabIndex = 12;
            NumPad9.Text = "9";
            NumPad9.UseVisualStyleBackColor = true;
            // 
            // Decimal
            // 
            Decimal.Location = new Point(295, 437);
            Decimal.Name = "Decimal";
            Decimal.Size = new Size(62, 59);
            Decimal.TabIndex = 13;
            Decimal.Text = ".";
            Decimal.UseVisualStyleBackColor = true;
            // 
            // FormCalculator
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 742);
            Controls.Add(Decimal);
            Controls.Add(NumPad9);
            Controls.Add(NumPad8);
            Controls.Add(NumPad7);
            Controls.Add(NumPad6);
            Controls.Add(NumPad5);
            Controls.Add(NumPad4);
            Controls.Add(NumPad3);
            Controls.Add(NumPad2);
            Controls.Add(NumPad1);
            Controls.Add(NumPad0);
            Controls.Add(labelStack2);
            Controls.Add(labelStack1);
            Controls.Add(labelTitle);
            Name = "FormCalculator";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelStack1;
        private Label labelStack2;
        private ButtonEX NumPad0;
        private ButtonEX NumPad1;
        private ButtonEX NumPad2;
        private ButtonEX NumPad3;
        private ButtonEX NumPad4;
        private ButtonEX NumPad5;
        private ButtonEX NumPad6;
        private ButtonEX NumPad7;
        private ButtonEX NumPad8;
        private ButtonEX NumPad9;
        private ButtonEX Decimal;
    }
}
