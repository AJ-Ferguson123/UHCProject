﻿using System;
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
            Health_Level = 100;
            Blood_Level = 100;
        }

        public void PatientShowInfo()
        {
            Console.WriteLine($"PatientNumber: {this.PatientNumber}\n" +
                $"Health Level {this.Health_Level}\n" +
                $"Blood Level:{this.Blood_Level}");
        }
        





    }
}
