using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var s = new StringBuilder();

        var camelActive = false;
        
        foreach (var c in identifier)
        {

            switch (c)
            {
                case ' ':
                    s.Append('_');
                    continue;
                case '\0':
                    s.Append("CTRL");
                    continue;
                case '-':
                    camelActive = true;
                    continue;
            }

            if (camelActive)
            {
                s.Append(char.ToUpper(c));
                camelActive = false;
                continue;
            }

            if (!char.IsLetter(c) || char.IsBetween(c, 'α', 'ω'))
            {
                continue;
            }
            
            s.Append(c);
        }
        
        return s.ToString();
    }
}
