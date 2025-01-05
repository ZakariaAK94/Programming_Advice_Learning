#include <iostream>
#include "MyFunction.h";
using namespace std;

struct stEmployeInfo
{
    string FullName;
    int Salary;
};


int main()
{
    
    int* ptrTable;
    int Num = 0;
    cout << "How many places you want to allocate in memory ?" << endl;
    cin >> Num;

    ptrTable = new int[Num];

    for (int i = 0; i < Num; i++)
    {
        cout << "Please enter the garde of student " << i + 1 << " : ";
        cin >> *(ptrTable + i);
    }

    cout << "\n\n" ;

    for (int i = 0; i < Num; i++)
    {
        cout << "The garde of student " << i + 1 << " : " << *(ptrTable + i) << endl;
    }

    delete[] ptrTable;


    return 0;

}


