using System;

namespace AutoImplementedProperties
{
    class clsEmployee
    {
        // ID property
        public int ID
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
    }  

    internal class Program
    {
        static void Main(string[] args)
        {
            //create an object of employee class
            clsEmployee employee1 = new clsEmployee();
            employee1.ID = 1;
            employee1.Name = "Mohammed";

            Console.WriteLine("employee1 ID = {0} ",employee1.ID);
            Console.WriteLine("employee1 Name ={0} ",employee1.Name);

            Console.ReadLine();
        }
    }
}
