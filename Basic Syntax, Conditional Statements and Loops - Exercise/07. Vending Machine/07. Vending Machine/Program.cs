using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double totalMoneyAccumolated = 0;

            while (command != "Start")
            {
                double inputMoney = double.Parse(command);
                if (inputMoney == 0.1 || inputMoney == 0.2 || inputMoney == 0.5 || inputMoney == 1 || inputMoney == 2)
                {
                    totalMoneyAccumolated += inputMoney;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {inputMoney}");
                }
                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            double totalPrice = 0;

            while (command != "End")
            {
                switch (command)
                {
                    case "Nuts":
                        totalPrice = 2;
                        break;
                    case "Water":
                        totalPrice = 0.7;
                        break;
                    case "Crisps":
                        totalPrice = 1.5;
                        break;
                    case "Soda":
                        totalPrice = 0.8;
                        break;
                    case "Coke":
                        totalPrice = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        command = Console.ReadLine();
                        continue;
                }

                if (totalMoneyAccumolated >= totalPrice)
                {
                    totalMoneyAccumolated -= totalPrice;
                    Console.WriteLine($"Purchased {command.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Change: {totalMoneyAccumolated:f2}");
        }
    }
}
