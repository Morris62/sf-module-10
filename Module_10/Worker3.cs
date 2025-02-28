namespace Module_10;

public class Worker3(ILogger logger) : IWorker
{ 
    ILogger Logger { get; } = logger;

    public void Work()
    {
        Logger.Event("\"worker3\" начало работы");
        Thread.Sleep(3000);
        Logger.Event("\"worker3\": окончание работы");
    }
}