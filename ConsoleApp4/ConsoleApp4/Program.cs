using ConsoleApp4.Models;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Passenger passenger = new Passenger("Akbarjon", "Ismaylov", "123123123123");
            Console.WriteLine($"{passenger.Id}, {passenger.FirstName}, {passenger.LastName}, {passenger.Pinfl}");
            passenger.ShowCreatAt();

            Console.WriteLine();

            Admin admin = new Admin("Ismaylov", "Inomjon", "hammasi");
            Console.WriteLine($"{admin.Id}, {admin.FirstName}, {admin.LastName}, {admin.Permissions}");
            admin.ShowCreatAt();
        }
    }
}
