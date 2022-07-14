using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contest> contestList = new List<Contest>();
            List<Student> studentList = new List<Student>();

            string[] inputCmd = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

            while (inputCmd[0] != "no more time")
            {
                string currUserName = inputCmd[0];
                string currContestToGo = inputCmd[1];
                int currPoints = int.Parse(inputCmd[2]);

                if (!contestList.Any(contest => contest.Name == currContestToGo))
                {
                    var newContest = new Contest(currContestToGo);
                    contestList.Add(newContest);
                }

                if (!studentList.Any(student => student.Name == currUserName))
                {
                    var newStudent = new Student(currUserName);
                    studentList.Add(newStudent);
                }

                Contest currContest = contestList.Find(contest => contest.Name == currContestToGo);

                if (currContest.Participants.ContainsKey(currUserName))
                {
                    if (currContest.Participants[currUserName] < currPoints)
                    {
                        currContest.Participants[currUserName] = currPoints;
                    }
                }

                else
                {
                    currContest.Participants.Add(currUserName, currPoints);
                }

                Student currStudent = studentList.Find(student => student.Name == currUserName);

                if (currStudent.ContestsPassed.ContainsKey(currContestToGo))
                {
                    if (currStudent.ContestsPassed[currContestToGo] < currPoints)
                    {
                        currStudent.ContestsPassed[currContestToGo] = currPoints;
                    }
                }

                else
                {
                    currStudent.ContestsPassed.Add(currContestToGo, currPoints);
                }

                inputCmd = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var contest in contestList)
            {
                Console.WriteLine($"{contest.Name}: {contest.TotalParticipants} participants");
                int counter = 1;

                foreach (var participant in contest.Participants.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
                {
                    Console.WriteLine($"{counter}. {participant.Key} <::> {participant.Value}");
                    counter++;
                }
            }

            Console.WriteLine("Individual standings:");
            int counterr = 1;

            foreach (var student in studentList.OrderByDescending(x => x.TotalPoints).ThenBy(y => y.Name))
            {
                Console.WriteLine($"{counterr}. {student.Name} -> {student.TotalPoints}");
                counterr++;
            }
        }
    }

    class Student
    {
        public Student(string name)
        {
            this.Name = name;
            this.ContestsPassed = new Dictionary<string, int>();
        }
        public string Name { get; set; }

        public Dictionary<string, int> ContestsPassed { get; set; }

        public int TotalPoints { get { return ContestsPassed.Values.Sum(); } }
    }
    class Contest
    {
        public Contest(string name)
        {
            this.Name = name;
            this.Participants = new Dictionary<string, int>();
        }
        public string Name { get; set; }

        public Dictionary<string, int> Participants { get; set; }

        public int TotalParticipants { get { return this.Participants.Count; } }
    }
}

