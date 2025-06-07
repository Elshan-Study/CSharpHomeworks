namespace Utils;

public static class Logger
{
    private const string LogFile = "log.txt";

    public static void Log(string message)
    {
        File.AppendAllText(LogFile, $"{DateTime.Now:G} - {message}\n");
    }
}
