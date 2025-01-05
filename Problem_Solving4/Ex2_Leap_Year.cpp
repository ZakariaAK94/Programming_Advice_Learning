#include <iostream>
using namespace std;

int ReadYear()
{
    int Year;
    cout << "Please a year that you want to test ? " << endl;
    cin >> Year;

    return Year;
}

bool CheckIfaLeapYear(int Year)
{
    
    if ((Year % 400) ==0)
        return true;
    else if ((Year % 4)==0)
    {
        if ((Year % 10)==0)
            return false;
        else
            return true;
    }
    return false;
}

int main()
{
    if (CheckIfaLeapYear(ReadYear()))
        cout << "this is a leap year ";
    else
        cout << "this isn't a leap year ";

    system("pause>0");
}


