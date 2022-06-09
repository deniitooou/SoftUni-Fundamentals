using System;
using System.Text;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeate = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(text,repeate));
        }

        static string RepeatString (string text, int repeate)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < repeate; i++)
            {
                result.Append(text);
            }
            return result.ToString();
        }
    }
}
