using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();
            string word = string.Join("", text);

            Dictionary<char, int> characters = new Dictionary<char, int>();

            foreach (var charr in word)
            {
                if (!characters.ContainsKey(charr))
                {
                    characters.Add(charr, 0);
                }
                characters[charr]++;
            }
            foreach (var character in characters)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
