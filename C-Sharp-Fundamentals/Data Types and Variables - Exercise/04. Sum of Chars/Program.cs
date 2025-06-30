namespace _04._Sum_of_Chars;
class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        int aasciNum = 0;
        int totalSum = 0;
        for (int i = 1; i <= input; i++)
        {
            char letter = char.Parse(Console.ReadLine());
             aasciNum = letter;
            totalSum = aasciNum + totalSum;
        }
        Console.WriteLine($"The sum equals: {totalSum}");
    }
}

