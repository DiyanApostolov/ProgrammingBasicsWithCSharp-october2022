using Microsoft.VisualBasic;
using System;

namespace _01.OscarsCeremony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double statuetki = rent * 0.7;
            double catering = statuetki * 0.85;
            double sound = catering / 2;

            double funalPrice = rent + statuetki + catering + sound;

            Console.WriteLine($"{funalPrice:F2}");


        }
    }
}
