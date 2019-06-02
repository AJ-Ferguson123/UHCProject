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

        public Nurse(string name, int employeeNumber, int numberOfPatients) : base(name, employeeNumber)
        {
            EmployeeType = "Nurse";
            Salary = 50000;
            NumberOfPatients = 5;
        }
                          
        public override void PaySalary()
        {
            if (BeenPaid == false)
            {
                Console.WriteLine($"{this.Name} has been paid $50000");
                BeenPaid = true;
            }
            else
            {
                Console.WriteLine($"{this.Name} has already been paid");
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Employee Info:");
            Console.WriteLine($"Name:{this.Name}/n" +
                $"Employee Number:{this.EmployeeNumber}/n" +
                $"Profession:{this.EmployeeType}/n" +
                $"Salary:{this.Salary}/n" +
                $"Been paid?:{this.BeenPaid}/n" +
                $"Number of Patients:{this.NumberOfPatients}");
            Console.WriteLine("");
        }
        //public void InteractNurse()
        //{
        //    bool interacting = true;
        //    string interact = "";
        //    do
        //    {
        //        Console.WriteLine("You are interacting with " + Name + ". Press any key to continue.");
        //        Console.ReadLine();
        //        Console.Clear();
        //        Console.WriteLine("Interact Menu");                    
        //        Console.WriteLine(" 1 = DrawBlood:\n 2 = AffectHealth:\n");                   
        //        interact = Console.ReadLine();
        //        switch (interact)
        //        {
        //            case "1":
        //                DrawBlood();
        //                break;
        //            case "2":
        //                HealthLevel();
        //                break;                        
        //            case "3":

        //                interacting = false;
        //                break;
        //        }
        //    }
        //    while (interacting);


        //}


    }
}
