using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
    public class Menu
    {
        
        bool programIsRunning = false;
        
        Hospital hospital = new Hospital("Univeristy Clinic Hospital");
        Doctor Phil = new Doctor("Philip Dewgood", 14353, "MD");
        Doctor Tom = new Doctor("Thomas Smith", 43750, "Surgeon");
        Nurse Joy = new Nurse("Joy Williams", 38295, 5);
        Nurse Sam = new Nurse("Sam Smith", 34567, 5);
        Nurse Sarah = new Nurse("Sarah Godsend", 23456, 5);
        Receptionist Sally = new Receptionist("Sally Bible", 21212);
        Janitor Bill = new Janitor("Bill Harris", 31313);
        
       

        public bool OpeningMenu()
        {
            hospital.listOfEmployees.Add(Phil);
            hospital.listOfEmployees.Add(Tom);
            hospital.listOfEmployees.Add(Joy);
            hospital.listOfEmployees.Add(Sam);
            hospital.listOfEmployees.Add(Sarah);
            hospital.listOfEmployees.Add(Sally);
            hospital.listOfEmployees.Add(Bill);
            hospital.ConstructPatients();
            Console.WriteLine("Welcome to University Hospitals Employee Management Software!");
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
                Console.WriteLine("Please select and type either start or exit.");
                OpeningMenu();
            }

            while (programIsRunning)
            {
                Console.WriteLine("Select from these Menu Options.");
                MainMenu();
            }
            return true;
        }

        public void MainMenu()
        {
            //Console.WriteLine("Type 1 to add a new employee");
            Console.WriteLine("Type 2 to view current list of employees");
            Console.WriteLine("Type 4 to select a specific employee");
            Console.WriteLine("Type 5 to pay all employees");
            Console.WriteLine("Type 6 Show status of current of patients");
            Console.WriteLine("Type 9 to exit");
            string mainMenuInput = Console.ReadLine();

            switch (mainMenuInput)
            {
                //case "1":
                //    break;
                case "2":
                    {
                        Console.WriteLine("Here is a list of current employees.");
                        Phil.ShowInfo();
                        Tom.ShowInfo();
                        Joy.ShowInfo();
                        Sam.ShowInfo();
                        Sarah.ShowInfo();
                        Sally.ShowInfo();
                        Bill.ShowInfo();
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
                    Phil.PaySalary();
                    Tom.PaySalary();
                    Joy.PaySalary();
                    Sam.PaySalary();
                    Sarah.PaySalary();
                    Sally.PaySalary();
                    Bill.PaySalary();
                    break;

                case "9": programIsRunning = false;
                    break;

                default:
                    Console.WriteLine("please type in a number from the menu.");
                    break;

            }




        }

        //    public void AddDoctorToHospital()
        //    {
        //        Doctor doctor = new Doctor("no name", "no specialty");
        //        Doctor.AddDoctor();
        //        DoctorList.Add(Doctor);
        //    }

        //    public void AddNurseToHospital()
        //    {
        //        Nurse nurse = new Nurse("no name", "no specialty");
        //        Nurse.AddNurse();
        //        NurseList.Add(Nurse);
        //    }

        //    public void HospitalDoctorInfo()
        //    {
        //        int doctorNumber = 1;
        //        foreach (Doctor doctor in Doctorlist)
        //        {
        //            Console.WriteLine(doctorNumber + " :Name " + doctor.Name + "Specialty" + doctor.Specialty);
        //            doctorNumber++;
        //        }
        //    }

        //    public void HospitalNurseInfo()
        //    {
        //        int nurseNumber = 1;
        //        foreach (Nurse nurse in Nurselist)
        //    {
        //        Console.WriteLine(nurseNumber + " :Name " + nurse.Name + "Specialty" + nurse.Specialty);
        //        nurseNumber++;
        //    }
        //    }

        public void IndividualEmployeeMenu()
        {
            Console.Clear();
            Console.WriteLine("Which employee would you like to select");
            hospital.IndividualEmployeeList();

            int IndividualEmployeeInput = Convert.ToInt32(Console.ReadLine());
            Employee selectedEmployee = hospital.listOfEmployees[IndividualEmployeeInput - 1];
            Console.WriteLine("What would you like to do?");
            if (selectedEmployee.GetType() == typeof(Doctor))
            {
                Console.WriteLine("youve have selected doctor");
                //Doctor selectedDoctor = selectedEmployee;
            }

            else if (selectedEmployee.GetType() == typeof(Nurse))
            {
                Console.WriteLine("youve have selected nurse");
                selectedEmployee.ShowInfo();
            }

            else if (selectedEmployee.GetType() == typeof(Receptionist))
            {
                Console.WriteLine("youve have selected receptionist");
            }
            else if (selectedEmployee.GetType() == typeof(Janitor))
            {
                Console.WriteLine("youve have selected janitor");
            }
            else MainMenu();
        }

    }
}
