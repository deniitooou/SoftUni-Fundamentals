using System;

namespace _10._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int time = 0;

            for (int i = 1; i <= 10; i++)
            {
                int total = number * i;

                time += 1;
                Console.WriteLine($"{number} X {time} = {total}");
            }
        }
    }
}
