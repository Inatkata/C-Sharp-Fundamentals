﻿namespace _01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            double distanceInKilometers = distanceInMeters / 1000.0;
            Console.WriteLine($"{distanceInKilometers:f2}");
    }
    }
}
