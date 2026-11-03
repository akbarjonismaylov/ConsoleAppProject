using ConsoleApp7.Models;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            
            Circle circle = new Circle();
            circle.Name = "Doira";
            circle.ShowName();
        }
    }
}
