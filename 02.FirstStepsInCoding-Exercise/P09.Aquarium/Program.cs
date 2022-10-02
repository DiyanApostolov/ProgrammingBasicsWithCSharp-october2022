using System;

namespace P09.Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int lengthCm = int.Parse(Console.ReadLine());
            int widthCm = int.Parse(Console.ReadLine());
            int heightCm = int.Parse(Console.ReadLine());
            double lossPercent = double.Parse(Console.ReadLine()) / 100;

            //Act
            //Volume = a * b * c (int * int * int = int)
            int volumeCm3 = lengthCm * widthCm * heightCm;
            double volumeLiters = volumeCm3 / 1000.0;
            double lossLiters = volumeLiters * lossPercent;

            double totalLiters = volumeLiters - lossLiters;

            //Output
            Console.WriteLine(totalLiters);
        }
    }
}
