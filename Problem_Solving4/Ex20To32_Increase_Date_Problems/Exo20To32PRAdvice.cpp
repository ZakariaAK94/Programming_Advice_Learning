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
    return (Date1.Year < Date2.Year ? true : 
((Date1.Year ==Date2.Year) ? (Date1.Month < Date2.Month ? true : (Date1.Month ==Date2.Month ? Date1.Days < Date2.Days : false)) : false));
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

stDate IncreaseDateByOneDay(stDate& Date)
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

stDate IncreaseDateByXDays(stDate& Date, short Days=10)
{
    while (Days > 0)
    {
        IncreaseDateByOneDay(Date);
        Days--;
    }

    return Date;
}

stDate IncreaseDateByOneWeek(stDate& Date, short Days = 7)
{
    while (Days > 0)
    {
        IncreaseDateByOneDay(Date);
        Days--;
    }

    return Date;
}


stDate IncreaseDateByXWeek(stDate& Date, short Weeks = 10)
{
    while (Weeks > 0)
    {
        IncreaseDateByOneWeek(Date);
        Weeks--;
    }

    return Date;
}

stDate IncreaseDateByOneMonth(stDate& Date)
{
    if (IsLastMonthInYear(Date.Month))
    {
        Date.Year++;
        Date.Month = 1;
    }
    else
        Date.Month++;

    if(Date.Days > NumberOfDaysInAMonth(Date.Month, Date.Year))
        Date.Days = NumberOfDaysInAMonth(Date.Month, Date.Year);

    return Date;
}

stDate IncreaseDateByXMonths(stDate& Date, short Months=5)
{
    while (Months > 0)
    {
        IncreaseDateByOneMonth(Date);
        Months--;
    }

    return Date;
}

stDate IncreaseDateByOneYear(stDate& Date)
{
        Date.Year++;

    return Date;
}

stDate IncreaseDateByXYear(stDate& Date, short Years=10)
{
    
    for (int i = 0; i < Years ; i++)
        IncreaseDateByOneYear(Date);

    /*we can use this fast method
    Date.Year += Years;
    */
    
    return Date;
}

stDate IncreaseDateByOneDecade(stDate& Date)
{
    for (int i = 0; i < 10; i++)
        IncreaseDateByOneYear(Date);
    /* or we can use 
    Date.Year += 10; */

    return Date;
}

stDate IncreaseDateByXDecade(stDate& Date, short Decades =10)
{
    for (int j = 0; j < Decades * 10; j++)
    {
        IncreaseDateByOneYear(Date);
    }

    /* or we can use
    Date.Year += Decades * 10; */

    return Date;
}

stDate IncreaseDateByOneCentury(stDate& Date)
{
    Date.Year += 100;

    return Date;
}

stDate IncreaseDateByMillennium(stDate& Date)
{
    Date.Year += 1000;

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

    Date1 = IncreaseDateByOneDay(Date1);
    cout << "Date After :\n" << endl;
    cout << "\n01-Adding one day is : " << Date1.Days <<"/" << Date1.Month <<"/" << Date1.Year;
    Date1 = IncreaseDateByXDays(Date1);
    cout << "\n02-Adding 10 days is : " << Date1.Days << "/" << Date1.Month << "/" << Date1.Year;
    Date1 = IncreaseDateByOneWeek(Date1);
    cout << "\n03-Adding One Week is : " << Date1.Days << "/" << Date1.Month << "/" << Date1.Year;
    Date1 = IncreaseDateByXWeek(Date1);
    cout << "\n04-Adding Ten Week is : " << Date1.Days << "/" << Date1.Month << "/" << Date1.Year;
    Date1 = IncreaseDateByOneMonth(Date1);
    cout << "\n05-Adding One Month is : " << Date1.Days << "/" << Date1.Month << "/" << Date1.Year;
    Date1 = IncreaseDateByXMonths(Date1);
    cout << "\n06-Adding 5 Months is : " << Date1.Days << "/" << Date1.Month << "/" << Date1.Year;
    Date1 = IncreaseDateByOneYear(Date1);
    cout << "\n07-Adding One Year is : " << Date1.Days << "/" << Date1.Month << "/" << Date1.Year;
    Date1 = IncreaseDateByXYear(Date1);
    cout << "\n08-Adding Ten Year is : " << Date1.Days << "/" << Date1.Month << "/" << Date1.Year;
    Date1 = IncreaseDateByOneDecade(Date1);
    cout << "\n09-Adding One Decade is : " << Date1.Days << "/" << Date1.Month << "/" << Date1.Year;
    Date1 = IncreaseDateByXDecade(Date1);
    cout << "\n10-Adding Ten Decade is : " << Date1.Days << "/" << Date1.Month << "/" << Date1.Year;
    Date1 = IncreaseDateByOneCentury(Date1);
    cout << "\n11-Adding One Centary is : " << Date1.Days << "/" << Date1.Month << "/" << Date1.Year;
    Date1 = IncreaseDateByMillennium(Date1);
    cout << "\n12-Adding Millennium is : " << Date1.Days << "/" << Date1.Month << "/" << Date1.Year;

    system("pause>0");

    return 0;
}




