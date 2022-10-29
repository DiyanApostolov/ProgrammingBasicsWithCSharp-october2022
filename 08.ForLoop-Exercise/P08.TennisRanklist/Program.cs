using System;

namespace P08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Четем от конзолата:
            //=> Брой турнири, в които е участвал – цяло число в интервала [1…20]
            int n = int.Parse(Console.ReadLine());

            //=> Начален брой точки в ранглистата - цяло число в интервала[1...4000]
            int points = int.Parse(Console.ReadLine());

            //2. Създаваме променлива за:
            //=> позицията на завършване:
            string possition;

            //=> общият брой точки:
            int matchPoints = 0;

            int totalSum = 0;

            double wins = 0;

            //Създаваме цикъл, който се върти от 1 до n включително
            for (int i = 1; i <= n; i++)
            {
                possition = Console.ReadLine();

                if (possition == "W")
                {
                    matchPoints += 2000;
                    wins++;
                }
                else if (possition == "F")
                {
                    matchPoints += 1200;
                }
                else
                {
                    matchPoints += 720;
                }

                totalSum = points + matchPoints;
            }

            double averigePoints = matchPoints / n;

            double percentWinsPerTournament = wins / n * 100;

            Console.WriteLine($"Final points: {totalSum}");
            Console.WriteLine($"Average points: {averigePoints}");
            Console.WriteLine($"{percentWinsPerTournament:f2}%");
        }
    }
}
