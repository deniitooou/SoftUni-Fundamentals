using System;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int power = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (power > 0 && inputString[i] != '>')
                {
                    inputString = inputString.Remove(i, 1);
                    power--;
                    i--;
                }
                else if (inputString[i] == '>')
                {
                    power += int.Parse(inputString[i + 1].ToString());
                }
            }
            Console.WriteLine(inputString);
        }
    }
}
