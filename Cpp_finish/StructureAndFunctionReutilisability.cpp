#include <iostream>
#include<string>
using namespace std;

struct strInfo
{
	string FullName;
	short Age;
	string City;
	string Country;
	int MonthlySalary;
	int YearlySalary ;
	char Gender;
	bool IsMarried;
};

void ReadInfo(strInfo &Info)
{
	cout << "Please enter your FullName :" << endl;
	getline(cin, Info.FullName);
	cout << "Please enter your age :" << endl;
	cin >> Info.Age;
	cout << "Please enter your city :" << endl;
	cin >> Info.City;
	cout << "Please enter your country :" << endl;
	cin >> Info.Country;
	cout << "Please enter your salary :" << endl;
	cin >> Info.MonthlySalary;
	Info.YearlySalary = Info.MonthlySalary * 12;
	cout << "Please enter your gender M for Man and F for woman :" << endl;
	cin >> Info.Gender;
	cout << "Please enter your 1 if you are married, and 0 if not :" << endl;
	cin >> Info.IsMarried;
}

void PrintInfo(strInfo Info)
{
		cout << "****************************************" << endl;
		cout << "FullName :" << Info.FullName << endl;
		cout << "Age :" << Info.Age << endl;
		cout << "City :" << Info.City << endl;
		cout << "Country :" << Info.Country << endl;
		cout << "Monthlysalary :" << Info.MonthlySalary << endl;
		cout << "Yearlysalary :" << Info.YearlySalary << endl;
		cout << "Gender :" << Info.Gender << endl;
		cout << "MaritalStatut :" << Info.IsMarried << endl;		
		cout << "****************************************" << endl;	
}

int main()
{

	strInfo Person1Info;
	ReadInfo(Person1Info);
	PrintInfo(Person1Info);

	return 0;

}