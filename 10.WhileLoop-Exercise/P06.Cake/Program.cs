using System;

namespace P06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cakeLength = int.Parse(Console.ReadLine());
            int cakeWidth = int.Parse(Console.ReadLine());

            int totalPieces = cakeLength * cakeWidth; //Pieces count = Area of the rectangle

            string command;
            while ((command = Console.ReadLine()) != "STOP")
            {
                int piecesTaken = int.Parse(command);

                totalPieces -= piecesTaken;
                if (totalPieces < 0)
                {
                    break;
                }
            }

            if (totalPieces < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
            }
            else
            {
                //0 pieces are left!!!
                Console.WriteLine($"{totalPieces} pieces are left.");
            }
        }
    }
}
