namespace Design_Patterns.Singleton;

internal class Logger
{
    private static Logger? instance = null;
    private string logFilePath = "app.log";

    private Logger()
    {
        if (!File.Exists(logFilePath))
        {
            File.Create(logFilePath).Close();
        }
    }

    public static Logger GetInstance()
    {
        if (instance is null)
        {
            instance = new Logger();
        }
        return instance;
    }

    public void LogMessage(string message)
    {
        using (StreamWriter writer = File.AppendText(logFilePath))
        {
            writer.WriteLine($"{DateTime.Now}: {message}");
        }
    }
}
