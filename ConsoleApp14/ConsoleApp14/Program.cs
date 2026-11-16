namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> userPinfl = new Dictionary<string, string>();
            userPinfl.Add("10293847561029", "Akbarjon");
            userPinfl.Add("12121212121212", "Inomjon");

            Console.Write("Pinfl kiriting > ");
            string? pinfl = Console.ReadLine();

            if (pinfl != null && userPinfl.ContainsKey(pinfl))
            {
                Console.WriteLine($"Salom {userPinfl[pinfl]}!");
            }

            else Console.WriteLine("Foydalanuvchi topilmadi");

        }
    }
}
