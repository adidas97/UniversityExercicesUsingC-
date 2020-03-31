using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    class LitersToGallons : Convert
    {
        public override double ToValue
        {
            get { return fromValue / 3.7854; }
        }
        public LitersToGallons(double v) : base(v) { }
        public override String ToString()
        {
            String result = String.Format("{0} in litters is {1:F3} gallons.",
            fromValue, ToValue);
            return result;
        }
    }
}
