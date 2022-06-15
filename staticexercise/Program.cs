using System;

namespace staticexercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Celsius = TempConverter.FahrenheitToCelsius(68);

            var Fahrenheit = TempConverter.CelsiusToFahrenheit(20);

            Console.WriteLine($"after conversion");

            Console.WriteLine($"fahrenheit {Fahrenheit}");

            Console.WriteLine($"Celsius {Celsius}");

        }
    }
}
