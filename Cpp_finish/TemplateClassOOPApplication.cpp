#include <iostream>
using namespace std;

template <class T>
class Calculator
{
private:
    T Number1, Number2;
public:

    Calculator(T n1, T n2)
    {
        Number1 = n1;
        Number2 = n2;
    }

    void PrintResults()
    {
        cout << "Numbers :" << Number1 << " and " << Number2 << "." << endl;
        cout << Number1 << " + " << Number2 << " = " << Add() << endl;
        cout << Number1 << " * " << Number2 << " = " << Multiply() << endl;
        cout << Number1 << " - " << Number2 << " = " << Subtract() << endl;
        cout << Number1 << " / " << Number2 << " = " << Divide() << endl;
    }

    T Add()
    {
        return Number1 + Number2;
    }

    T Divide()
    {
        if(Number2 != 0)
            return Number1 / Number2;
    }

    T Subtract()
    {
        return Number1 - Number2;
    }

    T Multiply()
    {
        return Number1 * Number2;
    }

};


template <typename T> T myMax(T Number1, T Number2)
{
    return Number1 > Number2 ? Number1 : Number2;
}

int main()
{
    Calculator<int> intCalulator(10 , 15);
    Calculator<float> floatCalulator(10.35 , 15.6);

    cout << "Int Results :" << endl;
    intCalulator.PrintResults();

    cout << "\nfloat Results :" << endl;
    floatCalulator.PrintResults();

    // call myMax for int
    cout << myMax<int>(3, 7) << endl;
    // call myMax for double
    cout << myMax<double>(15.8, 15.7) << endl;
    // call myMax for char
    cout << myMax<char>('a','t') << endl;


    return 0;
}

