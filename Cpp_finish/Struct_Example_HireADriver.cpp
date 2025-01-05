#include <iostream>
using namespace std;

struct InfoPerson
{
    short Age;
    bool IsHasDriverLicense;
};
void ReadInfo(InfoPerson& Info)
{
    cout << "Please enter your Age? \n";
    cin >> Info.Age;
    cout << "Do you have a Driver License ? tap 1 if yes and 0 if not \n";
    cin >> Info.IsHasDriverLicense;
}
void HireTestPerson(InfoPerson Info)
{
    if (Info.Age > 21 && Info.IsHasDriverLicense == 1)
    {
        cout << " You are Hired !! :)" << endl;
    }
    else {
        cout << "You are Refused !! :( \n";
    }
}
void ReadInfoPersons(InfoPerson Persons[3])
{
    ReadInfo(Persons[0]);
    ReadInfo(Persons[1]);
    ReadInfo(Persons[2]);
 }
void HiredPersons(InfoPerson Persons[3])
{
    HireTestPerson(Persons[0]);
    HireTestPerson(Persons[1]);
    HireTestPerson(Persons[2]);
}

int main()
{
    InfoPerson Persons[3];
    ReadInfoPersons(Persons);
    HiredPersons(Persons);
    return 0;

}


