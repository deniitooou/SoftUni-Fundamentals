using System;

namespace _02._From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputNumber; i++)
            {
                string input = Console.ReadLine();
                string stringBeforeSpace = input.Substring(0, input.IndexOf(" "));
                string stringAfterSpace = input.Substring(input.IndexOf(" ") + 1);
                long numLeft = (long.Parse(stringBeforeSpace));
                long numRight = (long.Parse(stringAfterSpace));

                long maxNumber = Math.Max(numLeft, numRight);
                long sum = 0;
                while (Math.Abs(maxNumber) > 0)
                {
                    sum += maxNumber % 10;
                    maxNumber /= 10;
                }
                Console.WriteLine(Math.Abs(sum));
            }
        }
    }
}
