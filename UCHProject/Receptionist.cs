using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
    public class Receptionist : Employee
    {

        public bool AreTheyOnThePhone;

        public Receptionist(string name, int employeeNumber) : base(name, employeeNumber)
        {
            EmployeeType = "Receptionist";
            Salary = 45000;
            AreTheyOnThePhone = false;
        }

        public void AnsweringPhone()
        {

            this.AreTheyOnThePhone = true;
        }
        public void HangUpPhone()
        {
            this.AreTheyOnThePhone = false;
        }

        public override void PaySalary()
        {
            if (BeenPaid == false)
            {
                Console.WriteLine($"{this.Name} has been paid $45000");
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
