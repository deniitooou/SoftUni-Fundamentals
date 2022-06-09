using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int firstInt = int.Parse(Console.ReadLine());
                    int secondInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstInt, secondInt));
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMaxChar(firstChar, secondChar));
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    Console.WriteLine(GetMaxString(firstString, secondString));
                    break;

            }

            static int GetMax(int first, int second)
            {
                if (first > second)
                {
                    return first;
                }
                return second;
            }

            static char GetMaxChar(char first, char second)
            {
                if (first > second)
                {
                    return first;
                }
                return second;
            }

            static string GetMaxString(string first, string second)
            {
                int result = first.CompareTo(second);
                if (result > 0)
                {
                    return first;
                }
                return second;
            }
        }
    }
}
