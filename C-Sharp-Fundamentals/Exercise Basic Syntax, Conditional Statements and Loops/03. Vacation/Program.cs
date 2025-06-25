namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double pricePerPerson = 0.0;    
            double totalPrice = 0.0;

            if (groupType == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    pricePerPerson = 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    pricePerPerson = 9.80;
                }
                else if (dayOfWeek == "Sunday")
                {
                    pricePerPerson = 10.46;
                }
                if (peopleCount >= 30)
                {
                    pricePerPerson *= 0.85; // 15% discount
                }

            }
            else if (groupType == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    pricePerPerson = 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    pricePerPerson = 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    pricePerPerson = 16.00;
                }
                if (peopleCount >= 100)
                {
                    peopleCount -= 10; // Free 10 people
                }
            }
            else if (groupType == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    pricePerPerson = 15.00;
                }
                else if (dayOfWeek == "Saturday")
                {
                    pricePerPerson = 20.00;
                }
                else if (dayOfWeek == "Sunday")
                {
                    pricePerPerson = 22.50;
                }
                if (peopleCount >= 10 && peopleCount <= 20)
                {
                    pricePerPerson *= 0.95; // 5% discount
                }
            }
            totalPrice = peopleCount * pricePerPerson;

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
