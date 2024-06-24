using System;

namespace HomeWorkFifteenMultiplesNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int minRangeNumber = 10;
            int maxRangeNumber = 26;
            int countMultiplesNumberes = 0;
            int minRangeMultiplesNumberes = 50;
            int maxRangeMultiplesNumberes = 150;
            int stepNumber = 0;

            Random random = new Random();
            number = random.Next(minRangeNumber, maxRangeNumber);

            while (stepNumber <= maxRangeMultiplesNumberes)
            {
                stepNumber += number;

                if (stepNumber >= minRangeMultiplesNumberes && stepNumber <= maxRangeMultiplesNumberes)
                {
                    countMultiplesNumberes++;
                }
            }

            Console.WriteLine($"The number of multiples numberes by {number} is equal to {countMultiplesNumberes}");
        }
    }
}