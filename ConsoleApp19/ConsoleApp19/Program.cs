namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Low price\n");
            List<Product> products = new List<Product>
            {
                new Product { Name = "Watermelon", Price = 94.35m },
                new Product { Name = "Apple", Price = 79.47m },
                new Product { Name = "Corn", Price = 68.39m },
                new Product { Name = "Pear", Price = 87.5m },
            };

            List<Product> lowPrices = products.OrderBy(p => p.Price).ToList();
            foreach (Product p in lowPrices)
            {
                Console.WriteLine($"{p.Name} - {p.Price} ");
            }

            Console.WriteLine("\nHigh price\n");

            List<Product> highPrice = products.OrderByDescending(p => p.Price).ToList();

            foreach (Product p in highPrice)
            {
                Console.WriteLine($"{p.Name} - {p.Price} ");
            }

            Console.WriteLine("\nLetters\n");

            List<Product> orderOfLetters = products.OrderBy(o => o.Name).ToList();
            foreach(Product p in orderOfLetters)
            {
                Console.WriteLine(p.Name);
            }
        }
    }
}
