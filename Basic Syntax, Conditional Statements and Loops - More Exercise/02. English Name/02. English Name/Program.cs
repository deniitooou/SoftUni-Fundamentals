using System;

namespace _02._English_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            long lastD = FindLastDigits(num);

            if (num == 1)
            {
                Console.WriteLine("one");
            }
            else if (lastD == 2)
            {
                Console.WriteLine("two");
            }
            else if (lastD == 3)
            {
                Console.WriteLine("three");
            }
            else if (lastD == 4)
            {
                Console.WriteLine("four");
            }
            else if (lastD == 5)
            {
                Console.WriteLine("five");
            }
            else if (lastD == 6)
            {
                Console.WriteLine("six");
            }
            else if (lastD == 7)
            {
                Console.WriteLine("seven");
            }
            else if (lastD == 8)
            {
                Console.WriteLine("eight");
            }
            else if (lastD == 9)
            {
                Console.WriteLine("nine");
            }
            else if (lastD == 0)
            {
                Console.WriteLine("zero");
            }
        }

        private static long FindLastDigits(long num)
        {
            long lastDigs = Math.Abs(num % 10);
            return lastDigs;
        }
    }
}
