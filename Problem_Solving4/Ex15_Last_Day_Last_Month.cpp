#include <iostream>
#include <iomanip>
using namespace std;

struct sDate
{
    short Days;
    short Month;
    short Year;
};


sDate ReadDataFromUser(string Message)
{
    sDate DateBeforeAddingDays;
    cout << Message;
    cout << "\nPlease enter a Day ? ";
    cin >> DateBeforeAddingDays.Days;
    cout << "\nPlease enter a Month ? ";
    cin >> DateBeforeAddingDays.Month;
    cout << "\nPlease enter a Year ? ";
    cin >> DateBeforeAddingDays.Year;


    return DateBeforeAddingDays;
}

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

bool CheckIsDayAndMonthIsTheLast(sDate Date1)
{
    return  NumberOfDaysInAMonth(Date1.Month, Date1.Year) ==Date1.Days;
}

bool ChechIsMonthLastOneInTheYear(short Month)
{
    return Month == 12;
}

int main()
{
    sDate Date1 = ReadDataFromUser("Please enter the first date:\n");
    

    if (CheckIsDayAndMonthIsTheLast(Date1))
    {
        cout << "\nYes, Day is Last Day in Month";
    }
    else
    {
        cout << "\nNo, Day is not Last Day in Month";
    }
    if (ChechIsMonthLastOneInTheYear(Date1.Month))
    {
        cout << "\nYes, Month is Last Month in Year";
    }
    else
    {
        cout << "\nNo, Month is not Last Month in Year";
    }

    system("pause>0");
    return 0;
}
