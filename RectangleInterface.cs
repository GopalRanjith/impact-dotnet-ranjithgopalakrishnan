using System;

namespace CSharpLearning
{
    public class RectangleInterface : IShape, IDrawable
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public RectangleInterface(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double CalculateArea()
        {
            return Length * Width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }

        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }
}