using System;

namespace _02._Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rectangleSideA = double.Parse(Console.ReadLine());
            var rectangleSideB = double.Parse(Console.ReadLine());
            var rectangleArea = rectangleSideA * rectangleSideB;

            Console.WriteLine("{0:F2}", rectangleArea);
        }
    }
}
