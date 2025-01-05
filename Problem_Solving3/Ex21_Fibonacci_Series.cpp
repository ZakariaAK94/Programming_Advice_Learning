#include <iostream>
#include<cstdlib>
#include<cstdio>
#include<iomanip>
#include<vector>
using namespace std;

void PrintFibonacciUsingLoop(short Number)
{
    int FebNumber = 0;

    int Prev2 = 0, Prev1 = 1;
    cout << "1    ";
    for (int i = 1; i < Number; i++)
    {
        FebNumber = Prev2 + Prev1;
        cout << FebNumber << "    ";
        Prev2 = Prev1;
        Prev1 = FebNumber;
    }
}
int main()
{
    PrintFibonacciUsingLoop(10);
    system("pause>0");
}
