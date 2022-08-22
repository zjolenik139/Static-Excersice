using System;

namespace StaticExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelsius(68);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);
            Console.WriteLine("After conversation:");
            Console.WriteLine($"fahrenheit {fahrenheit}");
            Console.WriteLine($"celcius {celcius}");
        }
    }
}
