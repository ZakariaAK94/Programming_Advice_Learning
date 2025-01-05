#include <iostream>
using namespace std;

void ReadTwoNumbers(int& A, int& B)
{
    cout << "Please enter the number 1 : ";
    cin >> A;
    cout << "Please enter the  number 2 : ";
    cin >> B;
}

void swipNumber(int& A, int& B)
{
    int C;
    C = A;
    A = B;
    B = C;
}

void PrintNewNUmber(int A, int B)
{
    cout << "Number1 = " << A << endl;
    cout << "Number2 = " << B << endl << endl;
}
int main()
{
    int A, B;
    ReadTwoNumbers(A, B);
    PrintNewNUmber(A, B);
    swipNumber(A, B);
    PrintNewNUmber(A, B);
    return 0;
}

