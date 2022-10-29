using System;

namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int clas = 1;
            double allGrades = 0;

            int badGrades = 0;

            while (clas <= 12)
            {
                double currentGrade = double.Parse(Console.ReadLine());

                if (currentGrade < 4)
                {
                    badGrades++;

                    if (badGrades > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {clas} grade");
                        return;
                    }
                    continue;
                }

                clas++;
                allGrades += currentGrade;
            }

            double averageGrade = allGrades / 12;

            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:F2}");
        }
    }
}
