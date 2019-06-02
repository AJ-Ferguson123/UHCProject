using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
    class Menu
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
            Console.WriteLine("Type 2 to view current list of employees");
            Console.WriteLine("Type 3 to select a specific employee");
            Console.WriteLine("Type 4 to pay all employees");
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

        public void IndividualEmployeeMenu()
        {
            Console.WriteLine("Which employee would you like to select");
        }

    }
}
