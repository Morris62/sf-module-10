namespace Module_10;

public interface ILogger
{
    public void Event(string message);
    public void Error(string message);
}