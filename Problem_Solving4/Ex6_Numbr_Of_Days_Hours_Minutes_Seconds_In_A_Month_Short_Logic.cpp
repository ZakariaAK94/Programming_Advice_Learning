#include <iostream>
#include <vector>
using namespace std;

bool IsaLeapYear(int Year)
{
    return (Year % 400 == 0) || (Year % 4 == 0) && (Year % 10 != 0);

}

short NumberOfDaysInAMonth(short Month, short Year)
{
      
        return (Month == 2) ? (IsaLeapYear(Year)?29:28) :((Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8||Month == 10|| Month == 12) ? 31 : 30);
    
}

short NumberOfHoursInAMonth(short Month, short Year)
{
    return  NumberOfDaysInAMonth(Month, Year) * 24;
}

int NumberOfMinutesInAMonth(short Month, short Year)
{
    return  NumberOfHoursInAMonth(Month, Year) * 60;
}

int NumberOfSecondsInAMonth(short Month, short Year)
{
    return  NumberOfMinutesInAMonth(Month, Year) * 60;
}

short ReadMonth()
{
    short Month;
    cout << "\nPlease enter a Month to check? ";
    cin >> Month;
    return Month;
}

short ReadYear()
{
    short Year;
    cout << "\nPlease enter a year to check? ";
    cin >> Year;
    return Year;
}



int main()
{
    
    short Year = ReadYear();
    short Month = ReadMonth();
    cout << "\nNumber of Days    in Month [" << Month << "] is " << NumberOfDaysInAMonth(Month, Year);
    cout << "\nNumber of Hours   in Month [" << Month << "] is " << NumberOfHoursInAMonth(Month, Year);
    cout << "\nNumber of Minutes in Month [" << Month << "] is " << NumberOfMinutesInAMonth(Month, Year);
    cout << "\nNumber of Seconds in Month [" << Month << "] is " << NumberOfSecondsInAMonth(Month, Year);

    system("pause>0");
}
