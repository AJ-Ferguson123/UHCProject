using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
    class Menu
    {
        string mainMenuInput;
        bool programIsRunning = false;

        Hospital hospital = new Hospital("Univeristy Circle Hospital");

        public void OpeningMenu();
        {
            
            Console.WriteLine("Welcome to University Hospitals Employee Management Software!");
            Console.WriteLine("Type start to begin the program. Type exit to close the program.");
            string openMenuInput = Console.ReadLine();
            Console.Clear

            if (openMenuInput = "start")
            {
                programIsRunning = true;            
            }

            else if (openMenuInput = "exit")
            {
                programIsRunning = false;
            }

            else
            {
                Console.WriteLine("Please select and type either start or exit.");
                OpeningMenu();
            }

            while(programIsRunning)
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
}           mainMenuInput = COnsole.ReadLine();
            Console.Clear();

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
            }

        }
        
        public void IndividualEmployeeMenu()
        {
            Console.WriteLine("Which employee would you like to select")
        }
//you rock!
// lol. why do you say that?
//just being positive
//gotcha. im just looking into .TypeOf() methods as to be able to figure out some blockers i have moving foreward
//you and i will get it  team work makes the dream work!  
//oh dont you start with that cheesey teamwork lines now lol
//will do, see ya tomorrow!
//yup. are you heading out now?
//will be on and off for the next few hours
// ok, well i think i need to do some specific whiteboarding for the menu... so I think ill log off now and do that. just make sure to add and commit to github periodically here.

//perfect ill do the same and compare notes tomorrow
//sounds good. catch you tomorrow.

}
