using System;
//using System.Globalization;

namespace P07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We can dynamically calculate price based on different months we stay
            //DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            //DateTime endDate = date.AddDays(nightsCount);

            double studioPrice = 0;
            double apartmentPrice = 0;
            if (month == "May" || month == "October")
            {
                //May or October
                studioPrice = nightsCount * 50;
                apartmentPrice = nightsCount * 65;

                if (nightsCount > 14)
                {
                    studioPrice -= studioPrice * 0.3;
                }
                else if (nightsCount > 7)
                {
                    studioPrice -= studioPrice * 0.05;
                }
            }
            else if (month == "June" || month == "September")
            {
                //June or September
                studioPrice = nightsCount * 75.20;
                apartmentPrice = nightsCount * 68.70;

                if (nightsCount > 14)
                {
                    studioPrice -= studioPrice * 0.2;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = nightsCount * 76;
                apartmentPrice = nightsCount * 77;
            }

            //Additional discount independant of the month
            if (nightsCount > 14)
            {
                apartmentPrice -= apartmentPrice * 0.1;
            }

            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
