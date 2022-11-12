using System;

namespace _05.Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int leftPoints = 301;

            int successfulShoots = 0;
            int failedShoots = 0;

            while (leftPoints != 0)
            {
                string field = Console.ReadLine();

                if (field == "Retire")
                {
                    break;
                }

                int currentPoints = int.Parse(Console.ReadLine());

                if (field == "Single")
                {
                    if (currentPoints <= leftPoints)
                    {
                        leftPoints -= currentPoints;
                        successfulShoots++;
                    }
                    else 
                    {
                        failedShoots++;
                    }
                }
                else if (field == "Double")
                {
                    if (currentPoints * 2 <= leftPoints)
                    {
                        leftPoints -= currentPoints * 2;
                        successfulShoots++;
                    }
                    else
                    {
                        failedShoots++;
                    }
                }
                else if (field == "Triple")
                {
                    if (currentPoints * 3 <= leftPoints)
                    {
                        leftPoints -= currentPoints * 3;
                        successfulShoots++;
                    }
                    else
                    {
                        failedShoots++;
                    }
                }
            }

            if (leftPoints == 0)
            {
                Console.WriteLine($"{name} won the leg with {successfulShoots} shots.");
            }
            else
            {
                Console.WriteLine($"{name} retired after {failedShoots} unsuccessful shots.");
            }
        }
    }
}
