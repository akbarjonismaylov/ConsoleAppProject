using ConsoleApp6.Models;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> user = new List<User>();
            user.Add(new Admin("Ali", "Valiyev"));
            user.Add(new Passenger("G'ani", "Ganiyev"));

            foreach (var item in user)
            {
                Console.WriteLine(item.GetRole());
            }
        }
    }
}
