namespace ConsoleApp4.Models;

public class User
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    protected DateTime CreatedAt { get; set; }

    public User(string firstName, string lastName)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        CreatedAt = DateTime.Now;
    }
    public void ShowCreatAt() { Console.WriteLine($"{CreatedAt}"); }
}