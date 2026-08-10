using System;

namespace CSharpLearning
{
    public class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }

        public ElectricCar(
            string make,
            string model,
            int year,
            int numberOfDoors,
            int batteryCapacity)
            : base(make, model, year, numberOfDoors)
        {
            Console.WriteLine("ElectricCar constructor called");

            BatteryCapacity = batteryCapacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine(
                $"Electric Car - {Make} {Model} ({Year}), Doors: {NumberOfDoors}, Battery: {BatteryCapacity} kWh");
        }
    }
}