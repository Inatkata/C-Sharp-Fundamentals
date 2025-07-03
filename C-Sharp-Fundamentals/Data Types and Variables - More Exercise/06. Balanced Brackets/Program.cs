namespace _06._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());
            int openBrackets = 0;
            bool isBalanced = true;
            for (int i = 0; i < numOfLines; i++)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    openBrackets++;
                }
                else if (input == ")")
                {
                    openBrackets--;
                }
                if (openBrackets < 0)
                {
                    isBalanced = false;
                    break;
                }
            }
            if (openBrackets != 0)
            {
                isBalanced = false;
            }
            if (isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
