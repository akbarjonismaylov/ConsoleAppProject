namespace ConsoleApp8.Models;

public class BankAccount
{
    public decimal Balance { get; private set; }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Manfiy son mumkin emas!");
            return;
        }
        Balance = Balance + amount;
    }
}