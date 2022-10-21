using System;

namespace P03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 -> True
            //0 -> False
            //&& -> AND (all expressions must be true(1)), if one is false, the whole expression goes false
            //|| -> OR (one of the expressions must be true(1)), if one is true, the whole expression goes true
            //! -> NOT (!true = false)
            //Input
            string flowers = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            //Actions
            //Default value
            double totalPrice = 0;
            if (flowers == "Roses")
            {
                //Only Roses
                totalPrice = flowersCount * 5;

                if (flowersCount > 80)
                {
                    totalPrice -= totalPrice * 0.1;
                }
            }
            else if (flowers == "Dahlias")
            {
                //Only Dahlias
                totalPrice = flowersCount * 3.80;

                if (flowersCount > 90)
                {
                    totalPrice -= totalPrice * 0.15;
                }
            }
            else if (flowers == "Tulips")
            {
                //Only Tulips
                totalPrice = flowersCount * 2.80;

                if (flowersCount > 80)
                {
                    totalPrice -= totalPrice * 0.15;
                }
            }
            else if (flowers == "Narcissus")
            {
                //Only Narcissus
                totalPrice = flowersCount * 3;

                if (flowersCount < 120)
                {
                    totalPrice += totalPrice * 0.15;
                }
            }
            else if (flowers == "Gladiolus")
            {
                totalPrice = flowersCount * 2.50;

                if (flowersCount < 80)
                {
                    totalPrice += totalPrice * 0.20;
                }
            }

            //We have the total price
            //Output
            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowers} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyMoreNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyMoreNeeded:f2} leva more.");
            }
        }
    }
}
