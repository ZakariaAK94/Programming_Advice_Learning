#include <iostream>
#include <vector    >
using namespace std;

int ReadYear()
{
    int Year;
    cout << "Please a year that you want to test ?" << endl;
    cin >> Year;

    return Year;
}

bool IsaLeapYear(int Year)
{
    return (Year % 400 == 0) || (Year % 4 == 0) && (Year % 10 != 0);

}

vector<int> DivideIntoDuration(int Year)
{
    vector<int> Durations;
    if (IsaLeapYear(Year))
    {
        Durations.push_back(366);
        Durations.push_back(Durations[0] * 24);
        Durations.push_back(Durations[1]*60);
        Durations.push_back(Durations[2] * 60);
    }
    else
    {
        Durations.push_back(366);
        Durations.push_back(Durations[0] * 24);
        Durations.push_back(Durations[1] * 60);
        Durations.push_back(Durations[2] * 60);
    }
    return Durations;
}

void ShowResult(vector<int> Durations, int Year)
{
    cout << "\nNumber of Days in year [" << Year << "] is " << Durations[0];
    cout << "\nNumber of Hours in year [" << Year << "] is " << Durations[1];
    cout << "\nNumber of Minutes in year [" << Year << "] is " << Durations[2];
    cout << "\nNumber of Seconds in year [" << Year << "] is " << Durations[3];
}

int main()
{
    vector <int> Durations;
    int Year = ReadYear();
    Durations = DivideIntoDuration(Year);
    ShowResult(Durations, Year);
     
    system("pause>0");
}
