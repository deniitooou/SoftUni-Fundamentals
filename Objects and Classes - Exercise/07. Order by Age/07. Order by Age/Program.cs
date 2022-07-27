using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split();
                string currName = tokens[0];
                string currID = tokens[1];
                int currAge = int.Parse(tokens[2]);

                if (personList.Any(person => person.ID == currID))
                {
                    Person personToUpdate = personList.FirstOrDefault(person => person.ID == currID);
                    personToUpdate.Age = currAge;
                    personToUpdate.Name = currName;
                }

                else
                {
                    Person newPerson = new Person(currName, currID, currAge);
                    personList.Add(newPerson);
                }

                command = Console.ReadLine();
            }

            personList
                .OrderBy(person => person.Age)
                .ToList()
                .ForEach(person => Console.WriteLine(person));
        }
    }

    class Person
    {
        public Person(string name, string iD, int age)
        {
            this.Name = name;
            this.ID = iD;
            this.Age = age;
        }

        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }

        public override string ToString() => $"{this.Name} with ID: {this.ID} is {this.Age} years old.";
    }
}

