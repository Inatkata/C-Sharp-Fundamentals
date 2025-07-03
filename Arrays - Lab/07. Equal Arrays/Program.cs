namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] input2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum1 = 0;
            int sum2 = 0;
            bool areEqual = false;
            for (int i = 0; i < input1.Length; i++)
            {
                if (input1[i] == input2[i])
                {
                    areEqual = true;
                }
                else
                {
                    areEqual = false;
                    break;
                }
                sum1 += input1[i];
                sum2 += input2[i];
            }
            if (areEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum1}");
            }
            else
            {
                for (int i = 0; i < input1.Length; i++)
                {
                    if (input1[i] != input2[i])
                    {
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                        break;
                    }
                }
            }
        }
    }
}

