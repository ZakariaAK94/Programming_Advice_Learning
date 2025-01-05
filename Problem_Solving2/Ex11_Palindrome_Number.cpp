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

bool IsPalindromeNumber(int Number) 
{ 
    return Number == ReverseNumber(Number);
}



int main()
{
    int Number = ReadPositiveNumber("Please enter a positive number?");
    if (IsPalindromeNumber(Number))
        cout << "Yes, it is a Palindrome Number." << endl;
    else
        cout << "No, it is not a Palindrome Number." << endl;
    
    return 0;
}
