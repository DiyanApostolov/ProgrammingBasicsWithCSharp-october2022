using System;

namespace P05.VacationsBookList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int pagesCount = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysCount = int.Parse(Console.ReadLine());

            //Act
            int hoursNeeded = pagesCount / pagesPerHour;
            int hoursPerDay = hoursNeeded / daysCount;

            //Output
            Console.WriteLine(hoursPerDay);
        }
    }
}
