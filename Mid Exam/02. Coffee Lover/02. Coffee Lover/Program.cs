using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Coffee_Lover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] listOfCoffees = Console.ReadLine().Split(" ");

            string input;

            for (int i = 0; i < listOfCoffees.Length; i++)
            {
                string output = listOfCoffees[i];
                string[] tokens = output.Split();

                if (tokens[0] == "Include")
                {
                    listOfCoffees.Add
                }


            }


            List<string> list = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            
            int numberOfCommands = int.Parse(Console.ReadLine());

            string input;

            for (int i = 0; i < numberOfCommands; i++)
            {
                input = Console.ReadLine();
                int number = 1;
                for (int j =0; i < input.Length; ++j)
                {
                    bool result = int.TryParse(input, out number);
                }

                string[] command = input.Split();

                switch (command[0])
                {
                    case "Include":
                        Include(list, command[1]);
                        break;
                    case "Remove":
                        if (input == "first")
                        {
                            Remove(list, command[0], number);
                        }
                        if (input == "last")
                        {
                            RemoveLast(list, command[numberOfCommands - 1]);
                        }
                        break;
                    case "Prefer":
                        Prefer(list, command[1], command[2]);
                        break;
                    case "Reverse":
                        list.Reverse();
                        break;
                }
            }
            Console.WriteLine("Coffees:");
            Console.WriteLine(String.Join(", ", list));

            static void Include(List<string> list, string coffee)
            { 
                list.Add(coffee);
            }

            static void RemoveLast(List<string> list, string coffee)
            {
                list.RemoveAt(coffee.Length -1);
            }

            static void Remove(List<string> list, string coffee, int number)
            {
                for(int i = 0; i < number; i++)
                {
                    list.RemoveAt(0);
                }
            }

            static void Prefer(List<string> list, string coffee1, string coffee2)
            {
               int 
            }

        }
    }
}
