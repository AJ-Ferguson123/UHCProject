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
    }
}