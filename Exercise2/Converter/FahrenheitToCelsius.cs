using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    class FahrenheitToCelsius : Convert
    {
        public override double ToValue
        {
            get { return (fromValue - 32) / 1.8; }
        }
        public FahrenheitToCelsius(double v) : base(v) { }
        public override String ToString()
        {
            String result = String.Format("{0} in Fahrenheit is {1:F3} Celsius.",
            fromValue, ToValue);
            return result;
        }
    }
}
