namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Queue<string> names = new Queue<string>();
            names.Enqueue("Ali");
            names.Enqueue("Vali");
            names.Enqueue("Xo'ji");

            string first = names.Dequeue();
            Console.WriteLine(first);
            Console.WriteLine(names.Peek());
            Console.WriteLine(names.Count);

            Console.WriteLine();

            first = names.Dequeue();
            Console.WriteLine(first);
            Console.WriteLine(names.Peek());
            Console.WriteLine(names.Count);*/

            Stack<string> names = new Stack<string>();

            names.Push("Ali");
            names.Push("Vali");
            names.Push("Xo'ji");

            string first = names.Pop();
            Console.WriteLine(first);
            Console.WriteLine(names.Peek());
            Console.WriteLine(names.Count);

            Console.WriteLine();

            first = names.Pop();
            Console.WriteLine(first);
            Console.WriteLine(names.Peek());
            Console.WriteLine(names.Count);
        }
    }
}
