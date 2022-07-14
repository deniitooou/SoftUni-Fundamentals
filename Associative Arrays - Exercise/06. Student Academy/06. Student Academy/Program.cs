using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int inputCnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCnt; i++)
            {
                string currStudentName = Console.ReadLine();
                decimal currGrade = decimal.Parse(Console.ReadLine());

                if (!students.Any(students => students.Name == currStudentName))
                {
                    var newStudent = new Student(currStudentName);
                    students.Add(newStudent);
                }
                var currStudent = students.Find(student => student.Name == currStudentName);
                currStudent.Grades.Add(currGrade);
            }

            List<Student> goodStudents = students.Where(student => student.AvgGrade >= 4.50m).ToList();

            foreach (var student in goodStudents)
            {
                Console.WriteLine($"{student.Name} -> {student.AvgGrade:f2}");
            }
        }
    }

    class Student
    {
        public Student(string name)
        {
            this.Name = name;
            this.Grades = new List<decimal>();
        }
        public string Name { get; set; }

        public List<decimal> Grades { get; set; }

        public decimal AvgGrade { get { return this.Grades.Average(); } }
    }
}

