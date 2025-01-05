#pragma warning(disable : 4996)

#include <iostream>
#include <ctime>
using namespace std;

struct stDate
{
    short Days;
    short Month;
    short Year;
};

bool isLeapYear(short Year)
{
    return (Year % 400 == 0) || (Year % 4 == 0) && (Year % 10 != 0);

}

bool IsDate1BeforeDate2(stDate Date1, stDate Date2)
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

bool IsLastDayInMonth(stDate Date)
{
    return (Date.Days == NumberOfDaysInAMonth(Date.Month, Date.Year));
}
bool IsLastMonthInYear(short Month)
{
    return (Month == 12);
}

stDate IncreaseDateByOneDay(stDate Date)
{
    if (IsLastDayInMonth(Date))
    {
        if (IsLastMonthInYear(Date.Month))
        {
            Date.Month = 1; Date.Days = 1; Date.Year++;
        }
        else
        {
            Date.Days = 1; Date.Month++;
        }
    }
    else
    {
        Date.Days++;
    }
    return Date;
}

void  SwapDates(stDate& Date1, stDate& Date2)
{
    stDate TempDate;
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

/*Teacher solution*/
//int GetDifferenceInDays(stDate Date1, stDate Date2, bool IncludeEndDay = false)
//{
//    int Days = 0; 
//    short SawpFlagValue = 1;
//    if (!IsDate1BeforeDate2(Date1, Date2))
//    { 
//        //Swap Dates
//        SwapDates(Date1, Date2);        
//        SawpFlagValue = -1;   
//    }
//    while (IsDate1BeforeDate2(Date1, Date2)) 
//    {      
//        Days++; 
//        Date1 = IncreaseDateByOneDay(Date1);
//    } 
//    return IncludeEndDay ? ++Days * SawpFlagValue : Days * SawpFlagValue;
//}
/* My solution*/
short GetDifferenceInDays(stDate Date2, stDate Date1, bool IncludeEndDay = false)
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

stDate ReadDataFromUser(string Message)
{
    stDate DateBeforeAddingDays;
    cout << Message;
    cout << "\nPlease enter a Day ? ";
    cin >> DateBeforeAddingDays.Days;
    cout << "\nPlease enter a Month ? ";
    cin >> DateBeforeAddingDays.Month;
    cout << "\nPlease enter a Year ? ";
    cin >> DateBeforeAddingDays.Year;


    return DateBeforeAddingDays;
}


int main()
{
    stDate Date1 = ReadDataFromUser("Please enter Date 1: \n");
    stDate Date2 = ReadDataFromUser("\nPlease enter Date 2: \n");


    cout << "\nDifference is : " << GetDifferenceInDays(Date2, Date1) << "Day(s)";
    cout << "\nDifference (Including End Day) is : " << GetDifferenceInDays(Date2, Date1,true) << "Day(s)";

    system("pause>0");

    return 0;
}
