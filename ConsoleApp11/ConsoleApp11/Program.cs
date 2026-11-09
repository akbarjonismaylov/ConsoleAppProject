namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Birinchi sonni kiriting > ");
                string num1 = Console.ReadLine();
                int number1 = int.Parse(num1);

                Console.Write("Ikkinchi sonni kiriting > ");
                string num2 = Console.ReadLine();
                int number2 = int.Parse(num2);

                int result = number1 / number2;
                Console.WriteLine(result);
            }

            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Hisob tugadi");
            }
        }
    }
}
