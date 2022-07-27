using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split("\\");

            string[] fileAndText = path[path.Length - 1].Split('.');

            string file = fileAndText[0];
            string text = fileAndText[1];

            Console.WriteLine($"File name: {file}");
            Console.WriteLine($"File extension: {text}");
        }
    }
}
