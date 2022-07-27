using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3._Post_Office
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            char[] capitalLetters = GetCapitalLetters(input[0]);
            Dictionary<char, int> wordLengthsByFirstLetter = GetWordLengths(input[1], capitalLetters);
            List<string> extractedWords = ExtractValidWords(input[2], wordLengthsByFirstLetter);

            for (int i = 0; i < capitalLetters.Length; i++)
            {
                Console.WriteLine(extractedWords.Find(x => x[0] == capitalLetters[i]));
            }
        }

        private static List<string> ExtractValidWords(string inputText, Dictionary<char, int> wordLengthsByFirstLetter)
        {
            string[] allWords = inputText.Split();
            List<string> validWords = new List<string>();

            foreach (string word in allWords)
            {
                char firstLetter = word[0];

                if (wordLengthsByFirstLetter.ContainsKey(firstLetter)
                    && wordLengthsByFirstLetter[firstLetter] == word.Length)
                {
                    validWords.Add(word);
                }
            }

            return validWords;
        }

        private static Dictionary<char, int> GetWordLengths(string inputText, char[] capitalLetters)
        {
            var wordLengthsByFirstLetter = new Dictionary<char, int>();

            string regex = @"(?<ascii>[\d]{2}):(?<length>[\d]{2})";
            MatchCollection matches = Regex.Matches(inputText, regex);

            foreach (Match match in matches)
            {
                char asciiSymbol = (char)int.Parse(match.Groups["ascii"].Value);
                int length = 1 + int.Parse(match.Groups["length"].Value);

                if (capitalLetters.Contains(asciiSymbol))
                {
                    if (wordLengthsByFirstLetter.ContainsKey(asciiSymbol))
                        wordLengthsByFirstLetter[asciiSymbol] = length;

                    else
                        wordLengthsByFirstLetter.Add(asciiSymbol, length);
                }
            }

            return wordLengthsByFirstLetter;
        }

        private static char[] GetCapitalLetters(string inputText)
        {
            string regex = @"([#$%*&])(?<capitalChars>[A-Z]+)\1";

            MatchCollection match = Regex.Matches(inputText, regex);
            string regexResult = String.Empty;

            for (int i = 0; i < match.Count; i++)
            {
                regexResult += match[i].Groups["capitalChars"].Value;
            }

            return regexResult.ToCharArray();
        }
    }
}
