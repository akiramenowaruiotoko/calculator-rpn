namespace calculator_simple
{
    public partial class FormCalculator : Form
    {
        // UI�֘A�̕ϐ�
        private bool inputOverwrite = true;
        private bool decimalStatus = false;
        private string markText = "";
        private readonly Stack<double> cStack = new();

        // �R���X�g���N�^
        public FormCalculator()
        {
            InitializeComponent();

            // �L�[�C�x���g�����o
            this.KeyPreview = true;
            this.KeyUp += FormCalculator_KeyUp;
        }

        // �L�[�C�x���g�̏���
        private void FormCalculator_KeyUp(object? sender, KeyEventArgs e)
        {
            int eValue = e.KeyValue;

            // �L�[�R�[�h�̒u������
            if ((eValue >= (int)Keys.D0) && (eValue <= (int)Keys.D9))
            {
                eValue -= (int)Keys.D0;
            }
            else if ((eValue >= (int)Keys.NumPad0) && (eValue <= (int)Keys.NumPad9))
            {
                eValue -= (int)Keys.NumPad0;
            }

            // ���̓L�[�ɑ΂��鏈��
            HandleInputKey(e.KeyCode, eValue);
        }

        // ���̓L�[�ɑ΂��鏈��
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
                    markText = "�~";
                    break;
                case Keys.Divide:
                case Keys.Oem2:
                    markText = "��";
                    break;
                default:
                    if ((eValue >= 0) && (eValue <= 9))
                    {
                        // �����L�[�̏ꍇ��NumSet���\�b�h���Ăяo��
                        NumSet(eValue.ToString());
                    }
                    return;
            }

            // ���̓L�[�ɑ΂���v�Z����
            Calc(markText);
        }

        // �����{�^���̃N���b�N�C�x���g
        private void ButtonNums_Click(object sender, EventArgs e)
        {
            NumSet(((Button)sender).Text);
        }

        // ���Z�q�{�^���̃N���b�N�C�x���g
        private void ButtonMarks_Click(object sender, EventArgs e)
        {
            Calc(((Button)sender).Text);
        }

        // �����̏���
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

        // ���Z�̏���
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

        // �����_�̏���
        private void HandleDecimalInput()
        {
            if (!decimalStatus)
            {
                textInput.Text += ".";
                decimalStatus = true;
                inputOverwrite = false;
            }
        }

        // �������]�̏���
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

        // �X�^�b�N�����폜���鏈��
        private void DeleteOneStack()
        {
            if (cStack.Count < 1)
            {
                textComment.Text = "Stack is empty.";
                return;
            }

            cStack.Pop();
        }

        // ���Z�̎��s
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
                    // C�L�[�������ꂽ�ꍇ�͉������Ȃ�
                    break;
                case "AC":
                    ClearStack();
                    break;
                default:
                    PerformArithmeticOperation(mark);
                    break;
            }
        }

        // �X�^�b�N�Ƀv�b�V�����鏈��
        private void PushToStack(double value)
        {
            if (cStack.Count >= 5)
            {
                textComment.Text = "Stack is Overflow: Stack limit is 5";
                return;
            }

            cStack.Push(value);
        }

        // �X�^�b�N���N���A���鏈��
        private void ClearStack()
        {
            cStack.Clear();
        }

        // �l�����Z�̏���
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
                case "�~":
                    cStack.Push(stack1 * stack2);
                    break;
                case "��":
                    HandleDivisionOperation(stack1, stack2);
                    break;
                default:
                    break;
            }
        }

        // ���Z�̏���
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

        // �X�^�b�N���x���̍X�V
        private void UpdateStackLabels()
        {
            for (int i = 5; i > 0; i--)
            {
                // Sequential number control to textStack
                Control[] textStacks = this.Controls.Find($"textStack{i}", true);

                // output stack to the textStack.text 
                if (cStack.Count >= i)
                {
                    // �X�^�b�N�̒l��\��
                    textStacks[0].Text = cStack.ElementAt(i - 1).ToString();
                }
                else
                {
                    // �X�^�b�N���s������ꍇ�͕\�����N���A
                    textStacks[0].Text = "";
                }
            }
        }
    }
}
