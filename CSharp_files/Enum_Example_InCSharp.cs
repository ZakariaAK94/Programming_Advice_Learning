﻿
//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud

using System;

namespace Main
{
    internal class Program
    {

        enum enWeekDays
        {
            Monday,     // 0
            Tuesday,    // 1
            Wednesday,  // 2
            Thursday,   // 3
            Friday=4,     // 4
            Saturday,   // 5
            Sunday      // 6
        }

        //if you set a value , it will auto number everything after it.
        enum enCategories
        {
            Electronics,    // 0
            Food,           // 1
            Automotive = 6, // 6
            Arts,           // 7
            BeautyCare,     // 8
            Fashion         // 9
        }

        enum enJobs
        {
            Doctor = 10,
            Developper =20,
            Teacher = 30,
            Coach = 40
        }


        //Enum can have any numarical data type byte, sbyte, short, ushort, int, uint, long, or ulong
        //but not string

        enum enCategories2 : byte
        {
            Electronics = 1,
            Food = 5,
            Automotive = 6,
            Arts = 10,
            BeautyCare = 11,
            Fashion = 15
        }


        static void Main(string[] args)
        {

            enWeekDays WeekDays;

            enJobs eJob;

            eJob = enJobs.Developper;

            Nullable<int> Age = null;
            WeekDays = enWeekDays.Friday;

            Console.WriteLine(WeekDays.Equals(enWeekDays.Friday));
            Console.WriteLine("I will be the best {0} in the world!",eJob);

            Console.ReadKey();
        }
    }
}

