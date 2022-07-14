using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Dragon_Army
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<DragonType> dragonTypes = new List<DragonType>();

            int inputCnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCnt; i++)
            {
                string[] inputData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currDragonTypeName = inputData[0];
                string currDragonName = inputData[1];
                string currDamage = inputData[2];
                string currHealth = inputData[3];
                string currArmor = inputData[4];

                if (!dragonTypes.Any(dragonType => dragonType.TypeName == currDragonTypeName))
                {
                    var newDragonType = new DragonType(currDragonTypeName);
                    dragonTypes.Add(newDragonType);
                }

                var currDragonType = dragonTypes.Find(dragonType => dragonType.TypeName == currDragonTypeName);

                if (!currDragonType.DragonList.Any(dragon => dragon.Name == currDragonName))
                {
                    var newDragon = new Dragon(currDragonName);

                    if (currDamage != "null")
                    {
                        int currDamageToInt = int.Parse(currDamage);
                        newDragon.Damage = currDamageToInt;
                    }

                    if (currHealth != "null")
                    {
                        int currHealthToInt = int.Parse(currHealth);
                        newDragon.Health = currHealthToInt;
                    }

                    if (currArmor != "null")
                    {
                        int currArmorToInt = int.Parse(currArmor);
                        newDragon.Armor = currArmorToInt;
                    }

                    currDragonType.DragonList.Add(newDragon);
                }

                else
                {
                    var currDragon = currDragonType.DragonList.Find(dragon => dragon.Name == currDragonName);
                    currDragon.UpdateDragon(currDamage, currHealth, currArmor);
                }
            }

            foreach (var dragonType in dragonTypes)
            {
                Console.WriteLine($"{dragonType.TypeName}::({dragonType.AvarageDamage:f2}/{dragonType.AvarageHealth:f2}/{dragonType.AvarageArmor:f2})");

                foreach (var dragon in dragonType.DragonList.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }

        }
    }

    class DragonType
    {
        public DragonType(string typeName)
        {
            this.TypeName = typeName;
            this.DragonList = new List<Dragon>();
        }
        public string TypeName { get; set; }

        public List<Dragon> DragonList { get; set; }

        public double AvarageDamage { get { return DragonList.Average(dragon => dragon.Damage); } }

        public double AvarageHealth { get { return DragonList.Average(dragon => dragon.Health); } }

        public double AvarageArmor { get { return DragonList.Average(dragon => dragon.Armor); } }
    }

    class Dragon
    {
        public Dragon(string name)
        {
            this.Name = name;
            this.Damage = 45;
            this.Health = 250;
            this.Armor = 10;
        }
        public string Name { get; set; }

        public int Damage { get; set; }

        public int Health { get; set; }

        public int Armor { get; set; }


        public void UpdateDragon(string damage, string health, string armor)
        {
            int damageToInt = 45;
            int healthToint = 250;
            int armorToInt = 10;

            if (damage != "null")
            {
                damageToInt = int.Parse(damage);
            }
            if (health != "null")
            {
                healthToint = int.Parse(health);
            }
            if (armor != "null")
            {
                armorToInt = int.Parse(armor);
            }

            this.Damage = damageToInt;
            this.Health = healthToint;
            this.Armor = armorToInt;
        }
    }
}
