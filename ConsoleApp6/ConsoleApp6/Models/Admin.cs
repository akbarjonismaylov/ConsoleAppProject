using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp6.Models;

public class Admin : User
{
    public Admin(string firstName, string lastName) : base(firstName, lastName)
    {
        
    }

    public override string GetRole()
    {
        return "Administrator";
    }
}
