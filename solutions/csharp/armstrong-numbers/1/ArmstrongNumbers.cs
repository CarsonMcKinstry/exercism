public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        if (number < 1) return true;
        
        var str = number.ToString();

        var numDigits = str.Length;

        var sum = str
            .Select(c => (int)Math.Pow(double.Parse(c.ToString()), numDigits))
            .Sum();
        
        return sum == number;
    }
}