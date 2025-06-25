namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double availableMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double priceOfLightSaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());

            int freeBelts = studentsCount / 6;
            double priceForLightSabers = Math.Ceiling(studentsCount * 1.10) * priceOfLightSaber; 
            double totalRobes = studentsCount * priceOfRobe;
            double totalBelts = (studentsCount - freeBelts) * priceOfBelt;
            double totalPrice = priceForLightSabers + totalRobes + totalBelts;
            if (availableMoney >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(totalPrice - availableMoney):f2}lv more.");
            }


        }
    }
}
