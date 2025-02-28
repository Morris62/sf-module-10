namespace Module_10;

class Program
{
    class Worker : IWorker
    {
        void IWorker.Build()
        {
            Console.WriteLine("Worker");
        }
    }

    static void Main(string[] args)
    {
        var worker = new Worker();
        ((IWorker)worker).Build();
    }
}