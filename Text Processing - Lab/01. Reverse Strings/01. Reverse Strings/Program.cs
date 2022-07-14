using System;
using System.Linq;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string stringToReverse = Console.ReadLine();

                if (stringToReverse == "end")
                {
                    break;
                }

                string reversedString = string.Join("", stringToReverse.ToCharArray().Reverse());

                Console.WriteLine($"{stringToReverse} = {reversedString}");
            }
        }
    }
}
