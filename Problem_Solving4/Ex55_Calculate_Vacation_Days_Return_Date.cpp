#pragma warning (disable: 4996)

#include<iostream>
using namespace std;

struct stDate
{
    short Day;
    short Month;
    short Year;
};

bool isLeapYear(short Year)
{
    // if year is divisible by 4 AND not divisible by 100
    // OR if year is divisible by 400
    // then it is a leap year
    return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
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
    return (Date.Day == NumberOfDaysInAMonth(Date.Month, Date.Year));
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
            Date.Month = 1; Date.Day = 1; Date.Year++;
        }
        else
        {
            Date.Day = 1; Date.Month++;
        }
    }
    else
    {
        Date.Day++;
    }
    return Date;
}

short DayOfWeekOrder(short Day, short Month, short Year)
{
    short a, y, m;
    a = (14 - Month) / 12;
    y = Year - a;
    m = Month + (12 * a) - 2; // Gregorian://0:sun, 1:Mon, 2:Tue...etc
    return (Day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;
}

short DayOfWeekOrder(stDate Date)
{
    return DayOfWeekOrder(Date.Day, Date.Month, Date.Year);
}

string DayShortName(short DayOfWeekOrder)
{
    string arrDayNames[] = { "Sun" ,"Mon","Tue","Wed","Thu","Fri","Sat" };
    return arrDayNames[DayOfWeekOrder];
}

bool IsWeekEnd(stDate Date)
{
    //Weekends are Fri and Sat
    return (DayOfWeekOrder(Date) == 5 || DayOfWeekOrder(Date) == 6);
}

stDate CalculateReturnDate(stDate Date1,short VacationDays)
{    
    while (VacationDays > 0)
    {
        if(!IsWeekEnd(Date1))
            VacationDays--;
        Date1 = IncreaseDateByOneDay(Date1);
    }
    return Date1;
}
//soultion of the teacher
stDate CalculateVacationReturnDate(stDate DateFrom, short VacationDays)
{

    short WeekEndCounter = 0;

    for (short i = 1; i <= VacationDays; i++)
    {

        if (IsWeekEnd(DateFrom))
            WeekEndCounter++;

        DateFrom = IncreaseDateByOneDay(DateFrom);
    }
    //to add weekends 
    for (short i = 1; i <= WeekEndCounter; i++)
        DateFrom = IncreaseDateByOneDay(DateFrom);

    //in case the return date is week end keep adding one day until you reach business day
    while (IsWeekEnd(DateFrom))
    {
        DateFrom = IncreaseDateByOneDay(DateFrom);
    }

    return DateFrom;
}

short ReadDay()
{
    short Day;
    cout << "\nPlease enter a Day? ";
    cin >> Day;
    return Day;
}
short ReadMonth()
{
    short Month;
    cout << "Please enter a Month? ";
    cin >> Month;
    return Month;
}
short ReadYear()
{
    short Year;
    cout << "Please enter a Year? ";
    cin >> Year;
    return Year;
}

stDate ReadFullDate()
{
    stDate Date;
    Date.Day = ReadDay();
    Date.Month = ReadMonth();
    Date.Year = ReadYear();
    return Date;
}

stDate GetSystemDate()
{
    stDate Date;
    time_t t = time(0);
    tm* now = localtime(&t);
    Date.Year = now->tm_year + 1900;
    Date.Month = now->tm_mon + 1;
    Date.Day = now->tm_mday;

    return Date;
}



int main()
{
    stDate DateFrom;
    stDate DateTo,DateTest;
    short VacationDays;
    cout << "Vacation Starts :\n";
    DateFrom = ReadFullDate();
    cout << "\nPlease enter Vacation Days ?\n";
    cin >> VacationDays;
    DateTo = CalculateReturnDate(DateFrom, VacationDays); 
    DateTest = CalculateVacationReturnDate(DateFrom, VacationDays);
    cout << "\n Return Date : " << DayShortName(DayOfWeekOrder(DateTo)) <<", " << DateTo.Day <<"/" <<DateTo.Month <<"/"<<DateTo.Year;
    cout << "\n Return Date : " << DayShortName(DayOfWeekOrder(DateTest)) <<", " << DateTest.Day <<"/" << DateTest.Month <<"/"<< DateTest.Year;
    system("pause>0");
    return 0;


}
