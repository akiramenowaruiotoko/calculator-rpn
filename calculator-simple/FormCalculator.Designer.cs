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
            labelInput = new Label();
            textInput = new Label();
            buttonEx0 = new ButtonEX();
            buttonEx1 = new ButtonEX();
            buttonEx2 = new ButtonEX();
            buttonEx3 = new ButtonEX();
            buttonEx4 = new ButtonEX();
            buttonEx5 = new ButtonEX();
            buttonEx6 = new ButtonEX();
            buttonEx7 = new ButtonEX();
            buttonEx8 = new ButtonEX();
            buttonEx9 = new ButtonEX();
            buttonexDecimal = new ButtonEX();
            buttonexC = new ButtonEX();
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
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Font = new Font("Yu Gothic UI", 12F);
            labelInput.Location = new Point(43, 110);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(94, 45);
            labelInput.TabIndex = 1;
            labelInput.Text = "input";
            // 
            // textInput
            // 
            textInput.BackColor = SystemColors.ButtonHighlight;
            textInput.Font = new Font("Yu Gothic UI", 12F);
            textInput.Location = new Point(163, 110);
            textInput.Name = "textInput";
            textInput.Size = new Size(404, 45);
            textInput.TabIndex = 2;
            textInput.Text = "0";
            textInput.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonEx0
            // 
            buttonEx0.Location = new Point(159, 437);
            buttonEx0.Name = "buttonEx0";
            buttonEx0.Size = new Size(130, 59);
            buttonEx0.TabIndex = 3;
            buttonEx0.Text = "0";
            buttonEx0.UseVisualStyleBackColor = true;
            buttonEx0.Click += ButtonNums_Click;
            // 
            // buttonEx1
            // 
            buttonEx1.Location = new Point(159, 372);
            buttonEx1.Name = "buttonEx1";
            buttonEx1.Size = new Size(62, 59);
            buttonEx1.TabIndex = 4;
            buttonEx1.Text = "1";
            buttonEx1.UseVisualStyleBackColor = true;
            buttonEx1.Click += ButtonNums_Click;
            // 
            // buttonEx2
            // 
            buttonEx2.Location = new Point(227, 372);
            buttonEx2.Name = "buttonEx2";
            buttonEx2.Size = new Size(62, 59);
            buttonEx2.TabIndex = 5;
            buttonEx2.Text = "2";
            buttonEx2.UseVisualStyleBackColor = true;
            buttonEx2.Click += ButtonNums_Click;
            // 
            // buttonEx3
            // 
            buttonEx3.Location = new Point(295, 372);
            buttonEx3.Name = "buttonEx3";
            buttonEx3.Size = new Size(62, 59);
            buttonEx3.TabIndex = 6;
            buttonEx3.Text = "3";
            buttonEx3.UseVisualStyleBackColor = true;
            buttonEx3.Click += ButtonNums_Click;
            // 
            // buttonEx4
            // 
            buttonEx4.Location = new Point(159, 307);
            buttonEx4.Name = "buttonEx4";
            buttonEx4.Size = new Size(62, 59);
            buttonEx4.TabIndex = 7;
            buttonEx4.Text = "4";
            buttonEx4.UseVisualStyleBackColor = true;
            buttonEx4.Click += ButtonNums_Click;
            // 
            // buttonEx5
            // 
            buttonEx5.Location = new Point(227, 307);
            buttonEx5.Name = "buttonEx5";
            buttonEx5.Size = new Size(62, 59);
            buttonEx5.TabIndex = 8;
            buttonEx5.Text = "5";
            buttonEx5.UseVisualStyleBackColor = true;
            buttonEx5.Click += ButtonNums_Click;
            // 
            // buttonEx6
            // 
            buttonEx6.Location = new Point(295, 307);
            buttonEx6.Name = "buttonEx6";
            buttonEx6.Size = new Size(62, 59);
            buttonEx6.TabIndex = 9;
            buttonEx6.Text = "6";
            buttonEx6.UseVisualStyleBackColor = true;
            buttonEx6.Click += ButtonNums_Click;
            // 
            // buttonEx7
            // 
            buttonEx7.Location = new Point(159, 242);
            buttonEx7.Name = "buttonEx7";
            buttonEx7.Size = new Size(62, 59);
            buttonEx7.TabIndex = 10;
            buttonEx7.Text = "7";
            buttonEx7.UseVisualStyleBackColor = true;
            buttonEx7.Click += ButtonNums_Click;
            // 
            // buttonEx8
            // 
            buttonEx8.Location = new Point(227, 242);
            buttonEx8.Name = "buttonEx8";
            buttonEx8.Size = new Size(62, 59);
            buttonEx8.TabIndex = 11;
            buttonEx8.Text = "8";
            buttonEx8.UseVisualStyleBackColor = true;
            buttonEx8.Click += ButtonNums_Click;
            // 
            // buttonEx9
            // 
            buttonEx9.Location = new Point(295, 242);
            buttonEx9.Name = "buttonEx9";
            buttonEx9.Size = new Size(62, 59);
            buttonEx9.TabIndex = 12;
            buttonEx9.Text = "9";
            buttonEx9.UseVisualStyleBackColor = true;
            buttonEx9.Click += ButtonNums_Click;
            // 
            // buttonexDecimal
            // 
            buttonexDecimal.Location = new Point(295, 437);
            buttonexDecimal.Name = "buttonexDecimal";
            buttonexDecimal.Size = new Size(62, 59);
            buttonexDecimal.TabIndex = 13;
            buttonexDecimal.Text = ".";
            buttonexDecimal.UseVisualStyleBackColor = true;
            buttonexDecimal.Click += ButtonDecimal_Click;
            // 
            // buttonexC
            // 
            buttonexC.Location = new Point(159, 177);
            buttonexC.Name = "buttonexC";
            buttonexC.Size = new Size(62, 59);
            buttonexC.TabIndex = 14;
            buttonexC.Text = "C";
            buttonexC.UseVisualStyleBackColor = true;
            buttonexC.Click += ButtonC_Click;
            // 
            // FormCalculator
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 742);
            Controls.Add(buttonexC);
            Controls.Add(buttonexDecimal);
            Controls.Add(buttonEx9);
            Controls.Add(buttonEx8);
            Controls.Add(buttonEx7);
            Controls.Add(buttonEx6);
            Controls.Add(buttonEx5);
            Controls.Add(buttonEx4);
            Controls.Add(buttonEx3);
            Controls.Add(buttonEx2);
            Controls.Add(buttonEx1);
            Controls.Add(buttonEx0);
            Controls.Add(textInput);
            Controls.Add(labelInput);
            Controls.Add(labelTitle);
            Name = "FormCalculator";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelInput;
        private Label textInput;
        private ButtonEX buttonEx0;
        private ButtonEX buttonEx1;
        private ButtonEX buttonEx2;
        private ButtonEX buttonEx3;
        private ButtonEX buttonEx4;
        private ButtonEX buttonEx5;
        private ButtonEX buttonEx6;
        private ButtonEX buttonEx7;
        private ButtonEX buttonEx8;
        private ButtonEX buttonEx9;
        private ButtonEX buttonexDecimal;
        private ButtonEX buttonexC;
    }
}
