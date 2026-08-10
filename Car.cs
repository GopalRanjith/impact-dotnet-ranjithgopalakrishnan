using System;

namespace CSharpLearning
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string make, string model, int year, int numberOfDoors)
            : base(make, model, year)
        {
            Console.WriteLine("Car constructor called");

            NumberOfDoors = numberOfDoors;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Car - {Make} {Model} ({Year}), Doors: {NumberOfDoors}");
        }
    }
}