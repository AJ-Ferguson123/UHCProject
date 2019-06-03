using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
    public class Receptionist : Employee
    {

        public bool AreTheyOnThePhone;

        public Receptionist(string name, int employeeNumber, Hospital hospital) : base(name, employeeNumber, hospital)
        {
            EmployeeType = "Receptionist";
            Salary = 45000;
            AreTheyOnThePhone = false;
        }

        public void AnsweringPhone()
        {

            this.AreTheyOnThePhone = true;
        }
        public void HangUpPhone()
        {
            this.AreTheyOnThePhone = false;
        }

        public override void PaySalary()
        {
            if (BeenPaid == false)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{this.Name} has been paid $45000");
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
                $"Salary:{this.Salary}\n" +
                $"Been paid?:{this.BeenPaid}");
            Console.WriteLine("");
        }

        public override void InteractReceptionist()
        {

            bool interacting = true;
            do
            {
                Console.Clear();
                Console.WriteLine($"You are interacting with {this.Name}.");
                Console.WriteLine("");
                Console.WriteLine("Interact Menu");
                Console.WriteLine(" 1 = Start answering phones\n 2 = Stop answering phones\n 3 = Return to above menu");
                string interactReceptionistInput = Console.ReadLine();
                switch (interactReceptionistInput)
                {
                    case "1":
                        Console.WriteLine($"{this.Name} Has started answering phone calls.");
                        AnsweringPhone();
                        break;
                    case "2":
                        Console.WriteLine($"{this.Name} Has stopped answering phone calls.");
                        HangUpPhone();
                        break;
                    case "3":
                        interacting = false;
                        break;
                }
            } while (interacting);
        }
    }
}
