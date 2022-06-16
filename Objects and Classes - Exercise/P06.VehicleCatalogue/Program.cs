using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.VehicleCatalogue
{
    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }

        public override string ToString()
        {
            string output = string.Empty;
            if(this.Type == "car")
            {
                output = $"Type: Car\n";
            }
            if(this.Type == "truck")
            {
                output = $"Type: Truck\n";
            }

            output += $"Model: {this.Model}\nColor: {this.Color}\nHorsepower: {this.HorsePower}";
            return output.Trim();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            string command = Console.ReadLine();
            while (command  != "End")
            {
                string[] cmdArgs = command.Split();

                string type = cmdArgs[0];
                string model = cmdArgs[1];
                string color = cmdArgs[2];
                int horsePower = int.Parse(cmdArgs[3]);

                Vehicle currentVehicle = new Vehicle(type, model, color, horsePower);
                vehicles.Add(currentVehicle);

                command = Console.ReadLine();
            }
            string infoRequest = Console.ReadLine();
            while(infoRequest != "Close the Catalogue")
            {
                Vehicle infoResponce = vehicles.Find(v => v.Model == infoRequest);
                Console.WriteLine(infoResponce);

                infoRequest = Console.ReadLine();
            }

            List<Vehicle> listOfCars = vehicles.FindAll(v => v.Type == "car").ToList();
            List<Vehicle> listOfTrucks = vehicles.FindAll(v => v.Type == "truck").ToList();

            int totalCarsHP = listOfCars.Sum(car => car.HorsePower);
            int totalTrucksHP = listOfTrucks.Sum(truck => truck.HorsePower);
            int carsCount = listOfCars.Count();
            int trucksCount = listOfTrucks.Count();

            PrintAverageHorsePower("Cars", carsCount, totalCarsHP);
            PrintAverageHorsePower("Trucks", trucksCount, totalTrucksHP);
        }

        private static void ToList()
        {
            throw new NotImplementedException();
        }

        static void PrintAverageHorsePower(string typeOfVehicles, int vehiclesCount, int totalHorsePower)
        {
            double averageHorsePower = (double)totalHorsePower / vehiclesCount;

            if(vehiclesCount == 0)
            {
                averageHorsePower = 0;
            }
            Console.WriteLine($"{typeOfVehicles} have average horsepower of: {averageHorsePower:f2}.");
        }
    }
}
