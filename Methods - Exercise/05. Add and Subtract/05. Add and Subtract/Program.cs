using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            int result = SumOfTheFirstTwoInts(numberOne,numberTwo);
            int finalResult = SubtractTheThirdIntFromSum(result, numberThree);
            Console.WriteLine((finalResult));
        }

        static int SumOfTheFirstTwoInts(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }
        static int SubtractTheThirdIntFromSum(int result, int numberThree)
        {
            return result - numberThree;
        }
    }
}
