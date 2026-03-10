public static class DifferenceOfSquares
{
    // modified https://en.wikipedia.org/wiki/Triangular_number
    public static int CalculateSquareOfSum(int max)
    {
        var numerator = max * (max + 1);
        var denominator = 2;
        
        var result = numerator / denominator;

        return result * result;
    }

    // https://www.trans4mind.com/personal_development/mathematics/series/sumNaturalSquares.htm
    public static int CalculateSumOfSquares(int max) {
        var numerator = max * (max + 1) * (2 * max + 1);
        var denominator = 6;
    
        return numerator / denominator;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        var squareOfSums = CalculateSquareOfSum(max);
        var sumOfSquares = CalculateSumOfSquares(max);
        
        return  squareOfSums - sumOfSquares;
    }
}