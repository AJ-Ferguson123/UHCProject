using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
    public class Nurse : Employee
    {

        public int NumberOfPatients;
        public int Health;
        public int Blood;

        public Nurse(string name, int employeeNumber, int numberOfPatients, Hospital hospital) : base(name, employeeNumber, hospital)
        {
            EmployeeType = "Nurse";
            Salary = 50000;
            NumberOfPatients = 5;
        }

        public override void PaySalary()
        {
            if (BeenPaid == false)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{this.Name} has been paid $50000");
                BeenPaid = true;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{this.Name} has already been paid");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Employee Info:");
            Console.WriteLine($"Name:{this.Name}\n" +
            $"Employee Number:{this.EmployeeNumber}\n" +
            $"Profession:{this.EmployeeType}\n" +
            $"Salary:{this.Salary}\n" +
            $"Been paid?:{this.BeenPaid}\n" +
            $"Number of Patients:{this.NumberOfPatients}");
            Console.WriteLine("");
        }
        public override void InteractNurse()
        {
            bool interacting = true;
            do
            {
                int IndividualPatientInput;
                Patient selectedPatient;

                Console.WriteLine($"You are interacting with {this.Name}.");
                Console.WriteLine("");
                Console.WriteLine("Interact Menu");
                Console.WriteLine(" 1 = DrawBlood:\n 2 = AffectHealth:\n 3 = Show the status of Patients:\n 4 = Return to above menu");
                string interactNurseInput = Console.ReadLine();
                switch (interactNurseInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Which Patient would you like to select");
                        Hospital.IndividualPatientList();

                        IndividualPatientInput = Convert.ToInt32(Console.ReadLine());
                        selectedPatient = Hospital.listOfPatients[IndividualPatientInput - 1];
                        selectedPatient.NurseDrawBlood();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Which Patient would you like to select");
                        Hospital.IndividualPatientList();

                        IndividualPatientInput = Convert.ToInt32(Console.ReadLine());
                        selectedPatient = Hospital.listOfPatients[IndividualPatientInput - 1];
                        selectedPatient.NurseCareForPatient();
                        break;

                    case "3":
                        {
                            Console.Clear();
                            foreach (Patient element in Hospital.listOfPatients)
                            {
                                element.PatientShowInfo();
                                Console.WriteLine("");
                            }
                        }
                        break;

                    case "4":
                        Console.Clear();
                        interacting = false;
                        break;
                }
            } while (interacting);
        }
    }
}

