using System;

namespace P01.CurrencyConvertor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cast example
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine((double)a / b);
            //Console.WriteLine(a % b);

            //Input
            //string -> double (Parsing)
            double usd = double.Parse(Console.ReadLine());

            //Actions
            double bgn = usd * 1.79549;

            //Output
            Console.WriteLine(bgn);
        }
    }
}
