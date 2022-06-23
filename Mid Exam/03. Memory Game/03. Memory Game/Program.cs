using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sequenceOfElements = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string elements;
            int moves = 0;
            while ((elements = Console.ReadLine()) != "end")
            {
                moves++;
                int[] indexes = elements
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                if (indexes[0] == indexes[1] ||
                    indexes[0] < 0 ||
                    indexes[1] < 0 ||
                    indexes[0] >= sequenceOfElements.Count ||
                    indexes[1] >= sequenceOfElements.Count)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    sequenceOfElements.Insert(sequenceOfElements.Count / 2, "-" + moves + "a");
                    sequenceOfElements.Insert(sequenceOfElements.Count / 2, "-" + moves + "a");
                }
                else if (sequenceOfElements[indexes[0]] == sequenceOfElements[indexes[1]])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {sequenceOfElements[indexes[0]]}!");
                    if (indexes[0] < indexes[1])
                    {
                        sequenceOfElements.RemoveAt(indexes[1]);
                        sequenceOfElements.RemoveAt(indexes[0]);
                    }
                    else
                    {
                        sequenceOfElements.RemoveAt(indexes[0]);
                        sequenceOfElements.RemoveAt(indexes[1]);
                    }
                }
                else Console.WriteLine("Try again!");

                if (sequenceOfElements.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    return;
                }
            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(String.Join(" ", sequenceOfElements));
        }
    }
}
