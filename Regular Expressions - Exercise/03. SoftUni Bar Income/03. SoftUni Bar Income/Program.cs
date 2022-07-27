using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-Z][a-z]+)\%[^.$%|]*\<(?<product>\w+)\>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+([.]\d+)?)\$";

            double totalIncome = 0;
            string input = Console.ReadLine();
            while (input != "end of shift")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    string currCustomer = Regex.Match(input, pattern).Groups["customer"].ToString();
                    string currProduct = Regex.Match(input, pattern).Groups["product"].ToString();
                    int currQty = int.Parse(Regex.Match(input, pattern).Groups["count"].ToString());
                    double price = double.Parse(Regex.Match(input, pattern).Groups["price"].ToString());

                    double currTotalPrice = price * currQty;

                    Console.WriteLine($"{currCustomer}: {currProduct} - {currTotalPrice:f2}");

                    totalIncome += currTotalPrice;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
