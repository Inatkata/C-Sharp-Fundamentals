using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;

            while (input > 0)
            {
                sum += input % 10; // Вземаме последната цифра
                input /= 10;       // Премахваме последната цифра
            }

            Console.WriteLine(sum);
        }
    }
}
