using System;

namespace CSharpLearning
{
    public class TemperatureConverter
    {
        // Conversion methods (used by unit tests)

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public static double FahrenheitToKelvin(double fahrenheit)
        {
            return FahrenheitToCelsius(fahrenheit) + 273.15;
        }

        public static double KelvinToCelsius(double kelvin)
        {
            return kelvin - 273.15;
        }

        public static double KelvinToFahrenheit(double kelvin)
        {
            return CelsiusToFahrenheit(KelvinToCelsius(kelvin));
        }

        // Existing overloaded methods (used by Program.cs)

        public static void Convert(double celsius)
        {
            Console.WriteLine($"Celsius : {celsius}");
            Console.WriteLine($"Fahrenheit : {CelsiusToFahrenheit(celsius):F2}");
            Console.WriteLine($"Kelvin : {CelsiusToKelvin(celsius):F2}");
        }

        public static void Convert(double fahrenheit, bool isFahrenheit)
        {
            Console.WriteLine($"Fahrenheit : {fahrenheit}");
            Console.WriteLine($"Celsius : {FahrenheitToCelsius(fahrenheit):F2}");
            Console.WriteLine($"Kelvin : {FahrenheitToKelvin(fahrenheit):F2}");
        }

        public static void Convert(double kelvin, char isKelvin)
        {
            Console.WriteLine($"Kelvin : {kelvin}");
            Console.WriteLine($"Celsius : {KelvinToCelsius(kelvin):F2}");
            Console.WriteLine($"Fahrenheit : {KelvinToFahrenheit(kelvin):F2}");
        }
    }
}