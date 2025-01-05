#include <iostream>
#include "MyFunctions.h";
using namespace std;

int main()
{

    /*int Number = MyFunctions::ReadPositiveNumber("Please enter a Number ?");*/
   
    string Name = "Zakaria";
    for (char i : Name)
    {
        cout << i << endl;
        /*MyFunctions::CheckIfNumberPositive(i);
        cout << "\n";*/
        
    }
     
    return 0;

}

