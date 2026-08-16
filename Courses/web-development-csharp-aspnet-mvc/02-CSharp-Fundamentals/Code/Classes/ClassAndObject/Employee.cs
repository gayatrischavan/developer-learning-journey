using System;

namespace ClassAndObjectDemo
{
    // Employee is a simple class (blueprint) that represents
    // the common data and behavior of an employee.
    class Employee
    {
        // Auto-implemented properties (see Properties.cs for details)
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        // Method: calculates the final salary including a 10% bonus.
        public double FindSalary()
        {
            double bonus = Salary * 0.10;
            return Salary + bonus;
        }
    }
}
