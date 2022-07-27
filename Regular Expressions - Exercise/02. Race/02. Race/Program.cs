using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Runner> runners = Console.ReadLine()
               .Split(", ")
               .Select(runner => new Runner(runner))
               .ToList();

            string namePattern = @"[A-Za-za]";
            string digitPattern = @"[0-9]";

            string input = Console.ReadLine();
            while (input != "end of race")
            {
                MatchCollection letters = Regex.Matches(input, namePattern);
                MatchCollection digits = Regex.Matches(input, digitPattern);

                char[] currNameArr = letters
                    .Select(letter => letter.Value)
                    .Select(lettrValue => char.Parse(lettrValue))
                    .ToArray();
                string currName = string.Join("", currNameArr);
                int kmRan = digits
                    .Select(digit => int.Parse(digit.Value))
                    .Sum();

                if (runners.Any(runner => runner.Name == currName))
                {
                    var runner = runners.Find(runner => runner.Name == currName);
                    runner.KmRunned += kmRan;
                }
                input = Console.ReadLine();
            }

            var orderedRunners = runners.OrderByDescending(runner => runner.KmRunned).ToList();
            Console.WriteLine($"1st place: {orderedRunners[0].Name}");
            Console.WriteLine($"2nd place: {orderedRunners[1].Name}");
            Console.WriteLine($"3rd place: {orderedRunners[2].Name}");
        }
    }
    class Runner
    {
        public Runner(string name)
        {
            Name = name;
            KmRunned = 0;
        }

        public string Name { get; set; }
        public int KmRunned { get; set; }
    }
}

