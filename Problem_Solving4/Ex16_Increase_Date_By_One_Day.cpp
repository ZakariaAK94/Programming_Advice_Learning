#include <iostream>
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
/* My teacher's solution*/
bool IsLastDayInMonth(sDate Date) 
{
    return (Date.Days == NumberOfDaysInAMonth(Date.Month, Date.Year));
}

bool IsLastMonthInYear(short Month) 
{
    return (Month == 12);
}

sDate IncreaseDateByOneDay(sDate Date) 
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

/*My solution
sDate GetNawDateAfterAddingOneDay(sDate CurrentDate)
{
    short NbrOfDaysByMonth = NumberOfDaysInAMonth(CurrentDate.Month, CurrentDate.Year);
    CurrentDate.Days++ ;
        
    if (CurrentDate.Days <= NbrOfDaysByMonth)
    {
        return CurrentDate;
    }
    else 
    {
        CurrentDate.Days -= NbrOfDaysByMonth;
        CurrentDate.Month++;
        if (CurrentDate.Month > 12)
        {
            CurrentDate.Month = 1;
            CurrentDate.Year++;
            return CurrentDate;
        }
        return CurrentDate;
    }
}
*/


int main()
{
    sDate Date1 = ReadDataFromUser("Please enter the first date:\n");
    Date1 = IncreaseDateByOneDay(Date1);

    cout << "\nDate after adding one day : " << Date1.Days << "/" << Date1.Month << "/" << Date1.Year;

    system("pause>0");
    return 0;
}
