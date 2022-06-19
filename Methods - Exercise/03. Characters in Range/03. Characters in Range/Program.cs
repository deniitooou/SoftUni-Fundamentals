using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            CharsInRange(first, second);
        }

        static void CharsInRange (char first, char second)
        {
            int start = Math.Min(first, second);
            int end = Math.Max(first, second);

            for (int i = start + 1; i < end; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
