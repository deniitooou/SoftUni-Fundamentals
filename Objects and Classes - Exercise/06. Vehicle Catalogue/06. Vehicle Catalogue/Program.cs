using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split();

                Vehicle vehicle = new Vehicle(tokens[0], tokens[1], tokens[2], int.Parse(tokens[3]));
                vehicles.Add(vehicle);

                command = Console.ReadLine();
            }

            string requiredCar = Console.ReadLine();

            while (requiredCar != "Close the Catalogue")
            {
                var reqiredVehicle = vehicles
                    .Find(vehicle => vehicle.VehicleModel == requiredCar);
                Console.Write(reqiredVehicle);

                requiredCar = Console.ReadLine();
            }

            List<Vehicle> cars = vehicles
                .Where(vehicle => vehicle.VehicleType == "car")
                .ToList();

            List<Vehicle> trucks = vehicles
                .Where(vehicle => vehicle.VehicleType == "truck")
                .ToList();

            double avgCarsHorsepower = cars.Count > 0 ? cars.Average(car => car.HorsePower) : 0.00;
            double avgTrucksHorsepower = trucks.Count > 0 ? trucks.Average(truck => truck.HorsePower) : 0.00;

            Console.WriteLine($"Cars have average horsepower of: {avgCarsHorsepower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avgTrucksHorsepower:f2}.");
        }
    }

    class Vehicle
    {
        public Vehicle(string vehicleType, string vehicleModel, string vehicleColor, int horsePower)
        {
            this.VehicleType = vehicleType;
            this.VehicleModel = vehicleModel;
            this.VehicleColor = vehicleColor;
            this.HorsePower = horsePower;
        }

        public string VehicleType { get; set; }

        public string VehicleModel { get; set; }

        public string VehicleColor { get; set; }

        public int HorsePower { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Type: {char.ToUpper(this.VehicleType[0]) + this.VehicleType.Substring(1)}");
            sb.AppendLine($"Model: {this.VehicleModel}");
            sb.AppendLine($"Color: {this.VehicleColor}");
            sb.AppendLine($"Horsepower: {this.HorsePower}");

            return sb.ToString();
        }
    }
}
