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
short ReadMonth()
{
    short Month;
    cout << "\nPlease enter a Month ? ";
    cin >> Month;

    return Month;
}
short ReadYear()
{
    short Year;
    cout << "\nPlease enter a Year ? ";
    cin >> Year;

    return Year;
}
short ReadDay()
{
    short Day;
    cout << "\nPlease enter a Day ? ";
    cin >> Day;

    return Day;
}

short NumberOfDaysFromTheBeginingOfTheYear(short Days, short Month, short Year)
{
    short sum=0;
    for (int i = 1; i < Month; i++)
    {
        sum += NumberOfDaysInAMonth(i, Year);        
    }
    sum = sum + Days;
    return sum;
}

int main()
{
    short Days = ReadDay();
    short Month = ReadMonth();
    short Year = ReadYear();
    short ArrDayAndMonth[2];
    short NbrDaysFromBeginningOfYear = NumberOfDaysFromTheBeginingOfTheYear(Days, Month, Year);
    cout << "Number of Days from beginning of the year is : "<< NbrDaysFromBeginningOfYear;
    
    system("pause>0");
    return 0;
}
