#include<iostream>
using namespace std;

/* Declaration fo a funcion */
int BitWiseEndOperator(int, int);
int BitWiseOrOperator(int, int);
int MySum(int, int, int, int);


int main()
{
    cout << "Result:" << BitWiseEndOperator(20,25) << endl;
    cout << "Result:" << BitWiseOrOperator(20,25) <<endl;
    cout << "Result:" << MySum(10, 20, 30,50) << endl;
}

/* Definition to a funcion */
int BitWiseEndOperator(int A, int B)
{
    return A & B;
}

int BitWiseOrOperator(int A, int B)
{
    return A | B;
}

int MySum(int a, int b, int c = 0, int d = 0)
{
    return a + b + c + d;
}