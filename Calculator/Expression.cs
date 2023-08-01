namespace Calculator;

internal static class Expression
{
    public static int Calculate(int leftOperand, int rightOperand, Operation? operationType)
    {
        return operationType switch
        {
            Operation.Add => leftOperand + rightOperand,
            Operation.Subtract => leftOperand - rightOperand,
            Operation.Multiply => leftOperand * rightOperand,
            Operation.Divide => leftOperand / rightOperand,
            _ => throw new ArgumentException("Unknown operation."),
        };
    }
    public static double Calculate(double leftOperand, double rightOperand, Operation? operationType)
    {
        return operationType switch
        {
            Operation.Add => leftOperand + rightOperand,
            Operation.Subtract => leftOperand - rightOperand,
            Operation.Multiply => leftOperand * rightOperand,
            Operation.Divide => leftOperand / rightOperand,
            _ => throw new ArgumentException("Unknown operation."),
        };
    }
}