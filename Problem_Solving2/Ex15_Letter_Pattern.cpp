#include<iostream>
using namespace std;

int ReadPositiveNumber(string Message)
{
    int Number = 0;
    do {
        cout << Message << endl;
        cin >> Number;
    } while (Number < 0);
    return Number;
}

void ShowNumberNtimes(int Number)
{
    for (int i = 1; i <= Number; i++)
        cout << char(65 + Number - 1);
    cout << endl;
}

void PrintLetterPatternINV(int Number)
{
    for (int i = 1; i <= Number; i++)
        ShowNumberNtimes(i);
}

int main()
{
    PrintLetterPatternINV(ReadPositiveNumber("Please enter a Number ?"));


    return 0;
}
