using System;

namespace _01._Guinea_Pig
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalFood = double.Parse(Console.ReadLine()) * 1000;
            double totalHay = double.Parse(Console.ReadLine()) * 1000;
            double totalCover = double.Parse(Console.ReadLine()) * 1000;
            double pigWeight = double.Parse(Console.ReadLine()) * 1000;
            for (int i = 1; i <= 30; i++)
            {
                totalFood -= 300;
                if (i % 2 == 0)
                {
                    totalHay -= 0.05 * totalFood;
                }
                if (i % 3 == 0)
                {
                    totalCover -= pigWeight / 3;
                }
                
            }
            if (totalFood <= 0 || totalHay <= 0 || totalCover <= 0)
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
            else
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {totalFood / 1000:f2}, Hay: {totalHay/ 1000:f2}, Cover: {totalCover / 1000:f2}.");
            }
        }
    }
}
