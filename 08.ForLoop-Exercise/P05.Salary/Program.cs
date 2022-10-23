using System;

namespace P05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string website = Console.ReadLine();
                if (website == "Facebook")
                {
                    salary -= 150;
                }
                else if (website == "Instagram")
                {
                    salary -= 100;
                }
                else if (website == "Reddit")
                {
                    salary -= 50;
                }

                if (salary <= 0)
                {
                    //Console.WriteLine("You have lost your salary.");
                    //return; //Program ends here...
                    break; //Breaks the loop
                }
            }

            //My salary has gone or I have passed all tabs
            if (salary <= 0)
            {
                Console.WriteLine($"You have lost your salary.");
            }
            else
            {
                Console.WriteLine($"{salary:f0}");
            }
        }
    }
}
