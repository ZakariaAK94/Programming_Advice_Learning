#include <iostream>
using namespace std;

struct stDate
{
    short Day;
    short Month;
    short Year;
};

short ReadDay()
{
    short Day;
    cout << "\nPlease enter a Day? ";
    cin >> Day;
    return Day;
}
short ReadMonth()
{
    short Month;
    cout << "Please enter a Month? ";
    cin >> Month;
    return Month;
}
short ReadYear()
{
    short Year;
    cout << "Please enter a Year? ";
    cin >> Year;
    return Year;
}

stDate ReadFullDate()
{
    stDate Date;
    Date.Day = ReadDay();
    Date.Month = ReadMonth();
    Date.Year = ReadYear();
    return Date;
}

bool IsDate1BeforeDate2(stDate Date1, stDate Date2)
{
    return  (Date1.Year < Date2.Year) ? true : ((Date1.Year ==
        Date2.Year) ? (Date1.Month < Date2.Month ? true : (Date1.Month ==
            Date2.Month ? Date1.Day < Date2.Day : false)) : false);
}

bool IsDate1EqualToDate2(stDate Date1, stDate Date2)
{
    return (Date1.Year ==Date2.Year) && (Date1.Month == Date2.Month) && (Date1.Day == Date2.Day);
}

bool IsDate1AfterDate2(stDate Date1, stDate Date2)
{
    return (!IsDate1BeforeDate2(Date1, Date2) && !IsDate1EqualToDate2(Date1, Date2)); }

void Print(stDate Date1, stDate Date2)
{
    if (IsDate1AfterDate2(Date1, Date2))
        cout << "\nNo, Date1 is not After Date2" << endl;
    else
        cout << "\nYes, Date1 is after Date2" << endl;
}

int main()
{
    cout << "Enter Date1: \n";
    stDate Date1 = ReadFullDate();
    cout << "\nEnter Date2: \n";
    stDate Date2= ReadFullDate();
    Print(Date1, Date2);

    system("pause>0");
}

