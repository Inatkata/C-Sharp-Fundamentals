﻿namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int originalNumber = input;
            int sumOfFactorials = 0;
            while (input > 0)
            {
                int digit = input % 10;
                input /= 10;
                int factorial = 1;
                for (int i = 1; i <= digit; i++)
                {
                    factorial *= i;
                }
                sumOfFactorials += factorial;
            }
            if (sumOfFactorials == originalNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");

            }
        }
    }
}
