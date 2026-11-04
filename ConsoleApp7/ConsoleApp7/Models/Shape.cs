namespace ConsoleApp7.Models;

public abstract class Shape
{
    public string Name { get; set; }

    public void ShowName()
    {
        Console.WriteLine(Name);
    }

    public abstract double GetArea();
    
}

