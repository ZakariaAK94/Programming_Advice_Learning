using CADelegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var Employees = new Employee[]
            {
                new Employee() {ID=1,Name ="Zaki1",TotalSales=10000F,Gendor ='M'},
                new Employee() {ID=2,Name ="Zaki2",TotalSales=30000F,Gendor ='F'},
                new Employee() {ID=3,Name ="Zaki3",TotalSales=20000F,Gendor ='F'},
                new Employee() {ID=4,Name ="Zaki4",TotalSales=40000F,Gendor ='M'},
                new Employee() {ID=5,Name ="Zaki5",TotalSales=50000F,Gendor ='M'},
                new Employee() {ID=6,Name ="Zaki6",TotalSales=610000F,Gendor ='F'},
                new Employee() {ID=7,Name ="Zaki7",TotalSales=65000F,Gendor ='M'},
            };

            var report = new Report();    

            report.ProcessEmployee(Employees, "Commercials with Totalsales more or egal to 60000$ :",  TotalSales => TotalSales >= 60000F);
            report.ProcessEmployee(Employees, "Commercials with Totalsales between 60000$ and 30000$ :", TotalSales => TotalSales >= 30000F && TotalSales < 60000F);
            report.ProcessEmployee(Employees, "Commercials with Totalsales less than 30000$ :", TotalSales => TotalSales < 30000F);

            
            Console.ReadLine();
        }

     

    }
}

