using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace calculator_simple
{
    public partial class FormCalculator : Form
    {
        /// <summary>
        ///  initial setting
        /// </summary>
        public FormCalculator()
        {
            InitializeComponent();

            // Detect key events throughout the form
            this.KeyPreview = true;
            this.KeyUp += FormCalculator_KeyUp;
        }

        // setting textInput
        private bool inputOverwrite = true;
        private bool decimalStatus = false;

        // Variable for input key identification
        string markText = "";

        // Instantiate .NET Stack collection
        private Stack<double> cStack = new Stack<double>();

        /// <summary>
        ///  branch KeyUp events
        /// </summary>
        private void FormCalculator_KeyUp(object? sender, KeyEventArgs e)
        {
            int eValue = e.KeyValue;
            // Replace keyboard and keypad KeyCode values from 0 to 9
            if ((eValue >= (int)Keys.D0) && (eValue <= (int)Keys.D9))
            {
                eValue -= (int)Keys.D0;
            }
            else if ((eValue >= (int)Keys.NumPad0) && (eValue >= (int)Keys.NumPad9))
            {
                eValue -= (int)Keys.NumPad0;
            }

            // switch call function
            switch (e.KeyCode)
            {
                case Keys.Decimal:
                case Keys.OemPeriod:
                    markText = ".";
                    break;
                case Keys.Enter:
                    markText = "Enter";
                    break;
                case Keys.C:
                    markText = "C";
                    break;
                case Keys.S:
                    markText = "+/-";
                    break;
                case Keys.Delete:
                    markText = "AC";
                    break;
                case Keys.Back:
                    markText = "StackC";
                    break;
                case Keys.Add:
                case Keys.Oemplus:
                    markText = "+";
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    markText = "-";
                    break;
                case Keys.Multiply:
                case Keys.Oem1:
                    markText = "~";
                    break;
                case Keys.Divide:
                case Keys.Oem2:
                    markText = "€"; break;
                default:
                    // call NumSet if eValue is 0 to 9
                    if ((eValue >= 0) && (eValue <= 9))
                    {
                        NumSet(eValue.ToString());
                    }
                    return;
            }
            Calc(markText);
        }

        /// <summary>
        ///  Button_Click events
        /// </summary>
        private void ButtonNums_Click(object sender, EventArgs e)
        {
            // call NumSet
            NumSet(((Button)sender).Text);
        }
        private void ButtonMarks_Click(object sender, EventArgs e)
        {
            // call Calc
            Calc(((Button)sender).Text);
        }

        /// <summary>
        ///  functions
        /// </summary>
        private void NumSet(string numText)
        {
            // Digit limit 16 digits
            if (textInput.Text.Length > 16)
            {
                textComment.Text = "inputText is Overflow : digit limit 16";
                return;
            }
            // update textInput.Text
            if (inputOverwrite)
            {
                textInput.Text = numText;
                if (numText != "0")
                {
                    inputOverwrite = false;
                }
            }
            else
            {
                textInput.Text += numText;
            }
        }
        private void Calc(string mark)
        {
            // initialize textInput
            textComment.Text = "";

            // inputlabel Excluded processing switch
            switch (mark)
            {
                case ".":
                    // grant "."
                    if (!decimalStatus)
                    {
                        textInput.Text += ".";
                        decimalStatus = true;
                        inputOverwrite = false;
                    }
                    return;
                case "+/-":
                    // revers sign
                    if (textInput.Text.Contains('-'))
                    {
                        textInput.Text = textInput.Text.Replace("-", "");
                    }
                    else
                    {
                        textInput.Text = "-" + textInput.Text;
                    }
                    return;
                case "StackC":
                    // delete one stack
                    if (cStack.Count < 1)
                    {
                        textComment.Text = "Stack is empty.";
                        return;
                    }
                    cStack.Pop();
                    goto stackLabelUpdate;
                default: break;
            }

            // Store the value of textInput in calcNum
            double calcNum = double.Parse(textInput.Text);

                // textInput reset
                textInput.Text = "0";
                decimalStatus = false;
                inputOverwrite = true;

            // inputlabel Subject processing switch
            switch (mark)
            {
                case "Enter":
                    // stack limit 5
                    if(cStack.Count >= 5)
                    {
                        textComment.Text = "stack is Overflow : stack limit 5";
                        return;
                    }
                    // Push the value of calcNum in stack
                    cStack.Push(calcNum);
                    goto stackLabelUpdate;
                case "C":
                    return;
                case "AC":
                    cStack.Clear();
                    goto stackLabelUpdate;
                default: break;
            }

            // Arithmetic processing stack confirmation
            if (cStack.Count < 2)
            {
                textComment.Text = "Out of stack.";
                return;
            }

            // Pop the two variable from stack
            double stack1 = cStack.Pop();
            double stack2 = cStack.Pop();

        // Operator switch processing
        switch (mark)
            {
                case "+":
                    cStack.Push(stack1 + stack2);
                    break;
                case "-":
                    cStack.Push(stack2 - stack1);
                    break;
                case "~":
                    cStack.Push(stack1 * stack2);
                    break;
                case "€":
                    if (stack1 == 0.0)
                    {
                        cStack.Push(stack2);
                        cStack.Push(stack1);
                        textComment.Text = "Division by 0 is not possible.";
                    }
                    else
                    {
                        cStack.Push(stack2 / stack1);
                    }
                    break;
                default: break;
            }

            // goto
            stackLabelUpdate:

            // update textStack
            for (int i = 5; i > 0; i--)
            {
                // Sequential number control to textStack
                Control[] textStacks = this.Controls.Find($"textStack{i}", true);

                // output stack to the textStack.text 
                if (cStack.Count >= i)
                {
                    textStacks[0].Text = cStack.ElementAt(i - 1).ToString();
                }
                else
                {
                    textStacks[0].Text = "";
                }
            }
        }
    }
}