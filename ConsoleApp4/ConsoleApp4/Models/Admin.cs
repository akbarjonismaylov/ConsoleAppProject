namespace ConsoleApp4.Models;

public class Admin : User
{
    public string Permissions { get; set; }

    public Admin(string firstName, string lastName, string permissions) : base(firstName, lastName)
    {
        Permissions = permissions;
    }
}
