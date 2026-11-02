using ConsoleApp2.Models;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Kia", 200, 4);
            Console.WriteLine($"{car.Name}, {car.Speed}, {car.Door}");
        }
    }
}
    