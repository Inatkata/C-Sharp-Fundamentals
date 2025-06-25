namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double pricePerGame = 0.0;
            double startingMoney = money;
            while (command != "Game Time")
            {
                if (command == "OutFall 4")
                {
                    pricePerGame = 39.99;
                }
                else if (command == "CS: OG")
                {
                    pricePerGame = 15.99;

                }
                else if (command == "Zplinter Zell")
                {
                    pricePerGame = 19.99;

                }
                else if (command == "Honored 2")
                {
                    pricePerGame = 59.99;

                }
                else if (command == "RoverWatch")
                {
                    pricePerGame = 29.99;

                }
                else if (command == "RoverWatch Origins Edition")
                {
                    pricePerGame = 39.99;

                }
                else
                {
                    Console.WriteLine("Not Found");
                    command = Console.ReadLine();
                    continue;
                }
                if (money < pricePerGame)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    money -= pricePerGame;
                    Console.WriteLine($"Bought {command}");
                }
                if (money == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${Math.Abs(startingMoney - money):f2}. Remaining: ${money:f2}");
        }
    }
}
