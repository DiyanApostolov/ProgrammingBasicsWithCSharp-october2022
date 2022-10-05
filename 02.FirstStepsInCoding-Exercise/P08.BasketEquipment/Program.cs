using System;

namespace P08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            double yearPaiment = double.Parse(Console.ReadLine());

            // Calculation
            double priceForSneakers = yearPaiment * 0.6;
            double priceForOutfit = priceForSneakers - (priceForSneakers * 0.2); // priceForSneakers * 0.8
            double priceForBall = priceForOutfit / 4; // priceForOutfith * 0.25;
            double priceForAccessories = priceForBall / 5; // priceForBall * 0.2;

            double finalPrice = yearPaiment + priceForSneakers + priceForOutfit + priceForBall + priceForAccessories;

            // Output
            Console.WriteLine(finalPrice);
        }
    }
}
