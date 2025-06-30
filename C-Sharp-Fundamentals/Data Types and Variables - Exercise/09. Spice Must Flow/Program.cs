namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int totalSpice = 0;
            while (startingYield >= 100)
            {
                days++;
                totalSpice += startingYield;
                startingYield -= 10;         
                totalSpice -= 26;            
            }
            if (totalSpice >= 26)
            {
                totalSpice -= 26; 
            }
            else
            {
                totalSpice = 0; 
            }

            Console.WriteLine(days);
            Console.WriteLine(totalSpice);
        }
    }
}
