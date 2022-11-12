using System;

namespace _02.MovieDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timeForFilming = int.Parse(Console.ReadLine());
            int countOfScenes = int.Parse(Console.ReadLine());
            int timeForOneScene = int.Parse(Console.ReadLine());

            double prepearing = timeForFilming * 0.15;
            double timeForScenes = countOfScenes * timeForOneScene;

            double finalTime = prepearing + timeForScenes;

            if (finalTime <= timeForFilming)
            {
                double timeLeft = Math.Round(timeForFilming - finalTime);
                Console.WriteLine($"You managed to finish the movie on time! You have {timeLeft} minutes left!");
            }
            else
            {
                double neededTime = Math.Round(finalTime - timeForFilming);
                Console.WriteLine($"Time is up! To complete the movie you need {neededTime} minutes.");
            }

        }
    }
}
