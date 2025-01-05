#include <iostream>
#include <string>
using namespace std;

enum enDaysOfWeek { Sunday = 1, Monday = 2, Tuesday= 3, Wednesday = 4, Thuesday =5, Friday =6, Saturday =7 };
enum enMonthOfYear {Jan =1, Feb=2, Mar=3,Apr=4, May=5,June=6, July=7, Aug=8, Sep=9, Oct=10, Nov=11, Dec=12};
enum enChoiceBtwDayAndMonth{Day =1, Month=2};

enChoiceBtwDayAndMonth ReadDayOrMonth()
{
    int choice = 0;
    do {
        cout <<"If you are looking for a name of a day Tap 1,  if you are looking for a name of a Month tap 2 ?"  << endl;
        cin >> choice;
    } while (choice != 1 && choice != 2);

    return (enChoiceBtwDayAndMonth)choice;

}

enDaysOfWeek ReadDayOfWeek(string Message)
{
    int choice=0;
    do {
        cout << Message << endl;
        cin >> choice;
    } while (choice <= 0 || choice >7 );

    return (enDaysOfWeek)choice;
    
}

enDaysOfWeek ReadMonthOfYear(string Message)
{
    int choice = 0;
    do {
        cout << Message << endl;
        cin >> choice;
    } while (choice <= 0 || choice > 12);

    return (enDaysOfWeek)choice;

}

string GetDayOfWeek(enDaysOfWeek day)
{
    switch (day)
    {
    case enDaysOfWeek::Sunday:
        return "Sunday";
    case enDaysOfWeek::Monday:
        return "Monday";
    case enDaysOfWeek::Tuesday:
        return "Tuesday";
    case enDaysOfWeek::Wednesday:
        return "Wednesday";
    case enDaysOfWeek::Thuesday:
        return "Thuesday";
    case enDaysOfWeek::Friday:
        return "Friday";
    case enDaysOfWeek::Saturday:
        return "Saturday";
    default:
        return "Wrong day";
    } 
}

string GetMonthOfYear(enDaysOfWeek month)
{
    switch (month)
    {
    case enMonthOfYear::Jan:
        return "January";
    case enMonthOfYear::Feb:
        return "Ferbruary";
    case enMonthOfYear::Mar :
        return "March";
    case enMonthOfYear::Apr:
        return "April";
    case enMonthOfYear::May:
        return "May";
    case enMonthOfYear::June:
        return "June";
    case enMonthOfYear::July:
        return "Juy";
    case enMonthOfYear::Aug:
        return "August";
    case enMonthOfYear::Sep:
        return "September";
    case enMonthOfYear::Oct:
        return "October";
    case enMonthOfYear::Nov:
        return "November";
    case enMonthOfYear::Dec:
        return "December";
    default:
        return "Wrong Month";
    }
}


void PrintResult(string NameofDay)
{
    cout << "its " << NameofDay << endl;
}

int main()
{
    if (ReadDayOrMonth() == enChoiceBtwDayAndMonth::Day)
    {
           PrintResult(GetDayOfWeek(ReadDayOfWeek("Choose one of the day : Sun=1, Mon=2, Tues=3, Wedn=4, Thues=5, Frid=6, Satur=7 :")));
    }
    else
    {
           PrintResult(GetMonthOfYear(ReadMonthOfYear("Choose one of the month : Jan =1, Feb=2, Mar=3,Apr=4, May=5,June=6, July=7, Aug=8, Sep=9, Oct=10, Nov=11, Dec=12 :")));

    }
    

    return 0;
}

