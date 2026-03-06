using System.Text.RegularExpressions;

public class LogParser
{
    public bool IsValidLine(string text)
    {
        var reg = new Regex(@"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]");
        
        return reg.IsMatch(text);
    }

    public string[] SplitLogLine(string text)
    {
        var reg = new Regex(@"\<[\^*=-]+\>");
        
        return reg.Split(text);
    }

    public int CountQuotedPasswords(string lines)
    {

        var reg = new Regex("\".{0,}password.{0,}\"", RegexOptions.IgnoreCase);
        
        return lines.Split(Environment.NewLine)
            .Count(line => reg.IsMatch(line));
    }

    public string RemoveEndOfLineText(string line)
    {
        var reg = new Regex("end-of-line[0-9]{0,}");

        return reg.Replace(line, "");
    }

    public string[] ListLinesWithPasswords(string[] lines)
    {
        // if the word password is used, prefix with "--------: "
        // otherwise, prefix with the password

        var reg = new Regex(@"\s(?<password>password\w+)", RegexOptions.IgnoreCase);

        return lines
            .Select(
                line =>
                {
                    var match = reg.Match(line).Groups["password"].Value;

                    return $"{(match.Length > 0 ? match : "--------")}: {line}";
                })
            .ToArray();
    }
}
