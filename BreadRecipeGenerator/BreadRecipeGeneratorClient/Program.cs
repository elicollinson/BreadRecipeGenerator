using BreadRecipeGeneratorClient.Models;
using System;

namespace BreadRecipeGeneratorClient
{
    class Program
    {
        static void Main(string[] args)
        {
            StepTiming temp = new StepTiming(DateTime.Now, true, 8, 60, 2);
            Console.WriteLine(temp.RecipeTimingToString());
            Console.ReadLine();
        }
    }
}
