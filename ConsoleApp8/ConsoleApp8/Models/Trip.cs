namespace ConsoleApp8.Models;

public class Trip
{
    public string Name { get; set; }
    public int AvailableSeats { get; private set; }

    public Trip(string name, int availableSeats)
    {
        Name = name;
        AvailableSeats = availableSeats;
    }

    public void BuyTicket()
    {
        if (AvailableSeats <= 0)
        {
            Console.WriteLine("O'rin qolmadi");
            return;
        }
        AvailableSeats--;
        Console.WriteLine($"Qolgan o'rinlar: {AvailableSeats}");
    }
}
