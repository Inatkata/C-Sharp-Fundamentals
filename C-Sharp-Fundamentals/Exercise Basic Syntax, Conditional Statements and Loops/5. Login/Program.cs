namespace _5._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            // Генерираме паролата, като обръщаме username
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            int attempts = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    attempts++;
                    if (attempts == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}