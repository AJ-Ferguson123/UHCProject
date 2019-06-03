using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
    public class Doctor : Employee
    {
        public string Specialty;
        
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
                Console.WriteLine($"{this.Name} has been paid $90000");
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
            Console.WriteLine($"Name:{this.Name}\n" +
                $"Employee Number:{this.EmployeeNumber}\n" +
                $"Profession:{this.EmployeeType}\n" +
                $"Specialty:{this.Specialty}\n" +
                $"Salary:{this.Salary}\n" +
                $"Been paid?:{this.BeenPaid}");
            Console.WriteLine("");
        }

        //public void InteractDoctor()
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
        //                //DrawBlood();
        //                break;
        //            case "2":
        //                //HealthLevel();
        //                break;
        //            case "3":

        //                interacting = false;
        //                break;
        //        }
        //    }

        //    while (interacting)

        //     public override void //PaySalary()
        //    {
        //    if (BeenPaid == false)
        //    {
        //        Console.WriteLine($"You have been paid {Doctor.Name} $50000");
        //        BeenPaid = true;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{Doctor} has already been paid");
        //    }

    }
}

