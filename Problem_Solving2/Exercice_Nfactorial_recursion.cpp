#include <iostream>
#include<math.h>
using namespace std;

//int CalNFactorial(int n)
//{
//    int s = 1;
//    if ( n == 0 || n == 1 )
//      { return s;}
//    else
//    {
//        for (int i = n; 1 <= i; i--)
//        {
//            s = s * i;
//        }
//    }
//    return s;
//}

int CalNFactorial2(int n)
{
    
    if ( n==0 || n == 1)
    {
        return 1;
    }
    else
    {
        
        return n * CalNFactorial2(n - 1);
        }
}

float DivisionFactorial(int m)
{
    if (m==1)
    {
        return 1;
    }
    else {
        return (pow(-1, m - 1) / CalNFactorial2(m)) + DivisionFactorial(m - 1);
    }

}

void ReadNumberPositivestrict(int& Number)
{
    cout << "Please enter a number :" << endl;
    cin >> Number;
    while (Number < 0)
    {
        cout << "Please enter a number superior than 0 : " << endl;
        cin >> Number;
    }
}

int main()
{
    int Number;
    ReadNumberPositivestrict(Number);
    cout << "The " << Number << "!  = " << CalNFactorial2(Number) << endl;
    cout << "The " << Number << " DivisionFactorial  = " << DivisionFactorial(Number) << endl;
    return 0;
}