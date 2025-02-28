namespace Module_10;

public interface ICalculations<T>
{
    T Sum(T a, T b);
    T Substract(T a, T b);
    T Multiply(T a, T b);
    T Divide(T a, T b);
}