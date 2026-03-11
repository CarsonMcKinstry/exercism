public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        if (subjects.Length == 0) return [];
        
        var first = subjects.First();

        return subjects
            .SkipLast(1)
            .Select((subject, i) => $"For want of a {subject} the {subjects[i + 1]} was lost.")
            .Append($"And all for the want of a {first}.")
            .ToArray();
    }
}