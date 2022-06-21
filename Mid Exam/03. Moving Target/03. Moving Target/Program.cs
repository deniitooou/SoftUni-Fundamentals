using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] tokens = command.Split();
                string action = tokens[0];

                switch (action)
                {
                    case "Shoot":
                        CommandShoot(int.Parse(tokens[1]), int.Parse(tokens[2]), targets);
                        break;
                    case "Add":
                        CommandAdd(int.Parse(tokens[1]), int.Parse(tokens[2]), targets);
                        break;
                    case "Strike":
                        CommandStrike(int.Parse(tokens[1]), int.Parse(tokens[2]), targets);
                        break;
                }
            }

            Console.WriteLine(string.Join("|", targets));
        }

        static void CommandShoot(int index, int power, List<int> targets)
        {
            if (index < 0 || index > targets.Count - 1)
            {
                return;
            }

            targets[index] -= power;

            if (targets[index] <= 0)
            {
                targets.RemoveAt(index);
            }
        }

        static void CommandAdd(int index, int value, List<int> targets)
        {
            if (index < 0 || index > targets.Count - 1)
            {
                Console.WriteLine("Invalid placement!");

                return;
            }

            targets.Insert(index, value);
        }

        static void CommandStrike(int index, int radius, List<int> targets)
        {
            if (index - radius < 0 || index + radius > targets.Count - 1)
            {
                Console.WriteLine("Strike missed!");

                return;
            }

            targets.RemoveRange(index - radius, radius * 2 + 1);
        }



    }
}

