using System;

namespace _10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char character = char.Parse(Console.ReadLine());

            if (Char.IsLower(character))
            {
                Console.WriteLine("lower-case");
            }
            else if (Char.IsUpper(character))
            {
                Console.WriteLine("upper-case");

            }
        }
    }
}
