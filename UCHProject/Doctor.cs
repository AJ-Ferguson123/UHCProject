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
        }
    }
}
