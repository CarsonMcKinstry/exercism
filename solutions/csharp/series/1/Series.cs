public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {

        if (numbers.Length < sliceLength || sliceLength <= 0)
        {
            throw new ArgumentException($"Numbers must be less than {sliceLength} characters");
        }

        return numbers
            .Take(numbers.Length - sliceLength + 1)
            .Select((_, i) => numbers.Substring(i, sliceLength))
            .ToArray();
    }
}