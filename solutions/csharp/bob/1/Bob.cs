public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        
        if (statement.Length == 0) return "Fine. Be that way!";

        var letters = statement.Where(char.IsLetter).ToArray();
        
        if (letters.Length > 0 && letters.All(c => c is >= 'A' and <= 'Z'))
        {
            return IsQuestion(statement) 
                ? "Calm down, I know what I'm doing!"
                : "Whoa, chill out!";

        }
        
        return IsQuestion(statement) ? "Sure." : "Whatever.";

    }
    
    private static bool IsQuestion(string statement) => statement.EndsWith('?');
}