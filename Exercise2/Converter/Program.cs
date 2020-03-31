using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Convert convert;
            convert = new LitersToGallons(100);
            Console.WriteLine(convert);
            convert = new FahrenheitToCelsius(100);
            Console.WriteLine(convert);            convert = new CelsiusToFahrenheit(100);
            Console.WriteLine(convert);
        }
    }
}
