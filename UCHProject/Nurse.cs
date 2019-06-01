using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
   public class Nurse : Employee
    {
        public int NumberOfPatients;

        public Nurse(string name, int employeeNumber) : base(name, employeeNumber)
        {
            NumberOfPatients = 0;
        }
    }
}
