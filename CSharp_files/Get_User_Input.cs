using System;

namespace GetUserInputPRAdviceCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type your user name
            Console.WriteLine("Enter your name ?");

            string userName = Console.ReadLine();

            Console.WriteLine("UserName: "+userName);

            // user input with ReadLine method

            Console.WriteLine("Please enter your Age?");
            //if you dont convert you will get error, and if you enter string you will get error
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Age is: " + Age);
            
            Console.ReadKey();
        }
    }
}
