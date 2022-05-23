using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine(); // Students, Business, Regular
            string day = Console.ReadLine(); //  Friday, Saturday,Sunday

            double totalPrice = 0;

            switch (day)
            {
                case "Friday":
                    if (type == "Students")
                    {
                        totalPrice = countOfPeople * 8.45;
                    }
                    else if (type == "Business")
                    {
                        totalPrice = countOfPeople * 10.90;
                    }
                    else if (type == "Regular")
                    {
                        totalPrice = countOfPeople * 15;
                    }
                    break;
                case "Saturday":
                    if (type == "Students")
                    {
                        totalPrice = countOfPeople * 9.80;
                    }
                    else if (type == "Business")
                    {
                        totalPrice = countOfPeople * 15.60;
                    }
                    else if (type == "Regular")
                    {
                        totalPrice = countOfPeople * 20;
                    }
                    break;
                case "Sunday":
                    if (type == "Students")
                    {
                        totalPrice = countOfPeople * 10.46;
                    }
                    else if (type == "Business")
                    {
                        totalPrice = countOfPeople * 16;
                    }
                    else if (type == "Regular")
                    {
                        totalPrice = countOfPeople * 22.50;
                    }
                    break;
            }

            if (countOfPeople >= 30 && type == "Students")
            {
                totalPrice = totalPrice - (0.15 * totalPrice);
            }
            else if (countOfPeople >= 100 && type == "Business")
            {
                totalPrice = totalPrice - ((totalPrice / countOfPeople) * 10);
            }
            else if (type == "Regular" && countOfPeople >= 10 && countOfPeople <= 20)
            {
                totalPrice = totalPrice * 0.95;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
