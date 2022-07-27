using System;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            char[] inputChars = inputText.ToCharArray();

            char[] outputChars = new char[inputChars.Length];

            for (int i = 0; i < inputChars.Length; i++)
            {
                char result = Convert.ToChar((inputChars[i] + 3));
                outputChars[i] = result;
            }
            Console.WriteLine(String.Join("", outputChars));
        }
    }
}
