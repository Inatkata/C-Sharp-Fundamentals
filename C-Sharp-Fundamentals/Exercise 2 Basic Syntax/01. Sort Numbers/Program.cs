namespace _01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double first = 0;
            double second = 0;
            double third = 0;

            if (a >= b && a >= c)
            {
                first = a;
                if (b >= c)
                {
                    second = b;
                    third = c;
                }
                else
                {
                    second = c;
                    third = b;
                }
            }
            else if (b >= a && b >= c)
            {
                first = b;
                if (a >= c)
                {
                    second = a;
                    third = c;
                }
                else
                {
                    second = c;
                    third = a;
                }
            }
            else if (c >= a && c >= b)
            {
                first = c;
                if (a >= b)
                {
                    second = a;
                    third = b;
                }
                else
                {
                    second = b;
                    third = a;
                }
            }

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
        }
    }
}