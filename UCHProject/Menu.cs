using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
    public class Menu
    {

        bool programIsRunning = false;

        Hospital hospital = new Hospital("Univeristy Circle Hospital");
        

        public bool OpeningMenu()
        {

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
            Console.WriteLine("Type 1 to add a new employee");
            Console.WriteLine("Type 3 to view current list of employees");
            Console.WriteLine("Type 4 to select a specific employee");
            Console.WriteLine("Type 5 to pay all employees");
            Console.WriteLine("Type 9 to exit");
            string mainMenuInput = Console.ReadLine();


            


            switch (mainMenuInput)
            {



                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "9":
                    break;
                default:
                    Console.WriteLine("please type in a number from the menu.");
                    break;

            }
            



        }

            public void AddDoctorToHospital()
            {
                Doctor doctor = new Doctor("no name", "no specialty");
                Doctor.AddDoctor();
                DoctorList.Add(Doctor);
            }

            public void AddNurseToHospital()
            {
                Nurse nurse = new Nurse("no name", "no specialty");
                Nurse.AddNurse();
                NurseList.Add(Nurse);
            }

            public void HospitalDoctorInfo()
            {
                int doctorNumber = 1;
                foreach (Doctor doctor in Doctorlist)
                {
                    Console.WriteLine(doctorNumber + " :Name " + doctor.Name + "Specialty" + doctor.Specialty);
                    doctorNumber++;
                }
            }

            public void HospitalNurseInfo()
            {
                int nurseNumber = 1;
                foreach (Nurse nurse in Nurselist)
            {
                Console.WriteLine(nurseNumber + " :Name " + nurse.Name + "Specialty" + nurse.Specialty);
                nurseNumber++;
            }
        }

        public void HospitalNurseBlood()
        {
            bool blood = true;
            string blood = "";
            do
            {
             Console.WriteLine("You are have affected the blood level of the patient");
             Console.ReadLine();

            }

        }

        public void HospitalDoctorBlood()
        {
            bool blood = true;
            string blood = "";
            do
            {
             Console.WriteLine("You have affected the blood level of the patient");
             Console.ReadLine();
            }
        }
        public void HospitalNurseHealth()
        {
            bool health = true;
            string health = ""; 
            do
            {
                Console.WriteLine("You have increased the health level of the patient");
                Console.ReadLine();
            }

        public void HospitalDoctorHealth()
            {
                bool health = true;
                string health = "";
                do
            {
                Console.WriteLine("You have increased the health level of the patient");
                Console.ReadLine();

                }

            }
        }




        public void IndividualEmployeeMenu()
            {
                    Console.WriteLine("Which employee would you like to select");
            }

    }
}
