namespace calculator_simple
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();

            // Form�S�̂ŃL�[�C�x���g�����o
            this.KeyPreview = true;
            this.KeyUp += FormCalculator_KeyUp;
        }

        // textInput�����ݒ�
        private bool inputOverwrite = true;
        //private bool decimalStatus = false;

        /// <summary>
        ///  keyEvent�̕���
        /// </summary>
        private void FormCalculator_KeyUp(object? sender, KeyEventArgs e)
        {
            int keyNum = (int)e.KeyCode - 0x30;
            if ((keyNum >= 0) && (keyNum <= 9))
            {
                NumSet(keyNum.ToString());
            }

        }
        private void NumPads_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        ///  input����
        /// </summary>
        private void NumSet(string numText)
        {
            if (inputOverwrite == true)
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
    }
}