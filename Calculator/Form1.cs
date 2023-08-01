namespace Calculator;

public partial class Form1 : Form
{
    private double _result, _firstOperand, _secondOperand;
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
        string currentText = outputTextBox.Text;
        currentText = currentText.Trim('-');
        if (_inputActive)
        {
            if (outputTextBox.MaxLength > currentText.Length)
            {
                outputTextBox.Text += (sender as Button)!.Text;
            }
        }
        else
        {
            outputTextBox.Clear();
            _inputActive = true;
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
        EnableButtons();

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
        try
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
            outputTextBox.Text = _result.ToString("0.##############");
            if (_secondOperand == _result)
            {
                SetOperand(_result);
            }
        }
        catch
        {
            _operatorActive = false;
            outputTextBox.Text = "Error";
            DisableButtons();
        }
        _inputActive = false;

        UpdateDebugValues();
    }

    private void OutputTextBox_TextChanged(object sender, EventArgs e)
    {
        if (double.TryParse(outputTextBox.Text, out double value))
        {
            SetOperand(value);
        }
    }
    private void SetOperand(double value)
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

    private void DisableButtons()
    {
        additionButton.Enabled = false;
        subtractionButton.Enabled = false;
        multiplicationButton.Enabled = false;
        divisionButton.Enabled = false;

        equalsButton.Enabled = false;

        oneButton.Enabled = false;
        twoButton.Enabled = false;
        threeButton.Enabled = false;
        fourButton.Enabled = false;
        fiveButton.Enabled = false;
        sixButton.Enabled = false;
        sevenButton.Enabled = false;
        eightButton.Enabled = false;
        nineButton.Enabled = false;
        zeroButton.Enabled = false;
    }
    private void EnableButtons()
    {
        additionButton.Enabled = true;
        subtractionButton.Enabled = true;
        multiplicationButton.Enabled = true;
        divisionButton.Enabled = true;

        equalsButton.Enabled = true;

        oneButton.Enabled = true;
        twoButton.Enabled = true;
        threeButton.Enabled = true;
        fourButton.Enabled = true;
        fiveButton.Enabled = true;
        sixButton.Enabled = true;
        sevenButton.Enabled = true;
        eightButton.Enabled = true;
        nineButton.Enabled = true;
        zeroButton.Enabled = true;
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