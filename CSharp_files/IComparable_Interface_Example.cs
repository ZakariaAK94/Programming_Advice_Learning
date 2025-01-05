using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableInterfaceExample
{

    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(Person other)
        {
            if(other == null) return 1;
            return this.Age.CompareTo(other.Age);
        }
        public override string ToString()
        {
            return $" Name: {this.Name} -- Age:{this.Age} ";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {

            List<Person> list = new List<Person>
            {
                new Person("Zakaria",30),
                new Person("Otmane",28),
                new Person("Amal",49)
            };

            list.Sort();// it is based on the CompareTo function in the class Person.
            Console.WriteLine("The list Information:\n");
            foreach(var p in list)
            {
                Console.WriteLine(p.ToString());
            }

            Console.ReadKey();

        }
    }
}
