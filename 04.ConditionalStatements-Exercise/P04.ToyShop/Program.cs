using System;

namespace P04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            //Cnt = count
            //Num = number
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzlesCnt = int.Parse(Console.ReadLine());
            int dollsCnt = int.Parse(Console.ReadLine());
            int bearsCnt = int.Parse(Console.ReadLine());
            int minionsCnt = int.Parse(Console.ReadLine());
            int trucksCnt = int.Parse(Console.ReadLine());

            //Actions
            //In practice -> When working with money we use decimal
            double puzzlesPrice = puzzlesCnt * 2.60;
            double dollsPrice = dollsCnt * 3;
            double bearsPrice = bearsCnt * 4.10;
            double minionsPrice = minionsCnt * 8.20;
            double trucksPrice = trucksCnt * 2;

            double allToysCnt = puzzlesCnt + dollsCnt + bearsCnt 
                + minionsCnt + trucksCnt;
            double totalPrice = puzzlesPrice + dollsPrice + bearsPrice 
                + minionsPrice + trucksPrice;

            if (allToysCnt >= 50)
            {
                //Price - 25% => Price - (25% from Price) = Price - (0.25 * Price)
                //totalPrice = totalPrice * 0.75;
                //totalPrice *= 0.75;
                double discount = 0.25 * totalPrice;
                totalPrice -= discount;
            }

            double rent = 0.10 * totalPrice;
            totalPrice -= rent;

            //Round(0.1, 2) -> 0.1 <=> 0.10 <=> 1*10^-1 (Rounding -> Arithmetic operations)
            //Formatting(0.1, 2) (0.1:f2) -> 0.10 </=> 0.1 (Formatting -> Text representation)
            //Output
            //double diff = totalPrice - tripPrice;
            if (totalPrice >= tripPrice)
            {
                //Enough money
                double moneyLeft = totalPrice - tripPrice;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                //Insufficent funds
                double moneyNeeded = tripPrice - totalPrice;
                Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
            }
        }
    }
}
