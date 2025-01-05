using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithAListOfCustomObjects
{
    internal class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string Name, int Age) 
            {
                this.Name = Name;
                this.Age = Age;
            }
        }
        static void Main(string[] args)
        {
            List<Person> listPeople = new List<Person>
            {
                new Person("Karim",28),
                new Person("Reda",35),
                new Person("Taha",20),
                new Person("Nabil",40),
                new Person("Otmane",19),
                new Person("Oussama",25),
                new Person("Zakaria",30),
            };

            Console.WriteLine("Current state of the people listPeople:");
            listPeople.ForEach(x => Console.WriteLine($"name is {x.Name} and Age :{x.Age}.\n"));

            Person FoundPerson = listPeople.Find(x => x.Name == "Zakaria");
            if( FoundPerson != null )
            {
                Console.WriteLine($"the person is exist, Name {FoundPerson.Name} and Age {FoundPerson.Age}");
            }else
            {

                Console.WriteLine($"Person doesn't exist.");
            }

            Person searchResult = listPeople.FirstOrDefault(x => x.Name == "Otmane");

            if( searchResult != null )
            {
                searchResult.Age = 28;
                Console.WriteLine($"Update Otmane's Age to { searchResult.Age}");
            }

            List<Person> PeopleOver30 = listPeople.FindAll(person => person.Age>=30);
            Console.WriteLine("People over 30's: ");

            foreach (var person in PeopleOver30) 
            { 
                Console.WriteLine($"\nName: {person.Name} and Age : {person.Age}.");
            }

            bool containZakaria = listPeople.Any(x => x.Name == "Otmane");
            Console.WriteLine("list contains a person named 'Zakaria' :" + containZakaria);

            bool ExistsOver40 = listPeople.Exists(x => x.Age >33);
            Console.WriteLine("list contains a person with age greather than 33:" + ExistsOver40);


            listPeople.RemoveAll(p => p.Age < 25);
            Console.WriteLine("\nRemove people under the age of 30:");
            listPeople.ForEach(x => Console.WriteLine($"\nName = {x.Name}, Age ={x.Age}"));


            Console.ReadLine();

        }
    }
}
