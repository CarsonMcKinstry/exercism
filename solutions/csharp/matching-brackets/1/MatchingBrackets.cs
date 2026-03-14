public static class MatchingBrackets
{

    
    
    public static bool IsPaired(string input)
    {
        
        var stack = new Stack<char>();

        foreach (var c in input)
        {
            switch (c)
            {
                case '[':
                    stack.Push(']');
                    break;
                case '{':
                    stack.Push('}');
                    break;
                case '(':
                    stack.Push(')');
                    break;
                case ']':
                case '}': 
                case ')':
                    if (stack.Count <= 0 || stack.Pop() != c) return false;
                    break;
            }
        }

        return stack.Count == 0;
    }
}
