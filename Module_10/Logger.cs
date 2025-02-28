namespace Module_10;

public class Logger : ILogger
{
    public void Event(string message)
    {
        Console.WriteLine($"class: {message}");
    }
    
    public void Error(string message)
    {
        Console.WriteLine($"class: {message}");
    }
}