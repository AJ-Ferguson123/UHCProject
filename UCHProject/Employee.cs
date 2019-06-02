using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
    public abstract class Employee
    {
        public string Name;
        public int EmployeeNumber;
        public string EmployeeType;
        public int Salary;
        public bool BeenPaid;

        public Employee(string name, int employeeNumber)
        {
            Name = name;
            EmployeeNumber = employeeNumber;
            EmployeeType = "employee";
            Salary = 0;
            BeenPaid = false;
        }

        public virtual void PaySalary()
        {
            if (BeenPaid == false)
            {
                Console.WriteLine($"You have been paid {this.Name} $50000");
                BeenPaid = true;
            }
            else
            {
                Console.WriteLine($"{this.Name} has already been paid");
            }
        }

public void EmployeeStatus()
        {

        }


    }
}
