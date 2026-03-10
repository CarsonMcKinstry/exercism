public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var usedChars = new HashSet<char>();

        foreach (var c in word)
        {
            var lowerCased = char.ToLower(c);
            if (lowerCased is < 'a' or > 'z') continue;
            
            if (!usedChars.Add(lowerCased)) return false;
        }

        return true;
    }
}
