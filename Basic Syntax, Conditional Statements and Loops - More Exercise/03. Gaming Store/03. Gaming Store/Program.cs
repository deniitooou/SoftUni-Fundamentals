using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string game = string.Empty;
            double moneySpend = 0;
            while ((game = Console.ReadLine()) != "Game Time")
            {


                if (game == "OutFall 4")
                {
                    if (budget >= 39.99)
                    {
                        budget -= 39.99;
                        moneySpend += 39.99;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive"); continue;
                    }

                }
                else if (game == "CS: OG")
                {
                    if (budget >= 15.99)
                    {
                        budget -= 15.99;
                        moneySpend += 15.99;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive"); continue;
                    }
                }
                else if (game == "Zplinter Zell")
                {
                    if (budget >= 19.99)
                    {
                        budget -= 19.99;
                        moneySpend += 19.99;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive"); continue;
                    }
                }
                else if (game == "RoverWatch")
                {
                    if (budget >= 29.99)
                    {
                        budget -= 29.99;
                        moneySpend += 29.99;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive"); continue;
                    }
                }
                else if (game == "Honored 2")
                {
                    if (budget >= 59.99)
                    {
                        budget -= 59.99;
                        moneySpend += 59.99;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive"); continue;
                    }
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    if (budget >= 39.99)
                    {
                        budget -= 39.99;
                        moneySpend += 39.99;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive"); continue;
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                if (budget <= 0)
                {
                    Console.WriteLine("Out of money!"); return;
                }
            }
            Console.WriteLine($"Total spent: ${moneySpend:f2}. Remaining: ${budget:f2}");
        }
    }
}
