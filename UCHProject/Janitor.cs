using System;
using System.Collections.Generic;
using System.Text;

namespace UCHProject
{
    public class Janitor : Employee
    {
        public bool AreTheySweeping;

        public Janitor(string name, int employeeNumber, Hospital hospital) : base(name, employeeNumber, hospital)
        {
            EmployeeType = "Janitor";
            Salary = 40000;
            AreTheySweeping = false;
        }

        public void StartSweeping()
        {
            this.AreTheySweeping = true;
        }

        public void StopSweeping()
        {
            this.AreTheySweeping = false;
        }

        public override void PaySalary()
        {
            if (BeenPaid == false)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{this.Name} has been paid $40000");
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

        public override void InteractJanitor()
        {

            bool interacting = true;
            do
            {
                Console.Clear();
                Console.WriteLine($"You are interacting with {this.Name}.");
                Console.WriteLine("");
                Console.WriteLine("Interact Menu");
                Console.WriteLine(" 1 = Start sweeping floors\n 2 = Stop sweeping floors\n 3 = Return to above menu");
                string interactJanitorInput = Console.ReadLine();
                switch (interactJanitorInput)
                {
                    case "1":
                        Console.WriteLine($"{this.Name} Has started sweeping the floors.");
                        StartSweeping();
                        break;
                    case "2":
                        Console.WriteLine($"{this.Name} Has stopped sweeping the floors.");
                        StopSweeping();
                        break;
                    case "3":
                        interacting = false;
                        break;
                }
            } while (interacting);
        }
    }
}