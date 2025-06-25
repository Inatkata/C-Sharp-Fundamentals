namespace Eercise_Basic_Syntax__Conditional_Statements_and_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            if (input >= 0 && input <= 2)
            {
                Console.WriteLine("baby");
            }
            else if (input > 2 && input < 14)
            {
                Console.WriteLine("child");
            }
            else if (input > 13 && input < 20)
            {
                Console.WriteLine("teenager");
            }
            else if (input > 19 && input < 66)
            {
                Console.WriteLine("adult");
            }
            else if (input > 65)
            {
                Console.WriteLine("elder");
            }
        }
    }
}
