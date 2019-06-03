using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
    public class Patient
    {
        public int PatientNumber;
        public int Health_Level;
        public int Blood_Level;
        

        public Patient(int patientnumber) 
        {
            PatientNumber = patientnumber;
            Blood_Level = 20;
            Health_Level = 10;
        }

        public void PatientShowInfo()
        {
            Console.WriteLine($"PatientNumber: {this.PatientNumber}\n" +
                $"Health Level {this.Health_Level}\n" +
                $"Blood Level:{this.Blood_Level}");
        }

        public void DoctorDrawBlood()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            this.Blood_Level -= 1;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void DoctorCareForPatient()
        {            
            this.Health_Level += 10;
        }

        public void NurseDrawBlood()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            this.Blood_Level -= 3;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void NurseCareForPatient()
        {
            this.Health_Level += 5;
        }






    }
}
