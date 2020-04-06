using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    enum EmployeeErrors { NAME, SALARY, FORMAT }
    class EmployeeException : Exception
    {
        private double minimum;

        public override string Message { get;  }
        public EmployeeException(string message) : base(message) { }
        public EmployeeException(string message, Exception inner)
        : base(message, inner) { }
        public EmployeeException(double minimum, EmployeeErrors err) : base()
        {
            this.minimum = minimum;
            switch (err)
            {
                case EmployeeErrors.NAME:
                    
                    Message =  "Name is required!";
                    break;
                case EmployeeErrors.SALARY:
                    
                   Message =  "Value for Salary must be greater than " + minimum + "!";
                    break;
                case EmployeeErrors.FORMAT:
                   Message = "Wrong Salary!";
                    break;
            }
        }        public EmployeeException(EmployeeErrors err) : this (0,err)
        {
            
            
        }
    }
}
