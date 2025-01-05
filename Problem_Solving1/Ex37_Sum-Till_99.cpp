#include <iostream>
#include <string>
using namespace std;

float ReadNumber(string Message)
{
    float Number = 0;
    cout << Message << endl;
    cin >> Number;
    return Number;
}

float SumNumbers()
{
    int Number = 0, Sum=0, Counter=1;
    do
    {
        Number = ReadNumber("Please enter Number " + to_string(Counter));
        if (Number == -99)
        {
            break;
        }
        
        
        Sum += Number;
        Counter ++;
             

    }while (Number != -99);

    return Sum;
}

int main()
{
      cout << "The sum is : "<< SumNumbers() << endl;

      return 0;
}


