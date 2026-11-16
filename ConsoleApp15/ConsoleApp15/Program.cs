using System.Xml.Linq;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<string> users = new List<string>();
            users.Add("Ali");
            users.Add("Vali");
            users.Add("Ali");

            HashSet<string> user = new HashSet<string>();
            user.Add("Ali");
            user.Add("Vali");
            user.Add("Ali");

            Console.WriteLine(users.Count);
            Console.WriteLine(user.Count);

            Console.WriteLine();

            foreach (string s in user)
            {
                Console.WriteLine(s);
            }*/

            /*HashSet<string> pinfl = new HashSet<string>();
            pinfl.Add("111");
            pinfl.Add("222");

            Console.Write("Pinfl kiritirng > ");
            string? enterPinfl = Console.ReadLine();

            if (enterPinfl != null && pinfl.Add(enterPinfl))
            {
                Console.WriteLine("Qo'shildi!");
            }
            else Console.WriteLine("Bu pinfl allaqachon bor!");*/

            /*List<int> numbers = new List<int>() {1, 2, 2, 3, 3, 3};
            HashSet<int> set = new HashSet<int>(numbers);

            foreach (int i in set)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"set.Count: {set.Count}");*/

            List<string> names = new List<string>() { "Ali", "Vali", "Xo'ji", "Xo'ji", "Ali" };
            HashSet<string> uniqueNames = new HashSet<string>(names);

            foreach (string name in uniqueNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
            Console.Write("Ism kiriting > ");
            string? enteredName = Console.ReadLine();

            if (enteredName != null && uniqueNames.Contains(enteredName))
            {
                Console.WriteLine("Bunday ism ro'yxatda bor!");
            }
            else Console.WriteLine("Bunday ism ro'yxatda yo'q!");

            Console.WriteLine(uniqueNames.Count);
        }
    }
}
