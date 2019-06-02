using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
    public class Hospital
    {
        
        public string Name;

        public Hospital(string name)
        {
            Name = name;
        }

        public List<Employee> listOfEmployees = new List<Employee>();
        public List<Patient> listOfPatients = new List<Patient>();

        string employeeName = "noname";

        int employeeNewNumber = 0;

        public void CreateEmployee()
        {
            string employeeName = "noname";
            int employeeNumber = 0;
            string employeeType = "nojob";
            


        }
        public void CreatePatients()
        {
            Patient testCreatedPatient;
            int patientNumber;
            for (patientNumber = 1; patientNumber <= 5; patientNumber++)

            testCreatedPatient = new Patient(patientNumber);
        }
        



    }
}
