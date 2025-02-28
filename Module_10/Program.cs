namespace Module_10;

internal class Program
{
    private static void Main(string[] args)
    {
        IGarageManager<Car, Garage> garageManager1 = new GarageManagerBase();
        IGarageManager<Truck, Garage> garageManager2 = new GarageManagerBase();
        IGarageManager<Truck, House> garageManager3 = new GarageManagerBase();
    }

    private class Car
    {
    }

    private class Truck : Car
    {
    }

    private class Garage : House
    {
    }

    private class House
    {
    }

    private interface IGarageManager<in T, out Z>
    {
        void Add(T car);
        Z GetGarageInfo();
    }

    private class GarageManagerBase : IGarageManager<Car, Garage>
    {
        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public Garage GetGarageInfo()
        {
            throw new NotImplementedException();
        }
    }
}