namespace calculator_simple
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();

            // Detect key events throughout the form
            this.KeyPreview = true;
            this.KeyUp += FormCalculator_KeyUp;
        }
        // initial setting textInput
        private bool inputOverwrite = true;
        private bool decimalStatus = false;

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
                    Decimal_Click(this, e);
                    break;
                default:
                    // call NumSet if eCaode is 0 to 9
                    NumSet(eValue.ToString());
                    return;
            }
        }
        private void NumButton_Click(object sender, EventArgs e)
        {
            // call NumSet
            NumSet(((Button)sender).Text);
        }
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
        private void Decimal_Click(object sender, EventArgs e)
        {
            if (!decimalStatus)
            {
                textInput.Text += ".";
                decimalStatus = true;
            }
        }
    }
}