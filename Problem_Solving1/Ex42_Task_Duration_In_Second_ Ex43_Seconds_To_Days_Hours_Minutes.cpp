#include <iostream>
using namespace std;

int main()
{
	int NumberOfDays, SecondsPerDay, SecondsPerHours, SecondsPerMinutes, NumberOfHours, NumberOfMinutes, NumberOfSeconds , ResteDiv;
	SecondsPerDay = 24 * 3600;
	SecondsPerHours = 3600;
	SecondsPerMinutes = 60;
	cout << "Give me the time duration of a task in the number of days, hours, minutes and seconds" << endl;
	cin >> NumberOfDays;
	cin >> NumberOfHours;
	cin >> NumberOfMinutes;
	cin >> NumberOfSeconds;
	cout << "the duration on seconds is :" << (NumberOfDays * SecondsPerDay) + (NumberOfHours * SecondsPerHours) + (NumberOfMinutes * SecondsPerMinutes) + NumberOfSeconds << endl;
	/***********************************************************************/
	cout << "Give me the duration on seconds you wanna change it to days, hours,minutes and seconds " << endl;
	cin >> NumberOfSeconds;
	NumberOfDays = round(NumberOfSeconds / (SecondsPerDay));
	ResteDiv = NumberOfSeconds % (NumberOfDays * SecondsPerDay);
	NumberOfHours = round(ResteDiv / SecondsPerHours);
	ResteDiv = ResteDiv % (NumberOfHours* SecondsPerHours);
	NumberOfMinutes = round(ResteDiv / SecondsPerMinutes);
	NumberOfSeconds = round(ResteDiv % (NumberOfMinutes*SecondsPerMinutes));
	cout << " the duration is :" << NumberOfDays << ":" << NumberOfHours << ":" << NumberOfMinutes << ":" << NumberOfSeconds<< ".\n";

	return 0;
}