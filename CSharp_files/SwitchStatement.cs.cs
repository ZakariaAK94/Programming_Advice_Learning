using System;

namespace SwitchStatementCSharpPRAdvice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char Letter;
            Console.WriteLine("Please enter a Letter ?");
            Letter = Convert.ToChar(Console.ReadLine());

            switch(Char.ToLower(Letter))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("{0} is a Vowel", Letter);
                    break;
                default:
                    Console.WriteLine("{0} is not a Vowel", Letter);
                    break;
            }

            Console.ReadKey();
        }
    }
}
