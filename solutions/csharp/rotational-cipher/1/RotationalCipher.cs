public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey) => string
        .Join("", text.Select(c => Rotate(c, shiftKey)));

    private static char Rotate(char c, int shiftKey)
    {
        if (!IsLetter(c)) return c;

        var offset = c is >= 'a' and <= 'z' ? 'a' : 'A';

        var value = c - offset;
        
        var nextValue = (value + shiftKey) % 26;
        
        return (char)(nextValue + offset);

    }
    
    private static bool IsLetter(char c) => c is >= 'A' and <= 'Z' or >= 'a' and <= 'z';
}