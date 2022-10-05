using System;

namespace P06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constants
            double priceForNylon = 1.5;
            double priceForPaint = 14.5;
            double priceForThinner = 5;
            double priceForbags = 0.40;

            // Input
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            // Calculations
            double sumForNylon = (nylon + 2) * priceForNylon;
            double sumForPaint = (paint * 1.1) * priceForPaint;
            double sumForThinner = thinner * priceForThinner;

            double sumForMaterials = sumForNylon + sumForPaint + sumForThinner + priceForbags;
            double priceForWorkman = sumForMaterials * 0.3 * hours;
            double finalPrice = sumForMaterials + priceForWorkman;

            // Output
            Console.WriteLine(finalPrice);
        }
    }
}
