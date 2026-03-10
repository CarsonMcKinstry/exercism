public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class ClassificationExtension
{
    public static Classification Classify(int number, int aliquotSum)
    {
        
        if (aliquotSum == number)
        {
            return Classification.Perfect;
        }
        if (aliquotSum > number)
        {
            return Classification.Abundant;
        }
        return Classification.Deficient;
    }
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(number));
        }
        
        var half = (number / 2) + 1;

        var factors = new HashSet<int>();
        
        for (var i = 1; i < half; i++)
        {
            if (number % i == 0)
            {
                factors.Add(i);
            }
        }

        return ClassificationExtension.Classify(number, factors.Sum());
    }
}
