namespace Module_10;

public class Worker1(ILogger logger) : IWorker
{ 
    ILogger Logger { get; } = logger;

    public void Work()
    {
        Logger.Event("\"worker1\" начало работы");
        Thread.Sleep(3000);
        Logger.Event("\"worker1\": окончание работы");
    }
}