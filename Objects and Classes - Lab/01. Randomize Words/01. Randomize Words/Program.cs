using System;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] wordsInput = Console.ReadLine().Split(' ');

            Random random = new Random();

            for (int i = 0; i < wordsInput.Length; i++)
            {
                int randomize = random.Next(0, wordsInput.Length);

                string currentWord = wordsInput[i];

                wordsInput[i] = wordsInput[randomize];
                wordsInput[randomize] = currentWord;
            }

            foreach (var word in wordsInput)
            {
                Console.WriteLine(word);
            }

        }
    }
}
