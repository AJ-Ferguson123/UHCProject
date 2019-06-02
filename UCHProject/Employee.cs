using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
    public abstract class Employee
    {
        public string Name;
        public int EmployeeNumber;
        public int Salary;
        public bool BeenPaid;
        public string EmployeeType;

        public Employee(string name, int employeeNumber, int salary, bool beenpaid, string employeetype)
        {
            Name = name;
            EmployeeNumber = employeNewNumber;
            Salary = 0;
            BeenPaid = false;
            EmployeeType = employeetype;
        }

        public abstract void PaySalary();
        public abstarct void EmployeeStatus();


    }
}
