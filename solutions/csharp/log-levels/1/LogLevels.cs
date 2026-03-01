using System.Text.RegularExpressions;

static partial class LogLine
{

    [GeneratedRegex("\\[(?<logLevel>\\w+)\\]")]
    private static partial Regex LogLevelRegex();

    public static string Message(string logLine)
    {
        return logLine.Split("]: ").Last().Trim();
    }

    public static string LogLevel(string logLine)
    {
        var regex = LogLevelRegex();

        return regex.Match(logLine).Groups["logLevel"].Captures.First().ToString().ToLower();
    }

    public static string Reformat(string logLine)
    {
        var logLevel = LogLevel(logLine);
        var message = Message(logLine);
        
        return $"{message} ({logLevel})";
    }

}