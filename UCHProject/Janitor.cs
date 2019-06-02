using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
    public class Janitor : Employee
    {
        public bool AreTheySweeping;

        public Janitor(string name, int employeeNumber) : base(name, employeeNumber)
        {
            EmployeeType = "Janitor";
            Salary = 40000;
            AreTheySweeping = false;
        }

        public void StartSweeping()
        {
            this.AreTheySweeping = true;
        }

        public void StopSweeping()
        {
            this.AreTheySweeping = false;
        }

        public override void PaySalary()
        {
            if (BeenPaid == false)
            {
                Console.WriteLine($"{this.Name} has been paid $40000");
                BeenPaid = true;
            }
            else
            {
                Console.WriteLine($"{this.Name} has already been paid");
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Employee Info:");
            Console.WriteLine($"Name:{this.Name}/n" +
                $"Employee Number:{this.EmployeeNumber}/n" +
                $"Profession:{this.EmployeeType}/n" +
                $"Salary:{this.Salary}/n" +
                $"Been paid?:{this.BeenPaid}");
            Console.WriteLine("");
        }

    }
}