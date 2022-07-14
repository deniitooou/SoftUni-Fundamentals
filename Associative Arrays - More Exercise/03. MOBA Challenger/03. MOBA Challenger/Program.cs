using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> playersList = new List<Player>();

            string input = Console.ReadLine();

            while (input != "Season end")
            {
                List<string> temp = input.Split().ToList();

                if (!temp.Contains("vs"))
                {
                    string[] inputCmd = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string currUsername = inputCmd[0];
                    string currPosition = inputCmd[1];
                    int currPoints = int.Parse(inputCmd[2]);

                    if (!playersList.Any(player => player.Name == currUsername))
                    {
                        var newPlayer = new Player(currUsername);
                        playersList.Add(newPlayer);
                    }

                    var currPlayer = playersList.Find(player => player.Name == currUsername);

                    if (!currPlayer.PositionPoints.ContainsKey(currPosition))
                    {
                        currPlayer.PositionPoints.Add(currPosition, currPoints);
                    }

                    else
                    {
                        if (currPlayer.PositionPoints[currPosition] < currPoints)
                        {
                            currPlayer.PositionPoints[currPosition] = currPoints;
                        }
                    }
                }

                else
                {
                    string[] inputCmd = input.Split(" vs ", StringSplitOptions.RemoveEmptyEntries);
                    string currFirstPlayerName = inputCmd[0];
                    string currSecondPlayerName = inputCmd[1];

                    if (playersList.Any(player => player.Name == currFirstPlayerName) && playersList.Any(player2 => player2.Name == currSecondPlayerName))
                    {
                        BattlePlayers(playersList, currFirstPlayerName, currSecondPlayerName);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var player in playersList.OrderByDescending(x => x.TotalPoints).ThenBy(y => y.Name))
            {
                Console.WriteLine($"{player.Name}: {player.TotalPoints} skill");

                foreach (var positon in player.PositionPoints.OrderByDescending(position => position.Value).ThenBy(positionn => positionn.Key))
                {
                    Console.WriteLine($"- {positon.Key} <::> {positon.Value}");
                }
            }
        }

        private static void BattlePlayers(List<Player> playersList, string currFirstPlayerName, string currSecondPlayerName)
        {
            var player1 = playersList.Find(player => player.Name == currFirstPlayerName);
            var player2 = playersList.Find(player2 => player2.Name == currSecondPlayerName);

            bool isValid = false;

            foreach (var positon1 in player1.PositionPoints.Keys)
            {
                foreach (var position2 in player2.PositionPoints.Keys)
                {
                    if (positon1 == position2)
                    {
                        isValid = true;
                        break;
                    }
                }
            }
            if (isValid == false)
            {
                return;
            }
            if (player1.TotalPoints == player2.TotalPoints)
            {
                return;
            }

            if (player1.TotalPoints > player2.TotalPoints)
            {
                playersList.Remove(player2);
            }
            else
            {
                playersList.Remove(player1);
            }
        }
    }

    class Player
    {
        public Player(string name)
        {
            this.Name = name;
            this.PositionPoints = new Dictionary<string, int>();
        }
        public string Name { get; set; }

        public Dictionary<string, int> PositionPoints { get; set; }

        public int TotalPoints
        {
            get { return this.PositionPoints.Values.Sum(); }
        }
    }
}
