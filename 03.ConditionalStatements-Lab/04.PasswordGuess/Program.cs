using System;

namespace _04.PasswordGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string password = "s3cr3t!P@ssw0rd";

            bool isSame = input == password;

            if (isSame)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }

        }
    }
}
