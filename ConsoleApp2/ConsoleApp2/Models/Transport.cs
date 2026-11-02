namespace ConsoleApp2.Models;

public class Transport
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Model { get; set; }
    public int Speed { get; set; }
    public string Color { get; set; }

    public Transport(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }
}
