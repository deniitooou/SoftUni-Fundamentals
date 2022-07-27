using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _1._Winning_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] allTickets = Console.ReadLine()
              .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < allTickets.Length; i++)
            {
                string ticket = allTickets[i];

                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                string leftSide = String.Join("", ticket.Take(10));
                string rightSide = String.Join("", ticket.Skip(10));

                string regex = @"([@#$^])\1{5,9}";
                MatchCollection matchLeft = Regex.Matches(leftSide, regex);
                MatchCollection matchRight = Regex.Matches(rightSide, regex);

                if ((matchLeft.Count > 0 && matchRight.Count > 0) &&
                    (matchLeft[0].Value.Contains(matchRight[0].Value) ||
                    matchRight[0].Value.Contains(matchLeft[0].Value)))
                {
                    char winningSymbol = matchLeft[0].Value[0];
                    int winningLength = Math.Min(matchLeft[0].Value.Length, matchRight[0].Value.Length);

                    string output = $"ticket \"{ticket}\" - {winningLength}{winningSymbol}";
                    if (winningLength == 10) output += " Jackpot!";
                    Console.WriteLine(output);
                }
                else
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
            }
        }
    }
}

