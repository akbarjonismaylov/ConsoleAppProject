using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Id = Guid.NewGuid();
            car.Model = "Kia";
            car.Name = "Sanet";
            car.Color = "white";
            car.Speed = 200;
            car.Door = 4;
            Console.WriteLine($"{car.Id}, {car.Model}, {car.Name}, {car.Color}, {car.Speed}, {car.Door}");

            Train train = new Train();
            train.Id = Guid.NewGuid();
            train.Model = "test";
            train.Name = "test";
            train.Color = "red";
            train.Speed = 200;
            train.Wagons = 15;
            Console.WriteLine($"{train.Id}, {train.Model}, {train.Name}, {train.Color}, {train.Speed}, {train.Wagons}");

            SportsCar sportsCar = new SportsCar();
            sportsCar.Id = Guid.NewGuid();
            sportsCar.Model = "Mercedes";
            sportsCar.Name = "GT63s";
            sportsCar.Color = "Black";
            sportsCar.Speed = 400;
            sportsCar.Door = 2;
            sportsCar.HasTurbo = true;
            Console.WriteLine($"{sportsCar.Id}, {sportsCar.Model}, {sportsCar.Name}, {sportsCar.Color}, {sportsCar.Speed}, {sportsCar.HasTurbo}");
        }
    }
}
