using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndAbstractMethod
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void introduce();

        public void SayGoodbye()
        {
            Console.WriteLine("GoodBye!");
        }
    }

    public class Employee : Person
    {
        public int EmployeeID { get; set; }
        public decimal Salary { get; set; }

        public override void introduce()
        {
            Console.WriteLine($"My full name is {FirstName} {LastName}, and my EmployeeID is {EmployeeID} and my salary is {Salary:C}.");
        }
    }
        
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employ1 = new Employee();

            employ1.FirstName = "Zakaria";
            employ1.LastName = "AKIL";
            employ1.Salary = 5026.79m;
            employ1.EmployeeID = 156;
            employ1.introduce();

            Console.ReadKey();

        }
    }
}
