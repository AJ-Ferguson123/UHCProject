using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
    public class Menu
    {
        
        bool programIsRunning = false;
        public Hospital hospital = new Hospital("Univeristy Clinic Hospital");      
        
                
        public void ConstructOriginalEmployees()
        {
            Doctor doctor = new Doctor("Philip Dewgood", 14353, hospital, "MD");
            hospital.listOfEmployees.Add(doctor);
            doctor = new Doctor("Thomas Smith", 43750, hospital, "Surgeon");
            hospital.listOfEmployees.Add(doctor);
            Nurse nurse = new Nurse("Joy Williams", 38295, 5, hospital);
            hospital.listOfEmployees.Add(nurse);
            nurse = new Nurse("Sam Smith", 34567, 5, hospital);
            hospital.listOfEmployees.Add(nurse);
            nurse = new Nurse("Sarah Godsend", 23456, 5, hospital);
            hospital.listOfEmployees.Add(nurse);
            Receptionist receptionist = new Receptionist("Sally Bible", 21212, hospital);
            hospital.listOfEmployees.Add(receptionist);
            Janitor janitor = new Janitor("Bill Harris", 31313, hospital);
            hospital.listOfEmployees.Add(janitor);
        }

        public bool OpeningMenu()
        {
            
            hospital.ConstructPatients();
            ConstructOriginalEmployees();
            Console.WriteLine("Welcome to University Hospitals Employee Management Software!\n");
            Console.WriteLine("Type start to begin the program. Type exit to close the program.");
            string openMenuInput = Console.ReadLine();
            Console.Clear();

            if (openMenuInput == "start")
            {
                programIsRunning = true;
                
            }

            else if (openMenuInput == "exit")
            {
                programIsRunning = false;
            }

            else
            {                
                Console.WriteLine("Please select and type either start, or exit.");
                OpeningMenu();
                
            }

            while (programIsRunning)
            {
                Console.WriteLine("Select from these Menu Options.\n");
                MainMenu();
            }
            return true;
        }

        public void MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;            
            Console.WriteLine("Type 2 to view current list of employees");
            Console.WriteLine("Type 4 to select a specific employee");
            Console.WriteLine("Type 5 to pay all employees");
            Console.WriteLine("Type 6 Show status of current of patients");
            Console.WriteLine("Type 9 to exit");
            string mainMenuInput = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            switch (mainMenuInput)
            {
                
                case "2":
                    {
                        Console.WriteLine("Here is a list of current employees.");
                        foreach (Employee element in hospital.listOfEmployees)
                        {
                            element.ShowInfo();
                            Console.WriteLine("");
                        }
                    }
                    break;
                    
                case "6":
                    {
                        Console.Clear();
                        foreach(Patient element in hospital.listOfPatients)
                        {
                            element.PatientShowInfo();
                            Console.WriteLine("");
                        }
                    }
                    break;

                case "4": IndividualEmployeeMenu();
                    break;

                case "5":
                    Console.Clear();
                    Console.WriteLine("You have paid all of your employees.");
                    foreach (Employee element in hospital.listOfEmployees)
                    {
                        element.PaySalary();
                        Console.WriteLine("");
                    }
                    break;

                case "9": programIsRunning = false;
                    break;

                default:
                    Console.WriteLine("please type in a number from the menu.");
                    break;

            }
                                 
        }


        public void IndividualEmployeeMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Which employee would you like to select");
            hospital.IndividualEmployeeList();

            int IndividualEmployeeInput = Convert.ToInt32(Console.ReadLine());
            Employee selectedEmployee = hospital.listOfEmployees[IndividualEmployeeInput - 1];
            Console.WriteLine("What would you like to do?");
            if (selectedEmployee.GetType() == typeof(Doctor))
            {
                selectedEmployee.InteractDoctor();
            }

            else if (selectedEmployee.GetType() == typeof(Nurse))
            {
                selectedEmployee.InteractNurse();
            }

            else if (selectedEmployee.GetType() == typeof(Receptionist))
            {
                selectedEmployee.InteractReceptionist();
            }

            else if (selectedEmployee.GetType() == typeof(Janitor))
            {
                selectedEmployee.InteractJanitor();
            }

            else MainMenu();
        }

    }
}
