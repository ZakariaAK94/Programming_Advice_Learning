using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureInCsharpPRAdvice
{
    internal class Program
    {


        struct stStudent
        {
            public string FirstName;
            public string LastName;
        }


        static void Main(string[] args)
        {
            // A struct object can be created with or without the new operator 
            // same as primitive  type variables 

            stStudent Student;
            stStudent Student2 = new stStudent();

            Student.FirstName = "Zakaria";
            Student.LastName = "AKIL";

            Console.WriteLine(Student.FirstName);
            Console.WriteLine(Student.LastName);

            Student2.FirstName = "Otmane";
            Student2.LastName = "AKIL";

            Console.WriteLine(Student2.FirstName);
            Console.WriteLine(Student2.LastName);

            Console.ReadKey();

        }
    }
}
