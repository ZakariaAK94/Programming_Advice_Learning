#include <iostream>
using namespace std;

int ReadYear()
{
    int Year;
    cout << "Please a year that you want to test ?" << endl;
    cin >> Year;

    return Year;
}

bool CheckIfaLeapYear(int Year)
{
    return (Year % 400 == 0) || (Year % 4 == 0) && (Year % 10 != 0);
    
}

int main()
{
    if (CheckIfaLeapYear(ReadYear()))
        cout << "this is a leap year ";
    else
        cout << "this isn't a leap year ";

    system("pause>0");
}