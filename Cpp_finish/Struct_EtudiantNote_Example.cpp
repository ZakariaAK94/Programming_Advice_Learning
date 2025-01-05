#include <iostream>
using namespace std;

struct strStudent
{
	char FirstName[50];
	char LastName[50];
	float Note;
};

void ReadInfo(strStudent& Info)
{
	cout << "Please enter the FirstName :" << endl;
	cin >> Info.FirstName;
	cout << "Please enter the LastName :" << endl;
	cin >> Info.LastName;
	cout << "Please enter the Note :" << endl;
	cin >> Info.Note;
	cout << "******************************* \n";
}
void PrintTheResult(strStudent Info)
{
	if (Info.Note >= 10)
	{
		cout << "the person : " << Info.FirstName << " "<<Info.LastName << endl;
		cout << "You are succeed, with Note = " << Info.Note << ".\n";
		cout << "**************************************" << endl;
	}
	else {
		cout << "the person : " << Info.FirstName << " " << Info.LastName << endl;
		cout << "You are failed, with Note = " << Info.Note << ".\n";
		cout << "**************************************" << endl;
	}
}
void ReadPersonsInfo(strStudent Persons[3])
{
	ReadInfo(Persons[0]);
	ReadInfo(Persons[1]);
	ReadInfo(Persons[2]);
}
void PrintPersonsResult(strStudent Persons[3])
{
	PrintTheResult(Persons[0]);
	PrintTheResult(Persons[1]);
	PrintTheResult(Persons[2]);
}

int main()
{
	
	strStudent Persons[3];
	ReadPersonsInfo(Persons);
	PrintPersonsResult(Persons);

return 0;

}

