namespace Module_10;

class Program
{
    class Writer : IWriter
    {
        void IWriter.Write()
        {
            Console.WriteLine("Writer");
        }
    }

    static void Main(string[] args)
    {
        var writer = new Writer();
        ((IWriter)writer).Write();
    }
}