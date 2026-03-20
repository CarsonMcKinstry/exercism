using System.Text.RegularExpressions;

public static partial class Acronym
{
    public static string Abbreviate(string phrase)
    {

        var parts = WordBoundaryRegex()
            .Split(phrase)
            .Where(word => word.Length > 0)
            .Select(GetUpperFirst);
            
        return string.Join("", parts);
    }

    private static char GetUpperFirst(string word) => char.ToUpper(word.First());
    
    [GeneratedRegex("[\\s-_]")]
    private static partial Regex WordBoundaryRegex();
}