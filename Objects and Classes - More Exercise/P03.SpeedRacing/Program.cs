using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.SpeedRacing
{
    public class Car
    {
        string model;
        double fuelAmount;
        double fuelConsumptionPerKm;
        double travelDistance;
        public Car()
        {

        }
        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
            this.TravelDistance = 0;
        }

        public string Model 
        { 
            get
            {
                return model;
            }
            set
            {
                this.model = value;
            }
        }
        public double FuelAmount
        {
            get
            {
                return fuelAmount;
            }
            set
            {
                this.fuelAmount = value;
            }
        }
        public double FuelConsumptionPerKm
        {
            get
            {
                return fuelConsumptionPerKm;
            }
            set
            {
                this.fuelConsumptionPerKm = value;
            }
        }
        public double TravelDistance
        {
            get
            {
                return travelDistance;
            }
            set
            {
                this.travelDistance = value;
            }
        }
        public void CanIReachTheDistance(string model, double amountKm)
        {
            double neededLiters = amountKm * this.FuelConsumptionPerKm;

            if(this.FuelAmount >= neededLiters)
            {
                this.fuelAmount -= neededLiters;
                this.TravelDistance += amountKm;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfCarsToTrack = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numOfCarsToTrack; i++)
            {
                string[] data = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string model = data[0];
                double fuelAmount = double.Parse(data[1]);
                double fuelConsumptionPerKm = double.Parse(data[2]);

                Car currentCar = new Car(model, fuelAmount, fuelConsumptionPerKm);
                cars.Add(currentCar);
            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                string model = cmdArgs[1];
                double amountOfKm = double.Parse(cmdArgs[2]);

                Car carToDrive = cars.Where(x => x.Model == model).ToList().First();

                carToDrive.CanIReachTheDistance(model, amountOfKm);
            }
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TravelDistance}");
            }
        }
    }
}
