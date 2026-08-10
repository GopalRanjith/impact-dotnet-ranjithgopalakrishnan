using System;

namespace CSharpLearning
{
    public class Bike : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Bike(string make, string model, int year, bool hasSidecar)
            : base(make, model, year)
        {
            Console.WriteLine("Bike constructor called");

            HasSidecar = hasSidecar;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Bike - {Make} {Model} ({Year}), Sidecar: {HasSidecar}");
        }
    }
}