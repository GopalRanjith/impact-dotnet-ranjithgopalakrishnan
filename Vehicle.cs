using System;

namespace CSharpLearning
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string make, string model, int year)
        {
            Console.WriteLine("Vehicle constructor called");

            Make = make;
            Model = model;
            Year = year;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
        }
    }
}