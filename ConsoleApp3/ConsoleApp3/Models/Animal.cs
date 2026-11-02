namespace ConsoleApp3.Models;

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Color { get; set; }
    protected int Energy { get; set; }
    private string Secret = "sir";

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
        Energy = 100;
    }
}