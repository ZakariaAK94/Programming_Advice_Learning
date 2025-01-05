using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchStatementExampleCSharpPRAdvice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] MyTable = new int[4];
                Random rnd = new Random();
                for(int i = 0; i < MyTable.Length; i++)
                    MyTable[i] = rnd.Next(10,50);
                foreach(int i in MyTable)
                    Console.WriteLine(i);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }

            Console.ReadKey();
        }
    }
}
