using ConsoleApp8.Models;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*BankAccount account = new BankAccount();
            account.Deposit(1000);
            Console.WriteLine(account.Balance);

            account.Deposit(-3000);
            Console.WriteLine(account.Balance);*/


            Trip trip = new Trip("Akbarjon", 100);
            trip.BuyTicket();
            trip.BuyTicket();
            trip.BuyTicket();

        }
    }
}
