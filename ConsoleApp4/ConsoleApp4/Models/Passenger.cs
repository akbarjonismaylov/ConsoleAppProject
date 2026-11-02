namespace ConsoleApp4.Models;

public class Passenger : User
{
    public string Pinfl { get; set; }

    public Passenger(string firstName,  string lastName, string pinfl) : base(firstName, lastName)
    {
        Pinfl = pinfl;
    }
}
