#include <iostream>
using namespace std;


int ReadPositiveNumber(string Message)
{
    int Number;
    do {
        cout << Message  << endl;
        cin >> Number;
    } while (Number < 0);
    return Number;
}

bool FindDivisors(int Number)
{
    int sum = 1;
    for (int i = 2; i < sqrt(Number); i++)
    {
        if (Number % i == 0)
        {
           
            sum = sum + i + Number/i;
        }

    }
    
     return (sum == Number);
    
}

void PrintResult(bool result)
{
    if (result)
        cout << "The number is perfect" << endl;
    else
        cout << "The number is not perfect" << endl;

}

void PrintNumberPerfectfrom0toN(int Number)
{
    bool test = false;
    for (int i = 2; i <= Number; i++)
    {
        if (FindDivisors(i))
        {
            cout << i << " is a number perfect " << endl;
            test = true;
        }
        else
            continue;

    }
    if (test == false)
        cout << "there doesn't exist any number perfect \n\n";

}


int main()
{
    /*PrintResult(FindDivisors(ReadPositiveNumber("Please enter a number ?")));*/
    PrintNumberPerfectfrom0toN(ReadPositiveNumber("Please enter a number ?"));
    return 0;
}


