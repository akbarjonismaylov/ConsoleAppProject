namespace ConsoleApp6.Models;

public class Passenger : User
{
    public Passenger(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override string GetRole()
    {
        return "Yo'lovchi";
    }
}
