using System;

namespace StringInterpolationCSharpPRAdvice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstName = "Zakaria";
            string LastName = "AKIL";
            string Code = "140";

            string FullName = $"Mr. {FirstName},{LastName}, code :{Code}";

            Console.WriteLine(FullName);

            Console.ReadKey();
        }
    }
}
