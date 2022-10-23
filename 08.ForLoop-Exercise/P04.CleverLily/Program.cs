using System;

namespace P04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washerPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int totalMoney = 0;
            for (int currYear = 1; currYear <= age; currYear++)
            {
                if (currYear % 2 != 0)
                {
                    //Odd birthday
                    totalMoney += toyPrice;
                }
                else
                {
                    //Even birthday
                    int moneyGain = (currYear / 2) * 10;
                    totalMoney += moneyGain;
                    totalMoney -= 1;
                }
            }

            if (totalMoney >= washerPrice)
            {
                double moneyLeft = totalMoney - washerPrice;
                Console.WriteLine($"Yes! {moneyLeft:f2}");
            }
            else
            {
                double moneyNeeded = washerPrice - totalMoney;
                Console.WriteLine($"No! {moneyNeeded:f2}");
            }
        }
    }
}
