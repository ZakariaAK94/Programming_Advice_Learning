using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsCSharPRAdvice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S1 = "I will be the best programmer";
            Console.WriteLine(S1.Length);

            //this is will take five characters starting position 2

        Console.WriteLine(S1.Substring(2,5));
        Console.WriteLine(S1.ToLower());
        Console.WriteLine(S1.ToUpper());
        Console.WriteLine(S1[2]);
        Console.WriteLine(S1.Insert(3, "KKKK"));
        Console.WriteLine(S1.Replace("m", "*"));
        Console.WriteLine(S1.IndexOf("m"));
        Console.WriteLine(S1.Contains("m"));
        Console.WriteLine(S1.Contains("x"));
        Console.WriteLine(S1.LastIndexOf("m"));

        string S2 = "Ali,Ahmed,Khalid";

        string[] NamesList = S2.Split(',');

        Console.WriteLine(NamesList[0]);
        Console.WriteLine(NamesList[1]);
        Console.WriteLine(NamesList[2]);

        string S3 = "  Abu-Hadhoud  ";
        Console.WriteLine(S3.Trim());
        Console.WriteLine(S3.TrimStart());
        Console.WriteLine(S3.TrimEnd());

        Console.ReadKey();

        }
    }
}
