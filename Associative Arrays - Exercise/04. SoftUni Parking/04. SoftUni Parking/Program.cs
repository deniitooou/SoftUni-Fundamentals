using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Parking> parkingList = new List<Parking>();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string currUser = tokens[1];

                switch (tokens[0])
                {
                    case "register":
                        string currLicense = tokens[2];

                        if (parkingList.Any(parking => parking.Username == currUser))
                        {
                            Parking parking = parkingList.Find(parking => parking.Username == currUser);
                            Console.WriteLine($"ERROR: already registered with plate number {parking.LicensePlate}");
                        }
                        else
                        {
                            parkingList.Add(new Parking(currUser, currLicense));
                            Console.WriteLine($"{currUser} registered {currLicense} successfully");
                        }
                        break;
                    case "unregister":
                        if (!parkingList.Any(parking => parking.Username == currUser))
                        {
                            Console.WriteLine($"ERROR: user {currUser} not found");
                        }
                        else
                        {
                            parkingList.Remove(parkingList.Find(parking => parking.Username == currUser));
                            Console.WriteLine($"{currUser} unregistered successfully");
                        }
                        break;
                }
            }
            foreach (var parking in parkingList)
            {
                Console.WriteLine(parking);
            }
        }
    }

    class Parking
    {
        public Parking(string username, string licensePlate)
        {
            Username = username;
            LicensePlate = licensePlate;
        }

        public string Username { get; set; }
        public string LicensePlate { get; set; }

        public override string ToString()
        {
            return $"{this.Username} => {this.LicensePlate}";
        }
    }
    }

