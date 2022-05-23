using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int input = number;
            int factorialSum = 0;

            while (number > 0)
            {
                int factorial = 1;
                int currNumber = number % 10;
                number /= 10;

                for (int i = 2; i <= currNumber; i++)
                {
                    factorial *= i;
                }

                factorialSum += factorial;

            }

            if (factorialSum == input)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
