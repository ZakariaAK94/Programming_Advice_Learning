using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        void Introduce();
        void Print();
        string To_String();
    }

    public interface ICommunicate
    {
        void CallPhone();
        void SendEmail(string Title, string Body);
        void SendFax(string Title, string Body);
        void SendSMS(string Title, string Body);
    }

    public abstract class Person : IPerson,ICommunicate
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void Introduce();
        public void Print()
        {
            Console.WriteLine("Hi I'm the print method");
        }

        public string To_String()
        {
            return "Hi,this is the complete string... ";
        }
        // extra functions, no one stops you to add as many as functions you want
        public void SayGoodBye()
        {
            Console.WriteLine("Goodbye!");
        }
 
        public void CallPhone()
        {
            Console.WriteLine("Calling phone...");
        }

        public void SendEmail(string Title, string Body)
        {
            Console.WriteLine("Sending email :-).");
        }

        public void SendFax(string Title, string Body)
        {
            Console.WriteLine("Sending Fax...");
        }

        public void SendSMS(string Title, string Body)
        {
            Console.WriteLine("Seding SMS...");
        }


    }

    public class Employee : Person
    {
        public int EmployeeID { get; set; }
        public override void Introduce()
        {
            Console.WriteLine($"Hi,My FullName is {FirstName} {LastName}, and my EmployeeId is {EmployeeID}");
        }
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            // you cannot create an object of an interface, you can only Implement it
            // IPerson Person1 = new IPerson();

            Employee employee1 = new Employee();
            employee1.FirstName = "Zakaria";
            employee1.LastName = "AKIL";
            employee1.EmployeeID = 1243;
            employee1.Introduce(); // Output: "Hi, my name is John Doe, and my employee ID is 123."
            employee1.SayGoodBye(); // Output: "Goodbye!"
            employee1.Print();
            employee1.SendEmail("Hi","Body");
            employee1.SendFax("Hi", "Body");
            employee1.SendSMS("Hi", "Body");
            employee1.CallPhone();
            Console.ReadKey();

        }
    }
}
