#include <iostream>
using namespace std;

struct PersInformation
{
	string Name;
	short Age;
	string City;
	string Country;
	int MonthlySalary;
	/*int YearlySalary = MonthlySalary * 12;*/
	char Gender;
	bool IsMarried;
	
};

struct SecondaryInformations
{
	string fbaccount;
	string skypeaccount;
	short durationofusingfacebook;
	short durationofusingskype;
	PersInformation UserPersonInformations;

};


int main()
{

	SecondaryInformations User01;

	cout << "Please enter your Name :" << endl;
	cin >> User01.UserPersonInformations.Name;
	cout << "Please enter your Age :" << endl;
	cin >> User01.UserPersonInformations.Age;
	cout << "Please enter your City :" << endl;
	cin >> User01.UserPersonInformations.City;
	cout << "Please enter your Country :" << endl;
	cin >> User01.UserPersonInformations.Country;
	cout << "Please enter your MonthlySalary :" << endl;
	cin >> User01.UserPersonInformations.MonthlySalary;
	cout << "Please enter your Gender M for Man and W for Woman:" << endl;
	cin >> User01.UserPersonInformations.Gender;
	cout << "Please enter true if you are married otherwise enter false :" << endl;
	cin >> User01.UserPersonInformations.IsMarried;
	cout << "Please enter your facebook account :" << endl;
	cin >> User01.fbaccount;
	cout << "Please enter your skype account :" << endl;
	cin >> User01.skypeaccount;
	cout << "Please enter how long do you use facebook per day :" << endl;
	cin >> User01.durationofusingfacebook;
	cout << "Please enter how long do you use skype per day :" << endl;
	cin >> User01.durationofusingskype;
	cout << "Here below you can find your personal and secondary informations :" << endl;
	cout << " Name :" << User01.UserPersonInformations.Name << endl;
	cout << " Age :" << User01.UserPersonInformations.Age << endl;
	cout << " City :" << User01.UserPersonInformations.City << endl;
	cout << " Country :" << User01.UserPersonInformations.Country << endl;
	cout << " Monthlysalary :" << User01.UserPersonInformations.MonthlySalary << endl;
	cout << " Yearlysalary :" << User01.UserPersonInformations.MonthlySalary * 12 << endl;
	cout << " Gender :" << User01.UserPersonInformations.Gender << endl;
	cout << " Married :" << User01.UserPersonInformations.IsMarried << endl;
	cout << "facebook account :" << User01.fbaccount << endl;
	cout << "skype account :" << User01.skypeaccount << endl;
	cout << "You are using facebook :" << User01.durationofusingfacebook << " per day " << endl;
	cout << "You are using skype :" << User01.durationofusingskype << " per day " << endl;

	return 0;
}
