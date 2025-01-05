#include <iostream>
#include <vector>
using namespace std;

int ReadYear(string text)
{
    int Year;
    cout << "Please enter a " <<text <<" that you want to test ? " << endl;
    cin >> Year;

    return Year;
}

bool IsaLeapYear(int Year)
{
    return (Year % 400 == 0) || (Year % 4 == 0) && (Year % 10 != 0);

}

int NumbersOfDays(int Month, int Year)
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
    }
}

vector<int> DivideIntoDurationDependOnMonth(int Year, int Month)
{
    vector<int> Durations;
    int NbrsOfDays = NumbersOfDays(Year, Month);
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

int main()
{
    vector <int> Durations;
    int Year = ReadYear("Year");
    int Month = ReadYear("Month");
    Durations = DivideIntoDurationDependOnMonth(Year, Month);
    ShowResult(Durations, Month);

    system("pause>0");
}

