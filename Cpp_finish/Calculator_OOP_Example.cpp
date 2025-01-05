#include <iostream>
using namespace std;

class clsCalculator
{
private:
    float _LastNumber = 0;
    float _Result = 0;
    float _PreviousResult = 0;
    string _LastOperation = "clear";

    bool IsZero(float Number)
    {
        return (Number == 0);
    }

public:
    void Clear()
    {
        _PreviousResult = 0;
        _Result = 0;
        _LastOperation = "clear";
        _LastNumber = 0;
    }

    void Add(float Number)
    {
        _LastNumber = Number; 
        _PreviousResult = _Result;
        _LastOperation = "Adding";
        _Result += Number;
        
    }
    void Subtract(float Number)
    {
        _LastNumber = Number;
        _PreviousResult = _Result;
        _LastOperation = "Subtracting";
        _Result -= Number;        
    }
    void Multiply(float Number)
    {
        _LastNumber = Number;
        _PreviousResult = _Result;
        _LastOperation = "Multiplying";
        _Result *= Number;        
    }
    void Divide(float Number)
    {
        _LastNumber = Number;
        _PreviousResult = _Result;
        _LastOperation = "Dividing";
        if (Number == 0)
        {
            Number = 1;
            _LastNumber = Number;
        }
        _Result /=  Number;
       
    }
    void CancelLastOperation()
    {
        _LastNumber = 0;
        _LastOperation = "Cancelling Last Operation";
        _Result = _PreviousResult;
    }
    void PrintResult()
    {
        cout << "Result after " << _LastOperation <<" "<< _PreviousResult << " is : " << _Result << endl;
                   
    }
};

int main()
{
    clsCalculator Calculator1;
    Calculator1.Add(10);
    Calculator1.PrintResult();
    Calculator1.Add(10);
    Calculator1.PrintResult();
    Calculator1.Multiply(25);
    Calculator1.PrintResult();
    Calculator1.Subtract(100);
    Calculator1.PrintResult();
    Calculator1.Divide(10);
    Calculator1.PrintResult();
    Calculator1.Clear();
    Calculator1.PrintResult();

    system("pause>0");
}


