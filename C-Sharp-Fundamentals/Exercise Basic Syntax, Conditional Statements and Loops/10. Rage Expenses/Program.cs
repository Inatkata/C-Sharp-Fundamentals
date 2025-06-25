namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double totalHeadsetPrice = 0.0;
            double totalMousePrice = 0.0;
            double totalKeyboardPrice = 0.0;
            double totalDisplayPrice = 0.0;
            totalHeadsetPrice = (lostGamesCount / 2) * headsetPrice; // Every second game
            totalMousePrice = (lostGamesCount / 3) * mousePrice; // Every third game
            totalKeyboardPrice = (lostGamesCount / 6) * keyboardPrice; // Every sixth game
            totalDisplayPrice = (lostGamesCount / 12) * displayPrice; // Every second keyboard
            double expenses = totalHeadsetPrice + totalMousePrice + totalKeyboardPrice + totalDisplayPrice;
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");

        }
    }
}
