using ConsoleApp5.Models;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Sound();

            Dog dog = new Dog();
            dog.Sound();

            Fish fish = new Fish();
            fish.Sound();
        }
    }
}
