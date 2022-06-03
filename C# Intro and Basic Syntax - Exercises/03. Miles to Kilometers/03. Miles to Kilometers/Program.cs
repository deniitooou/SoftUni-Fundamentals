using System;

namespace _03._Miles_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var distanceInMiles = double.Parse(Console.ReadLine());
            const double kilometersPerMile = 1.60934;
            var distanceInKilometers = distanceInMiles * kilometersPerMile;

            Console.WriteLine("{0:F2}", distanceInKilometers);
        }
    }
}
