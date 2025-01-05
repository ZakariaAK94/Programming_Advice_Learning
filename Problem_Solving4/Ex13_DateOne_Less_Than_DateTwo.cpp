#include <iostream>
#include <iomanip>
using namespace std;

struct sDate
{
    short Days;
    short Month;
    short Year;
};
 

sDate ReadDataFromUser()
{
    sDate DateBeforeAddingDays;
    cout << "\nPlease enter a Day ? ";
    cin >> DateBeforeAddingDays.Days;
    cout << "\nPlease enter a Month ? ";
    cin >> DateBeforeAddingDays.Month;
    cout << "\nPlease enter a Year ? ";
    cin >> DateBeforeAddingDays.Year;


    return DateBeforeAddingDays;
}

// My solution taking in consideration the equality entre to dates
/*string CompareTwoDates(sDate Date1, sDate Date2)
{
    if (Date1.Year > Date2.Year)
        return "Yes, Date 1 is more than Date 2 ";
    else if (Date1.Year < Date2.Year)
        return "No, Date 1 is less than Date 2 ";
    else
        if (Date1.Month > Date2.Month)
            return "Yes, Date 1 is more than Date 2 ";
        else if (Date1.Month < Date2.Month)
            return "No, Date 1 is less than Date 2 ";
        else
            if (Date1.Days > Date2.Days)
                return "No, Date 1 is more than Date 2 ";
            else if (Date1.Days < Date2.Days)
                return "No, Date 1 is less than Date 2 ";
            else
                return "Date 1 is egal to Date 2";
}*/
// Solution of the teacher without considering the equality entre to dates
bool IsDate1BeforeDate2(sDate Date1, sDate Date2)
{
    return (Date1.Year < Date2.Year ? true : ((Date1.Year == 
        Date2.Year) ? (Date1.Month < Date2.Month ? true : (Date1.Month ==
            Date2.Month ? Date1.Days < Date2.Days : false)) : false));
} 

int main()
{
    sDate Date1 = ReadDataFromUser();
    sDate Date2 = ReadDataFromUser();
    
    if (IsDate1BeforeDate2(Date1, Date2))     
        cout << "\nYes, Date1 is Less than Date2."; 
    else      
        cout << "\nNo, Date1 is NOT Less than Date2.";

    system("pause>0");
    return 0;
}
