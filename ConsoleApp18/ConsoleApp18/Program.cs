namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<Praduct> praducts = new List<Praduct>
            {
            new Praduct { Name = "Tomato", Price = 120 },
            new Praduct { Name = "Cucumber", Price = 100 },
            new Praduct { Name = "Cabbage", Price = 77.5m },
            new Praduct { Name = "Corn", Price = 68.39m }
            };

            List<decimal> prices = praducts.Select(p => p.Price).ToList();

            foreach (decimal x in prices)
            {
                Console.WriteLine(x);
            }*/

            List<Student> students = new List<Student>
            {
                new Student {Name = "Ali", Grade = 2 },
                new Student {Name = "Vali", Grade= 1 },
                new Student {Name = "G'ani", Grade = 4},
                new Student {Name = "Xo'ji", Grade = 1}
            };

            List<string> names = students.Select(s => s.Name).ToList();
            foreach (var student in names)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            List<int> grades = students.Select(s => s.Grade + 5).ToList();
            foreach (var g in grades)
            {
                Console.WriteLine(g);
            }
        }
    }
}
