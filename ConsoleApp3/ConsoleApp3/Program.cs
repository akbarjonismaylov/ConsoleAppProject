using ConsoleApp3.Models;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Rex", 2, "Alabay");
            dog.Color = "Brown";
            Console.WriteLine($"{dog.Name}, {dog.Age}, {dog.Breed}, {dog.Color}, {dog.Energy}");

            dog.Show();
        }
    }
}