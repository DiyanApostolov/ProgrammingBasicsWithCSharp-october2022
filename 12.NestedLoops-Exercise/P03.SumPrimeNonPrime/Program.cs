using System;

namespace P03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumPrime = 0;
            int sumNonPrime = 0;

            string command; //= Console.ReadLine();
            while ((command = Console.ReadLine()) != "stop")
            {
                int currNumber = int.Parse(command);

                if (currNumber < 0)
                {
                    //Special case -> Negative numbers cannot be proceeded
                    Console.WriteLine($"Number is negative.");
                    //command = Console.ReadLine();
                    continue;
                }
                else if (currNumber == 0 || currNumber == 1)
                {
                    //Special cases -> NonPrime
                    sumNonPrime += currNumber;
                    //command = Console.ReadLine();
                    continue;
                }

                //Not negative number, not 0 or 1
                //We assume that the number is prime
                //We will try to prove the opposite
                //NonPrime number -> can be divided on a number from 2 to SQRT(num)
                bool isPrime = true;
                for (int div = 2; div <= Math.Sqrt(currNumber); div++)
                {
                    if (currNumber % div == 0)
                    {
                        //I found divider apart from 1 and the number itselft
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    sumPrime += currNumber;
                }
                else
                {
                    sumNonPrime += currNumber;
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
