using System;

namespace P05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //All numbers from 1111 to 9999 without zeros
            for (int n1 = 1; n1 <= 9; n1++)
            {
                for (int n2 = 1; n2 <= 9; n2++)
                {
                    for (int n3 = 1; n3 <= 9; n3++)
                    {
                        for (int n4 = 1; n4 <= 9; n4++)
                        {
                            bool isSpecial = n % n4 == 0 && n % n3 == 0 &&
                                n % n2 == 0 && n % n1 == 0;
                            if (isSpecial)
                            {
                                Console.Write($"{n1}{n2}{n3}{n4} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
