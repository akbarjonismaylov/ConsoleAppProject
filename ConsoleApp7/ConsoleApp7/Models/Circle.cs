namespace ConsoleApp7.Models;

public class Circle : Shape, IDrawable
{
    public double Radius { get; set; }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
    public void Draw()
    {
        Console.WriteLine("Doira chizildi");
    }
}
