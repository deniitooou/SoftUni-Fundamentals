using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _2._Rage_Quit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();

            MatchCollection matchesByPattern = Regex.Matches(input, @"(?<string>[^\d]+)(?<number>[\d]+)");
            StringBuilder resultString = new StringBuilder();

            foreach (Match match in matchesByPattern)
                resultString.Append(GetRepeatedText(match));

            char[] uniqueSymbols = GetUniqueSymbols(resultString.ToString());

            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Length}");
            Console.WriteLine($"{resultString}");
        }

        static string GetRepeatedText(Match match)
        {
            StringBuilder sb = new StringBuilder();
            string rageText = match.Groups["string"].Value;
            int numberOfRepeats = int.Parse(match.Groups["number"].Value);

            for (int i = 0; i < numberOfRepeats; i++)
                sb.Append(rageText);

            return sb.ToString();
        }

        static char[] GetUniqueSymbols(string result)
        {
            var uniqueSymbolsList = new List<char>();
            foreach (char c in result)
            {
                if (c >= '0' && c <= '9') continue;
                if (!uniqueSymbolsList.Contains(c))
                    uniqueSymbolsList.Add(c);
            }
            return uniqueSymbolsList.ToArray();
        }
    }
}
