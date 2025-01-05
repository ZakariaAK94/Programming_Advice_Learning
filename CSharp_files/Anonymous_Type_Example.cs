using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypeCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new { FirstName = "John", LastName = "Doe", Age = 30 };

            Console.WriteLine($"Name: {employee.FirstName} {employee.LastName}, Age: {employee.Age}");
            Console.WriteLine(employee);

            var Student = new { FirstName = "Zakaria", LastName = "AKIL", Age = 29 };
            Console.WriteLine($"My name is :{Student.FirstName} {Student.LastName}, I am: {Student.Age}");
            Console.ReadKey();

            var WorkStudent = new
            {
                Id = "AD214686",
                Nationality = "Maroc",
                Student = new { FirstName = "Zakaria", LastName = "AKIL", Age = 29 }
            };

            Console.WriteLine($"My name is : {WorkStudent.Student.FirstName} {WorkStudent.Student.LastName} ,I am :{WorkStudent.Student.Age} ,my id is: {WorkStudent.Id}, I am: {WorkStudent.Nationality}");

            //you dont specify any type here , automatically will be specified
            var student = new { Id = 20, FirstName = "Mohammed", LastName = "Abu-Hadhoud" };

            Console.WriteLine("\nExample1:\n");
            Console.WriteLine(student.Id); //output: 20
            Console.WriteLine(student.FirstName); //output: Mohammed
            Console.WriteLine(student.LastName); //output: Abu-Hadhoud

            //You can print like this:
            Console.WriteLine(student);


            //anonymous types are read-only
            //you cannot change the values of properties as they are read-only.

            // student.Id = 2;//Error: cannot chage value
            // student.FirstName = "Ali";//Error: cannot chage value


            //An anonymous type's property can include another anonymous type.
            var student2 = new
            {
                Id = 20,
                FirstName = "Mohammed",
                LastName = "Abu-Hadhoud",
                Address = new { Id = 1, City = "Amman", Country = "Jordan" }
            };

            Console.WriteLine("\nExample2:\n");
            Console.WriteLine(student2.Id);
            Console.WriteLine(student2.FirstName);
            Console.WriteLine(student2.LastName);

            Console.WriteLine(student2.Address.Id);
            Console.WriteLine(student2.Address.City);
            Console.WriteLine(student2.Address.Country);
            Console.WriteLine(student2.Address);



            Console.ReadKey();

        }
    }
}