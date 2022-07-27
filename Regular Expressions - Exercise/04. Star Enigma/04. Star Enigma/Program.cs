using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> atackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            string validPattern = @"@(?<name>[A-Za-z]+)[^-@!:>]*:(?<population>\d+)[^-@!:>]*!(?<state>[AD])![^-@!:>]*->(?<soliders>\d+)";


            int messageCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < messageCount; i++)
            {
                string currMessage = Console.ReadLine();
                string decryptedMessage = DecryptMessage(currMessage);

                if (Regex.IsMatch(decryptedMessage, validPattern))
                {
                    string name = Regex.Match(decryptedMessage, validPattern).Groups["name"].ToString();
                    string state = Regex.Match(decryptedMessage, validPattern).Groups["state"].ToString();

                    if (state == "A")
                    {
                        atackedPlanets.Add(name);
                    }
                    else
                    {
                        destroyedPlanets.Add(name);
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {atackedPlanets.Count}");
            foreach (var planetA in atackedPlanets.OrderBy(name => name))
            {
                Console.WriteLine($"-> {planetA}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planetD in destroyedPlanets.OrderBy(name => name))
            {
                Console.WriteLine($"-> {planetD}");
            }
        }

        private static string DecryptMessage(string currMessage)
        {
            string lettersPattern = @"[sSTtAaRr]";
            MatchCollection matches = Regex.Matches(currMessage, lettersPattern);
            int lettersCount = matches.Count;

            StringBuilder result = new StringBuilder();
            char[] message = currMessage.ToCharArray();

            for (int i = 0; i < message.Length; i++)
            {
                char updatedChar = Convert.ToChar(message[i] - lettersCount);
                result.Append(updatedChar);
            }
            return result.ToString();
        }
    }
}
