using System;

namespace P06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentTicketsCnt = 0;
            int standardTicketsCnt = 0;
            int kidTicketsCnt = 0;

            string movieName;
            while ((movieName = Console.ReadLine()) != "Finish")
            {
                int totalSeats = int.Parse(Console.ReadLine());
                int takenSeats = 0;

                string ticketType;
                while (takenSeats < totalSeats && (ticketType = Console.ReadLine()) != "End")
                {
                    takenSeats++;

                    if (ticketType == "student")
                    {
                        studentTicketsCnt++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTicketsCnt++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTicketsCnt++;
                    }
                }

                double projectionPercantage = ((double)takenSeats / totalSeats) * 100;
                Console.WriteLine($"{movieName} - {projectionPercantage:f2}% full.");
            }

            int totalTicketsCount = studentTicketsCnt + standardTicketsCnt + kidTicketsCnt;
            double studentPercentage = ((double)studentTicketsCnt / totalTicketsCount) * 100;
            double standardPercentage = ((double)standardTicketsCnt / totalTicketsCount) * 100;
            double kidPercantage = ((double)kidTicketsCnt / totalTicketsCount) * 100;

            Console.WriteLine($"Total tickets: {totalTicketsCount}");
            Console.WriteLine($"{studentPercentage:f2}% student tickets.");
            Console.WriteLine($"{standardPercentage:f2}% standard tickets.");
            Console.WriteLine($"{kidPercantage:f2}% kids tickets.");
        }
    }
}
