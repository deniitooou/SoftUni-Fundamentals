using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();

            foreach (var ch in input)
            {
                if (char.IsDigit(ch))
                {
                    digits.Append(ch);
                }

                else if (char.IsLetter(ch))
                {
                    letters.Append(ch);
                }

                else
                {
                    others.Append(ch);
                }
            }

            Console.WriteLine(digits);

            Console.WriteLine(letters);

            Console.WriteLine(others);
        }
    }
}
