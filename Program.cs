﻿using System;

namespace HomeWorkFifteenMultiplesNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int minRangeNumber = 10;
            int maxRangeNumber = 26;
            int multiplesCount = 0;
            int minRangeMultiplesNumberes = 50;
            int maxRangeMultiplesNumberes = 150;

            Random random = new Random();
            number = random.Next(minRangeNumber, maxRangeNumber);

            for (int i = number; i <= maxRangeMultiplesNumberes; i += number)
            {

                if (i >= minRangeMultiplesNumberes)
                {
                    multiplesCount++;
                }
            }

            Console.WriteLine($"The number of multiples numberes by {number} is equal to {multiplesCount}");
        }
    }
}