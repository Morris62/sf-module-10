namespace Module_10;

public class Logger : ILogger
{
    void ILogger.Event(string message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"[{DateTime.Now:dd.MM.yyyy hh:mm:ss}] {message}");
        Console.ResetColor();
    }

    void ILogger.Error(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[{DateTime.Now:dd.MM.yyyy hh:mm:ss}] {message}");
        Console.ResetColor();
    }
}