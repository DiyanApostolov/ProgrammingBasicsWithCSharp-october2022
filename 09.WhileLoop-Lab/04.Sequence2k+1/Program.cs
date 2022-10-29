using System;

namespace _04.Sequence2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int k = 1;

            while (k <= num)
            {
                Console.WriteLine(k);

                k = k * 2 + 1;
            }


        }
    }
}
