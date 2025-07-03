namespace _04._Refactoring_Prime_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 2; i <= input; i++)
            {
                bool IsPrimeNumber = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        IsPrimeNumber = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {IsPrimeNumber.ToString().ToLower()}" );
            }
        }
    }
}
