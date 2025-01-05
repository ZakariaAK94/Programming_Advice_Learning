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

int CalculateDigitFrequency(int Number, short DigitToCheck)
{
    int Remainder = 0;
    int FreqCount = 0;
    while (Number > 0)
    {
        Remainder = Number % 10;
        if (Remainder == DigitToCheck)
            FreqCount++;
        Number = Number / 10;
    }
    return FreqCount;
}

void ShowFrequencyOfAllDigit(int Number)
{
    cout << endl;
    for (int i = 0; i < 10; i++)
    {
        short DigitFrequency = 0;
        DigitFrequency = CalculateDigitFrequency(Number, i);
        if (DigitFrequency > 0)
        {
            cout << "\n Digit " << i << " Frequency is " << DigitFrequency << " times." << endl;
        }
    }
    
            
}

int main()
{
   ShowFrequencyOfAllDigit(ReadPositiveNumber("Please enter the main number ?"));
    
    return 0;
}
