using System;

namespace _01._Debit_Card_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var number3 = int.Parse(Console.ReadLine());
            var number4 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:D4} {1:D4} {2:0000} {3:0000}", number1, number2, number3, number4);
        }
    }
}
