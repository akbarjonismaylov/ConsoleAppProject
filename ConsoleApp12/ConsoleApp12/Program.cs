using ConsoleApp12.Models;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.Deposit(1000);

            try
            {
                account.Withdraw(5000);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"Balance: {account.Balance}");
        }
    }
}
