using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
   public class Nurse : Employee
    {
        public int NumberOfPatients {get; set; }
        public int Health { get; set; }
        public int Blood { get; set; }
        public Nurse(string name, int employeeNumber) : base(name, employeeNumber)
        {
            Salary = 50000
            NumberOfPatients = 0;
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
}
