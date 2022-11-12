using System;

namespace _04.EasterEggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfEggs = int.Parse(Console.ReadLine());

            // "red", "orange", "blue", "green"

            int redEggs = 0;
            int orangeEggs = 0;
            int blueEggs = 0;
            int greenEggs = 0;

            int maxCount = int.MinValue;
            string maxColor = string.Empty;

            for (int i = 0; i < countOfEggs; i++)
            {
                string color = Console.ReadLine();

                if (color == "red")
                {
                    redEggs++;

                    if (redEggs > maxCount)
                    {
                        maxCount = redEggs;
                        maxColor = color;
                    }
                }
                else if (color == "orange")
                {
                    orangeEggs++;

                    if (orangeEggs > maxCount)
                    {
                        maxCount = orangeEggs;
                        maxColor = color;
                    }
                }
                else if (color == "blue")
                {
                    blueEggs++;

                    if (blueEggs > maxCount)
                    {
                        maxCount = blueEggs;
                        maxColor = color;
                    }
                }
                else if (color == "green")
                {
                    greenEggs++;

                    if (greenEggs > maxCount)
                    {
                        maxCount = greenEggs;
                        maxColor = color;
                    }
                }
            }

            Console.WriteLine($"Red eggs: {redEggs}");
            Console.WriteLine($"Orange eggs: {orangeEggs}");
            Console.WriteLine($"Blue eggs: {blueEggs}");
            Console.WriteLine($"Green eggs: {greenEggs}");
            Console.WriteLine($"Max eggs: {maxCount} -> {maxColor}");

        }
    }
}
