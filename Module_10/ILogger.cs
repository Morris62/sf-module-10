namespace Module_10;

public interface ILogger
{
    public void Event(string message)
    {
        Console.WriteLine($"interface: {message}");   
    }

    public void Error(string message)
    {
        Console.WriteLine($"interface: {message}");
    }
}