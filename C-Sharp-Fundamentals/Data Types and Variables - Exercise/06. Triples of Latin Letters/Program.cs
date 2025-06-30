namespace _06._Triples_of_Latin_Letters;
class Program
{
    static void Main(string[] args)
    {
       int input = int.Parse(Console.ReadLine());
        

        for (int i = 0; i < input; i++)
        {
            char firstChar = (char)('a' + i);
            for (int k = 0; k < input; k++)
            {
                char secondChar = (char)('a' + k);
                for (int j = 0; j < input; j++)
                {
                    char thirdChar = (char)('a' + j);
                    Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                }
            }
        }
    }
}

