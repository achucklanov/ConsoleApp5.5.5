namespace ConsoleApp5._5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте!");

            static int Factorial(int x)
            {
                x = 20;

                if (x == 0)
                {
                    return 1;
                }
                else
                {
                    return x * Factorial(x - 1);
                }
            }

        }
    }
}