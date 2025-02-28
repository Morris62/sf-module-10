namespace Module_10;

class Program
{
    class Worker : IWorker
    {
        public void Build()
        {
            Console.WriteLine("Worker");
        }
    }

    static void Main(string[] args)
    {
        var worker = new Worker();
        worker.Build();
    }
}