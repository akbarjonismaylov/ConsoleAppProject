using ConsoleApp5.Models;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Cat());
            animals.Add(new Dog());
            animals.Add(new Fish());
            animals.Add(new Bird());

            Bird bird = new Bird();
            bird.Sound();
            bird.Sound(2);

            foreach (Animal animal in animals)
            {
                animal.Sound();
            }
        }
    }
}
