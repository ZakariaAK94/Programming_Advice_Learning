#include <iostream>
using namespace std;

struct strInfoPres
{
    string FirstName;
    string LastName;
    string Phone;
    int Age;
};

void ReadInfo(strInfoPres& Info)
{
    cout << "********************************" << endl;
    cout << "Please enter the FirstName ? " << endl;
    cin >> Info.FirstName;
    cout << "Please enter the LastName ? :" << endl;
    cin >> Info.LastName;
    cout << "Please enter the Age ? :" << endl;
    cin >> Info.Age;
    cout << "Please enter the phone ? :" << endl;
    cin >> Info.Phone;
}

void PrintInfo(strInfoPres Info)
{
    cout << "*****************************" << endl;
    cout << "FirstName :" << Info.FirstName << endl;
    cout << "LastName :" << Info.LastName << endl;
    cout << "Age :" << Info.Age << endl;
    cout << "Phone :" << Info.Phone << endl;
    
}


void ReadPersonsInfo(strInfoPres Persons[100], int& Size)
{
    cout << "Please enter the number of persons you want to create :" << endl;
    cin >> Size;
    for (int i = 0; i <= Size - 1; i++)
    {
        cout << "Please fill out the information for person N" << i+1 << endl << endl;
        ReadInfo(Persons[i]);
    }
    
}

void PrintPersonsInfo(strInfoPres Persons[100], int Size)
{
    for (int i = 0; i <= Size - 1; i++)
    {
        cout << "The Informations for the person N" << i+1 << " are listed below :" << endl << endl;
        PrintInfo(Persons[i]);
    }
        
}


int main()
{
    int Size;
    cout << "**********************************";
    strInfoPres Persons[100];
    ReadPersonsInfo(Persons, Size);
    PrintPersonsInfo(Persons, Size);

    return 0;
}
