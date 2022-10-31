using System;

namespace P04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double stepsSum = 0;
            while (command != "Going home")
            {
                double currentSteps = double.Parse(command);
                stepsSum += currentSteps;

                if (stepsSum >= 10000)
                {
                    break;
                }

                command = Console.ReadLine();
            }

            if (command == "Going home")
            {
                double moreSteps = double.Parse(Console.ReadLine());
                stepsSum += moreSteps;
            }

            if (stepsSum >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsSum - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - stepsSum} more steps to reach goal.");
            }
        }
    }
}