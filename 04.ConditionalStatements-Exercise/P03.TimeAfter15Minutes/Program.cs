using System;

namespace P03.TimeAfter15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            //Action
            minutes += 15; //After 15 minutes
            if (minutes >= 60)
            {
                //Take us to the next hour
                hour += 1;
                minutes -= 60;
            }

            if (hour >= 24)
            {
                //Take us to the next day
                hour -= 24;
            }

            //Output
            //if (minutes <= 9)
            //{
            //    Console.WriteLine($"{hour}:0{minutes}");
            //}
            //else
            //{
            //    Console.WriteLine($"{hour}:{minutes}");
            //}
            Console.WriteLine($"{hour}:{minutes:d2}");
        }
    }
}
