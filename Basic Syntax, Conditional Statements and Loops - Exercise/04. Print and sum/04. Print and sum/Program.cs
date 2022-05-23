using System;

namespace _04._Print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            int sum = 0;
            string numbers = "";

            for (int i = startNumber; i <= endNumber; i++)
            {
                sum = sum + i;
                numbers += i + " ";

            }
            Console.WriteLine($"{numbers}");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
