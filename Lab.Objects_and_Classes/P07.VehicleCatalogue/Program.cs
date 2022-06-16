using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.VehicleCatalogue
{
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }
    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }
    class Catalogue
    {
        public Catalogue()
        {
            this.Trucks = new List<Truck>();
            this.Cars = new List<Car>();
        }
        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogueObjects = new Catalogue();

            string command = Console.ReadLine();
            while(command != "end")
            {
                string[] cmdArgs = command.Split('/', StringSplitOptions.RemoveEmptyEntries);

                string type = cmdArgs[0];
                string brand = cmdArgs[1];
                string model = cmdArgs[2];
                int finalParam = int.Parse(cmdArgs[3]);

                if(type == "Car")
                {
                    Car newCar = new Car(brand, model, finalParam);

                    catalogueObjects.Cars.Add(newCar);
                }
                if(type == "Truck")
                {
                    Truck newTruck = new Truck(brand, model, finalParam);

                    catalogueObjects.Trucks.Add(newTruck);
                }

                command = Console.ReadLine();
            }

            if(catalogueObjects.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                List<Car> orderedCars = catalogueObjects.Cars.OrderBy(car => car.Brand).ToList();

                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }

            }
            
            if(catalogueObjects.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                List<Truck> orderedTrucks = catalogueObjects.Trucks.OrderBy(truck => truck.Brand).ToList();

                foreach (Truck truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
