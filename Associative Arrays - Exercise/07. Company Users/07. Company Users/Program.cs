using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Company> companies = new List<Company>();

            string[] tokens = Console.ReadLine().Split(" -> ");

            while (tokens[0] != "End")
            {
                string currCompanyName = tokens[0];
                string currEmployeeId = tokens[1];

                if (!companies.Any(company => company.Name == currCompanyName))
                {
                    var newCompany = new Company(currCompanyName);
                    companies.Add(newCompany);
                }

                var currCompany = companies.Find(company => company.Name == currCompanyName);

                if (!currCompany.Employees.Contains(currEmployeeId))
                {
                    currCompany.Employees.Add(currEmployeeId);
                }

                tokens = Console.ReadLine().Split(" -> ");
            }

            foreach (var company in companies)
            {
                Console.WriteLine(company.Name);

                foreach (var employee in company.Employees)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }

    class Company
    {
        public Company(string name)
        {
            this.Name = name;
            this.Employees = new List<string>();
        }

        public string Name { get; set; }

        public List<string> Employees { get; set; }
    }
}
