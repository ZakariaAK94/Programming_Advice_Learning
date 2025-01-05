#include<iostream>
using namespace std;

struct PersonInfors
{
	int Age;
	bool HasDrivingLicense;
	bool HasRecommondation;
};

PersonInfors ReadInformation()
{
	PersonInfors Person;
	cout << "Please enter your Age ?" << endl;
	cin >> Person.Age;
	cout << "Do you have a driver's license ?" << endl;
	cin >> Person.HasDrivingLicense;
	cout << "Do you have a recommendation ?" << endl;
	cin >> Person.HasRecommondation;
	return Person;
}

bool IsAccepted(PersonInfors Person)
{
	return(Person.Age > 21 && Person.HasDrivingLicense || Person.HasRecommondation);
}

void TestElgiblityOfPerson(PersonInfors Person)
{
	if (IsAccepted(Person))
		cout << "You are eligible for this program, congratulation!!" << endl;
	else
		cout << "You aren't eligible, try next time !!" << endl;
}

int main()
{
	TestElgiblityOfPerson(ReadInformation());
	return 0;
}
