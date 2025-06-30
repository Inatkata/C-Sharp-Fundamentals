namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string biggestKeg = "";
            double biggestCapacity = 0;

            for (int i = 0; i < input; i++)
            {
                string kegModel = Console.ReadLine();
                double radiusOfKeg = double.Parse(Console.ReadLine());
                int heightOfKeg = int.Parse(Console.ReadLine());

                double kegCapacity = Math.PI * Math.Pow(radiusOfKeg, 2) * heightOfKeg;

                if (kegCapacity > biggestCapacity)
                {
                    biggestCapacity = kegCapacity;
                    biggestKeg = kegModel;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
