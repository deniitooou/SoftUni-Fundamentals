using System;

namespace _08._Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputInteger = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputInteger; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
