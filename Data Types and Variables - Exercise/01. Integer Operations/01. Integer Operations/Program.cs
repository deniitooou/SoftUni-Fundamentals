using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int divideNumber = int.Parse(Console.ReadLine());
            int multiplayNumber = int.Parse(Console.ReadLine());

            int sumNums = firstNumber + secondNumber;
            int divisionResult = sumNums / divideNumber;
            int multiplyResult = divisionResult * multiplayNumber;

            Console.WriteLine(multiplyResult);
        }
    }
}
