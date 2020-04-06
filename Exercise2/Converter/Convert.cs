using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
   abstract class Convert
    {
        protected double fromValue;
        public double FromValue
        {
            get { return fromValue; }
        }
        protected double toValue;
        public abstract double ToValue { get; }
        protected Convert(double v)
        {
            fromValue = v;
            toValue = 0;
        }
        public abstract override String ToString();
    }
}
