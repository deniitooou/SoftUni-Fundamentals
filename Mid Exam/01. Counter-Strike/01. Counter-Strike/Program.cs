using System;

namespace _01._Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());

            int battlesWon = 0;
            string input;

            while ((input = Console.ReadLine()) != "End of battle")
            {

                int distance = int.Parse(input);

                if (distance > initialEnergy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battlesWon} won battles and {initialEnergy} energy");
                    return;
                }
                else
                {
                    battlesWon++;
                   initialEnergy -= distance;

                }

                if (battlesWon % 3 == 0)
                {
                    initialEnergy += battlesWon;
                }

            }

            Console.WriteLine($"Won battles: {battlesWon}. Energy left: {initialEnergy}");
        }
    }
}
