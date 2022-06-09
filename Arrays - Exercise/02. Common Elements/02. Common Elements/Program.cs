using System;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] arrOne = Console.ReadLine().Split(' ');
            string[] arrTwo = Console.ReadLine().Split(' ');

            foreach (string currElement in arrOne)
            {
                for (int i = 0; i< arrTwo.Length; i++)
                {
                    string secondCurElement = arrTwo[i];
                    if (currElement == secondCurElement)
                    {
                        Console.Write($"{currElement} ");
                        break;
                    }
                }
            }
        }
    }
}
