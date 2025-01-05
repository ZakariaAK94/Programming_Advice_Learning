#include <iostream>
#include <vector>
#include <iomanip>
#include <stdlib.h>
using namespace std;

struct sDate
{
    short Days;
    short Month;
    short Year;
};

bool isLeapYear(int Year)
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
sDate ReadDataFromUser()
{
    sDate DateBeforeAddingDays;
    cout <<"\nPlease enter a Day ? ";
    cin >> DateBeforeAddingDays.Days;
    cout <<"\nPlease enter a Month ? ";
    cin >> DateBeforeAddingDays.Month;
    cout <<"\nPlease enter a Year ? ";
    cin >> DateBeforeAddingDays.Year;
    

    return DateBeforeAddingDays;
}
short NumberOfDaysFromTheBeginingOfTheYear(sDate DateBeforeAddingDays)
{
    short TotalDays = 0;
    for (int i = 1; i < DateBeforeAddingDays.Month; i++)
    {
        TotalDays += NumberOfDaysInAMonth(i, DateBeforeAddingDays.Year);
    }
    TotalDays = TotalDays + DateBeforeAddingDays.Days;
    return TotalDays;
}

sDate GetDateFromDayOrderInYear(short NbrOfDaysToAdd, short Year)
{
    sDate DateAfterAddingDays; 
    short NbrOfDays ;
    if (isLeapYear(Year))
        NbrOfDays = 366;
    else
        NbrOfDays = 365;
   while (NbrOfDaysToAdd > NbrOfDays)
   {
       NbrOfDaysToAdd = NbrOfDaysToAdd - NbrOfDays;
       Year++;
       /*if (isLeapYear(Year))
           NbrOfDays = 366;
       else
           NbrOfDays = 365;*/
   }
    short ArrDaysOfMonth[] = { 31,isLeapYear(Year) ? 29 : 28,31,30,31,30,31,31,30,31,30,31 };
    short i;
    DateAfterAddingDays.Year = Year;
    for (i = 0; i < 12; i++)
    {

        if (NbrOfDaysToAdd - ArrDaysOfMonth[i] > 0)
        {
            NbrOfDaysToAdd -= ArrDaysOfMonth[i];
        }
        else
        {
            DateAfterAddingDays.Days = NbrOfDaysToAdd;
            break;
        }
        if (i == 11)
        {
            DateAfterAddingDays.Year++;
            i = 0;
        }
    }
    DateAfterAddingDays.Month = i + 1;

    return DateAfterAddingDays;
}




int main()
{
    sDate DateBeforeAddingDays = ReadDataFromUser();
    short DaysToAdd;
    cout << "\nHow many Days wanna added ? ";
    cin >> DaysToAdd;
    sDate DateAfterAddingDays;
    short NbrDaysFromBeginningOfYear = NumberOfDaysFromTheBeginingOfTheYear(DateBeforeAddingDays);
    DateAfterAddingDays = GetDateFromDayOrderInYear(NbrDaysFromBeginningOfYear + DaysToAdd, DateBeforeAddingDays.Year);
    cout << "\n Date after adding for [" << DaysToAdd << "] is : " << DateAfterAddingDays.Days << "/" << DateAfterAddingDays.Month << "/" << DateAfterAddingDays.Year;
    system("pause>0");
    return 0;
}