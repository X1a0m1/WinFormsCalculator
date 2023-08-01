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
        outputTextBox.Text = _result.ToString();

        UpdateDebugValues();
    }

    private void NumButton_Click(object sender, EventArgs e)
    {
        if (outputTextBox.MaxLength > outputTextBox.Text.Length)
        {
            if (!_inputActive)
            {
                outputTextBox.Clear();
                _inputActive = true;
            }
            outputTextBox.Text += (sender as Button)!.Text;
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
        outputTextBox.Text = _result.ToString();

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
        outputTextBox.Text = _result.ToString();
        if (_secondOperand == _result)
        {
            SetOperand(_result);
        }
        _inputActive = false;

        UpdateDebugValues();
    }

    private void OutputTextBox_TextChanged(object sender, EventArgs e)
    {
        if (int.TryParse(outputTextBox.Text, out int value))
        {
            SetOperand(value);
        }
    }
    private void SetOperand(int value)
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

    private void UpdateDebugValues()
    {
        firstText.Text = _firstOperand.ToString();
        operText.Text = _operation?.ToString() ?? "NULL";
        operActText.Text = _operatorActive.ToString();
        secondText.Text = _secondOperand.ToString();
        resultText.Text = _result.ToString();
    }
}