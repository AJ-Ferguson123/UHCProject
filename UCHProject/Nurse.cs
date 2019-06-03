using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
   public class Nurse : Employee
    {
        
        public int NumberOfPatients;
        public int Health;
        public int Blood;

        public Nurse(string name, int employeeNumber, int numberOfPatients, Hospital hospital) : base(name, employeeNumber, hospital)
        {
            EmployeeType = "Nurse";
            Salary = 50000;
            NumberOfPatients = 5;
        }
                          
        public override void PaySalary()
        {
            if (BeenPaid == false)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{this.Name} has been paid $50000");
                BeenPaid = true;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{this.Name} has already been paid");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Employee Info:");
            Console.WriteLine($"Name:{this.Name}\n" +
                $"Employee Number:{this.EmployeeNumber}\n" +
                $"Profession:{this.EmployeeType}\n" +
                $"Salary:{this.Salary}\n" +
                $"Been paid?:{this.BeenPaid}\n" +
                $"Number of Patients:{this.NumberOfPatients}");
            Console.WriteLine("");
        }
        

    }
}
