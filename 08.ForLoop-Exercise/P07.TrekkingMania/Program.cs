using System;

namespace P07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfClimberGroups = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 1; i <= numberOfClimberGroups; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num <= 5)
                {
                    p1 += num;
                }
                else if (num >= 6 && num <= 12)
                {
                    p2 += num;
                }
                else if (num >= 13 && num <= 25)
                {
                    p3 += num;
                }
                else if (num >= 26 && num <= 40)
                {
                    p4 += num;
                }
                else if (num >= 41)
                {
                    p5 += num;
                }
            }

            double allCount = p1 + p2 + p3 + p4 + p5;
            p1 = p1 / allCount * 100;
            p2 = p2 / allCount * 100;
            p3 = p3 / allCount * 100;
            p4 = p4 / allCount * 100;
            p5 = p5 / allCount * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
