using System;

namespace _08.CinemaTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();

            double price = 0;

            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Friday")
            {
                price = 12;
            }
            else if (dayOfWeek == "Wednesday" || dayOfWeek == "Thursday")
            {
                price = 14;
            }
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                price = 16;
            }

            Console.WriteLine(price);
        }
    }
}
