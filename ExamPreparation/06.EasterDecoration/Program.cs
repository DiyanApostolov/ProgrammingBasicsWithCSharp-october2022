using System;

namespace _06.EasterDecoration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //кошничка за яйца(basket) – 1.50 лв.
            //великденски венец(wreath) – 3.80 лв.
            //шоколадов заек(chocolate bunny) – 7 лв.

            int countOfCusrtomers = int.Parse(Console.ReadLine());

            double allPurchases = 0;

            for (int i = 0; i < countOfCusrtomers; i++)
            {
                double currentClientPurchase = 0;
                int countOfPurchase = 0;

                string product = Console.ReadLine();

                while (product != "Finish")
                {
                    if (product == "basket")
                    {
                        currentClientPurchase += 1.5;
                        countOfPurchase++;
                    }
                    else if (product == "wreath")
                    {
                        currentClientPurchase += 3.8;
                        countOfPurchase++;
                    }
                    else if (product == "chocolate bunny")
                    {
                        currentClientPurchase += 7;
                        countOfPurchase++;
                    }

                    product = Console.ReadLine();
                }

                if (countOfPurchase % 2 == 0)
                {
                    currentClientPurchase = currentClientPurchase * 0.8;
                }

                allPurchases += currentClientPurchase;
                Console.WriteLine($"You purchased {countOfPurchase} items for {currentClientPurchase:F2} leva.");
            }

            double averagePurchase = allPurchases / countOfCusrtomers;

            Console.WriteLine($"Average bill per client is: {averagePurchase:F2} leva.");
        }
    }
}
