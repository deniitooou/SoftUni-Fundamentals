using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dwarf> dwarfList = new List<Dwarf>();

            string[] inputCmd = Console.ReadLine().Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);

            while (inputCmd[0] != "Once upon a time")
            {
                string currDwarfName = inputCmd[0];
                string currHatColor = inputCmd[1];
                int currPhysics = int.Parse(inputCmd[2]);

                if (!dwarfList.Any(dwarf => dwarf.Name == currDwarfName && dwarf.HatColor == currHatColor))
                {
                    var newDwarf = new Dwarf(currDwarfName, currHatColor, currPhysics);
                    dwarfList.Add(newDwarf);
                }

                else
                {
                    var currDwarf = dwarfList.Find(dwarf => dwarf.Name == currDwarfName && dwarf.HatColor == currHatColor);

                    if (currDwarf.Physics < currPhysics)
                    {
                        currDwarf.Physics = currPhysics;
                    }
                }

                inputCmd = Console.ReadLine().Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var dwarf in dwarfList.OrderByDescending(dwarf => dwarf.Physics).ThenByDescending(dwarf => dwarfList.Where(listdwarf => listdwarf.HatColor == dwarf.HatColor).Count()))
            {
                Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }

    class Dwarf
    {
        public Dwarf(string name, string hatColor, int physics)
        {
            this.Name = name;
            this.HatColor = hatColor;
            this.Physics = physics;
        }
        public string Name { get; set; }

        public string HatColor { get; set; }

        public int Physics { get; set; }
    }
}

