// TODO: define the 'LogLevel' enum

using System.Text.RegularExpressions;

enum LogLevel
{
    Unknown,
    Trace,
    Debug,
    Info,
    Warning,
    Error,
    Fatal,
}

static partial class LogLine
{
    
    [GeneratedRegex("\\[(?<logLevel>\\w+)\\]")]
    private static partial Regex LogLevelRegex();

    
    public static LogLevel ParseLogLevel(string logLine)
    {
        var level = LogLevelRegex().Match(logLine).Groups["logLevel"].Value;

        return level.ToLower() switch
        {
            "trace" or "trc" => LogLevel.Trace,
            "debug" or "dbg" => LogLevel.Debug,
            "info" or "inf" => LogLevel.Info,
            "warning" or "wrn" => LogLevel.Warning,
            "error" or "err" => LogLevel.Error,
            "fatal" or "ftl" => LogLevel.Fatal,
            _ => LogLevel.Unknown
        };
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        var level = logLevel switch
        {
            LogLevel.Unknown => 0,
            LogLevel.Trace => 1,
            LogLevel.Debug => 2,
            LogLevel.Info => 4,
            LogLevel.Warning => 5,
            LogLevel.Error => 6,
            LogLevel.Fatal => 42,
            _ => throw new ArgumentOutOfRangeException(nameof(logLevel), logLevel, null)
        };
        
        return $"{level}:{message}";
    }
}