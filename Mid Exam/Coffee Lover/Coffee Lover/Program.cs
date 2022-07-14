using System;
using System.Collections.Generic;
using System.Linq;

namespace Coffee_Lover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfCoffees = Console.ReadLine().Split().ToList();

            int command = int.Parse(Console.ReadLine());

            for (int i = 0; i < command; i++)
            {
                string[] coffeeCommand = Console.ReadLine().Split();

                if (coffeeCommand[0] == "Include") // add the coffee at the end
                {
                    listOfCoffees.Add(coffeeCommand[1]);
                }
                else if (coffeeCommand[0] == "Remove") // depending on the input, remove first or last
                {
                    int count = int.Parse(coffeeCommand[2]);

                    if (count <= listOfCoffees.Count)
                    {
                        if (coffeeCommand[1] == "first")
                        {
                            for (int j = 0; j < count; j++)
                            {
                                listOfCoffees.RemoveAt(0);
                            }
                        }
                        else
                        {
                            for (int j = 0; j < count; j++)
                            {
                                listOfCoffees.RemoveAt(listOfCoffees.Count - 1);
                            }
                        }
                    }
                }

                else if (coffeeCommand[0] == "Prefer") // if both coffee indexes exist..change their places
                {
                    int index1 = int.Parse(coffeeCommand[1]);
                    int index2 = int.Parse(coffeeCommand[2]);

                    if ((index1 >= 0 && index2 >= 0) && (index1 < listOfCoffees.Count && index2 < listOfCoffees.Count))
                    {
                        string tempCoffee = listOfCoffees[index2];
                        listOfCoffees[index2] = listOfCoffees[index1];
                        listOfCoffees[index1] = tempCoffee;
                    }
                }
                else if (coffeeCommand[0] == "Reverse") // reverse the order of the coffees
                {
                    listOfCoffees.Reverse();
                }
            }

            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ", listOfCoffees));
        }
    }
}
