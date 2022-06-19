using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintNxNMatrix(number);
        }

        static void PrintNxNMatrix(int number)
        {
            for (int k = 0; k <number; k++)
            {
                for (int i = 0; i < number; i++)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
        }
    }
}
