using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contest> contests = new List<Contest>();
            List<Student> students = new List<Student>();

            string[] inputContest = Console.ReadLine().Split(":");

            while (inputContest[0] != "end of contests")
            {
                var newContest = new Contest(inputContest[0], inputContest[1]);
                contests.Add(newContest);

                inputContest = Console.ReadLine().Split(":");
            }

            string[] inputSubmission = Console.ReadLine().Split("=>");

            while (inputSubmission[0] != "end of submissions")
            {
                string currContestToPass = inputSubmission[0];
                string currPassword = inputSubmission[1];
                string currStudentName = inputSubmission[2];
                int currPoints = int.Parse(inputSubmission[3]);

                if (contests.Any(contest => contest.Name == currContestToPass && contest.Password == currPassword))
                {
                    if (!students.Any(student => student.Name == currStudentName))
                    {
                        var newStudent = new Student(currStudentName);
                        students.Add(newStudent);
                    }

                    var currStudent = students.Find(student => student.Name == currStudentName);
                    
                    if (currStudent.ContestsPassed.ContainsKey(currContestToPass))
                    {
                        if (currPoints > currStudent.ContestsPassed[currContestToPass])
                        {
                            currStudent.ContestsPassed[currContestToPass] = currPoints;
                        }
                    }

                    else
                    {
                        currStudent.ContestsPassed.Add(currContestToPass, currPoints);
                    }
                }
                inputSubmission = Console.ReadLine().Split("=>");
            }

            Student bestStudent = GetBestStudent(students);

            Console.WriteLine($"Best candidate is {bestStudent.Name} with total {bestStudent.TotalPoints} points.");
            Console.WriteLine("Ranking: ");

            foreach (var student in students.OrderBy(student => student.Name))
            {
                Console.WriteLine($"{student.Name}");

                foreach (var contest in student.ContestsPassed.OrderByDescending(contest => contest.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }

        private static Student GetBestStudent(List<Student> students)
        {
            int bestTotalPts = int.MinValue;
            Student bestStudent = null;

            foreach (var student in students)
            {
                if (student.TotalPoints > bestTotalPts)
                {
                    bestTotalPts = student.TotalPoints;
                    bestStudent = student;
                }
            }
            return bestStudent;
        }
    }

    class Student
    {
        public Student(string name)
        {
            Name = name;
            ContestsPassed = new Dictionary<string, int>();
        }

        public string Name { get; set; }

        public Dictionary<string, int> ContestsPassed { get; set; }

        public int TotalPoints { get { return this.ContestsPassed.Values.Sum(); } }

    }
    class Contest
    {
        public Contest(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public string Name { get; set; }

        public string Password { get; set; }
    }
}
