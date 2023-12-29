namespace calculator_simple
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();

            // Form全体でキーイベントを検出
            this.KeyPreview = true;
            this.KeyUp += FormCalculator_KeyUp;
        }

        // textInput初期設定
        private bool inputOverwrite = true;
        //private bool decimalStatus = false;

        /// <summary>
        ///  keyEventの分岐
        /// </summary>
        private void FormCalculator_KeyUp(object? sender, KeyEventArgs e)
        {
            int keyNum = (int)e.KeyCode;
            // キーボードとキーパッドの値を0_9に修正
            if ((keyNum >= 0x30) && (keyNum <= 0x39))
            {
                keyNum -= 0x30;
            }
            else if ((keyNum >= 0x60) && (keyNum <= 0x69 ))
            {
                keyNum -= 0x60;
            }

            // NumSet関数呼び出し
            if ((keyNum >= 0) && (keyNum <= 9))
            {
                NumSet(keyNum.ToString());
            }

        }
        private void NumPads_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        ///  input処理
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