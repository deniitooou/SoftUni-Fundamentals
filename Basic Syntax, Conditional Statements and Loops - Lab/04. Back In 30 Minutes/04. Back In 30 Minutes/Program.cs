using System;

namespace _04._Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int finalTimeinMins = (hours * 60) + (minutes + 30);

            if (finalTimeinMins / 60 > 23)
            {
                finalTimeinMins -= 24 * 60;
            }
            if (finalTimeinMins % 60 < 10)
            {
                Console.WriteLine(finalTimeinMins / 60 + ":" + "0" + finalTimeinMins % 60);
            }
            else
            {
                Console.WriteLine(finalTimeinMins / 60 + ":" + finalTimeinMins % 60);
            }
        }
    }
}
