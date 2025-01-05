using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesSetAndGet
{
    class clsEmployee
    {
        private int _Id;
        private string _Name = string.Empty;
        private int _Age = 20;
        //Id property declaration
        public int Id
        {
            //Get  is use for Reading a field
            get { return _Id; }
            //Set is use for Writing a field
            set { _Id = value; }
        }
        // Name property declaration
        public string Name
        {
            //Get is use for Reading a field
            get { return _Name; }  
            // Get is use for Writing a field
            set { _Name = value; }
        }

        public int Age
        {
            get { return _Age; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmployee employee = new clsEmployee();
            employee.Name = "Zakaria AKIL";
            employee.Id = 100;
            Console.WriteLine("employee ID: = {0}",employee.Name);
            Console.WriteLine("Employee Name: ={0}",employee.Id); 
            Console.WriteLine("Employee Age: ={0}",employee.Age); 
            Console.ReadLine();
        }
    }
}
