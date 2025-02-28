namespace Module_10;

public class Worker2(ILogger logger) : IWorker
{ 
    ILogger Logger { get; } = logger;

    public void Work()
    {
        Logger.Event("\"worker2\" начало работы");
        Thread.Sleep(3000);
        Logger.Event("\"worker2\": окончание работы");
    }
}