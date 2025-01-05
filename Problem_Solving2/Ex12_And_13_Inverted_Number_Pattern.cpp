#include <iostream>
using namespace std;

int ReadPositiveNumber(string Message)
{
    int Number = 0;
    do {
        cout << Message << endl;
        cin >> Number;
    } while (Number < 0 || Number >= 10);
    return Number;
}

void ShowNumberNtimes(int Number)
{
    for (int i = 1; i <= Number; i++)
        cout << Number;
    cout << endl;
}

void PrintInvertedNumberPattern(int Number)
{
    for (int i = Number; i > 0; i--)
        ShowNumberNtimes(i);
}
/* exercice 13 */
void PrintInvertedNumberPatternReversed(int Number)
{
    for (int i = 1; i <= Number; i++)
        ShowNumberNtimes(i);
}


int main()
{
    PrintInvertedNumberPattern(ReadPositiveNumber("Please enter a Number ?"));
    PrintInvertedNumberPatternReversed(ReadPositiveNumber("Please enter a Number ?"));
    
    return 0;
}

