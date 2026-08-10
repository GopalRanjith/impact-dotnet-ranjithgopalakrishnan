using System;

namespace CSharpLearning
{
    public abstract class Shape
    {
        // Abstract method (no implementation)
        public abstract double CalculateArea();

        // Concrete method (implemented once)
        public void DisplayArea()
        {
            Console.WriteLine($"Area: {CalculateArea():F2}");
        }
    }
}