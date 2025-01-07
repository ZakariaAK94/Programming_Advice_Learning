using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADelegate
{
    public class Report
    {
        public delegate bool IsIligibale(float TotalSales);
        public void ProcessEmployee(Employee[] employee,string Title, IsIligibale isIligibale)
        {
            Console.WriteLine(Title);
            Console.WriteLine("------------------------------");
            Console.WriteLine($" ID |  Name | Gender |  TotalSales |");
            foreach (var emp in employee)
            {
                if (isIligibale(emp.TotalSales))
                {
                    Console.WriteLine($" {emp.ID}  | {emp.Name} |   {emp.Gendor}    | ${emp.TotalSales}      |");
                }
            }
            Console.WriteLine("\n\n");
        }      




    }
}
