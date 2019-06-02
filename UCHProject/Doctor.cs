using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
   public class Doctor : Employee
    {
        public string Specialty;

        public Doctor(string name, int employeeNumber, string specialty) : base(name, employeeNumber)
        {
            Specialty = specialty;
            Salary = 90000
        }
   
        public override void PaySalary()
        {
            if (BeenPaid == false)
        {
            Console.WriteLine($"You have been paid {Employee} $50000");
                BeenPaid = true;
        }
            else
            {
                Console.WriteLine($"{Employee} has already been paid");
            }
















   }
}
