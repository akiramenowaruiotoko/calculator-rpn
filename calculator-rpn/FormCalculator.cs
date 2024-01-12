namespace calculator_simple
{
    public partial class FormCalculator : Form
    {
        // UI関連の変数
        private bool inputOverwrite = true;
        private bool decimalStatus = false;
        private string markText = "";
        private readonly Stack<double> cStack = new();

        // コンストラクタ
        public FormCalculator()
        {
            InitializeComponent();

            // キーイベントを検出
            this.KeyPreview = true;
            this.KeyUp += FormCalculator_KeyUp;
        }

        // キーイベントの処理
        private void FormCalculator_KeyUp(object? sender, KeyEventArgs e)
        {
            int eValue = e.KeyValue;

            // キーコードの置き換え
            if ((eValue >= (int)Keys.D0) && (eValue <= (int)Keys.D9))
            {
                eValue -= (int)Keys.D0;
            }
            else if ((eValue >= (int)Keys.NumPad0) && (eValue <= (int)Keys.NumPad9))
            {
                eValue -= (int)Keys.NumPad0;
            }

            // 入力キーに対する処理
            HandleInputKey(e.KeyCode, eValue);
        }

        // 入力キーに対する処理
        private void HandleInputKey(Keys keyCode, int eValue)
        {
            switch (keyCode)
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
                    markText = "×";
                    break;
                case Keys.Divide:
                case Keys.Oem2:
                    markText = "÷";
                    break;
                default:
                    if ((eValue >= 0) && (eValue <= 9))
                    {
                        // 数字キーの場合はNumSetメソッドを呼び出し
                        NumSet(eValue.ToString());
                    }
                    return;
            }

            // 入力キーに対する計算処理
            Calc(markText);
        }

        // 数字ボタンのクリックイベント
        private void ButtonNums_Click(object sender, EventArgs e)
        {
            NumSet(((Button)sender).Text);
        }

        // 演算子ボタンのクリックイベント
        private void ButtonMarks_Click(object sender, EventArgs e)
        {
            Calc(((Button)sender).Text);
        }

        // 数字の処理
        private void NumSet(string numText)
        {
            if (textInput.Text.Length > 16)
            {
                textComment.Text = "Input text is Overflow: Digit limit is 16";
                return;
            }

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

        // 演算の処理
        private void Calc(string mark)
        {
            textComment.Text = "";

            switch (mark)
            {
                case ".":
                    HandleDecimalInput();
                    break;
                case "+/-":
                    ReverseSign();
                    break;
                case "StackC":
                    DeleteOneStack();
                    break;
                default:
                    PerformCalculation(mark);
                    break;
            }

            UpdateStackLabels();
        }

        // 小数点の処理
        private void HandleDecimalInput()
        {
            if (!decimalStatus)
            {
                textInput.Text += ".";
                decimalStatus = true;
                inputOverwrite = false;
            }
        }

        // 符号反転の処理
        private void ReverseSign()
        {
            if (textInput.Text.Contains('-'))
            {
                textInput.Text = textInput.Text.Replace("-", "");
            }
            else
            {
                textInput.Text = "-" + textInput.Text;
            }
        }

        // スタックから一つ削除する処理
        private void DeleteOneStack()
        {
            if (cStack.Count < 1)
            {
                textComment.Text = "Stack is empty.";
                return;
            }

            cStack.Pop();
        }

        // 演算の実行
        private void PerformCalculation(string mark)
        {
            double calcNum = double.Parse(textInput.Text);
            textInput.Text = "0";
            decimalStatus = false;
            inputOverwrite = true;

            switch (mark)
            {
                case "Enter":
                    PushToStack(calcNum);
                    break;
                case "C":
                    // Cキーが押された場合は何もしない
                    break;
                case "AC":
                    ClearStack();
                    break;
                default:
                    PerformArithmeticOperation(mark);
                    break;
            }
        }

        // スタックにプッシュする処理
        private void PushToStack(double value)
        {
            if (cStack.Count >= 5)
            {
                textComment.Text = "Stack is Overflow: Stack limit is 5";
                return;
            }

            cStack.Push(value);
        }

        // スタックをクリアする処理
        private void ClearStack()
        {
            cStack.Clear();
        }

        // 四則演算の処理
        private void PerformArithmeticOperation(string mark)
        {
            if (cStack.Count < 2)
            {
                textComment.Text = "Out of stack.";
                return;
            }

            double stack1 = cStack.Pop();
            double stack2 = cStack.Pop();

            switch (mark)
            {
                case "+":
                    cStack.Push(stack1 + stack2);
                    break;
                case "-":
                    cStack.Push(stack2 - stack1);
                    break;
                case "×":
                    cStack.Push(stack1 * stack2);
                    break;
                case "÷":
                    HandleDivisionOperation(stack1, stack2);
                    break;
                default:
                    break;
            }
        }

        // 除算の処理
        private void HandleDivisionOperation(double stack1, double stack2)
        {
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
        }

        // スタックラベルの更新
        private void UpdateStackLabels()
        {
            for (int i = 5; i > 0; i--)
            {
                // Sequential number control to textStack
                Control[] textStacks = this.Controls.Find($"textStack{i}", true);

                // output stack to the textStack.text 
                if (cStack.Count >= i)
                {
                    // スタックの値を表示
                    textStacks[0].Text = cStack.ElementAt(i - 1).ToString();
                }
                else
                {
                    // スタックが不足する場合は表示をクリア
                    textStacks[0].Text = "";
                }
            }
        }
    }
}
