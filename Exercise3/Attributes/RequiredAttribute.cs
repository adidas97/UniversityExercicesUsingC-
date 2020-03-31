using System;
using System.Collections.Generic;
using System.Text;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field |
 AttributeTargets.Parameter, AllowMultiple = false)]
    class RequiredAttribute : Attribute
    {
        public string ErrorMessage { get; set; }
        public bool AllowEmptyStrings { get; set; }
        public bool IsValid(object value)
        {
            if (value == null)
                return false;
            var stringValue = value as string;
            if (stringValue != null && !AllowEmptyStrings)
            {
                return stringValue.Trim().Length != 0;
            }
            return true;
        }
    }
}
