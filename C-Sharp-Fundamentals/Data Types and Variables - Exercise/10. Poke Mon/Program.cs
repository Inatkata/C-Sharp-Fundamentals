namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingPower = int.Parse(Console.ReadLine());
            int distanceTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int currentPower = startingPower;
            int targetCount = 0;

            while (currentPower >= distanceTargets)
            {
                currentPower -= distanceTargets;
                targetCount++;

                if (currentPower == startingPower / 2 && exhaustionFactor != 0)
                {
                    currentPower /= exhaustionFactor;
                }
            }

            Console.WriteLine(currentPower);
            Console.WriteLine(targetCount);
        }
    }
}
