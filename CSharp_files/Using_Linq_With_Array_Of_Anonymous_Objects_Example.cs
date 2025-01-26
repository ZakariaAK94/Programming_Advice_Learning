using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingLinqWithArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Zakaria", "Amal", "Otmane", "Ana", "Reda" };

            Console.WriteLine("\n****************** First Example ***********************\n");
            var GetNames = names.Where(x => x.StartsWith("A") && x.Length >= 3);
            foreach (var name in GetNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\n****************** Second Example ***********************\n");
            // Advanced Linq Operations on Arrays

            var people = new[]
            {
                new {Name="Karim",Age=23},
                new {Name="Reda",Age=23},
                new {Name="Zakaria",Age=30},
                new {Name="Amal",Age=30},
                new {Name="Otmane",Age=28}
            };

            var PeopleGroupByAge = people.GroupBy(x => x.Age)
                                   .Select(g => new
                                   {
                                       Age = g.Key,
                                       People = g.OrderBy(x => x.Name)
                                   });

            foreach(var group in PeopleGroupByAge)
            {
                Console.WriteLine("Age group:" + group.Age);
                foreach(var person in group.People)
                {
                    Console.WriteLine("\t- " + person.Name);
                }
            }

            Console.WriteLine("\n****************** Third Example ***********************\n");
            var Students = new[]
            {
                new {ID =1,Name ="Zakaria", Field ="Math"},
                new {ID =2,Name ="Oussam", Field ="IT"},
                new {ID =3,Name ="Otmane", Field ="Math"},
                new {ID =4,Name ="Reda",   Field ="IT"},
                new {ID =5,Name ="Zineb",   Field ="HR"},
            };


            var StudentsGroupByField = Students.GroupBy(x => x.Field)
                                               .Select(g => new
                                               {
                                                   Field = g.Key,
                                                   students = g.OrderBy(x=>x.Name)
                                               });

            foreach(var group in StudentsGroupByField)
            {
                Console.WriteLine("Field group: " + group.Field);
                foreach(var student in group.students)
                {
                    Console.WriteLine("\t- " + student.Name);
                }
            }
                     


            Console.ReadLine();
        }
    }
}
