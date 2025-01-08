#include <iostream>
using namespace std;

template<typename T>
void Change(T &a, T &b)
{
    T temp;
    temp = a;
    a = b;
    b = temp;
}

template<typename T>
class MyCalculator
{
    private:
        T _Number1, _Number2;
    public:
        MyCalculator(T a, T b)
        {
            _Number1 = a;
            _Number2 = b;
        }

        void PrintResult()
        {
            cout << "\nThe operation betwen N1=" << _Number1 << " and N2=" << _Number2 << " :\n";
            cout << " N1 (+) N2 =" << Add() << endl;
            cout << " N1 (-) N2 =" << Substract() << endl;
            cout << " N1 (*) N2 =" << Multiple() << endl;
            cout << " N1 (/) N2 =" << Divide() << endl;
        }

        T Add()
        {
            return _Number1 + _Number2;
        }

        T Substract()
        {
            return _Number1 - _Number2;
        }

        T Multiple()
        {
            return _Number1 * _Number2;
        }

        T Divide()
        {
            return _Number1 / _Number2;
        }

};

template<typename T> 
T Mymax(T Number1, T Number2)
{
    return (Number1 > Number2) ? Number1 : Number2;
}


int main()
{
    double a = 15.7;
    double b = 10.3;
    cout << "a: " << a << ", b: " << b << endl;
    cout << endl << Mymax(a, b);
    Change(a, b);
    cout << "\na: " << a << ", b: " << b << endl;
    cout << endl << Mymax(a, b);

    MyCalculator<int> IntCalculator1(2,3);
    IntCalculator1.PrintResult();
    cout << "\n\n\n";
    MyCalculator<float> FloatCalculator1(2.25, 6.3);
    FloatCalculator1.PrintResult();

    return 0;
}





