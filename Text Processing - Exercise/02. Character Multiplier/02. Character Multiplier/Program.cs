using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputStrings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


            char[] firstString = inputStrings[0].ToCharArray();
            char[] secondString = inputStrings[1].ToCharArray();

            long totalSum = 0;
            int maxLength = Math.Max(firstString.Length, secondString.Length);
            int minLength = Math.Min(firstString.Length, secondString.Length);

            for (int i = 0; i < minLength; i++)
            {
                totalSum += firstString[i] * secondString[i];
            }

            if (maxLength == firstString.Length)
            {
                for (int i = minLength; i < maxLength; i++)
                {
                    totalSum += firstString[i];
                }
            }
            else
            {
                for (int i = minLength; i < maxLength; i++)
                {
                    totalSum += secondString[i];
                }
            }
            Console.WriteLine(totalSum);
        }
    }
}
