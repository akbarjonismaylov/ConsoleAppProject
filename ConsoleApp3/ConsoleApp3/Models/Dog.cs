namespace ConsoleApp3.Models;

public class Dog : Animal
{
    public string Breed { get; set; }

    public Dog(string  name, int age, string breed) : base(name, age)
    {
        Breed = breed;
    }
}