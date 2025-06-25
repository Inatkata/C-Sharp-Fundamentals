namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine());
            double sum = 0.0;
            while (ordersCount > 0)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                double totalPrice = (pricePerCapsule * (days * capsulesCount));
                Console.WriteLine($"The price for the coffee is: ${totalPrice:f2}");
                ordersCount--;
                sum += totalPrice;
            }

            Console.WriteLine($"Total: ${sum:f2}");
        }
    }
}
