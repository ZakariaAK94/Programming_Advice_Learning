#include <iostream>
using namespace std;

class clsNumbers
{
private:
    int _X1;
protected:
    int _Y1;
public:
    int Z1;
    clsNumbers() : _X1(15), _Y1(150), Z1(1500) {};
    //or we can use these
    /*
    * clsNumbers()
    {
        _X1 = 15;
        _Y1 = 150;
        Z1 = 1500;
    }
    */

    friend class clsSum;
    friend int Sum2(clsNumbers Numbers1);
};

class clsSum 
{
public:
    int Sum(clsNumbers Numbers1)
    {
        return Numbers1.Z1 + Numbers1._X1 + Numbers1._Y1;
    }

};

int Sum2(clsNumbers Numbers1)
{
    return Numbers1.Z1 + Numbers1._X1 + Numbers1._Y1;
}

int main()
{
    clsNumbers Numbers1;
    clsSum Sum1;
    cout << "\nThe sum of private and protected numbers from clsNumbers using the class is :" << Sum1.Sum(Numbers1); 
    cout << "\nThe sum of private and protected numbers from clsNumbers using the function is :" << Sum2(Numbers1); 
    system("pause>0");
    return 0;
}


