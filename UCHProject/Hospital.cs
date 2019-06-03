using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
    public class Hospital
    {

        public string Name; //{ get; private set; }

        public Hospital(string name)
        {
            Name = name;
        }

        public List<Employee> listOfEmployees = new List<Employee>();
        public List<Patient> listOfPatients = new List<Patient>();

        
        public void ConstructPatients()
        {

            int patientNumber;
            for (patientNumber = 1; patientNumber <= 15; patientNumber++)
            {
                Patient patient = new Patient(patientNumber);
                listOfPatients.Add(patient);
            }
                            
        }
        
        public void IndividualEmployeeList()
        {
            int i = 0;

            foreach (Employee element in listOfEmployees)
            {
                i = i + 1;
                Console.WriteLine(i + " " + element.Name);
            }
        }

        public void IndividualPatientList()
        {
            int i = 0;

            foreach (Patient element in listOfPatients)
            {
                i = i + 1;
                Console.WriteLine(i + " " + element.PatientNumber);
            }
        }
               
    }
}
