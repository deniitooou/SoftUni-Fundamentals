using System;

namespace _01._Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double QuantityFood = double.Parse(Console.ReadLine()) * 1000;
            double QuantityHay = double.Parse(Console.ReadLine()) * 1000;
            double QuantityCover = double.Parse(Console.ReadLine()) * 1000;
            double weight = double.Parse(Console.ReadLine()) * 1000;

            for (int i = 1; i <= 30; i++)
            {

                QuantityFood -= 300;
                if (i %2 ==0)
                {
                    QuantityHay -= QuantityFood * 0.05;
                }
                if (i % 3 ==0)
                {
                    QuantityCover -= weight / 3;
                }
                if (QuantityFood <= 0 || QuantityHay <= 0 || QuantityCover <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");

                    return;
                }
            }
            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(QuantityFood/1000):f2}, Hay: {(QuantityHay / 1000):f2}, Cover: {(QuantityCover / 1000):f2}.");

        }
    }
}
