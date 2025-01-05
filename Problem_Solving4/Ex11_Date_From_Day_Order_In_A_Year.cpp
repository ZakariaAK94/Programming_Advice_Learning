#include <iostream>
#include <vector>
#include <iomanip>
#include <stdlib.h>
using namespace std;

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
short ReadDataFromUser(string Message)
{
    short UserData;
    cout << Message;
    cin >> UserData;

    return UserData;
}


short NumberOfDaysFromTheBeginingOfTheYear(short Days, short Month, short Year)
{
    short sum = 0;
    for (int i = 1; i < Month; i++)
    {
        sum += NumberOfDaysInAMonth(i, Year);
    }
    sum = sum + Days;
    return sum;
}

void GetDateFromDayOrderInYear(short NbrOfDaysToAdd, short ArrDayAndMonth[2], short Year)
{
    short ArrDaysOfMonth[] = { 31,isLeapYear(Year) ? 29 : 28,31,30,31,30,31,31,30,31,30,31 };
    short i;
    for (i = 0; i < 12; i++)
    {
        if (NbrOfDaysToAdd - ArrDaysOfMonth[i] > 0)
        {
            NbrOfDaysToAdd -= ArrDaysOfMonth[i];
        }
        else
        {
            ArrDayAndMonth[0] = NbrOfDaysToAdd;
            break;
        }
        if (i == 11)
        {
            ArrDayAndMonth[2] ++;
            i = 0;
        }
    }
    
    ArrDayAndMonth[1] = i + 1;
}

int main()
    {
        short Days = ReadDataFromUser("\nPlease enter a Day ? ");
        short Month = ReadDataFromUser("\nPlease enter a Month ? ");
        short Year = ReadDataFromUser("\nPlease enter a Year ? ");
        short ArrDayAndMonth[2];
        short NbrDaysFromBeginningOfYear = NumberOfDaysFromTheBeginingOfTheYear(Days, Month, Year);
        cout << "\nNumber of Days from the begining of the year is " << NbrDaysFromBeginningOfYear << "\n\n";
        GetDateFromDayOrderInYear(NbrDaysFromBeginningOfYear, ArrDayAndMonth, Year);
        cout << "\n Date after adding for [" << NbrDaysFromBeginningOfYear << "] is : " << ArrDayAndMonth[0] << "/" << ArrDayAndMonth[1] << "/" << Year;
        system("pause>0");
        return 0;
    }
