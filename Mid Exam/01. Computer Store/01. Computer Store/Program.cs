using System;

namespace _01._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = 0;
            string priceWithoutTax = Console.ReadLine();
            while (priceWithoutTax != "special" && priceWithoutTax != "regular")
            {
                double currentPrice = double.Parse(priceWithoutTax);
                if (currentPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                    priceWithoutTax = Console.ReadLine();
                    continue;
                }

                price += currentPrice;
                priceWithoutTax = Console.ReadLine();
            }

            if (price == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            double taxes = 0.2 * price;
            double total = price + taxes;
            if (priceWithoutTax == "special") total *= 0.9;

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {price:f2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {total:f2}$");

        }
    }
}
