using System;

namespace _03.EasterTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dateOfTrip = Console.ReadLine();
            int countOfNights = int.Parse(Console.ReadLine());

            int price = 0;

            switch (destination)
            {
                case "France":
                    if (dateOfTrip == "21-23")
                    {
                        price = 30;
                    }
                    else if (dateOfTrip == "24-27")
                    {
                        price = 35;
                    }
                    else if (dateOfTrip == "28-31")
                    {
                        price = 40;
                    }
                    break;
                case "Italy":
                    if (dateOfTrip == "21-23")
                    {
                        price = 28;
                    }
                    else if (dateOfTrip == "24-27")
                    {
                        price = 32;
                    }
                    else if (dateOfTrip == "28-31")
                    {
                        price = 39;
                    }
                    break;
                case "Germany":
                    if (dateOfTrip == "21-23")
                    {
                        price = 32;
                    }
                    else if (dateOfTrip == "24-27")
                    {
                        price = 37;
                    }
                    else if (dateOfTrip == "28-31")
                    {
                        price = 43;
                    }
                    break;
            }

            double finalPrice = countOfNights * price;

            Console.WriteLine($"Easter trip to {destination} : {finalPrice:F2} leva.");
        }
    }
}
