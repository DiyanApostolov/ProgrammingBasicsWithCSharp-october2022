using System;

namespace _06.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int i = floors; i >= 1; i--)
            {
                for (int j = 0; j < rooms; j++)
                {
                    if (i == floors)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else if (i % 2 == 1)
                    {
                        Console.Write($"A{i}{j} ");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
