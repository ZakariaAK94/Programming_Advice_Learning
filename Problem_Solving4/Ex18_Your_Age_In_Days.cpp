#include <iostream>
#include <vector>
#include <iomanip>
using namespace std;

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

bool IsaLeapYear(int Year)
{
    return (Year % 400 == 0) || (Year % 4 == 0) && (Year % 10 != 0);

}

short NumberOfDaysInAMonth(short Month, short Year)
{

    return (Month == 2) ? (IsaLeapYear(Year) ? 29 : 28) : ((Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12) ? 31 : 30);

}

short CalculateDayOfBirthday(short Month, short Year)
{
    short a, y, m, d;
    a = (14 - Month) / 12;
    y = Year - a;
    m = Month + 12 * a - 2;
    d = (1 + y + ((31 * m) / 12) + ((100 * y - 4 * y + y) / 400)) % 7;
    return d;
}

string GetDayName(short d)
{
    string ArrDay[] = { "Sun" ,"Mon" ,"Tue" ,"Wed" ,"Thu" ,"Fri","Sat" };

    return ArrDay[d];

}
//My solution for this exercice
void ShowCalendar(short Month, short Year)
{
    short d = CalculateDayOfBirthday(Month, Year);
    string DayOfMonth = GetDayName(d);
    string ArrDays[] = { "Sun" ,"Mon" ,"Tue" ,"Wed" ,"Thu" ,"Fri","Sat" };
    string ArrMonths[] = { "Jan" ,"Feb" ,"Mar" ,"Apr" ,"May" ,"Jun","Jul","Aug","Sep","Oct","Nov","Dec" };
  
    cout << "\n-----------------" << ArrMonths[Month - 1] << "-----------------" << endl;
    for (string C : ArrDays)
        cout << setw(5) << C;
    cout << "\n";
    int i;
    short NumberOfDays = NumberOfDaysInAMonth(Month, Year);
    for (i = 0; i < d; i++)
    {
        cout << setw(5) << ' ';
    }
    for (int j = 1; j <= NumberOfDays; j++)
    {
            
            cout << setw(5) << j;
            if (++i == 7)
            {
                cout << endl;
                i = 0;
            }            
    }
    cout << "------------------------------------------------------------------";
    

}


int main()
{
    short Year = ReadYear();
    short Month = ReadMonth();
    
    ShowCalendar(Month, Year);

    system("pause>0");
}

