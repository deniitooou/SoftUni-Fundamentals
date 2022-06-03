using System;

namespace _04._Refactoring__Prime_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string trueOrFalse = "";

            for (int i = 2; i <= number; i++)
            {
                bool ifItsTrue = true;
                trueOrFalse = "true";
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        trueOrFalse = "false";
                        ifItsTrue = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, trueOrFalse);
            }
        }

    }
}
