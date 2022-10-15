using System;

namespace P02.BonusPoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int number = int.Parse(Console.ReadLine()); //Blocking operation

            //Actions
            double bonusPoints = 0;
            if (number <= 100)
            {
                bonusPoints = 5;
            }
            else if (number > 1000)
            {
                bonusPoints = 0.1 * number; //10% from number
            }
            else if (number > 100)
            {
                bonusPoints = 0.2 * number; //20% from number
            }

            //Additional bonus points
            //Added to already gained points
            if (Math.Abs(number % 2) == 0)
            {
                //Even
                bonusPoints += 1;
            }
            else if (Math.Abs(number % 10) == 5)
            {
                bonusPoints += 2;
            }
            else if (Math.Abs(number % 10) == 6)
            {
                bonusPoints += 3;
            }

            //Output
            Console.WriteLine(bonusPoints);
            Console.WriteLine(number + bonusPoints);
        }
    }
}
