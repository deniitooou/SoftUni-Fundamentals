using System;

namespace _01._SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeEfficiency = int.Parse(Console.ReadLine());
            int secondEmployeeEfficiency = int.Parse(Console.ReadLine());
            int thirdEmployeeEfficiency = int.Parse(Console.ReadLine());

            int hourlyRate = firstEmployeeEfficiency + secondEmployeeEfficiency + thirdEmployeeEfficiency;

            int studentsCount = int.Parse(Console.ReadLine());
            if (studentsCount == 0)
            {
                Console.WriteLine("Time needed: 0h.");
                return;
            }

            int totalHours = 0;

            while (true)
            {
                totalHours++;
                if (totalHours % 4 == 0) continue;
                studentsCount -= hourlyRate;
                if (studentsCount <= 0) break;
            }

            Console.WriteLine($"Time needed: {totalHours}h.");
        }
    }
}
