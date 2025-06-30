namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int waterTankCapacity = 255;
            int n = int.Parse(Console.ReadLine()); 
            int sumOfWater = 0;

            for (int i = 0; i < n; i++)
            {
                int waterPour = int.Parse(Console.ReadLine());

                if (sumOfWater + waterPour > waterTankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sumOfWater += waterPour;
                }
            }

            Console.WriteLine(sumOfWater);
        }
    }
}
