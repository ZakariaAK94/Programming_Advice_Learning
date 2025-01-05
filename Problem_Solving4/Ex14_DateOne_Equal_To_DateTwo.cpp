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


bool CheckIsDate1EqualToDate2(sDate Date1, sDate Date2)
{
    return Date1.Year == Date2.Year ? (Date1.Month == Date2.Month ? (Date1.Days == Date2.Days ? true : false) : false):false;
    /* Second solution */
    return (Date1.Year == Date2.Year && Date1.Month == Date2.Month && Date1.Days == Date2.Days);

}

int main()
{
    sDate Date1 = ReadDataFromUser("Please enter the first date:\n");
    sDate Date2 = ReadDataFromUser("\nPlease enter the second date:\n");

    if (CheckIsDate1EqualToDate2(Date1, Date2))
        cout << "\nYes, Date1 is equal to Date2.";
    else
        cout << "\nNo, Date1 is NOT equal to Date2.";

    system("pause>0");
    return 0;
}