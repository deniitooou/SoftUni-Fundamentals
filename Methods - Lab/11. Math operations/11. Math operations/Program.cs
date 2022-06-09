using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string theOperator = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(firstNumber, theOperator, secondNumber));
        }
        static double Calculate(double first, string theOperator, double secondNumber)
        {
            double result = 0;

            switch (theOperator)
            {
                case "+":
                    result = first + secondNumber;
                    break;
                case "-":
                    result = first - secondNumber;
                    break;
                case "*":
                    result = first * secondNumber;
                    break;
                case "/":
                    result = first / secondNumber;
                    break;
            }
            return result;
        }
    }
}
