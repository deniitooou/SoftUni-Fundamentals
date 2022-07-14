using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int studentsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCount; i++)
            {
                string[] studentInfo = Console.ReadLine().Split();

                Student student = new Student(studentInfo[0], studentInfo[1], double.Parse(studentInfo[2]));
                students.Add(student);
            }

            List<Student> orderedStudents = students.OrderByDescending(student => student.Grade).ToList();
            
            foreach (var student in orderedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }
    }
    }

