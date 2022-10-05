using System;

namespace P04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            int pages = int.Parse(Console.ReadLine());
            int readPagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            // Calculations
            int hoursForRead = pages / readPagesPerHour;
            int daysForRead = hoursForRead / days;

            // Output
            Console.WriteLine(daysForRead);
        }
    }
}
