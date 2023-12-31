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
                    ButtonDecimal_Click(this, e);
                    break;
                case Keys.C:
                    ButtonC_Click(this, e);
                    break;
                default:
                    // call NumSet if eValue is 0 to 9
                    if ((eValue >= 0) && (eValue <= 9))
                    {
                        NumSet(eValue.ToString());
                    }
                    break;
            }
        }

        /// <summary>
        ///  Button_Cleck events
        /// </summary>
        private void ButtonNums_Click(object sender, EventArgs e)
        {
            // call NumSet
            NumSet(((Button)sender).Text);
        }
        private void ButtonDecimal_Click(object sender, EventArgs e)
        {
            if (!decimalStatus)
            {
                textInput.Text += ".";
                decimalStatus = true;
                inputOverwrite = false;
            }
        }
        private void ButtonC_Click(object sender, EventArgs e)
        {
            textInput.Text = "0";
            decimalStatus = false;
            inputOverwrite = true;
        }

        /// <summary>
        ///  functions
        /// </summary>
        private void NumSet(string numText)
        {
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

        private void ButtonexEnter_Click(object sender, EventArgs e)
        {

        }

        private void ButtonexStackClear_Click(object sender, EventArgs e)
        {

        }

        private void ButtonexSign_Click(object sender, EventArgs e)
        {

        }

        private void ButtonexAllClear_Click(object sender, EventArgs e)
        {

        }

        private void ButtonexAdd_Click(object sender, EventArgs e)
        {

        }

        private void ButtonexSubtract_Click(object sender, EventArgs e)
        {

        }

        private void ButtonexMultiply_Click(object sender, EventArgs e)
        {

        }

        private void ButtonexDivide_Click(object sender, EventArgs e)
        {

        }
    }
}