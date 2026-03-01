using System.Diagnostics;
using System.Text.RegularExpressions;

public static partial class LogAnalysis
{
    public static string SubstringAfter(this string str, string start)
    {
        var startIndex = str.IndexOf(start, StringComparison.Ordinal) + start.Length;
        
        return str.Substring(startIndex);
    }

    public static string SubstringBetween(this string str, string start, string end)
    {
        var startIndex = str.IndexOf(start, StringComparison.Ordinal) +  start.Length;
        var endIndex = str.IndexOf(end, StringComparison.Ordinal);

        return str.Substring(startIndex, endIndex - startIndex);
    }
    
    public static string Message(this string logLine)
    {
        return logLine.SubstringAfter("]: ");
    }

    public static string LogLevel(this string logLine)
    {
        return logLine.SubstringBetween("[", "]");
    }
}