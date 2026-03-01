
public class LogLine {

    private String line;

    public LogLine(String logLine) {
        line = logLine;
    }

    public LogLevel getLogLevel() {
        String rawLevel = line.substring(1, 4);

        return switch (rawLevel) {
            case "TRC" -> LogLevel.TRACE;
            case "DBG" -> LogLevel.DEBUG;
            case "INF" -> LogLevel.INFO;
            case "WRN" -> LogLevel.WARNING;
            case "ERR" -> LogLevel.ERROR;
            case "FTL" -> LogLevel.FATAL;
            default -> LogLevel.UNKNOWN;
        };
    }

    public String getOutputForShortLog() {
        int colonIndex = line.indexOf(':');
        String message = line.substring(colonIndex + 1).trim();
        LogLevel logLevel = getLogLevel();

        return String.format("%d:%s", logLevel.getShortLevel(), message);
    }
}
