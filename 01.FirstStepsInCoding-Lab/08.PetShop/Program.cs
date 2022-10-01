using System;

namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfFoodForDog = int.Parse(Console.ReadLine());
            int countOfCatFood = int.Parse(Console.ReadLine());

            double pricePerDogFood = 2.5;
            double pricePerCatFood = 4;
            double finalSum = countOfFoodForDog * pricePerDogFood + countOfCatFood * pricePerCatFood;

            Console.WriteLine($"{finalSum} lv.");
        }
    }
}
