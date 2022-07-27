using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(^|\s)[A-Za-z\d]+[\.\-_]*[A-Za-z\d]+@[A-Za-z]+([.-][A-Za-z]+)+\b";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
