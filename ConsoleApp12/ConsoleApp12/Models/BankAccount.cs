namespace ConsoleApp12.Models;

public class BankAccount
{
    public decimal Balance { get; private set; }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new Exception("Musbat son kiriting");
        }
        Balance = Balance + amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            throw new Exception("Mablag' yetarli emas!");
        }

        Balance = Balance - amount;
    }
}
