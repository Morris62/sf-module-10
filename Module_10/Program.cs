namespace Module_10;

internal class Program
{
    private static void Main()
    {
        ILogger logger = new Logger();
        IConsoleReader<int> reader = new ConsoleReader(logger);
        ICalculations<int> calculator = new Calculator(logger);

        var a = reader.Read("a");
        var b = reader.Read("b");

        calculator.Sum(a, b);
        calculator.Substract(a, b);
        calculator.Multiply(a, b);
        calculator.Divide(a, b);

        Console.ReadKey();
    }
}