#include <iostream>
using namespace std;

struct stDate
{
        short Day;
        short Month;
        short Year;      
};

struct stPeriod
{
    stDate StartDate;
    stDate EndDate;
};

bool IsDate1BeforeDate2(stDate Date1, stDate Date2)
{
    return  (Date1.Year < Date2.Year) ? true : ((Date1.Year ==
        Date2.Year) ? (Date1.Month < Date2.Month ? true : (Date1.Month ==
            Date2.Month ? Date1.Day < Date2.Day : false)) : false);
}

bool IsDate1EqualDate2(stDate Date1, stDate Date2)
{
    return  (Date1.Year == Date2.Year) ? ((Date1.Month == Date2.Month) ? ((Date1.Day == Date2.Day) ? true : false) : false) : false;
    //or my solution below
    //return  (Date1.Year == Date2.Year) && (Date1.Month == Date2.Month) && (Date1.Day == Date2.Day);
}

bool IsDate1AfterDate2(stDate Date1, stDate Date2)
{
    return (!IsDate1BeforeDate2(Date1, Date2) && !IsDate1EqualDate2(Date1, Date2)); 
}

enum enDateCompare{ Before = -1, Equal = 0, After = 1 };
 
enDateCompare CompareDates(stDate Date1, stDate Date2)
{
    if (IsDate1BeforeDate2(Date1, Date2)) 
        return enDateCompare::Before; 
    if (IsDate1EqualDate2(Date1, Date2))
        return enDateCompare::Equal;
    /* if (IsDate1AfterDate2(Date1,Date2))     
    return enDateCompare::After;
    *///this is faster
    return enDateCompare::After;
}

bool IsOverlapPeriods(stPeriod Period1, stPeriod Period2) 
{
 if (CompareDates(Period2.EndDate, Period1.StartDate) == enDateCompare::Before || CompareDates(Period2.StartDate, Period1.EndDate) == enDateCompare::After)
        return false; 
 else
        return true;
}

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

stPeriod ReadPeriod()
{
    stPeriod Period; 
    cout << "\nEnter Start Date:\n"; 
    Period.StartDate = ReadFullDate(); 
    cout << "\nEnter End Date:\n"; 
    Period.EndDate = ReadFullDate();
    return Period;
}


//My Solution that I Find isn't perfect
// struct stDate
//{
//    short StartDay;
//    short StartMonth;
//    short StartYear;
//    short EndDay;
//    short EndMonth;
//    short EndYear;
//};
//
//short ReadDay()
//{
//    short Day;
//    cout << "\nPlease enter a Day? ";
//    cin >> Day;
//    return Day;
//}
//short ReadMonth()
//{
//    short Month;
//    cout << "Please enter a Month? ";
//    cin >> Month;
//    return Month;
//}
//short ReadYear()
//{
//    short Year;
//    cout << "Please enter a Year? ";
//    cin >> Year;
//    return Year;
//}
//
//stDate ReadFullDate()
//{
//    stDate Date1;
//    cout << "\nEnter Start Date" << endl;
//    Date1.StartDay = ReadDay();
//    Date1.StartMonth = ReadMonth();
//    Date1.StartYear = ReadYear();
//    cout << "\nEnter End Date" << endl;
//    Date1.EndDay = ReadDay();
//    Date1.EndMonth = ReadMonth();
//    Date1.EndYear = ReadYear();
//    return Date1;
//}
//
//bool IsStartDate1BeforeStartDate2(stDate Date1, stDate Date2)
//{
//    return  (Date1.StartYear < Date2.StartYear) ? true : ((Date1.StartYear ==
//        Date2.StartYear) ? (Date1.StartMonth < Date2.StartMonth ? true : (Date1.StartMonth ==
//            Date2.StartMonth ? Date1.StartDay < Date2.StartDay : false)) : false);
//}
//
//bool IsEndDate1BeforeStartDate2(stDate Date1, stDate Date2)
//{
//    return  (Date1.EndYear < Date2.StartYear) ? true : ((Date1.EndYear ==
//        Date2.StartYear) ? (Date1.EndMonth < Date2.StartMonth ? true : (Date1.EndMonth ==
//            Date2.StartMonth ? Date1.EndDay < Date2.StartDay : false)) : false);
//}
//bool IsStartDate1BeforeEndDate2(stDate Date1, stDate Date2)
//{
//    return  (Date1.StartYear < Date2.EndYear) ? true : ((Date1.StartYear ==
//        Date2.EndYear) ? (Date1.StartMonth < Date2.EndMonth ? true : (Date1.StartMonth ==
//            Date2.EndMonth ? Date1.StartDay < Date2.EndDay : false)) : false);
//}
//bool IsEndDate1EqualToStartDate2(stDate Date1, stDate Date2)
//{
//    return (Date1.EndYear == Date2.StartYear) && (Date1.EndMonth == Date2.StartMonth) && (Date1.EndDay == Date2.StartDay);
//}
//
//bool IsStartDate1EqualToEndDate2(stDate Date1, stDate Date2)
//{
//    return (Date1.StartYear == Date2.EndYear) && (Date1.StartMonth == Date2.EndMonth) && (Date1.StartDay == Date2.EndDay);
//}
//
//bool IsEndDate1AfterStartDate2(stDate Date1, stDate Date2)
//{
//    return (!IsEndDate1BeforeStartDate2(Date1, Date2) && !IsEndDate1EqualToStartDate2(Date1, Date2));
//}
//
//bool IsStartDate1AfterEndDate2(stDate Date1, stDate Date2)
//{
//    return (!IsStartDate1BeforeEndDate2(Date1, Date2) && !IsStartDate1EqualToEndDate2(Date1, Date2));
//}
//
//void Print(stDate Date1, stDate Date2)
//{
//    if (IsEndDate1AfterStartDate2(Date1, Date2))
//        cout << "\nYes, Periods Overlap" << endl;
//    else if (IsStartDate1AfterEndDate2(Date1, Date2))
//        cout << "\nYes, Periods Overlap" << endl;
//    else
//        cout << "\nNo, Periods don't Overlap" << endl;
//
//}

int main()
{
    cout << "Enter Period 1: \n";
    stPeriod Period1 = ReadPeriod();
    cout << "\nEnter Period 2: \n";
    stPeriod Period2 = ReadPeriod();
    if (IsOverlapPeriods(Period1, Period2))
        cout << "\nYes, Periods Overlap\n";
    else
        cout << "\nNo, Periods don't Overlap\n";

    system("pause>0");
    return 0;
}