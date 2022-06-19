using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            Console.WriteLine(PrintTheSmallestNumber(numberOne, numberTwo, numberThree));
        }

        static int PrintTheSmallestNumber(int numberOne, int numberTwo, int numberThree)
        {
            return Math.Min(numberOne, Math.Min(numberTwo, numberThree));
        }
    }
}
