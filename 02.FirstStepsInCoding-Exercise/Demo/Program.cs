using System;

namespace Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Short arithmetic operations
            int a = 5;
            a += 2; //a = a + 2; //7
            a -= 2; //a = a - 2; //5
            a *= 2; //a = a * 2; //10
            a /= 10; //a = a / 10; //1
            a %= 2; //a = a % 2; //1

            int num = int.Parse(Console.ReadLine());

            //Take the last digit from a number
            int lastDigit = num % 10;

            //Remove the last digit from a number
            num /= 10;

            Console.WriteLine($"The last digit of the number is {lastDigit}.");
            Console.WriteLine($"Number now is {num}");
        }
    }
}