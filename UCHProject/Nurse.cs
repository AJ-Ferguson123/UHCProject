using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
   public class Nurse : Employee
    {
        public string Specialty;
        public int NumberOfPatients {get; set; }
        public int Health { get; set; }
        public int Blood { get; set; }

        public Nurse(string name, int employeeNumber) : base(name, employeeNumber, employeeType)
        {
            EmployeeType = "Nurse";
            Specialty = Specialty;
            Salary = 50000;
            NumberOfPatients = 0;
        }
       

        public override void PaySalary()
        {
            if (BeenPaid == false)
        {
            Console.WriteLine($"You have been paid {Employee} $50000");
                BeenPaid = true;
        }
            else
            {
                Console.WriteLine($"{Employee} has already been paid");
            }

            public void InteractNurse()
            {
                bool interacting = true;
                string interact = "";
                do
                {
                    Console.WriteLine("You are interacting with " + Name + ". Press any key to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Interact Menu");                    
                    Console.WriteLine(" 1 = DrawBlood:\n 2 = AffectHealth:\n");                   
                    interact = Console.ReadLine();
                    switch (interact)
                    {
                        case "1":
                            DrawBlood();
                            break;
                        case "2":
                            HealthLevel();
                            break;                        
                        case "3":

                            interacting = false;
                            break;
                    }
                }
                while (interacting);


            }


    }
}
