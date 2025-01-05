#include <iostream>
#include <string>
#include <math.h>
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

void PrintDigits(int Number)
{
    int  Remainder = 0;
    while (Number > 0)
    {
        Remainder = Number % 10;
        Number = Number / 10;
        cout << Remainder << endl;
    }
}
int ReverseNumber(int Number)
{
    int Remainder = 0, Number2 = 0;
    while (Number > 0)
    {
        Remainder = Number % 10;
        Number = Number / 10;
        Number2 = Number2 * 10 + Remainder;
    }
    return Number2;
}

//int ZakMethod(int Number)
//{
//    int i = 0;
//    while (Number > 0)
//    {
//        i++;
//        Number = Number / 10;
//    }
//    return i;
//}
//
//void ZakMethod2(int Number)
//{
//    int PowerOfTen = 0;
//    for (int j = ZakMethod(Number); j > 0; j--)
//    {
//        PowerOfTen = pow(10, j - 1);
//        cout << Number / PowerOfTen << endl;
//        Number = Number % PowerOfTen;
//    }
//}




int main()
{
    PrintDigits(ReverseNumber(ReadPositiveNumber("Please enter a positive number?")));
    /*ZakMethod2(ReadPositiveNumber("Please enter a positive number?"));*/
    return 0;
}
