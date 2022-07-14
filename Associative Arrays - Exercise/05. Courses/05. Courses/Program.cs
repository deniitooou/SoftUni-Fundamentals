using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>();

            string[] tokens = Console.ReadLine().Split(" : ");
            while (tokens[0] != "end")
            {
                string currCourseName = tokens[0];
                string currStudentName = tokens[1];
                if (!courses.Any(course => course.Name == currCourseName))
                {
                    var newCourse = new Course(currCourseName);
                    courses.Add(newCourse);
                }
                var currCourse = courses.Find(course => course.Name == currCourseName);
                currCourse.Students.Add(currStudentName);

                tokens = Console.ReadLine().Split(" : ");
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Name}: {course.RegisteredStudents}");

                foreach (var student in course.Students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }

    class Course
    {
        public Course(string name)
        {
            this.Name = name;
            this.Students = new List<string>();
        }

        public string Name { get; set; }

        public List<string> Students { get; set; }

        public int RegisteredStudents { get { return this.Students.Count; } }
    }
}

