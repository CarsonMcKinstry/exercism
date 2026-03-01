

public class LogLevels {

    enum Level {
        INFO,
        WARNING,
        ERROR
    }
    
    public static String message(String logLine) {
        return logLine.split(":")[1].trim();
    }

    public static String logLevel(String logLine) {
        return logLine.split(":")[0].replace("[", "").replace("]", "").toLowerCase();
    }

    public static String reformat(String logLine) {
        String msg = message(logLine);
        String level = logLevel(logLine);
        return msg + " (" + level + ")";
    }
}
