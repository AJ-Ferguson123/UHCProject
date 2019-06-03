using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
    public class Doctor : Employee
    {
        
        public string Specialty;
        
        public Doctor(string name, int employeeNumber, Hospital hospital, string specialty) : base(name, employeeNumber, hospital)
        {
            EmployeeType = "Doctor";
            Specialty = specialty;
            Salary = 90000;
        }

        

        public override void PaySalary()
        {
            if (BeenPaid == false)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{this.Name} has been paid $90000");
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
                $"Specialty:{this.Specialty}\n" +
                $"Salary:{this.Salary}\n" +
                $"Been paid?:{this.BeenPaid}");
            Console.WriteLine("");
        }

        public override void InteractDoctor()
        {
            
            bool interacting = true;
            do
            {
                
                int IndividualPatientInput;
                Patient selectedPatient;
                

                Console.WriteLine($"You are interacting with {this.Name}. Press any key to continue.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Interact Menu");
                Console.WriteLine(" 1 = DrawBlood:\n 2 = AffectHealth:\n 3 = Return to above menu");
                string interactDoctorInput = Console.ReadLine();
                switch (interactDoctorInput)
                {
                    case "1":
                        Console.WriteLine("Which Patient would you like to select");
                        Hospital.IndividualPatientList();

                        IndividualPatientInput = Convert.ToInt32(Console.ReadLine());
                        selectedPatient = Hospital.listOfPatients[IndividualPatientInput - 1];
                        selectedPatient.DoctorDrawBlood();
                        break;
                    case "2":
                        Console.WriteLine("Which Patient would you like to select");
                        Hospital.IndividualPatientList();

                        IndividualPatientInput = Convert.ToInt32(Console.ReadLine());
                        selectedPatient = Hospital.listOfPatients[IndividualPatientInput - 1];
                        selectedPatient.DoctorCareForPatient();
                        break;
                    case "3":interacting = false;
                        break;
                }
            } while (interacting);

            
            
        }
    }
}

