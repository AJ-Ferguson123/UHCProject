using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
    public class Hospital
    {
        
        public string Name { get; private set; }

        public Hospital(string name)
        {
            Name = name;
        }

        public List<Employee> listOfEmployees = new List<Employee>();
        public List<Patient> listOfPatients = new List<Patient>();

        
        

        //public void CreateEmployee()
        //{
        //    Console.WriteLine("What kind of an employee would you like to add?");
        //    string createChoiceInput = (Console.ReadLine());

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

        //                Doctor doctor = new Doctor(doctorName, doctorEmployeeNumber, doctorSpecialty);
        //                listOfEmployees.Add(doctor);
        //            }
        //            break;
        //        case ("Nurse"):
        //            {
        //                Console.WriteLine("Enter the Name of the Nurse.");
        //                string nurseName = Console.ReadLine();

        //                Console.WriteLine("Enter their custom Employee Number.");
        //                int nurseEmployeeNumber = Convert.ToInt32(Console.ReadLine());

        //                Console.WriteLine("Enter their Nurse's Patient Count.");
        //                int nursePatientCount = Convert.ToInt32(Console.ReadLine());

        //                Nurse nurse = new Nurse(nurseName, nurseEmployeeNumber, nursePatientCount);
        //                listOfEmployees.Add(nurse);
        //            }
        //            break;
        //        case ("Receptionist"):
        //            {
        //                Console.WriteLine("Enter the Name of the Receptionist.");
        //                string receptionistName = Console.ReadLine();

        //                Console.WriteLine("Enter their custom Employee Number.");
        //                int receptionistEmployeeNumber = Convert.ToInt32(Console.ReadLine());

        //                Receptionist receptionist = new Receptionist(receptionistName, receptionistEmployeeNumber);
        //                listOfEmployees.Add(receptionist);
        //            }
        //            break;
        //        case ("Janitor"):
        //            {
        //                Console.WriteLine("Enter the Name of the Janitor.");
        //                string janitorName = Console.ReadLine();

        //                Console.WriteLine("Enter their custom Employee Number.");
        //                int janitorEmployeeNumber = Convert.ToInt32(Console.ReadLine());

        //                Janitor janitor = new Janitor(janitorName, janitorEmployeeNumber);
        //                listOfEmployees.Add(janitor);
        //            }
        //            break;
        //        default:
        //            break;
        //    }

        //    string employeeName = "noname";
        //    int employeeNumber = 0;
        //    string employeeType = "nojob";



        //}
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

            foreach (Employee element in listOfEmployees)
            {
                i = i + 1;
                Console.WriteLine(i + " " + element.Name);
            }
        }



    }
}
