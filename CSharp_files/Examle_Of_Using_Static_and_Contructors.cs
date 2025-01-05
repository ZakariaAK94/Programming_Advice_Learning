using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationOfUsingStaticAndConstructors
{
    class clsPerson
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }

        public clsPerson(int ID, string Name, int Age)
        {
            this.Id = ID;
            this.Name = Name;   
            this.Age = Age;
        }

        public static clsPerson Find(int ID)
        {
            if (ID == 10)
                return new clsPerson(10, "Zakaria AKIL", 29);
            else
                return null;
        }

        public static clsPerson Find(string UserName, string Password)
        {
            if (UserName == "user1" &&  Password == "P156" )
                return new clsPerson(10, "Zakaria AKIL", 29);
            else
                return null;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //clsPerson Person1 = new clsPerson(10,"Zakaria AKIL",29);
            //Console.WriteLine("My Name is {0}, I am {1} and My Id is {2} ",Person1.Name,Person1.Age,Person1.Id);

            clsPerson Person2 = clsPerson.Find(11);
            Console.WriteLine("ID = {0}", Person2.Id);
            if (Person2 != null)    
            {
                Console.WriteLine("ID = {0}", Person2.Id);
                Console.WriteLine("Name = {0}", Person2.Name);
                Console.WriteLine("Age = {0}", Person2.Age);
            }
            else
                Console.WriteLine("Could not find the person by the given ID");

            clsPerson Person3 = clsPerson.Find("user1","P1560");
            if (Person3 != null)
            {
                Console.WriteLine("ID = {0}", Person3.Id);
                Console.WriteLine("Name = {0}", Person3.Name);
                Console.WriteLine("Age = {0}", Person3.Age);
            }
            else
                Console.WriteLine("Could not find the person by the given ID");


            Console.ReadKey();
       
        }
    }
}
