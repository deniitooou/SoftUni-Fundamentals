using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());

            for (int i = startNumber; i <= lastNumber; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
