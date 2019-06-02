using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
   public class Doctor : Employee
    {
        public string Specialty;
        public int NumberOfPatients { get; set; }
        public int Health { get; set; }
        public int Blood { get; set; }


        public Doctor(string name, int employeeNumber, string specialty) : base(name, employeeNumber)
        {
            Specialty = specialty;
            Salary = 90000
            Health = 100;
            Blood = 100;
        }
        
        public void Health()
        {
            Health += 5;
            Console.WriteLine("The doctor has performed a health check");



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
