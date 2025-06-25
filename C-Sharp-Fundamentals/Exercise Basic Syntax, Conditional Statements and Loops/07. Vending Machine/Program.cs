namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double moneyToSpend = 0.0;

            // Вземане на монети
            while (command != "Start")
            {
                double coins = double.Parse(command);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1.0 || coins == 2.0)
                {
                    moneyToSpend += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                command = Console.ReadLine(); 
            }

            // Купуване на продукти
            string product = Console.ReadLine();

            while (product != "End")
            {
                double price = 0.0;
                bool validProduct = true;

                switch (product)
                {
                    case "Nuts": price = 2.0; break;
                    case "Water": price = 0.7; break;
                    case "Crisps": price = 1.5; break;
                    case "Soda": price = 0.8; break;
                    case "Coke": price = 1.0; break;
                    default:
                        Console.WriteLine("Invalid product");
                        validProduct = false;
                        break;
                }

                if (validProduct)
                {
                    if (moneyToSpend >= price)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        moneyToSpend -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

                product = Console.ReadLine(); // Прочети следваща команда
            }

            Console.WriteLine($"Change: {moneyToSpend:f2}");
        }
    }
}
