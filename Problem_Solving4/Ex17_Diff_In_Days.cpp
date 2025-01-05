#include <iostream>
using namespace std;

struct stDate
{
    short Days;
    short Month;
    short Year;
};


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

bool isLeapYear(short Year)
{
    return (Year % 400 == 0) || (Year % 4 == 0) && (Year % 10 != 0);

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

bool IsDate1BeforeDate2(stDate Date1, stDate Date2)
{
    return (Date1.Year < Date2.Year ? true : ((Date1.Year ==
        Date2.Year) ? (Date1.Month < Date2.Month ? true : (Date1.Month ==
            Date2.Month ? Date1.Days < Date2.Days : false)) : false));
}
short GetDifferenceInDays(stDate Date2, stDate Date1, bool IncludeEndDay = false)
{
    short Days = 0;

    /*while (Date2.Year > Date1.Year)
    {
        if(isLeapYear(Date2.Year))
            sum +=366 ;
        else
            sum += 365;
        
        Date2.Year--;
    }
    for (short i = Date2.Month - 1; i >= Date1.Month; i--)
    {
            sum += NumberOfDaysInAMonth(i, Date2.Year);
    }
    sum += Date2.Days - Date1.Days;*/
    while (IsDate1BeforeDate2(Date1, Date2))
    {
        Days++;
        Date1 = IncreaseDateByOneDay(Date1);
    }
    return IncludeEndDay ? ++Days: Days;
        
}



int main()
{
    stDate Date1 = ReadDataFromUser("Please enter your date of Birth: \n");
    stDate Date2 = ReadDataFromUser("Please enter your date of Birth: \n");

    cout << "\nYour age is : " << GetDifferenceInDays(Date2,Date1) << "Day(s)";

    system("pause>0");

    return 0;
}

