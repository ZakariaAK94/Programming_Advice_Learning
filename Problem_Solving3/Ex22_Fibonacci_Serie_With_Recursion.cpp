#include <iostream>
using namespace std;


void PrintFibonacciUsingRecursion(int N, int Prev1, int Prev2)
{
    int FbNumber = 0;
    if (N > 0)
    {
        FbNumber = Prev1 + Prev2;
        cout << FbNumber << "     ";
        Prev2 = Prev1;
        Prev1 = FbNumber;
        PrintFibonacciUsingRecursion(N - 1, Prev1, Prev2);
    }
}


int main()
{
    PrintFibonacciUsingRecursion(10, 0, 1);
    return 0;
}
