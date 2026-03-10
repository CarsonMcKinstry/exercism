using System.Text.RegularExpressions;

public static partial class Pangram
{
    
    
    
    public static bool IsPangram(string input) => input.ToCharArray()
        .Select(char.ToLower)
        .Where(c => c is >= 'a' and <= 'z')
        .ToHashSet()
        .Count == 26;
}
