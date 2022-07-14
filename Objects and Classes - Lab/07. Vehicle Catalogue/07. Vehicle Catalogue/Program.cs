using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalogue vehicleCatalogue = new Catalogue();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split("/");

                string type = tokens[0];

                switch (type)
                {
                    case "Car":
                        Cars car = new Cars
                        {
                            Brand = tokens[1],
                            Model = tokens[2],
                            HorsePower = int.Parse(tokens[3])
                        };
                        vehicleCatalogue.Cars.Add(car);
                        break;
                    case "Truck":
                        Trucks truck = new Trucks
                        {
                            Brand = tokens[1],
                            Model = tokens[2],
                            Weight = int.Parse(tokens[3])
                        };
                        vehicleCatalogue.Trucks.Add(truck);
                        break;
                }
            }

            if (vehicleCatalogue.Cars.Count > 0)
            {
                List<Cars> orderedCars = vehicleCatalogue.Cars.OrderBy(c => c.Brand).ToList();

                Console.WriteLine("Cars:");

                foreach (var car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (vehicleCatalogue.Trucks.Count > 0)
            {
                List<Trucks> orderedTrucks = vehicleCatalogue.Trucks.OrderBy(c => c.Brand).ToList();

                Console.WriteLine("Trucks:");

                foreach (var truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    class Cars
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }
    class Trucks
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }

    class Catalogue
    {
        public Catalogue()
        {
            this.Cars = new List<Cars>();
            this.Trucks = new List<Trucks>();
        }

        public List<Cars> Cars { get; set; }

        public List<Trucks> Trucks { get; set; }
    }
    }

