using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfConstructors
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Age = 29;
            Name = "Zakaria AKIL";
            Id = 056;
        }
    }

    public class CalculateRectangleSurface
    {
        private int _Length;
        private int _Width;
        public int Surface;

        public CalculateRectangleSurface(int Length, int Width)
        {
            _Length = Length;   
            _Width = Width;
            Surface = _Length * _Width;
        }
    }






    internal class Program
    {
        static void Main(string[] args)
        {
            Person Person1 = new Person();

            Console.WriteLine("my Name is : {0}, I am {1} and My ID is {2}  ",Person1.Name,Person1.Age,Person1.Id);

            CalculateRectangleSurface rectangleSurface1 = new CalculateRectangleSurface(15,10);

            Console.WriteLine("the Surface is : {0}", rectangleSurface1.Surface);

            

            Console.ReadLine();
        }
    }
}
