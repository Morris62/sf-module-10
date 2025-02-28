namespace Module_10;

public class Calculator(ILogger logger) : ICalculations<int>
{
    private readonly ILogger Logger = logger;

    int ICalculations<int>.Sum(int a, int b)
    {
        var result = a + b;
        Logger.Event($"Сумма {a} + {b} = {result}");
        return result;
    }

    int ICalculations<int>.Substract(int a, int b)
    {
        var result = a - b;
        Logger.Event($"Разница {a} - {b} = {result}");
        return result;
    }

    int ICalculations<int>.Multiply(int a, int b)
    {
        var result = a * b;
        Logger.Event($"Произведение {a} * {b} = {result}");
        return result;
    }

    int ICalculations<int>.Divide(int a, int b)
    {
        var result = 0;
        try
        {
            result = a / b;
            Logger.Event($"Деление {a} / {b} = {result}");
        }
        catch (DivideByZeroException)
        {
            Logger.Error("Ошибка деления на ноль!");
        }

        return result;
    }
}