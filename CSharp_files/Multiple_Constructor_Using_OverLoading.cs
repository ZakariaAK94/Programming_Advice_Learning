using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleConstructorUsingOverLoading
{
    public class MyClass
    {
        private int _value1;
        private String _value2;

        // Constructor with no parameters
        public MyClass()
        {
            _value1 = 0;
            _value2 = "Default";
        }

        // Constructor with one parameter
        public MyClass(int v1)
        {
            _value1 = v1;
            _value2 = "Default";
        }

        // Constructor with two parameters
        public MyClass(int v1, String v2)
        {
            _value1 = v1;
            _value2 = v2;
        }

        public void display()
        {
            Console.WriteLine("Value1 is : {0} ",_value1);
            Console.WriteLine("Value2 is : {0} ",_value2);
        }
    }

    class clsPerson
    {
        public int ID { get; set; }
        public string Name { get; set; }   
        public int Age { get; set; }    

        public clsPerson() 
        {
            this.ID = -1;
            this.Name = "Empty";
            this.Age = 0;
        }

        public clsPerson(int ID, string Name, int Age)
        {
            this.ID = ID;
            this.Name = Name;
            this.Age = Age;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj1 = new MyClass(); // Calls the no-argument constructor
            MyClass obj2 = new MyClass(42); // Calls the constructor with one parameter
            MyClass obj3 = new MyClass(24, "Custom"); // Calls the constructor with two parameters

            obj1.display();
            obj2.display();
            obj3.display();


            clsPerson Person4 = new clsPerson();
            clsPerson Person5 = new clsPerson(10,"Zakaria AKIL",29);

            Console.WriteLine("Person4 information are : ID = {0}, Name ={1} and Age ={2}",Person4.ID,Person4.Name,Person4.Age);
            Console.WriteLine("Person5 information are : ID = {0}, Name ={1} and Age ={2}",Person5.ID,Person5.Name,Person5.Age);


            Console.ReadLine();
        }
    }
}
