public static class ReverseString
{
    public static string Reverse(string input)
    {
        var s = new LinkedList<char>();

        foreach (var c in input)
        {
            s.AddFirst(c);
        }
        
        return string.Join("", s);
    }
}