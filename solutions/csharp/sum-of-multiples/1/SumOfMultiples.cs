public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max) => multiples
        .Where(value => value > 0)
        .SelectMany(value => FindAllMultiples(value, max))
        .ToHashSet()
        .Sum();

    private static IEnumerable<int> FindAllMultiples(int baseValue, int max) => Enumerable
        .Range(1, (max / baseValue) + 1)
        .Select((n ) => baseValue * n)
        .Where(n => n < max);

}