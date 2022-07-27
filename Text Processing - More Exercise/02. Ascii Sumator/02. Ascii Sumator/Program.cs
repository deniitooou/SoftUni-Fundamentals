using System;

namespace _02._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startSymbol = char.Parse(Console.ReadLine());
            char endSymbol = char.Parse(Console.ReadLine());
            string inputString = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] > startSymbol && inputString[i] < endSymbol)
                {
                    sum += inputString[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
