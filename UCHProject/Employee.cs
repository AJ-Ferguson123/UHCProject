﻿using System;
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
        public Hospital Hospital;

        public Employee(string name, int employeeNumber, Hospital hospital)
        {
            Name = name;
            EmployeeNumber = employeeNumber;
            EmployeeType = "employee";
            Salary = 0;
            BeenPaid = false;
            Hospital = hospital;
        }

        public virtual void PaySalary()
        {
            if (BeenPaid == false)
            {
                Console.WriteLine($"You have been paid $0");
                BeenPaid = true;
            }
            else
            {
                Console.WriteLine($"{this.Name} has already been paid");
            }
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("Employee Info:");
            Console.WriteLine($"Name:{this.Name}\n" +
            $"Employee Number:{this.EmployeeNumber}\n" +
            $"Profession:{this.EmployeeType}\n" +
            $"Salary:{this.Salary}\n" +
            $"Been paid?:{this.BeenPaid}");
            Console.WriteLine("");
        }
        public virtual void InteractDoctor()
        { }
        public virtual void InteractNurse()
        { }
        public virtual void InteractReceptionist()
        { }
        public virtual void InteractJanitor()
        { }
    }
}
