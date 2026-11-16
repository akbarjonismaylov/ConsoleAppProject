namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> capitals = new Dictionary<string, string>();

            capitals.Add("Uzbekistan", "Tashkent");
            capitals.Add("China", "Beijing");
            capitals["England"] = "London";

           // Console.WriteLine(capitals["England"]);


            foreach (var item in capitals)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.WriteLine();

            foreach (string key in capitals.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine();

            foreach (string value in capitals.Values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine();
            
            if (capitals.ContainsKey("England"))
            {
                Console.WriteLine(capitals["England"]);
            }

            else
            {
                Console.WriteLine("Topilmadi");
            }

            capitals.Remove("China");
            Console.WriteLine(capitals.Count);
        }
    }
}
