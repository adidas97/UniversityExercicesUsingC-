using System;

namespace Exceptions
{
    class Program
    {  
        static void Main(string[] args)
        {
            
            const double Minimum = 500;
            
            Employee[] employees = new Employee[5];
            for (int i = 0; i < employees.Length; i++)
            {
                bool ok = false;
                Console.WriteLine("Please, enter employee!");
                while (!ok)
                {
                    try
                    {
                        try
                        {

                            employees[i] = new Employee(Minimum);
                            Console.Write("\nName:\t");
                            employees[i].Name = Console.ReadLine();
                            Console.Write("Salary:\t");
                            employees[i].Salary = double.Parse(Console.ReadLine());

                            ok = true;
                        }
                        catch (FormatException)
                        {
                            throw
                           new EmployeeException(employees[i].Minimum, EmployeeErrors.FORMAT);
                        }
                    }
                    catch (EmployeeException)
                    { }
                }
            }
                foreach (var emp in employees)
                {
                    Console.WriteLine($"Employee : {emp}");
                }
            
        }
    }
}
