using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
    class Patient
    {
        public Patient(int patientnumber) 
        {
            Health = 100;
            Blood = 100;
        }
        public void NurseHealth()
        {
            Health += 3;
            Console.WriteLine("The doctor has performed a health check");
        }

        public void NrseBlood()
        {
            Blood += 3;
            Console.WriteLine("The doctor has performed blood work");
        }
        public void DoctorHealth()
        {
            Health += 5;
            Console.WriteLine("The doctor has performed a health check");
        }

        public void DoctorBlood()
        {
            Blood += 5;
            Console.WriteLine("The doctor has performed blood work");
        }




    }
}
