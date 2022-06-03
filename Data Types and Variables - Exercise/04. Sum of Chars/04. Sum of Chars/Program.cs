using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());

            int totalSum = 0;

            for (int i = 0; i < number; i++)
            {
                char letters = char.Parse(Console.ReadLine());
                totalSum += letters;
            }

            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
