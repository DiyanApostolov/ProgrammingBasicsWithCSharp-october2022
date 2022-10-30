using System;

namespace P03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            double moneyBalance = double.Parse(Console.ReadLine());

            int totalDaysCnt = 0;
            int sequentialSpendDaysCnt = 0;
            //bool spendTooMuch = false;
            while (moneyBalance < vacationPrice && sequentialSpendDaysCnt < 5)
            {
                string action = Console.ReadLine(); //save/spend
                double sum = double.Parse(Console.ReadLine()); //sum to save/spend

                totalDaysCnt++;

                if (action == "save")
                {
                    moneyBalance += sum;
                    sequentialSpendDaysCnt = 0;
                }
                else if (action == "spend")
                {
                    moneyBalance -= sum;
                    if (moneyBalance < 0)
                    {
                        moneyBalance = 0;
                    }

                    sequentialSpendDaysCnt++;
                    //if (sequentialSpendDaysCnt >= 5)
                    //{
                    //    //spendTooMuch = true;
                    //    break;
                    //}
                }
            }

            if (sequentialSpendDaysCnt >= 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{totalDaysCnt}");
            }
            else
            {
                Console.WriteLine($"You saved the money for {totalDaysCnt} days.");
            }
        }
    }
}
