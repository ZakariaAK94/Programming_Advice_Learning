using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpCastingAndDownCastingExamples
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    public class Dog : Animal
    {
        // this class inherite the function Eat form the base class
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Upcasting: Converting a Dog object to an Animal object
            Dog myDog = new Dog();
            Animal myAnimal = myDog; // Upcasting

            myAnimal.Eat();  // Output: Animal is eating.
                             // myAnimal.Bark(); // Error: Animal class doesn't have Bark method

            Animal mySecondAnimal = new Dog();
            // Downcasting: Converting an Animal object to a Dog object
            if(mySecondAnimal is Dog)
            {
                Dog dog2 = (Dog)mySecondAnimal;
                dog2.Bark();
            }
            else
            {
                Console.WriteLine("Convert to Dog is not possible.");
            }
           
            Console.ReadKey();
        }
    }

   
}
