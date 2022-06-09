using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] wagons = new int[numberOfWagons];

            int sum = 0;

            for (int indexOfWagons = 0; indexOfWagons < wagons.Length; indexOfWagons++)
            {
                wagons[indexOfWagons]= int.Parse(Console.ReadLine());
                sum += wagons[indexOfWagons];
            }

            foreach (int wagon in wagons)
            {
                Console.Write($"{wagon} ");
            }

            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
