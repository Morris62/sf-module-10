namespace Module_10;

public class ConsoleReader(ILogger logger) : IConsoleReader<int>
{
    private ILogger Logger { get; } = logger;

    public int Read(string str = "")
    {
        var result = 0;
        while (true)
        {
            try
            {
                Console.Write($"Введите целое значение {str} = ");
                result = int.Parse(Console.ReadLine());
                Logger.Event($"Введено значение {str} = {result}");
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка! Повторите попытку!");
                Logger.Error("Ошибка ввода!");
                continue;
            }

            break;
        }

        return result;
    }
}