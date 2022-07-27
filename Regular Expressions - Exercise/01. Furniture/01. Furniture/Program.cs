using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<Name>[A-Za-z\s]+)<<(?<Integer>[0-9]+)(?<mantice>\.[0-9]+)?!(?<Quantity>[0-9]+)";

            List<string> validNames = new List<string>();
            double sum = 0;

            string furniture = Console.ReadLine();
            while (furniture != "Purchase")
            {
                bool isValid = Regex.IsMatch(furniture, pattern);

                if (isValid)
                {
                    string name = Regex.Match(furniture, pattern).Groups["Name"].Value;
                    validNames.Add(name);

                    string integer = Regex.Match(furniture, pattern).Groups["Integer"].Value;
                    string mantice = Regex.Match(furniture, pattern).Groups["mantice"].Value;
                    string priceString = integer + mantice;
                    double price = double.Parse(priceString);

                    string quantityString = Regex.Match(furniture, pattern).Groups["Quantity"].Value;
                    int quantity = int.Parse(quantityString);

                    double totalPrice = price * quantity;
                    sum += totalPrice;
                }
                furniture = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            if (validNames.Count > 0)
            {
                Console.WriteLine(String.Join(Environment.NewLine, validNames));
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
