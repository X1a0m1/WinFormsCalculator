namespace Calculator;

public partial class Form1 : Form
{
    private int _result, _firstOperand, _secondOperand;
    private Operation? _operation = null;
    private bool _operatorActive = false;
    private bool _inputActive = false;

    public Form1()
    {
        InitializeComponent();
        textBox1.Text = _result.ToString();

        UpdateDebugValues();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }
    private void NumButton_Click(object sender, EventArgs e)
    {
        if (textBox1.MaxLength > textBox1.Text.Length)
        {
            if (!_inputActive)
            {
                textBox1.Clear();
                _inputActive = true;
            }
            textBox1.Text += (sender as Button)!.Text;
        }

        UpdateDebugValues();
    }
    private void ClearButton_Click(object sender, EventArgs e)
    {
        _operatorActive = false;
        _inputActive = false;
        _result = 0;
        _operation = null;
        _secondOperand = 0;
        textBox1.Clear();
        textBox1.Text = _result.ToString();

        UpdateDebugValues();
    }
    private void OperButton_Click(object sender, EventArgs e)
    {
        if (_operatorActive)
        {
            EqualsButton_Click(sender, e);
        }
        _operatorActive = true;
        _operation = (Operation?)(sender as Button)!.Tag;
        _secondOperand = _firstOperand;
        _inputActive = false;

        UpdateDebugValues();
    }
    private void EqualsButton_Click(object sender, EventArgs e)
    {
        if (_operation == null)
        {
            _result = _firstOperand;
        }
        else
        {
            _result = Expression.Calculate(_firstOperand, _secondOperand, _operation);
        }
        _operatorActive = false;
        textBox1.Text = _result.ToString();
        _inputActive = false;

        UpdateDebugValues();
    }

    private void TextBox1_TextChanged(object sender, EventArgs e)
    {
        if (int.TryParse(textBox1.Text, out int value))
        {
            if (_operatorActive)
            {
                _secondOperand = value;
            }
            else
            {
                _firstOperand = value;
            }
        }
    }

    private void UpdateDebugValues()
    {
        firstText.Text = _firstOperand.ToString();
        operText.Text = _operation?.ToString() ?? "NULL";
        operActText.Text = _operatorActive.ToString();
        secondText.Text = _secondOperand.ToString();
        resultText.Text = _result.ToString();
    }
}