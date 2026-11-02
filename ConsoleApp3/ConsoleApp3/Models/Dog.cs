using System.Net.Sockets;

namespace ConsoleApp3.Models;

public class Dog : Animal
{
    public string Breed { get; set; }

    public Dog(string name, int age, string breed) : base(name, age)
    {
        Breed = breed;
    }

    public void Show()
    {
        Console.WriteLine($"{Name}, {Energy}");
        Console.WriteLine($"{Secret}");
    }

    
}