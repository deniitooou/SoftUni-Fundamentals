using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int startingPower = power;
            int countOfPokedTargets = 0;

            while (power >= distance)
            {
                power -= distance;
                countOfPokedTargets++;

                if (startingPower / 2 == power && exhaustionFactor !=0)
                {
                    power /= exhaustionFactor;
                }
            }

            Console.WriteLine(power);
            Console.WriteLine(countOfPokedTargets);
        }
    }
}
