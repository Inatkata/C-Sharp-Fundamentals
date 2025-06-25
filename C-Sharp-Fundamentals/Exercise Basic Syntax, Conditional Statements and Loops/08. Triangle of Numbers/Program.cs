namespace _08._Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte input = byte.Parse(Console.ReadLine());
            for (byte i = 1; i <= input; i++)
            {
                for (byte j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
