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
            buttonexEnter = new ButtonEX();
            buttonexStackClear = new ButtonEX();
            buttonexAdd = new ButtonEX();
            buttonexSubtract = new ButtonEX();
            buttonexMultiply = new ButtonEX();
            buttonexDivide = new ButtonEX();
            buttonexSign = new ButtonEX();
            buttonexAllClear = new ButtonEX();
            labelStack5 = new Label();
            textStack5 = new Label();
            textStack4 = new Label();
            labelStack4 = new Label();
            labelStack3 = new Label();
            labelStack2 = new Label();
            labelStack1 = new Label();
            textStack3 = new Label();
            textStack2 = new Label();
            textStack1 = new Label();
            label1 = new Label();
            textComment = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Yu Gothic UI", 18F);
            labelTitle.Location = new Point(11, 12);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(323, 65);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "calculator-rpn";
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Font = new Font("Yu Gothic UI", 12F);
            labelInput.Location = new Point(348, 143);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(94, 45);
            labelInput.TabIndex = 1;
            labelInput.Text = "input";
            // 
            // textInput
            // 
            textInput.BackColor = SystemColors.ButtonHighlight;
            textInput.BorderStyle = BorderStyle.FixedSingle;
            textInput.Font = new Font("Yu Gothic UI", 12F);
            textInput.Location = new Point(463, 143);
            textInput.Name = "textInput";
            textInput.Size = new Size(316, 45);
            textInput.TabIndex = 2;
            textInput.Text = "0";
            textInput.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonEx0
            // 
            buttonEx0.Location = new Point(8, 389);
            buttonEx0.Name = "buttonEx0";
            buttonEx0.Size = new Size(130, 59);
            buttonEx0.TabIndex = 3;
            buttonEx0.Text = "0";
            buttonEx0.UseVisualStyleBackColor = true;
            buttonEx0.Click += ButtonNums_Click;
            // 
            // buttonEx1
            // 
            buttonEx1.Location = new Point(8, 324);
            buttonEx1.Name = "buttonEx1";
            buttonEx1.Size = new Size(62, 59);
            buttonEx1.TabIndex = 4;
            buttonEx1.Text = "1";
            buttonEx1.UseVisualStyleBackColor = true;
            buttonEx1.Click += ButtonNums_Click;
            // 
            // buttonEx2
            // 
            buttonEx2.Location = new Point(76, 324);
            buttonEx2.Name = "buttonEx2";
            buttonEx2.Size = new Size(62, 59);
            buttonEx2.TabIndex = 5;
            buttonEx2.Text = "2";
            buttonEx2.UseVisualStyleBackColor = true;
            buttonEx2.Click += ButtonNums_Click;
            // 
            // buttonEx3
            // 
            buttonEx3.Location = new Point(144, 324);
            buttonEx3.Name = "buttonEx3";
            buttonEx3.Size = new Size(62, 59);
            buttonEx3.TabIndex = 6;
            buttonEx3.Text = "3";
            buttonEx3.UseVisualStyleBackColor = true;
            buttonEx3.Click += ButtonNums_Click;
            // 
            // buttonEx4
            // 
            buttonEx4.Location = new Point(8, 259);
            buttonEx4.Name = "buttonEx4";
            buttonEx4.Size = new Size(62, 59);
            buttonEx4.TabIndex = 7;
            buttonEx4.Text = "4";
            buttonEx4.UseVisualStyleBackColor = true;
            buttonEx4.Click += ButtonNums_Click;
            // 
            // buttonEx5
            // 
            buttonEx5.Location = new Point(76, 259);
            buttonEx5.Name = "buttonEx5";
            buttonEx5.Size = new Size(62, 59);
            buttonEx5.TabIndex = 8;
            buttonEx5.Text = "5";
            buttonEx5.UseVisualStyleBackColor = true;
            buttonEx5.Click += ButtonNums_Click;
            // 
            // buttonEx6
            // 
            buttonEx6.Location = new Point(144, 259);
            buttonEx6.Name = "buttonEx6";
            buttonEx6.Size = new Size(62, 59);
            buttonEx6.TabIndex = 9;
            buttonEx6.Text = "6";
            buttonEx6.UseVisualStyleBackColor = true;
            buttonEx6.Click += ButtonNums_Click;
            // 
            // buttonEx7
            // 
            buttonEx7.Location = new Point(8, 194);
            buttonEx7.Name = "buttonEx7";
            buttonEx7.Size = new Size(62, 59);
            buttonEx7.TabIndex = 10;
            buttonEx7.Text = "7";
            buttonEx7.UseVisualStyleBackColor = true;
            buttonEx7.Click += ButtonNums_Click;
            // 
            // buttonEx8
            // 
            buttonEx8.Location = new Point(76, 194);
            buttonEx8.Name = "buttonEx8";
            buttonEx8.Size = new Size(62, 59);
            buttonEx8.TabIndex = 11;
            buttonEx8.Text = "8";
            buttonEx8.UseVisualStyleBackColor = true;
            buttonEx8.Click += ButtonNums_Click;
            // 
            // buttonEx9
            // 
            buttonEx9.Location = new Point(144, 194);
            buttonEx9.Name = "buttonEx9";
            buttonEx9.Size = new Size(62, 59);
            buttonEx9.TabIndex = 12;
            buttonEx9.Text = "9";
            buttonEx9.UseVisualStyleBackColor = true;
            buttonEx9.Click += ButtonNums_Click;
            // 
            // buttonexDecimal
            // 
            buttonexDecimal.Location = new Point(144, 389);
            buttonexDecimal.Name = "buttonexDecimal";
            buttonexDecimal.Size = new Size(62, 59);
            buttonexDecimal.TabIndex = 13;
            buttonexDecimal.Text = ".";
            buttonexDecimal.UseVisualStyleBackColor = true;
            buttonexDecimal.Click += ButtonMarks_Click;
            // 
            // buttonexC
            // 
            buttonexC.Location = new Point(212, 129);
            buttonexC.Name = "buttonexC";
            buttonexC.Size = new Size(62, 59);
            buttonexC.TabIndex = 14;
            buttonexC.Text = "C";
            buttonexC.UseVisualStyleBackColor = true;
            buttonexC.Click += ButtonMarks_Click;
            // 
            // buttonexEnter
            // 
            buttonexEnter.Location = new Point(212, 324);
            buttonexEnter.Name = "buttonexEnter";
            buttonexEnter.Size = new Size(130, 124);
            buttonexEnter.TabIndex = 15;
            buttonexEnter.Text = "Enter";
            buttonexEnter.UseVisualStyleBackColor = true;
            buttonexEnter.Click += ButtonMarks_Click;
            // 
            // buttonexStackClear
            // 
            buttonexStackClear.Location = new Point(76, 129);
            buttonexStackClear.Name = "buttonexStackClear";
            buttonexStackClear.Size = new Size(130, 59);
            buttonexStackClear.TabIndex = 16;
            buttonexStackClear.Text = "StackC";
            buttonexStackClear.UseVisualStyleBackColor = true;
            buttonexStackClear.Click += ButtonMarks_Click;
            // 
            // buttonexAdd
            // 
            buttonexAdd.Location = new Point(212, 259);
            buttonexAdd.Name = "buttonexAdd";
            buttonexAdd.Size = new Size(62, 59);
            buttonexAdd.TabIndex = 17;
            buttonexAdd.Text = "+";
            buttonexAdd.UseVisualStyleBackColor = true;
            buttonexAdd.Click += ButtonMarks_Click;
            // 
            // buttonexSubtract
            // 
            buttonexSubtract.Location = new Point(212, 194);
            buttonexSubtract.Name = "buttonexSubtract";
            buttonexSubtract.Size = new Size(62, 59);
            buttonexSubtract.TabIndex = 18;
            buttonexSubtract.Text = "-";
            buttonexSubtract.UseVisualStyleBackColor = true;
            buttonexSubtract.Click += ButtonMarks_Click;
            // 
            // buttonexMultiply
            // 
            buttonexMultiply.Location = new Point(280, 259);
            buttonexMultiply.Name = "buttonexMultiply";
            buttonexMultiply.Size = new Size(62, 59);
            buttonexMultiply.TabIndex = 19;
            buttonexMultiply.Text = "×";
            buttonexMultiply.UseVisualStyleBackColor = true;
            buttonexMultiply.Click += ButtonMarks_Click;
            // 
            // buttonexDivide
            // 
            buttonexDivide.Location = new Point(280, 194);
            buttonexDivide.Name = "buttonexDivide";
            buttonexDivide.Size = new Size(62, 59);
            buttonexDivide.TabIndex = 20;
            buttonexDivide.Text = "÷";
            buttonexDivide.UseVisualStyleBackColor = true;
            buttonexDivide.Click += ButtonMarks_Click;
            // 
            // buttonexSign
            // 
            buttonexSign.Location = new Point(280, 129);
            buttonexSign.Name = "buttonexSign";
            buttonexSign.Size = new Size(62, 59);
            buttonexSign.TabIndex = 21;
            buttonexSign.Text = "+/-";
            buttonexSign.UseVisualStyleBackColor = true;
            buttonexSign.Click += ButtonMarks_Click;
            // 
            // buttonexAllClear
            // 
            buttonexAllClear.Location = new Point(8, 129);
            buttonexAllClear.Name = "buttonexAllClear";
            buttonexAllClear.Size = new Size(62, 59);
            buttonexAllClear.TabIndex = 22;
            buttonexAllClear.Text = "AC";
            buttonexAllClear.UseVisualStyleBackColor = true;
            buttonexAllClear.Click += ButtonMarks_Click;
            // 
            // labelStack5
            // 
            labelStack5.AutoSize = true;
            labelStack5.Font = new Font("Yu Gothic UI", 12F);
            labelStack5.Location = new Point(348, 223);
            labelStack5.Name = "labelStack5";
            labelStack5.Size = new Size(109, 45);
            labelStack5.TabIndex = 23;
            labelStack5.Text = "stack5";
            // 
            // textStack5
            // 
            textStack5.BackColor = SystemColors.ButtonHighlight;
            textStack5.BorderStyle = BorderStyle.FixedSingle;
            textStack5.Font = new Font("Yu Gothic UI", 12F);
            textStack5.Location = new Point(463, 223);
            textStack5.Name = "textStack5";
            textStack5.Size = new Size(316, 45);
            textStack5.TabIndex = 24;
            textStack5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textStack4
            // 
            textStack4.BackColor = SystemColors.ButtonHighlight;
            textStack4.BorderStyle = BorderStyle.FixedSingle;
            textStack4.Font = new Font("Yu Gothic UI", 12F);
            textStack4.Location = new Point(463, 268);
            textStack4.Name = "textStack4";
            textStack4.Size = new Size(316, 45);
            textStack4.TabIndex = 26;
            textStack4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelStack4
            // 
            labelStack4.AutoSize = true;
            labelStack4.Font = new Font("Yu Gothic UI", 12F);
            labelStack4.Location = new Point(348, 268);
            labelStack4.Name = "labelStack4";
            labelStack4.Size = new Size(109, 45);
            labelStack4.TabIndex = 25;
            labelStack4.Text = "stack4";
            // 
            // labelStack3
            // 
            labelStack3.AutoSize = true;
            labelStack3.Font = new Font("Yu Gothic UI", 12F);
            labelStack3.Location = new Point(348, 313);
            labelStack3.Name = "labelStack3";
            labelStack3.Size = new Size(109, 45);
            labelStack3.TabIndex = 27;
            labelStack3.Text = "stack3";
            // 
            // labelStack2
            // 
            labelStack2.AutoSize = true;
            labelStack2.Font = new Font("Yu Gothic UI", 12F);
            labelStack2.Location = new Point(348, 358);
            labelStack2.Name = "labelStack2";
            labelStack2.Size = new Size(109, 45);
            labelStack2.TabIndex = 28;
            labelStack2.Text = "stack2";
            labelStack2.UseWaitCursor = true;
            // 
            // labelStack1
            // 
            labelStack1.AutoSize = true;
            labelStack1.Font = new Font("Yu Gothic UI", 12F);
            labelStack1.Location = new Point(348, 403);
            labelStack1.Name = "labelStack1";
            labelStack1.Size = new Size(109, 45);
            labelStack1.TabIndex = 29;
            labelStack1.Text = "stack1";
            labelStack1.UseWaitCursor = true;
            // 
            // textStack3
            // 
            textStack3.BackColor = SystemColors.ButtonHighlight;
            textStack3.BorderStyle = BorderStyle.FixedSingle;
            textStack3.Font = new Font("Yu Gothic UI", 12F);
            textStack3.Location = new Point(463, 313);
            textStack3.Name = "textStack3";
            textStack3.Size = new Size(316, 45);
            textStack3.TabIndex = 30;
            textStack3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textStack2
            // 
            textStack2.BackColor = SystemColors.ButtonHighlight;
            textStack2.BorderStyle = BorderStyle.FixedSingle;
            textStack2.Font = new Font("Yu Gothic UI", 12F);
            textStack2.Location = new Point(463, 358);
            textStack2.Name = "textStack2";
            textStack2.Size = new Size(316, 45);
            textStack2.TabIndex = 31;
            textStack2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textStack1
            // 
            textStack1.BackColor = SystemColors.ButtonHighlight;
            textStack1.BorderStyle = BorderStyle.FixedSingle;
            textStack1.Font = new Font("Yu Gothic UI", 12F);
            textStack1.Location = new Point(463, 403);
            textStack1.Name = "textStack1";
            textStack1.Size = new Size(316, 45);
            textStack1.TabIndex = 32;
            textStack1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F);
            label1.Location = new Point(8, 461);
            label1.Name = "label1";
            label1.Size = new Size(156, 45);
            label1.TabIndex = 33;
            label1.Text = "comment";
            // 
            // textComment
            // 
            textComment.BackColor = SystemColors.Control;
            textComment.Font = new Font("Yu Gothic UI", 12F);
            textComment.Location = new Point(170, 461);
            textComment.Name = "textComment";
            textComment.Size = new Size(609, 45);
            textComment.TabIndex = 34;
            textComment.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Yu Gothic UI", 12F);
            label3.Location = new Point(8, 81);
            label3.Name = "label3";
            label3.Size = new Size(609, 45);
            label3.TabIndex = 35;
            label3.Text = "AC=del, StackC=back, C=C, +/-=S";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormCalculator
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 520);
            Controls.Add(label3);
            Controls.Add(textComment);
            Controls.Add(label1);
            Controls.Add(textStack1);
            Controls.Add(textStack2);
            Controls.Add(textStack3);
            Controls.Add(labelStack1);
            Controls.Add(labelStack2);
            Controls.Add(labelStack3);
            Controls.Add(textStack4);
            Controls.Add(labelStack4);
            Controls.Add(textStack5);
            Controls.Add(labelStack5);
            Controls.Add(buttonexAllClear);
            Controls.Add(buttonexSign);
            Controls.Add(buttonexDivide);
            Controls.Add(buttonexMultiply);
            Controls.Add(buttonexSubtract);
            Controls.Add(buttonexAdd);
            Controls.Add(buttonexStackClear);
            Controls.Add(buttonexEnter);
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
        private ButtonEX buttonexEnter;
        private ButtonEX buttonexStackClear;
        private ButtonEX buttonexAdd;
        private ButtonEX buttonexSubtract;
        private ButtonEX buttonexMultiply;
        private ButtonEX buttonexDivide;
        private ButtonEX buttonexSign;
        private ButtonEX buttonexAllClear;
        private Label labelStack5;
        private Label textStack5;
        private Label textStack4;
        private Label labelStack4;
        private Label labelStack3;
        private Label labelStack2;
        private Label labelStack1;
        private Label textStack3;
        private Label textStack2;
        private Label textStack1;
        private Label label1;
        private Label textComment;
        private Label label3;
    }
}
