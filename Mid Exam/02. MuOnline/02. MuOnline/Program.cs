using System;

namespace _02._MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split('|');
            int health = 100;
            int bitcoins = 0;


            for (int room = 0; room < rooms.Length; room++)
            {
                string[] thisInput = rooms[room].Split(' ');
                string monster = thisInput[0];
                int amount = int.Parse(thisInput[1]);

                switch (monster)
                {
                    case "potion":
                        
                        if (health + amount > 100) amount = 100 - health;
                        health += amount;
                        Console.WriteLine($"You healed for {amount} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                        break;
                    case "chest":
                        Console.WriteLine($"You found {amount} bitcoins.");
                        bitcoins += amount;
                        break;
                    default:
                        health -= amount;
                        if (health <= 0)
                        {
                            Console.WriteLine($"You died! Killed by {monster}.");
                            Console.WriteLine($"Best room: {room + 1}");
                            return;
                        }
                        Console.WriteLine($"You slayed {monster}.");
                        break;
                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
