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

    }
}
