using System;

namespace _11.FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //плод   banana  apple orange  grapefruit kiwi  pineapple grapes
            //цена    2.50    1.20    0.85    1.45    2.70    5.50    3.85

            //плод   banana   apple  oran  grapefruit kiwi  pineapple grapes
            //цена    2.70    1.25    0.90    1.60    3.00    5.60    4.20


            string product = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double priceOfFruit = 0;

            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (product)
                    {
                        case "banana":
                            priceOfFruit = 2.5;
                            break;
                        case "apple":
                            priceOfFruit = 1.2;
                            break;
                        case "orange":
                            priceOfFruit = 0.85;
                            break;
                        case "grapefruit":
                            priceOfFruit = 1.45;
                            break;
                        case "kiwi":
                            priceOfFruit = 2.7;
                            break;
                        case "pineapple":
                            priceOfFruit = 5.5;
                            break;
                        case "grapes":
                            priceOfFruit = 3.85;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (product)
                    {
                        case "banana":
                            priceOfFruit = 2.7;
                            break;
                        case "apple":
                            priceOfFruit = 1.25;
                            break;
                        case "orange":
                            priceOfFruit = 0.9;
                            break;
                        case "grapefruit":
                            priceOfFruit = 1.6;
                            break;
                        case "kiwi":
                            priceOfFruit = 3;
                            break;
                        case "pineapple":
                            priceOfFruit = 5.6;
                            break;
                        case "grapes":
                            priceOfFruit = 4.2;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;  
            }

            double finalPrice = quantity * priceOfFruit;

            if (finalPrice > 0)
            {
                Console.WriteLine($"{finalPrice:F2}");
            }
            
        }
    }
}
