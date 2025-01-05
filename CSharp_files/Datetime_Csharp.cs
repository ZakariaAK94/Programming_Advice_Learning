using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeInCsharpPRAdvice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////assigns default value 01/01/0001 00:00:00
            //DateTime dt1 = new DateTime();

            ////assigns year, month, day
            //DateTime dt2 = new DateTime(2023, 8,6);

            ////assigns year, month, day, hour, min, seconds
            //DateTime dt3 = new DateTime(2023, 8, 6, 13, 43, 20);

            ////assigns year, month, day, hour, min, seconds, UTC timezone
            //DateTime dt4 = new DateTime(2023, 8, 6, 13, 43, 20, DateTimeKind.Utc);

            //Console.WriteLine(dt1);
            //Console.WriteLine(dt2);
            //Console.WriteLine(dt3);
            //Console.WriteLine(dt4);

            ////assigns default value 01/01/0001 00:00:00
            //DateTime dt = new DateTime();

            //dt = DateTime.Now;
            //Console.WriteLine(dt);

            ////number of 100-nanosecond intervals that have elapsed
            ////since January 1, 0001, at 00:00:00.000 in the Gregorian calendar. 

            //DateTime dt12 = new DateTime();
            //Console.WriteLine(DateTime.MinValue.Ticks);  //min value of ticks
            //Console.WriteLine(DateTime.MaxValue.Ticks); // max value of ticks
            //Console.WriteLine(DateTime.Now.Ticks); // max value of ticks

           // DateTime Static Fields

            DateTime currentDateTime = DateTime.Now;  //returns current date and time
            DateTime todaysDate = DateTime.Today; // returns today's date
            DateTime currentDateTimeUTC = DateTime.UtcNow;// returns current UTC date and time
            DateTime maxDateTimeValue = DateTime.MaxValue; // returns max value of DateTime
            DateTime minDateTimeValue = DateTime.MinValue; // returns min value of DateTime

            Console.WriteLine("currentDateTime: " + currentDateTime);
            Console.WriteLine("Today: " + todaysDate);
            Console.WriteLine("currentDateTimeUTC: " + currentDateTimeUTC);
            Console.WriteLine("minDateTimeValue: " + minDateTimeValue);
            Console.WriteLine("maxDateTimeValue: " + maxDateTimeValue);

            Console.ReadKey();
        }
    }
}
