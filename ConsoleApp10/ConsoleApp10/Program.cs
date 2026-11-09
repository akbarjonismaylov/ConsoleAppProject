namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? age = 25;

            int result = age ?? 0;
            Console.WriteLine(result);
        }
    }
}
