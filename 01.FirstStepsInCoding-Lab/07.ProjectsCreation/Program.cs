using System;

namespace _07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstName = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());

            double hoursPerProject = 3;
            double finalTime = projects * hoursPerProject;

            Console.WriteLine($"The architect {FirstName} will need {finalTime} hours to complete {projects} project/s. ");
        }
    }
}
