#include<iostream>
using namespace std;

enum enWeekDay{ Sunday =1, Monday =2,Tuesday =3, Wednesday =4,Thursday = 5, Friday =6,Saturday = 7};

enum enScreenColor{ Red =1, Green =2,Yellow =3, Blue =4};

void ShowWeekDayMenue()
{
	cout << "****************************\n";
	cout << "           Weeks Days       \n";
	cout << "****************************\n";
	cout << "(1) : Sunday \n";
	cout << "(2) : Monday \n";
	cout << "(3) : Tuesday \n";
	cout << "(4) : Wednesday \n";
	cout << "(5) : Thursday \n";
	cout << "(6) : Friday \n";
	cout << "(7) : Saturday \n";
	cout << "****************************\n";
	cout << "Please enter the number of day? \n";
}

void ShowColorChoice()
{
	cout << "****************************\n";
	cout << "           Screen Color       \n";
	cout << "****************************\n";
	cout << "(1) : RED \n";
	cout << "(2) : GREEN \n";
	cout << "(3) : YELLOW \n";
	cout << "(4) : BLUE \n";
	cout << "****************************\n";
	cout << "Please enter the color of the screen? \n";
}

enWeekDay ReadWeekday()
{
	int c;
	cin >> c;
	return enWeekDay(c);
}

enScreenColor ReadScreenColor()
{
	int d;
	cin >> d;
	return enScreenColor(d);
}


string GetWeekDayName(enWeekDay Weekday)
{
	switch (Weekday)
	{
	case enWeekDay::Sunday :
		return "Sunday";
		break;
	case enWeekDay::Monday:
		return "Monday";
		break;
	case enWeekDay::Tuesday:
		return "Tuesday";
		break;
	case enWeekDay::Wednesday:
		return "Wednesday";
		break;
	case enWeekDay::Thursday:
		return "Thursday";
		break;
	case enWeekDay::Friday:
		return "Friday";
		break;
	case enWeekDay::Saturday:
		return "Saturday";
		break;
	default:
		return "not a week day!!!";
	}
}

void SetColortoTheScreen(enScreenColor ScreenColor)
{
	switch (ScreenColor)
	{
	case enScreenColor::Red:
		system("color 4F");
		break;
	case enScreenColor::Yellow:
		system("color 6F");
		break;
	case enScreenColor::Green:
		system("color 2F");
		break;
	case enScreenColor::Blue:
		system("color 1F");
		break;
	default:
		system("color 3F");
	}
}

int main()
{
	/*ShowWeekDayMenue();
	cout << "The day is : " << GetWeekDayName(ReadWeekday()) << endl;*/

	ShowColorChoice();
	SetColortoTheScreen(ReadScreenColor());


	return 0;
}