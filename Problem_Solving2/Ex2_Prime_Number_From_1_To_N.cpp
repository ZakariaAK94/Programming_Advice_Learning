#include <iostream>
#include <math.h>
#include <string.h>
using namespace std;

enum enIsPrime{Prime =1, Notprime=2};

int ReadPositiveNumber(string Message)
{
    int Number = 0;
    do
    {   cout << " Please enter a number ?\n";
        cin >> Number;
    } while (Number <= 0);

    return Number;
}

enIsPrime CheckPrime(int Number)
{
    for (int i = 2; i <= sqrt(Number); i++)
    {
        if(Number % i == 0)
            return enIsPrime::Notprime;
    }
    return enIsPrime::Prime;
  
}

void PrintPrimeNumbersFrom1ToN(int Number)
{
    int i = 1;
    cout << "prime numbers from 1 to " << Number << " are :" << endl;
    while (i <= Number)
    {
         
        switch (CheckPrime(i))
        {
        case Prime:
            cout << i << endl;
            break;
        case Notprime:
            break;
        }
        i++;
    }
          
}
int main()
{
        
    PrintPrimeNumbersFrom1ToN(ReadPositiveNumber("Please enter a Number ?"));
    return 0;

}

