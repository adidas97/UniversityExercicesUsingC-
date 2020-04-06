using System;
using System.Collections.Generic;
using System.Text;

namespace Attributes
{
    class Employee
    {
        private static int lastAssignedNumber = 0;
        private int id;
        [Required(ErrorMessage = "Name is required!",
        AllowEmptyStrings = false)]
        public string Name { get; set; }
        [GreaterThan(500,
        ErrorMessage = "Value for {0} must be greater than {1}!")]
        public double Salary { get; set; }
        public Employee()
        {
            lastAssignedNumber++;
            id = lastAssignedNumber;
        }
        public void Error()
        {
            lastAssignedNumber--;
        }
        public override string ToString()
        {
            return id + "\t" + Name + "\t" + Salary + "\t";
        }
    }
}
