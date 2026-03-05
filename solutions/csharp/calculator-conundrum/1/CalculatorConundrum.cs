enum Operator
{
    Addition,
    Multiplication,
    Division
}

static class OperatorExtensions
{
    public static Operator FromString(string? op)
    {
        return op switch
        {
            "+" => Operator.Addition,
            "*" => Operator.Multiplication,
            "/" => Operator.Division,
            null => throw new ArgumentNullException(nameof(op), "Operation cannot be null"),
            "" => throw new ArgumentException($"Unknown operator {op}", nameof(op)),
            _ => throw new ArgumentOutOfRangeException(nameof(op), op, null)
        };
    }

    public static int Apply(this Operator op, int operand1, int operand2)
    {
        return op switch
        {
            Operator.Addition => operand1 + operand2,
            Operator.Multiplication => operand1 * operand2,
            Operator.Division => operand2 != 0 ? operand1 / operand2 : throw new DivideByZeroException("Division by zero"),
            _ => throw new ArgumentOutOfRangeException(nameof(op), op, null)
        };  
    }
}


public static class SimpleCalculator
{

    private static readonly string[] AllowedOperations = ["+", "*", "/"];
    
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        var op = OperatorExtensions.FromString(operation);
        try
        {
            var value = op.Apply(operand1, operand2);
            return $"{operand1} {operation} {operand2} = {value}";    
        }
        catch (DivideByZeroException)
        {
            return "Division by zero is not allowed.";
        }
    }
}
