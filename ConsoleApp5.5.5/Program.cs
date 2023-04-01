namespace ConsoleApp5._5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте!");

            int f = Factorial(20);

            Console.WriteLine(f);
            Console.ReadKey();

            static int Factorial(int x)
            {


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