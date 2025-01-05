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

short NumberOfDaysInAMonth(short Month, short Year)
{
    if (Month < 1 || Month>12)
        return  0;
    int days[12] = { 31,28,31,30,31,30,31,31,30,31,30,31 };
    return (Month == 2) ? (isLeapYear(Year) ? 29 : 28) : days[Month - 1];

}

//bool IsLastDayInMonth(stDate Date)
//{
//    return (Date.Days == NumberOfDaysInAMonth(Date.Month, Date.Year));
//}
//bool IsLastMonthInYear(short Month)
//{
//    return (Month == 12);
//}
bool IsFirstDaysInAMonth(short Days)
{
    return (Days == 1);
}

bool IsFirstMonthInAYear(short Month)
{
    return (Month == 1);
}

stDate DecreaseDateByOneDay(stDate& Date)
{
    if (IsFirstDaysInAMonth(Date.Days))
    {
        if (IsFirstMonthInAYear(Date.Month))
        {
            Date.Month = 12; Date.Days = 31; Date.Year--;
        }
        else
        {
            Date.Month--; Date.Days = NumberOfDaysInAMonth(Date.Month, Date.Year);
        }
    }
    else
    {
        Date.Days--;
    }
    return Date;
}

stDate DecreaseDateByXDays(stDate& Date, short Days = 10)
{
    while (Days > 0)
    {
        DecreaseDateByOneDay(Date);
        Days--;
    }

    return Date;
}

stDate DecreaseDateByOneWeek(stDate& Date, short Days = 7)
{
    while (Days > 0)
    {
        DecreaseDateByOneDay(Date);
        Days--;
    }

    return Date;
}

stDate DecreaseDateByXWeek(stDate& Date, short Weeks = 10)
{
    while (Weeks > 0)
    {
        DecreaseDateByOneWeek(Date);
        Weeks--;
    }

    return Date;
}

stDate DecreaseDateByOneMonth(stDate& Date)
{
    if (IsFirstMonthInAYear(Date.Month))
    {
        Date.Year--;
        Date.Month = 12;
    }
    else
        Date.Month--;

    if (Date.Days > NumberOfDaysInAMonth(Date.Month, Date.Year))
        Date.Days = NumberOfDaysInAMonth(Date.Month, Date.Year);

    return Date;
}

stDate DecreaseDateByXMonths(stDate& Date, short Months = 5)
{
    while (Months > 0)
    {
        DecreaseDateByOneMonth(Date);
        Months--;
    }

    return Date;
}

stDate DecreaseDateByOneYear(stDate& Date)
{
    Date.Year--;

    return Date;
}

stDate DecreaseDateByXYear(stDate& Date, short Years = 10)
{

    for (int i = 0; i < Years; i++)
        DecreaseDateByOneYear(Date);

    /*we can use this fast method
    Date.Year += Years;
    */

    return Date;
}

stDate DecreaseDateByOneDecade(stDate& Date)
{
    for (int i = 0; i < 10; i++)
        DecreaseDateByOneYear(Date);
    /* or we can use
    Date.Year += 10; */

    return Date;
}

stDate DecreaseDateByXDecade(stDate& Date, short Decades = 10)
{
    for (int j = 0; j < Decades * 10; j++)
    {
        DecreaseDateByOneYear(Date);
    }

    /* or we can use
    Date.Year += Decades * 10; */

    return Date;
}

stDate DecreaseDateByOneCentury(stDate& Date)
{
    Date.Year -= 100;

    return Date;
}

stDate DecreaseDateByMillennium(stDate& Date)
{
    Date.Year -= 1000;

    return Date;
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
    stDate Date1 = ReadDataFromUser("Please enter Date: \n");

    Date1 = DecreaseDateByOneDay(Date1);
    cout << "Date before :\n" << endl;
    cout << "\n01-Subtracting one day is : " << Date1.Days << "/" << Date1.Month << "/" << Date1.Year;
    Date1 = DecreaseDateByXDays(Date1);
    cout << "\n02-Subtracting 10 days is : " << Date1.Days << "/" << Date1.Month << "/" << Date1.Year;
    Date1 = DecreaseDateByOneWeek(Date1);
    cout << "\n03-Subtracting One Week is : " << Date1.Days << "/" << Date1.Month << "/" << Date1.Year;
    Date1 = DecreaseDateByXWeek(Date1);
    cout << "\n04-Subtracting Ten Week is : " << Date1.Days << "/" << Date1.Month << "/" << Date1.Year;
    Date1 = DecreaseDateByOneMonth(Date1);
    cout << "\n05-Subtracting One Month is : " << Date1.Days << "/" << Date1.Month << "/" << Date1.Year;
    Date1 = DecreaseDateByXMonths(Date1);
    cout << "\n06-Subtracting 5 Months is : " << Date1.Days << "/" << Date1.Month << "/" << Date1.Year;
    Date1 = DecreaseDateByOneYear(Date1);
    cout << "\n07-Subtracting One Year is : " << Date1.Days << "/" << Date1.Month << "/" << Date1.Year;
    Date1 = DecreaseDateByXYear(Date1);
    cout << "\n08-Subtracting Ten Year is : " << Date1.Days << "/" << Date1.Month << "/" << Date1.Year;
    Date1 = DecreaseDateByOneDecade(Date1);
    cout << "\n09-Subtracting One Decade is : " << Date1.Days << "/" << Date1.Month << "/" << Date1.Year;
    Date1 = DecreaseDateByXDecade(Date1);
    cout << "\n10-Subtracting Ten Decade is : " << Date1.Days << "/" << Date1.Month << "/" << Date1.Year;
    Date1 = DecreaseDateByOneCentury(Date1);
    cout << "\n11-Subtracting One Centary is : " << Date1.Days << "/" << Date1.Month << "/" << Date1.Year;
    Date1 = DecreaseDateByMillennium(Date1);
    cout << "\n12-Subtracting Millennium is : " << Date1.Days << "/" << Date1.Month << "/" << Date1.Year;

    system("pause>0");

    return 0;
}

