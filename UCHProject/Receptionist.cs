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
            Salary = 45000
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
            Console.WriteLine($"You have been paid {Employee} $50000");
                BeenPaid = true;
        }
            else
            {
                Console.WriteLine($"{Employee} has already been paid");
            }












    }
}
