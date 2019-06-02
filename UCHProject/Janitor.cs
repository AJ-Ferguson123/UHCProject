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
            Salary = 40000
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
            Console.WriteLine($"You have been paid {Employee} $50000");
                BeenPaid = true;
        }
            else
            {
                Console.WriteLine($"{Employee} has already been paid");
            }















    }
}