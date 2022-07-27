using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4._Santa_s_Secret_Helper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            var goodChildren = new List<string>();
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string message = GetDecodedInput(input, key);
                string regex = @"[@](?<name>[A-Za-z]+)[^@!:>-]+[!](?<behaviour>[G|N])[!]";
                MatchCollection matchInfo = Regex.Matches(message, regex);

                if (matchInfo.Count == 0)
                {
                    continue;
                }

                string childName = matchInfo[0].Groups["name"].Value;
                string childBehaviour = matchInfo[0].Groups["behaviour"].Value;

                if (childBehaviour == "G")
                {
                    goodChildren.Add(childName);
                }
            }

            Console.WriteLine(String.Join("\n", goodChildren));
        }

        static string GetDecodedInput(string input, int key)
        {
            char[] decodedChars = input
                .ToCharArray()
                .Select(x => (char)(x - key))
                .ToArray();

            return String.Join("", decodedChars);
        }
    }
}
