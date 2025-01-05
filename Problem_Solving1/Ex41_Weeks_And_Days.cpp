#include <iostream>
#include <string>
using namespace std;

struct stWeeksAndDay
{
    float Days;
    float Weeks;
};

float ReadNumberOfHours(string Message)
{
    float NbrOfHours;
    do {
        cout << "Please enter number of days ?" << endl;
        cin >> NbrOfHours;
    } while (NbrOfHours < 0);

    return NbrOfHours;
}

stWeeksAndDay ChangeNbrHoursToDaysToWeeks(float NbrHours)
{
    stWeeksAndDay WeeksDays;
    WeeksDays.Days = NbrHours / (24);
    WeeksDays.Weeks = WeeksDays.Days / 7;
    return WeeksDays;
}

void PrintResult(stWeeksAndDay WeeksDays)
{
    cout << "number of days is : " << WeeksDays.Days << endl;
    cout << "number of weeks is : " << WeeksDays.Weeks << endl;
}


int main()
{

    PrintResult(ChangeNbrHoursToDaysToWeeks(ReadNumberOfHours("Please enter number of hours ?")));

    return 0;
}

