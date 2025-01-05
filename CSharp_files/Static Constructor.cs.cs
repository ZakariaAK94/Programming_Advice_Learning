using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructorExamples
{
    static class Settings
    {
        public static int DayNumber
        {
            get
            {
                return DateTime.Today.Day;
            }
        }

        public static string DayName
        {
            get
            {
                return DateTime.Today.DayOfWeek.ToString();
            }
        }

        public static string ProjectPath
        {
            get;
            set;            
        }

        static Settings()
        {
            //this is a static constructor will be called once during the program
            ProjectPath = @"B:\Download.";
        }
    }

    class clsPerson
    {
        public clsPerson()
        {
            Console.WriteLine("Constructor called.");
        }

        ~clsPerson()
        {
            Console.WriteLine("Constructor called.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // You cannot create an object here because class is static
            // Settings Obj1 = new Settings();

            //
            // Read the static properties.
            //
            Console.WriteLine("The number of Day : {0}.",Settings.DayNumber);
            Console.WriteLine("The name of Day : {0}.",Settings.DayName);
            //
            // Change the value of the static bool property.
            //
            Console.WriteLine("The ProjectPath is : {0}.",Settings.ProjectPath);

            Settings.ProjectPath = @"A:\ZakariaAKI\managers.";

            Console.WriteLine("The new ProjectPath is : {0}.", Settings.ProjectPath);

            clsPerson person1 = new clsPerson();
            clsPerson person2 = new clsPerson();

            Console.ReadKey();
        }
    }
}
