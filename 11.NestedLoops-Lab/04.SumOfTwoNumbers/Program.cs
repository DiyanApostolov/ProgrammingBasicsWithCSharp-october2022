using System;
using System.Diagnostics.Tracing;

namespace _04.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            int counter = 0;
            bool isFound = false;

            for (int i = start; i <= finish; i++)
            {
                for (int j = start; j <= finish; j++)
                {
                    counter++;

                    if (i + j == number)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {number})");
                        isFound = true;
                        break;
                    }
                }

                if (isFound)
                {
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"{counter} combinations - neither equals {number}");
            }
            
        }
    }
}
