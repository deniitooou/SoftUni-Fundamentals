using System;
using System.Text;

namespace _01._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputCnt = int.Parse(Console.ReadLine());

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < inputCnt; i++)
            {
                string inputString = Console.ReadLine();

                string name = FindName(inputString);
                string age = FindAge(inputString);

                output.AppendLine($"{name} is {age} years old.");
            }

            Console.WriteLine(output.ToString());
        }

        private static string FindAge(string inputString)
        {
            int startIndex = inputString.IndexOf('#');
            int endIndex = inputString.IndexOf('*');

            string age = inputString.Substring(startIndex + 1, endIndex - startIndex - 1);

            return age;
        }

        private static string FindName(string inputString)
        {
            int startIndex = inputString.IndexOf('@');
            int endIndex = inputString.IndexOf('|');

            string name = inputString.Substring(startIndex + 1, endIndex - startIndex - 1);

            return name;
        }
    }
}
