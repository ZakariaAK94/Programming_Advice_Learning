using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptOfInheritance
{
    public class clsPerson
    {
        public clsPerson(int Id, string FirstName, string LastName)
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.Id = Id;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       

        public string FullName
        {
            //Get is use for Reading field
            get
            {
                return FirstName + ' ' + LastName;
            }
        }

        public void introduce()
        {
            Console.WriteLine($"My id is {Id} and my name is {FullName}");
        }

    }

    public class clsEmployee:clsPerson
    {
        public clsEmployee(int Id, string FirstName, string LastName, string DepartementName, float Salary)
            :base(Id,FirstName,LastName)
        {
            this.DepartementName = DepartementName;
            this.Salary = Salary;
        }
        public string DepartementName { get; set; }
        public float Salary { get; set; }
        public void IncreaseSalaryBy(float Amount)
        {
            Salary+= Amount;
        }
        public void Profile()
        {
            Console.WriteLine($"I work in the departement {DepartementName} with a salary equal a {Salary} ");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmployee employee = new clsEmployee(12,"Zakaria","AKIL","Engineering",500);
            //employee.Id = 10;
            //employee.FirstName = "Zakaria";
            employee.introduce();
            //employee.Salary = 800;
            //employee.DepartementName = "Engineering";
            employee.Profile();
            employee.IncreaseSalaryBy(100);
            Console.WriteLine("Salary after increase := {0}", employee.Salary);

            Console.ReadKey();
        }
    }
}
