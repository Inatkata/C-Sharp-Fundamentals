namespace _5._Decrypting_Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int letterJump = int.Parse(Console.ReadLine());
            int numberOfLetters = int.Parse(Console.ReadLine());
            string decryptedMessage = string.Empty;
            for (int i = 0; i < numberOfLetters; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                int letterValue = (int)letter + letterJump;
                decryptedMessage += (char)letterValue;
            }
            Console.WriteLine(decryptedMessage);
        }
    }
}
