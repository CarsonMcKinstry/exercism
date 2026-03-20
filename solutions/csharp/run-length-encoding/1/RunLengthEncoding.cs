using System.Text;

public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        if (input.Length == 0) return input;
        
        var sb = new StringBuilder();
        
        var count = 0;
        char currChar = input[0];

        foreach (var c in input)
        {
            if (currChar != c)
            {
                if (count != 1)
                {
                    sb.Append(count);
                }
                sb.Append(currChar);
                count = 0;
                currChar = c;
            }

            count++;
        }
        if (count != 1)
        {
            sb.Append(count);
        }
        sb.Append(currChar);
        return sb.ToString();
    }

    public static string Decode(string input)
    {
        var sb = new StringBuilder();

        var num = new StringBuilder();
        
        foreach (var c in input)
        {
            if (char.IsDigit(c))
            {
                num.Append(c);
            }
            else
            {
                var count = num.Length > 0 ? int.Parse(num.ToString()) : 1;
                sb.Append(new string(c, count));
                num.Clear();
            }
        }
        
        return sb.ToString();
    }
}
