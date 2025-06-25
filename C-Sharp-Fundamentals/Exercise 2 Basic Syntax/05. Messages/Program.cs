namespace _05._Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPresses = int.Parse(Console.ReadLine());
            string message = "";

            for (int i = 0; i < numberOfPresses; i++)
            {
                string input = Console.ReadLine();
                int digit = int.Parse(input[0].ToString()); // главният бутон
                int count = input.Length; // колко пъти е натиснат

                int offset = (digit - 2) * 3;

                // ако е 7 или 9 – добавяме по още 1, защото имат 4 букви
                if (digit == 8 || digit == 9)
                {
                    offset += 1;
                }

                int letterIndex = offset + count - 1;

                char letter;

                if (digit == 0)
                {
                    letter = ' ';
                }
                else
                {
                    letter = (char)(97 + letterIndex); // 97 е ASCII за 'a'
                }

                message += letter;
            }

            Console.WriteLine(message);
        }
    }
}