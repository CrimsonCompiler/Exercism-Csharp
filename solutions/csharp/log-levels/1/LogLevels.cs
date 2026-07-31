static class LogLine
{
    public static string Message(string logLine)
    {
        int indexOfColon = logLine.IndexOf(':');
        string code = logLine[..indexOfColon];
        string message = logLine[(indexOfColon + 1)..];
        return message.Trim();

        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        int indexOfColon = logLine.IndexOf(":");
        string code = logLine[..indexOfColon];
        return code.Trim('[', ']').ToLower();

        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";

        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}