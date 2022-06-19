using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            SearchingForVoweles(text);
        }

        private static void SearchingForVoweles(string text)
        {
            int count = 0;
            foreach (char vowle in text)
            {
                if ("aouei".Contains(vowle))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
