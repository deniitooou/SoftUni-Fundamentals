using System;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringsList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double totalSum = 0;

            foreach (var word in stringsList)
            {
                char firstLetter = word[0];
                char lastLetter = word[word.Length - 1];
                string currWord = word;

                currWord = currWord.Trim(firstLetter);
                currWord = currWord.Trim(lastLetter);

                double number = double.Parse(currWord);

                double firstLetterResult = FirstLetterOperation(firstLetter, number);
                double finalResult = FinalleterOperation(firstLetterResult, lastLetter);
                totalSum += finalResult;
            }
            Console.WriteLine($"{totalSum:f2}");
        }

        private static double FinalleterOperation(double firstLetterResult, char lastLetter)
        {
            char[] upperAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] lowerAlphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            double result = 0;

            if (char.IsUpper(lastLetter))
            {
                int letterPosition = -1;
                for (int i = 0; i < upperAlphabet.Length; i++)
                {
                    if (upperAlphabet[i] == lastLetter)
                    {
                        letterPosition = i + 1;
                        break;
                    }
                }
                result = firstLetterResult - letterPosition;

                return result;
            }
            else
            {
                int letterPosition = -1;
                for (int i = 0; i < lowerAlphabet.Length; i++)
                {
                    if (lowerAlphabet[i] == lastLetter)
                    {
                        letterPosition = i + 1;
                        break;
                    }
                }
                result = firstLetterResult + letterPosition;

                return result;
            }
        }

        private static double FirstLetterOperation(char firstLetter, double number)
        {
            char[] upperAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] lowerAlphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            double result = 0;

            if (char.IsUpper(firstLetter))
            {
                int letterPosition = -1;
                for (int i = 0; i < upperAlphabet.Length; i++)
                {
                    if (upperAlphabet[i] == firstLetter)
                    {
                        letterPosition = i + 1;
                        break;
                    }
                }
                result = number / letterPosition;

                return result;
            }
            else
            {
                int letterPosition = -1;
                for (int i = 0; i < lowerAlphabet.Length; i++)
                {
                    if (lowerAlphabet[i] == firstLetter)
                    {
                        letterPosition = i + 1;
                        break;
                    }
                }
                result = number * letterPosition;

                return result;
            }
        }
    }
}
