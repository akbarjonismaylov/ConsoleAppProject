namespace ConsoleApp5.Models;

public class Bird : Animal
{
    public override void Sound()
    {
        Console.WriteLine("chirq - chirq");
    }

    public void Sound(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("chirq - chirq");
        }
    }
}
