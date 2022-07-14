using System;

namespace _01._Cooking_Masterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float budget = float.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            float pricePackageOfFlour = float.Parse(Console.ReadLine());
            float priceSingleEgg = float.Parse(Console.ReadLine());
            float priceSingleApron = float.Parse(Console.ReadLine());
            double percentStudents = Math.Ceiling(students * 0.2);
            int freePackage = 0;
            for (int i = 1; i <= students; ++i)
            {
                if (i % 5 == 0)
                {
                    freePackage++;
                }
            }
          
            double totalPrice = (priceSingleApron * (students + percentStudents) + ((priceSingleEgg * 10) * students) + (pricePackageOfFlour * (students - freePackage)));

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Items purchased for {totalPrice:f2}$.");
            }
            else if (budget < totalPrice)
            {
                Console.WriteLine($"{totalPrice - budget:f2}$ more needed.");
            }

        }

    }
}

