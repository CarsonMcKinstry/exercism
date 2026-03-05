using System.Globalization;

public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier)
    {
        try
        {
            return checked(@base * multiplier).ToString();
        } catch (OverflowException)
        {
            return "*** Too Big ***";
        }
    }

    public static string DisplayGDP(float @base, float multiplier)
    {

        var value = @base * multiplier;
        return float.IsInfinity(value) ? "*** Too Big ***" : $"{value}";

    }

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
        try
        {
            return $"{checked(salaryBase * multiplier)}";
        } catch  (OverflowException)
        {
            return "*** Much Too Big ***";
        }
    }
}
