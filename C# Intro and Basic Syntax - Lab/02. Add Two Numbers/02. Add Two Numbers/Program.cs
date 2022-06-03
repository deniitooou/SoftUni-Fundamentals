using System;

namespace _02._Add_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;

            Console.WriteLine("{0} + {1} = {2}", a, b, sum);
        }
    }
}
