using System;
using System.Collections.Generic;
using System.Text;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field |
 AttributeTargets.Parameter, AllowMultiple = false)]
    class GreaterThanAttribute : Attribute
    {
        public double Minimum { get; set; }
        public string ErrorMessage { get; set; }
        public GreaterThanAttribute(double minimum) : base()
        {
            Minimum = minimum;
        }
        public bool IsValid(double value)
        {
            return value >= Minimum;
        }
    }
}
