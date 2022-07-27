using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Demon> demonList = new List<Demon>();

            string input = Console.ReadLine();

            string[] demonNames = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var demonName in demonNames)
            {
                int health = GetHealth(demonName);
                double damage = GetDamage(demonName);

                var currDemon = new Demon(demonName, health, damage);
                demonList.Add(currDemon);
            }

            foreach (var demon in demonList.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }

        private static double GetDamage(string demonName)
        {
            string damagePattern = @"([-+]?\d+(\.\d+)?)";
            MatchCollection validDigitMatches = Regex.Matches(demonName, damagePattern);
            double[] numbers = validDigitMatches
                .Select(x => x.Value)
                .Select(y => double.Parse(y))
                .ToArray();
            double digitSum = numbers.Sum();

            for (int i = 0; i < demonName.Length; i++)
            {
                if (demonName[i] == '*')
                {
                    digitSum *= 2;
                }
                if (demonName[i] == '/')
                {
                    digitSum /= 2;
                }
            }

            return digitSum;
        }

        private static int GetHealth(string demonName)
        {
            int sum = 0;

            string healthPattern = @"[^\d\+\-\*\/\.]";
            MatchCollection validCharsMatches = Regex.Matches(demonName, healthPattern);
            char[] validChars = validCharsMatches.Select(x => x.Value)
                .Select(y => char.Parse(y))
                .ToArray();

            for (int i = 0; i < validChars.Length; i++)
            {
                sum += validChars[i];
            }

            return sum;
        }
    }

    class Demon
    {
        public Demon(string name, double health, double damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public string Name { get; set; }
        public double Health { get; set; }
        public double Damage { get; set; }
    }
}

