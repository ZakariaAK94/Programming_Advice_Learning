#include <iostream>
#include <vector>
#include <iomanip>
#include <stdlib.h>
using namespace std;

bool isLeapYear(int Year)
{
    return (Year % 400 == 0) || (Year % 4 == 0) && (Year % 10 != 0);

}

short DayOfWeekOrder(short Days,short Month, short Year)
{
    short a, y, m, d;
    a = (14 - Month) / 12;
    y = Year - a;
    m = Month + 12 * a - 2;
    d = (Days + y + ((31 * m) / 12) + ((100 * y - 4 * y + y) / 400)) % 7;
    return d;
}

string DayShortName(short DayOfWeekOrder)
{
    string ArrDay[] = { "Sun" ,"Mon" ,"Tue" ,"Wed" ,"Thu" ,"Fri","Sat" };

    return ArrDay[DayOfWeekOrder];

}

short NumberOfDaysInAMonth(short Month, short Year)
{

    if (Month < 1 || Month>12) 
        return  0;
    int days[12] = { 31,28,31,30,31,30,31,31,30,31,30,31 }; 
    return (Month == 2) ? (isLeapYear(Year) ? 29 : 28) : days[Month - 1];

}

string MonthShortName(short MonthNumber) 
{
    string Months[12] = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }; 
    return (Months[MonthNumber - 1]);
}

//solution of my teacher
void PrintMonthCalendar(short Month, short Year)
{
    int NumberOfDays; // Index of the day from 0 to 6
    int current = DayOfWeekOrder(1, Month, Year);
    NumberOfDays = NumberOfDaysInAMonth(Month, Year); // Print the current month name 
    printf("\n  _______________%s_______________\n\n",MonthShortName(Month).c_str()); // Print the columns 
    printf("  Sun  Mon  Tue  Wed  Thu  Fri  Sat\n"); // Print appropriate spaces
    int i;
    for (i = 0; i < current; i++)
        printf("     ");
    for (int j = 1; j <= NumberOfDays; j++)
    {
        printf("%5d", j); if (++i == 7)
        {
            i = 0;
            printf("\n");
        }
    }
    printf("\n  _________________________________\n");
}
short ReadMonth()
{
    short Month;
    cout << "\nPlease enter a Year ? ";
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

int main()
{
    short Year = ReadYear();
    short Month = ReadMonth(); 
    PrintMonthCalendar(Month, Year);
    system("pause>0");
    return 0;
}

