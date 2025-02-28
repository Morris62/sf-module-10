namespace Module_10;

internal class Program
{
    private static void Main(string[] args)
    {
        IMessenger<Phone> viberInPhone = new Viber<Phone>();
        
        IMessenger<IPhone> viberInIPhone = new Viber<Phone>();

        viberInPhone.DeviceInfo(new Phone());
        viberInIPhone.DeviceInfo(new IPhone());

        Console.ReadKey();
    }

    public interface IMessenger<in T>
    {
        void DeviceInfo(T device);
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
        public void DeviceInfo(T device)
        {
            Console.WriteLine(device);
        }
    }
}