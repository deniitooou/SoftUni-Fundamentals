using System;
using System.Linq;

namespace _01._Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTheStudents = int.Parse(Console.ReadLine());
            int numberOfTheLectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            int[] studentAttendance = new int[numberOfTheStudents];

            for (int i = 0; i < numberOfTheStudents; i++)
            {
                studentAttendance[i] = int.Parse(Console.ReadLine());
            }

            int bestStudentLectures = 0;
            if (studentAttendance.Length > 0)
                bestStudentLectures = studentAttendance.Max();

            double maxBonus = 0;
            if (numberOfTheLectures != 0)
                maxBonus = (double)bestStudentLectures / (double)numberOfTheLectures * (5 + additionalBonus);
            maxBonus = Math.Ceiling(maxBonus);

            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {bestStudentLectures} lectures.");
        }
    }
}
