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

        string employeeName = "no name";

        int employeeNewNumber = 0;

        //public void CreateEmployee()
        //{
        //    Console.WriteLine("What kind of an employee would you like to add?");
        //    string createChoiceInput = (Console.ReadLine();

        //    switch (createChoiceInput)
        //    {
        //        case ("Doctor"):
        //            {
        //                Console.WriteLine("Enter the Name of the Doctor.");
        //                string doctorName = Console.ReadLine();

        //                Console.WriteLine("Enter their custom Employee Number.");
        //                int doctorEmployeeNumber = Convert.ToInt32(Console.ReadLine());

        //                Console.WriteLine("Enter their Doctor Specialty.");
        //                string doctorSpecialty = Console.ReadLine();

        //                Doctor doctor = new Doctor(doctorName,doctorEmployeeNumber,doctorSpecialty);
        //                listOfEmployees.Add(doctor);
        //            }
        //            break;
        //        case ("Nurse"):
        //            {
        //                Console.WriteLine("Enter the Name of the Nurse.");
        //                string doctorName = Console.ReadLine();

        //                Console.WriteLine("Enter their custom Employee Number.");
        //                int doctorEmployeeNumber = Convert.ToInt32(Console.ReadLine());

        //                Console.WriteLine("Enter their Doctor Specialty.");
        //                string doctorSpecialty = Console.ReadLine();

        //                Doctor doctor = new Doctor(doctorName, doctorEmployeeNumber, doctorSpecialty);
        //                listOfEmployees.Add(doctor);
        //            }
        //            break;
        //        case ("Receptionist"):
        //            break;
        //        case ("Janitor"):
        //            break;
        //        default:
        //            break;
        //    }

        //    string employeeName = "noname";
        //    int employeeNumber = 0;
        //    string employeeType = "nojob";
            


        //}
        //public void CreatePatients()
        //{
        //    Patient testCreatedPatient;
        //    int patientNumber;
        //    for (patientNumber = 1; patientNumber <= 5; patientNumber++)

        //    testCreatedPatient = new Patient(patientNumber);
        //}
        



    }
}
