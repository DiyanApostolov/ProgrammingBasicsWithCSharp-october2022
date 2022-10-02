using System;

namespace P03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double depositValue = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double interestPercantage = double.Parse(Console.ReadLine()) / 100;

            //Actions
            double monthGain = (depositValue * interestPercantage) / 12;
            double depositGain = months * monthGain;
            double totalSum = depositValue + depositGain;

            //Output
            Console.WriteLine(totalSum);
        }
    }
}
