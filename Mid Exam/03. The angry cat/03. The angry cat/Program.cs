using System;
using System.Linq;

namespace _03._The_angry_cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] priceRatings = Console.ReadLine().Split(", ").Select(long.Parse).ToArray();

            int entryPoint = int.Parse(Console.ReadLine());
            string typeOFitems = Console.ReadLine();
            string position = string.Empty;

            long leftSide = priceRatings.Take(entryPoint).Where(num => IsItValid((int)num, (int)priceRatings[entryPoint], typeOFitems, position)).Sum();

            long rightSide = priceRatings.Skip(entryPoint + 1).Where(num => IsItValid((int)num, (int)priceRatings[entryPoint], typeOFitems, position)).Sum();

            if(leftSide >= rightSide)
            {
                Console.WriteLine("Left - " + leftSide);
            }
            else
            {
                Console.WriteLine("Right - " + rightSide);
            }
        }
        public static bool IsTheTypeIsValid(int number, string typeOFitems, string position)
        {
            if (position == "positive")
            {
                if (number > 0)
                {
                    return true;
                }
                return false;
            }

            if (position == "negative")
            {
                if (number < 0)
                {
                    return true;
                }
                return false;
            }
            return true;
        }

        public static bool IsItValid(int number, int entryPoint, string typeOFitems, string position)
        {
            if (typeOFitems == "cheap")
            {
                if (entryPoint > number)
                {
                    return IsTheTypeIsValid(number, typeOFitems, position);
                }
            }
            else
            {
                if (entryPoint <= number)
                {
                    return IsTheTypeIsValid(number, typeOFitems, position);
                }
            }

            return false;
        }

    }
}
