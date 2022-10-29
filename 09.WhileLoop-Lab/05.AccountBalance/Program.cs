using System;

namespace _05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double balance = 0;

            while (input != "NoMoreMoney")
            {
                double amount = double.Parse(input);

                if (amount >= 0)
                {
                    balance += amount;
                    Console.WriteLine($"Increase: {amount:F2}");
                }
                else 
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {balance:F2}");
        }
    }
}
