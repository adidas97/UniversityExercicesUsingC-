using System;
using System.Collections.Generic;
using System.Reflection;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Employee);
            PropertyInfo[] ps = type.GetProperties();
            int n; // Number of employees
            do
            {
                Console.Write("Enter number of employees: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            List<Employee> emps = new List<Employee>();

            Dictionary<string, Employee> dictionaryEmplyees = new Dictionary<string, Employee>();

            Console.WriteLine("\nPlease, enter employees!");
            for (int i = 0; i < n; i++)
            {
                bool attributeError = false;
                bool formatError = false;
                Employee e = new Employee();
                try
                {
                    Console.Write("\nName:\t");
                    e.Name = Console.ReadLine();
                    Console.Write("Salary:\t");
                    e.Salary = double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    formatError = true;
                }
                foreach (PropertyInfo p in ps)
                {
                    foreach (Attribute attr in p.GetCustomAttributes(true))
                    {
                        RequiredAttribute rqa = attr as RequiredAttribute;
                        if (null != rqa)
                        {
                            object v = p.GetValue(e);
                            if (!rqa.IsValid(v))
                            {
                                Console.WriteLine("* " + rqa.ErrorMessage);
                                attributeError = true;
                            }
                        }
                        GreaterThanAttribute gta = attr as GreaterThanAttribute;
                        if (null != gta)
                        {
                            double v = (double)p.GetValue(e);
                            if (formatError)
                            {
                                Console.WriteLine("* " + "Wrong " + p.Name + "!");
                                attributeError = true;
                            }
                            else if (!gta.IsValid(v))
                            {
                                Console.WriteLine("* " + gta.ErrorMessage,
                                p.Name, gta.Minimum);
                                attributeError = true;
                            }
                        }
                    }
                }
                if (attributeError)
                {
                    e.Error();
                    i--;
                }
                else
                {
                    emps.Add(e);
                    dictionaryEmplyees.Add(e.Name, e);
                }
            }
            Console.WriteLine("\nEmployees\n");
            foreach (var kvp in dictionaryEmplyees)
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
        }
    }
}
