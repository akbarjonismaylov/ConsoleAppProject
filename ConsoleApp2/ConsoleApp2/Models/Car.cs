namespace ConsoleApp2.Models;

public class Car : Transport
{
    public int Door { get; set; }

    public Car(string name, int speed, int door) : base(name, speed)
    {
        Door = door;
    }
}
