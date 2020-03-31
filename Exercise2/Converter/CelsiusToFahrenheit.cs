using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    class CelsiusToFahrenheit : Convert
    {
        public override double ToValue
        {
            get { return fromValue * 1.8 + 32; }
        }
        public CelsiusToFahrenheit(double v) : base(v) { }
        public override String ToString()
        {
            String result = String.Format("{0} in Celsius is {1:F3} Fahrenheit.",
            fromValue, ToValue);
            return result;
        }
    }
}
