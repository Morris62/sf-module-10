namespace Module_10;

internal class Program
{
    private static void Main(string[] args)
    {
        IMessenger<Phone> viberInPhone = new Viber<Phone>();
        IMessenger<Phone> viberInIPhone = new Viber<IPhone>();

        viberInPhone.DeviceInfo();
        viberInIPhone.DeviceInfo();

        Console.ReadKey();
    }

    public interface IMessenger<out T>
    {
        T DeviceInfo();
    }

    public class Phone
    {
    }

    public class IPhone : Phone
    {
    }

    public class Computer
    {
    }

    public class Viber<T> : IMessenger<T> where T : Phone, new()
    {
        public T DeviceInfo()
        {
            var device = new T();
            Console.WriteLine(device);
            return device;
        }
    }
}