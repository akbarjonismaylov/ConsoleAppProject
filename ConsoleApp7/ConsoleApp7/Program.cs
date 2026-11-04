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
            circle.Radius = 10;
            circle.Draw();
            
            Square square = new Square();
            square.Name = "Kvadrat";
            square.Side = 7;

            shapes.Add(circle);            
            shapes.Add(square);

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.Name}, {shape.GetArea()}");
            }
        }
    }
}
