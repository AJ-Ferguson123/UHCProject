using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
    public class Doctor : Employee
    {
        public string Specialty;
        public int NumberOfPatients;
        public int Health;
        public int Blood;


        public Doctor(string name, int employeeNumber, string specialty) : base(name, employeeNumber)
        {
            EmployeeType = "Doctor";
            Specialty = specialty;
            Salary = 90000;
        }


        public override void PaySalary()
        {
            if (BeenPaid == false)
            {
                Console.WriteLine($"You have been paid {this.Name} $50000");
                BeenPaid = true;
            }
            else
            {
                Console.WriteLine($"{this.Name} has already been paid");
            }
        }

        public void InteractDoctor()
        {
            bool interacting = true;
            string interact = "";
            //do
            //{
            //    Console.WriteLine("You are interacting with " + Name + ". Press any key to continue.");
            //    Console.ReadLine();
            //    Console.Clear();
            //    Console.WriteLine("Interact Menu");
            //    Console.WriteLine(" 1 = DrawBlood:\n 2 = AffectHealth:\n");
            //    interact = Console.ReadLine();
            //    switch (interact)
            //    {
            //        case "1":
            //            //DrawBlood();
            //            break;
            //        case "2":
            //            //HealthLevel();
            //            break;
            //        case "3":

            //            interacting = false;
            //            break;
            //    }
        }
            
            ////while (interacting)

        //public override void //PaySalary()
        //{
        //    if (BeenPaid == false)
        //    {
        //        Console.WriteLine($"You have been paid {Doctor.Name} $50000");
        //        BeenPaid = true;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{Doctor} has already been paid");
        //    }

        //}
    }
}
