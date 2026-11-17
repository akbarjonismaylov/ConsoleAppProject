namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<int> numbers = new List<int>() { 1, 2, 3, 4, 3, 2, 5, 6, 4, 6, 8, 6 };

            foreach (int i in numbers)
            {
                if (i > 5)
                    Console.WriteLine(i);
            }

            Console.WriteLine();
            
            List<int> filtered = numbers.Where(number => number > 5).ToList();
            foreach(int number in filtered)
            {
                Console.WriteLine(number);
            }*/

            /*List<int> numbers = new List<int>() { 1, 2, 2, 3, 4, 6, 7, 8, 9 };

            List<int> outsideRange = numbers.Where(x => x % 2 == 0).ToList();
            Console.WriteLine(string.Join(", ", outsideRange));

            List<int> even = numbers.Where(x => x < 3 || x > 6).ToList();
            Console.WriteLine(string.Join(", ", even));*/

            /*int firstNumber = numbers.FirstOrDefault(x => x > 5);
            Console.WriteLine(firstNumber);

            bool check = numbers.Any(x => x == 100);
            Console.WriteLine(check);

            bool check2 = numbers.Any(x => x % 2 == 0);
            Console.WriteLine(check2);*/


            List<Person> persons = new List<Person>();
            persons.Add(new Person
            {
                Name = "Ali",
                Pinfl = "111"
            });

            persons.Add(new Person
            {
                Name = "Vali",
                Pinfl = "222"
            });

            persons.Add(new Person
            {
                Name = "Xo'ji",
                Pinfl = "333"
            });

            Console.Write("Pinfl kiriting > ");
            string pinfl = Console.ReadLine();

            Person? user = persons.FirstOrDefault(u => u.Pinfl == pinfl);

            if (user != null)
            {
                Console.WriteLine($"Salom {user.Name}");
            }
            else Console.WriteLine("Topilmadi!");
        }
    }
}
