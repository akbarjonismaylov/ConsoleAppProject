namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3] { 10, 20, 30 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine();

            List<int> ints = new List<int>();
            ints.Add(10);
            ints.Add(20);
            ints.Add(30);
            ints.Add(40);

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

        }
    }
}
