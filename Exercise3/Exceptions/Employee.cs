using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    class Employee
    {
        private static int lastAssignedNumber = 0;
        private int id;
        public int Id
        {
            get { return id; }
        }

        private string name; 
        public string Name
        {
            get { return name; } 
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Error();
                    throw new EmployeeException(EmployeeErrors.NAME);
                }
                else
                    name = value;
            }
        }
        private readonly double minimum;
        public double Minimum
        {
            get { return minimum; }
        }
        private double salary;
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < minimum)
                {
                    Error();
                    throw new EmployeeException(this.minimum, EmployeeErrors.SALARY);
                }
                
                else
                    salary = value;
            }
        }
        public Employee(double minimum)
        {
            lastAssignedNumber++;
            id = lastAssignedNumber;
            this.minimum = minimum;
        }
        public void Error()
        {
            lastAssignedNumber--;
        }
        public override string ToString()
        { return id + "\t" + Name + "\t" + Salary + "\t"; }
    }
}

