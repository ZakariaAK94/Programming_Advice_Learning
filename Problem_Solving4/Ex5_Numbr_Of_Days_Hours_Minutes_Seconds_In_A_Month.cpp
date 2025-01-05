#include <iostream>
#include <vector>
using namespace std;

int ReadYear(string text)
{
    int Year;
    cout << "Please enter a " << text << " that you want to test ? " << endl;
    cin >> Year;

    return Year;
}

bool IsaLeapYear(int Year)
{
    return (Year % 400 == 0) || (Year % 4 == 0) && (Year % 10 != 0);

}

//My solution for this exercice
int NumberOfDaysInMonth(int Year, int Month)
{
    switch (Month)
    {
    case 1:
        return 31;
    case 2:
        return IsaLeapYear(Year) ? 29 : 28;
    case 3:
        return 31;
    case 4:
        return 30;
    case 5:
        return 31;
    case 6:
        return 30;
    case 7:
        return 31;
    case 8:
        return 31;
    case 9:
        return 30;
    case 10:
        return 31;
    case 11:
        return 30;
    case 12:
        return 31;
    default:
        return 0;
    }
}

vector<int> DivideIntoDurationDependOnMonth(int Year, int Month)
{
    vector<int> Durations;
    int NbrsOfDays = NumberOfDaysInMonth(Year, Month);
    Durations.push_back(NbrsOfDays);
    Durations.push_back(Durations[0] * 24);
    Durations.push_back(Durations[1] * 60);
    Durations.push_back(Durations[2] * 60);

    return Durations;
}

void ShowResult(vector<int> Durations, int Month)
{
    cout << "\nNumber of Days in Month [" << Month << "] is " << Durations[0];
    cout << "\nNumber of Hours in Month [" << Month << "] is " << Durations[1];
    cout << "\nNumber of Minutes in Month [" << Month << "] is " << Durations[2];
    cout << "\nNumber of Seconds in Month [" << Month << "] is " << Durations[3];
}

//The prof Solution

short NumberOfDaysInAMonth(short Month, short Year)
{
    if (Month < 1 || Month>12)
        return  0;
    if (Month == 2)
    {
        return  IsaLeapYear(Year) ? 29 : 28;
    } 
    short arr31Days[7] = { 1,3,5,7,8,10,12 }; 
    for (short i = 1; i <= 7; i++)
    {
        if (arr31Days[i - 1] == Month)
            return 31;
    } //if you reach here then its 30 days.
    return  30;
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
    vector <int> Durations;
    int Year = ReadYear("Year");
    int Month = ReadYear("Month");
    Durations = DivideIntoDurationDependOnMonth(Year, Month);
    ShowResult(Durations, Month);

    // prof solution
    short Year = ReadYear(); 
    short Month = ReadMonth(); 
    cout << "\nNumber of Days    in Month [" << Month << "] is " << NumberOfDaysInAMonth(Month, Year); 
    cout << "\nNumber of Hours   in Month [" << Month << "] is " << NumberOfHoursInAMonth(Month, Year); 
    cout << "\nNumber of Minutes in Month [" << Month << "] is " << NumberOfMinutesInAMonth(Month, Year); 
    cout << "\nNumber of Seconds in Month [" << Month << "] is " << NumberOfSecondsInAMonth(Month, Year);  
   
    system("pause>0");
}



