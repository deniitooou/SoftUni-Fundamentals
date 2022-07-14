using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> resources = new Dictionary<string, long>();

            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
                long resourceQuantity = long.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, 0);
                }
                resources[resource] += resourceQuantity;
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
