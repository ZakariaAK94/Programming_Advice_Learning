#pragma once
#include<iostream>
#include<string>
using namespace std;

struct stDate1
{
    short Days;
    short Month;
    short Year;
};

namespace myFunctions {

    bool isLeapYear(short Year)
    {
        return (Year % 400 == 0) || (Year % 4 == 0) && (Year % 10 != 0);

    }

    bool IsDate1BeforeDate2(stDate1 Date1, stDate1 Date2)
    {
        return (Date1.Year < Date2.Year ? true : ((Date1.Year ==
            Date2.Year) ? (Date1.Month < Date2.Month ? true : (Date1.Month ==
                Date2.Month ? Date1.Days < Date2.Days : false)) : false));
    }

    short NumberOfDaysInAMonth(short Month, short Year)
    {

        if (Month < 1 || Month>12)
            return  0;
        int days[12] = { 31,28,31,30,31,30,31,31,30,31,30,31 };
        return (Month == 2) ? (isLeapYear(Year) ? 29 : 28) : days[Month - 1];

    }

    bool IsLastDayInMonth(stDate1 Date)
    {
        return (Date.Days == NumberOfDaysInAMonth(Date.Month, Date.Year));
    }
    bool IsLastMonthInYear(short Month)
    {
        return (Month == 12);
    }

    stDate1 IncreaseDateByOneDay(stDate1 Date1)
    {
        if (IsLastDayInMonth(Date1))
        {
            if (IsLastMonthInYear(Date1.Month))
            {
                Date1.Month = 1; Date1.Days = 1; Date1.Year++;
            }
            else
            {
                Date1.Days = 1; Date1.Month++;
            }
        }
        else
        {
            Date1.Days++;
        }
        return Date1;
    }

    stDate1 IncreaseDateByXDays(stDate1& Date, int XDays)
    {
        while (XDays > 0)
        {
            IncreaseDateByOneDay(Date);
            XDays--;
        }
        return Date;
    }

    void  SwapDates(stDate1& Date1, stDate1& Date2)
    {
        stDate1 TempDate;
        TempDate.Year = Date1.Year;
        TempDate.Month = Date1.Month;
        TempDate.Days = Date1.Days;

        Date1.Year = Date2.Year;
        Date1.Month = Date2.Month;
        Date1.Days = Date2.Days;

        Date2.Year = TempDate.Year;
        Date2.Month = TempDate.Month;
        Date2.Days = TempDate.Days;
    }


    short GetDifferenceInDays(stDate1 Date2, stDate1 Date1, bool IncludeEndDay = false)
    {
        short Days = 0;
        short SwapFlagValue = 1;

        if (IsDate1BeforeDate2(Date1, Date2))
        {
            while (IsDate1BeforeDate2(Date1, Date2))
            {
                Days++;
                Date1 = IncreaseDateByOneDay(Date1);
            }
        }
        else
        {
            while (IsDate1BeforeDate2(Date2, Date1))
            {
                Days++;
                Date2 = IncreaseDateByOneDay(Date2);
            }
            SwapFlagValue = -1;
        }


        return IncludeEndDay ? ++Days * SwapFlagValue : Days * SwapFlagValue;

    }
}

