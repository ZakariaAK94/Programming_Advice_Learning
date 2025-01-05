using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_levelInheritanceExample
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is {Name} and I'm {Age} years old");
        }
    }

    public class Employee : Person
    {
        public int EmployeeID { get; set; }
        public decimal Salary { get; set; }

        public void Work()
        {
            Console.WriteLine($"Employee with ID {EmployeeID} and salary {Salary:c} is working.");
        }
    }

    // example of hierarchal inheritance 

    public class User : Person
    {
        public string Password { get; set; }
        public string UserName { get; set; }
        public int Permission { get; set; }

        public void Info()
        {
            Console.WriteLine($"User: {UserName} and Passwor: {Password}.");
        }
    }

    // Example of Multi level inheritance
    public class Doctor : Employee
    {
        public string Speciality { get; set; }
        
        public void Heal()
        {
            Console.WriteLine($"Doctor {Name},with ID {EmployeeID}, salary {Salary:C},and Speciality {Speciality} is healing a patient.");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor();
            doctor1.Salary = 5060.29m;
            doctor1.Name = "Zakaria";
            doctor1.Age = 29;
            doctor1.Speciality = "Cariology";
            doctor1.EmployeeID = 156;
            doctor1.Introduce();
            doctor1.Work();
            doctor1.Heal();

            Employee Employee1 = new Employee();
            Employee1.Name = "John";
            Employee1.Age = 35;
            Employee1.EmployeeID = 123;
            Employee1.Salary = 100000.00m;
            Console.WriteLine("\nEmployee:");
            Employee1.Introduce(); // Output: "Hi, my name is John and I'm 35 years old."
            Employee1.Work(); // Output: "Employee with ID 123 and salary $100,000.00 is working."

            User User1 = new User();
            //these information came from Person class
            User1.Name = "Ali";
            User1.Age = 45;
            //these information came from User Class
            User1.UserName = "User1";
            User1.Password = "1234";


            Console.WriteLine("\nUser:");
            User1.Introduce(); // Output: "Hi, my name is John and I'm 35 years old."
            User1.Info(); //Output: "User: User1 and Password 1234 ."

            Console.ReadKey();
        }
    }
}
