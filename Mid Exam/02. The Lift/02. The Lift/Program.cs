using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int waitingPeople = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxPeople = 4;

            for (int i = 0; i < lift.Length; i++)
            {
                for (int j = lift[i]; j < maxPeople; j++)
                {
                    lift[i]++;
                    waitingPeople--;

                    if (waitingPeople == 0)
                    {
                        if (lift.Sum() < lift.Length * maxPeople)
                        {
                            Console.WriteLine("The lift has empty spots!");
                        }

                        Console.WriteLine(String.Join(' ', lift));
                        return;
                    }
                }
            }
            Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
            Console.WriteLine(String.Join(' ', lift));
        }
    }
}